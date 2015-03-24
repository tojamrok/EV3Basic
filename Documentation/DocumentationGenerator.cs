﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Documentation
{
    /// <summary>
    /// A generator to create a readable and compact API documentation from the XML annotations scattered around the libraries.
    /// Additional summary and introductory chapters are added.
    /// </summary>
    class DocumentationGenerator
    {
        static Dictionary<String,EV3Object> objects;

        static void Main(string[] args)
        {
            objects = new Dictionary<String,EV3Object>();

            // read documentation for the EV3 extension
            ReadFile("C:/Users/Reinhard/Documents/GitHub/EV3Basic/SmallBasicEV3Extension/bin/Debug/SmallBasicEV3Extension.xml");
            // read documentation for the small basic classes 
            ReadFile("C:/Program Files (x86)/Microsoft/Small Basic/SmallBasicLibrary.xml");
            // remove unsupported objectgs
            objects.Remove("EV3Communicator");
            objects.Remove("Resources");
            objects.Remove("Turtle");
            objects.Remove("File");
            objects.Remove("Primitive");
            objects.Remove("Array");
            objects.Remove("NativeHelper");
            objects.Remove("Desktop");
            objects.Remove("GraphicsWindow");
            objects.Remove("Sound");
            objects.Remove("Keywords");
            objects.Remove("Mouse");
            objects.Remove("Flickr");
            objects.Remove("RestHelper");
            objects.Remove("Timer");
            objects.Remove("Platform");
            objects.Remove("Stack");
            objects.Remove("Dictionary");
            objects.Remove("Clock");
            objects.Remove("Network");
            objects.Remove("SmallBasicCallback");
            objects.Remove("SmallBasicApplication");
            objects.Remove("ImageList");
            objects.Remove("Controls");
            objects.Remove("Shapes");
            objects.Remove("TextWindow");

            // write documentation file
            String outfilename = "C:/Users/Reinhard/Documents/GitHub/EV3Basic/Documentation/ev3basic_manual.html";
            FileStream fs = new FileStream(outfilename, FileMode.Create, FileAccess.Write);
            StreamWriter target = new StreamWriter(fs);

            target.WriteLine("<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01//EN\">");
            target.WriteLine("<HTML>");
            target.WriteLine("<HEAD>");
            target.WriteLine("<TITLE>EV3-Basic Developer Manual</TITLE>");
            target.WriteLine(Documentation.Properties.Resources.Styles);
            target.WriteLine("</HEAD>");
            target.WriteLine("<BODY>");

            target.WriteLine(Documentation.Properties.Resources.Manual);

            // add API documentation
            var list = objects.Keys.ToList();
            list.Sort();

            foreach (var opkey in list)
            {
                var o = objects[opkey];
                target.WriteLine("<H2 class=\"object\">"+opkey+"</H2>");
                target.WriteLine("<P class=\"objectsummary\">"+o.summary.Replace("\n","<BR>")+"</P>");

                // write properties
                var plist = o.properties.Keys.ToList();
                plist.Sort();
                foreach (var pkey in plist)
                {
                    String p = o.properties[pkey];
                    target.WriteLine("<H3 class=\"property\">" + opkey+"."+pkey + " - property</H3>");
                    target.WriteLine("<P class=\"propertysummary\">" + p.Replace("\n","<BR>") + "</P>");
                }
                // write functions
                var flist = o.functions.Keys.ToList();
                flist.Sort();
                foreach (var fkey in flist)
                {
                    EV3Function f = o.functions[fkey];
                    target.WriteLine("<H3 class=\"operation\">"+opkey+"."+fkey+" "+f.GetParameterList()+"</H3>");
                    target.WriteLine("<P class=\"operationsummary\">"+f.summary.Replace("\n","<BR>")+"</P>");

                    // write function parameters
                    foreach (var pp in f.parameters)
                    {
                        String p = pp.Value;
                        target.WriteLine("<H4 class=\"parameter\">"+pp.Key+"</H4>");
                        target.WriteLine("<P class=\"parametersummary\">"+p+"</P>");
                    }
                    // write return value 
                    if (f.returnvalue != null)
                    {
                        target.WriteLine("<H4 class=\"returns\">Returns</H4>");
                        target.WriteLine("<P class=\"returnssummary\">" + f.returnvalue + "</P>");
                    }
                }
            }

            target.WriteLine(Documentation.Properties.Resources.Appendix);

            target.WriteLine("</BODY>");
            target.WriteLine("</HTML>");

            target.Close();

//            Console.ReadLine();
        }

        internal static void ReadFile(String filename)
        {
            // parse all data from the XML files
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);

            // scan all 'member' nodes 
            foreach (XmlNode member in xmlDoc.ChildNodes[1].SelectNodes("members/member"))
            {
                // only consider members that have a summary 
                XmlNode summary = member.SelectSingleNode("summary");
                if (summary != null)
                {
                    String summarystring = TrimIndents(summary.InnerText.Trim());
                    
                    // extract name (without parameter list)  and  get member type
                    String name = member.Attributes["name"].Value;
                    char type = name[0];
                    int paridx = name.IndexOf('(');
                    if (paridx >= 0)
                    {
                        name = name.Substring(0, paridx);
                    }
                    if (type == 'T')
                    {
                        int dotidx = name.LastIndexOf('.');
                        if (dotidx >= 0)
                        {
                            name = name.Substring(dotidx + 1);
                        }
                    }
                    else
                    {
                        int dotidx = name.LastIndexOf('.');
                        dotidx = name.LastIndexOf('.', dotidx - 1);
                        if (dotidx >= 0)
                        {
                            name = name.Substring(dotidx + 1);
                        }
                    }

                    switch (type)
                    {
                        case 'T':
                            objects[name] = new EV3Object(summarystring);
                            break;
                        case 'M':
                            int dotidx = name.IndexOf('.');
                            EV3Function f = new EV3Function(summarystring);
                            objects[name.Substring(0, dotidx)].functions[name.Substring(dotidx + 1)] = f;
                            foreach (XmlNode param in member.SelectNodes("param"))
                            {
//                                Console.WriteLine("PAR: "+param.Attributes["name"].Value);
//                                Console.WriteLine("INFO: "+TrimIndents(param.InnerText.Trim()));
                                f.parameters[param.Attributes["name"].Value] = TrimIndents(param.InnerText.Trim());
                            }
                            XmlNode returnvalue = member.SelectSingleNode("returns");
                            if (returnvalue!=null)
                            {
                                f.returnvalue = TrimIndents(returnvalue.InnerText.Trim());
                            }
                            break;
                        case 'E':
                        case 'P':
                            dotidx = name.IndexOf('.');
                            objects[name.Substring(0, dotidx)].properties[name.Substring(dotidx + 1)] = summarystring;
                            break;
                    }
                }
            }
        }

        static String TrimIndents(String s)
        {
            int idx = s.IndexOf('\n');
            if (idx>=0 && s[idx+1]==' ')
            {
                return s.Substring(0, idx + 1) + TrimIndents(s.Substring(idx + 1).Trim());
            }
            else
            {
                return s;
            }
        }
    }



    class EV3Object
    {
        public EV3Object(String summary)
        {
            this.summary = summary;
            this.functions = new Dictionary<String, EV3Function>();
            this.properties = new Dictionary<String, String>();
        }

        internal String summary;
        internal Dictionary<String, EV3Function> functions;
        internal Dictionary<String, String> properties;
    }
    class EV3Function
    {
        public EV3Function(String summary)
        {
            this.summary = summary;
            this.parameters = new Dictionary<String, String>();
            this.returnvalue = null;
        }
        internal String summary;
        internal Dictionary<String, String> parameters;
        internal String returnvalue;

        public String GetParameterList()
        {
            StringBuilder b = new StringBuilder();
            b.Append("(");

            bool first = true;
            foreach (KeyValuePair<String,String> p in parameters)
            {
                if (!first)
                {
                    b.Append(", ");
                }
                first = false;
                b.Append(p.Key);
            }

            b.Append(")");
            return b.ToString();
        }
    }
}
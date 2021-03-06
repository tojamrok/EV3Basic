﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Documentation.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Documentation.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///&lt;H1 class=&quot;chapter&quot;&gt;Appendix - Sensors&lt;/H1&gt;
        ///
        ///&lt;PRE&gt;
        ///Type  Mode  Name            get reading with   delivers 
        ///
        ///1        0  NXT-TOUCH       ReadPercent        0=not pressed,  100=pressed  
        ///
        ///4        0  NXT-COL-REF     ReadPercent        0=no reflective light, 100=maximum reflective light
        ///4        1  NXT-COL-AMB     ReadPercent        0=no ambient light, 100=maximum ambient light
        ///4        2  NXT-COL-COL     ReadRawValue       1=black, 2=blue, 3=green, 4=yellow, 5=red, 6=white
        ///
        ///5        0  NXT-US-CM [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Appendix {
            get {
                return ResourceManager.GetString("Appendix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///&lt;H1 class=&quot;chapter&quot;&gt;Annexe: Les Capteurs&lt;/H1&gt;
        ///&lt;P&gt;
        ///EV3 Basic fait un bon travail d&apos;auto-détection de nombreux capteurs, au moins de tous les capteurs qui sont livrés avec les 
        ///kits NXT 2.0 et EV3. Néanmoins, le programme a besoin de savoir comment interpréter au mieux les mesures des capteurs pour 
        ///les différents types et modes. Pour que la liste reste simple, je n&apos;inclus que les modes que je trouve utiles. Les capteurs 
        ///EV3 sont listés en premier et les capteurs NXT sont répertoriés dans un tableau d [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AppendixFR {
            get {
                return ResourceManager.GetString("AppendixFR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;H1 class=&quot;chapter&quot;&gt;Appendix - I2C Tutorial&lt;/H1&gt;
        ///&lt;H3 class=&quot;subchapter&quot;&gt;Why accessing I2C directly?&lt;/H3&gt;
        ///&lt;P&gt;
        ///Normally interfacing to sensors from the EV3 brick is done using the easy-to-use Sensor.Read... commands. 
        ///But some third-party devices are not compatible with the default sensor protocol and require extra programming. 
        ///The vendors of such devices normally provide some programming blocks for the original graphics programming 
        ///environment that handle all the details of the communication. 
        ///&lt;/P&gt;        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string I2C {
            get {
                return ResourceManager.GetString("I2C", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;H1 class=&quot;chapter&quot;&gt;Appendix - Advanced logic operators&lt;/H1&gt;
        ///&lt;H3 class=&quot;subchapter&quot;&gt;Motivation&lt;/H3&gt;
        ///&lt;P&gt;
        ///In Small Basic (and indeed in any dialect of Basic, I have encountered) the use of comparators or the 
        ///logic operators AND and OR is limited to the context of If and While. But sometimes it would be nice to have 
        ///a way to keep the outcome of some comparisions for future use. For this you have to write something like
        ///&lt;pre&gt;
        ///If X&lt;10 OR X&gt;50 Then
        ///   A = &quot;True&quot;
        ///Else
        ///   A = &quot;False&quot;
        ///EndIf
        ///&lt;/pre&gt;
        ///But [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Logic {
            get {
                return ResourceManager.GetString("Logic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;H1 class=&quot;chapter&quot;&gt;EV3Basic&lt;/H1&gt;
        ///&lt;P&gt;
        ///Programming a robot to do your bidding is great fun. The easiest way to program the Lego EV3 brick for simple tasks is to use the 
        ///graphical programming environment provided by Lego. 
        ///But for larger and more complex programs, this no longer works and you need some text-based programming language to write programs.
        ///There are already many different projects that have created programming environments for the EV3 to provide exactly this (LeJOS, MonoBrick, RobotC, ev3de [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Manual {
            get {
                return ResourceManager.GetString("Manual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;H1 class=&quot;chapter&quot;&gt;EV3Basic&lt;/H1&gt;
        ///&lt;P&gt;
        ///Einen Roboter nach eigenen Ideen zu programmieren macht Spaß. Am einfachsten gelingt das Programmieren einfacher Aufgaben 
        ///mit der grafischen Software von Lego.
        ///Für größere und komplexere Programme braucht man jedoch eine textbasierte Programmiersprache.
        ///Es gibt auch viele verschiedene Projekte, um Programmiersprachen für den EV3 zu adaptieren (LeJOS, MonoBrick, RobotC, ev3dev, and andere).
        ///Aber alle haben eine Sache gemeinsam: Sie sind unglaublich schwierig zum L [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ManualDE {
            get {
                return ResourceManager.GetString("ManualDE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;H1 class=&quot;chapter&quot;&gt;Manual EV3 Basic&lt;/H1&gt;
        ///&lt;P&gt;
        ///&lt;STRONG&gt;Amablemente traducido por Angel Ivan Moreno, Frankfurt&lt;/STRONG&gt;
        ///&lt;/P&gt;
        ///&lt;P&gt;
        ///Programar un robot para que obedezca tus órdenes es muy divertido. La manera más 
        ///fácil de programar el bloque de Lego EV3 para tareas sencillas es utilizar el 
        ///entorno de programación gráfica proporcionado por Lego. Pero para programas más 
        ///grandes y complejos, este entorno se queda corto y se necesita algún lenguaje de 
        ///programación textual para programarlo. Existen mucho [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ManualES {
            get {
                return ResourceManager.GetString("ManualES", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;H1 class=&quot;chapter&quot;&gt;EV3Basic&lt;/H1&gt;
        ///&lt;P&gt;
        ///Programmer un robot selon vos désirs est très amusant. La façon la plus facile de programmer l’EV3 pour 
        ///exécuter des tâches simples est l&apos;environnement de programmation graphique fourni par Lego. Mais pour des programmes plus 
        ///vastes et plus complexes, cela ne fonctionne plus si bien et vous avez plutôt besoin d’un langage de programmation textuel 
        ///pour écrire les programmes. Il y a déjà de nombreux projets différents pour créer des environnements de programmation [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ManualFR {
            get {
                return ResourceManager.GetString("ManualFR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;H1 class=&quot;chapter&quot;&gt;Справочник по командам EV3 Бейсик&lt;/H1&gt;
        ///&lt;P&gt;
        ///&lt;STRONG&gt;Перевод: Андрей Степанов, «Карандаш и Самоделкин»&lt;/STRONG&gt;
        ///&lt;/P&gt;
        ///.
        /// </summary>
        internal static string ManualRU {
            get {
                return ResourceManager.GetString("ManualRU", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;style type=&quot;text/css&quot;&gt;
        ///  H1.chapter {
        ///	margin-top: 100px;
        ///    font-family: Verdana; 
        ///  }
        ///  H3.subchapter {
        ///    font-family: Verdana; 
        ///  }
        ///  P {
        ///    font-family: Verdana; 
        ///  }
        ///  UL {
        ///    font-family: Verdana; 
        ///  }
        ///  ADDRESS {
        ///    font-family: Verdana; 
        ///	float: right;
        ///  }
        ///  TABLE {
        ///    font-family: Verdana;
        ///	border-spacing: 0px;
        ///	border:1px solid black;
        ///  }
        ///  TD {
        ///	padding: 4px;
        ///	border:1px solid black;
        ///  }
        ///  TR:nth-child(1)
        ///  {
        ///	background: #d0d0d0;
        ///  } 
        ///
        ///  H2.object {
        ///    f [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Styles {
            get {
                return ResourceManager.GetString("Styles", resourceCulture);
            }
        }
    }
}

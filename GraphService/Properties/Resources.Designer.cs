﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraphService.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GraphService.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Tato hrana v grafu již existuje!.
        /// </summary>
        internal static string EDGE_EXISTS {
            get {
                return ResourceManager.GetString("EDGE_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hrana nebyla v grafu nalezena!.
        /// </summary>
        internal static string EDGE_NOT_FOUND {
            get {
                return ResourceManager.GetString("EDGE_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nelze získat cestu, neboť graf není prozkoumán!.
        /// </summary>
        internal static string GRAPH_NOT_EXPLORED {
            get {
                return ResourceManager.GetString("GRAPH_NOT_EXPLORED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Výpočty cest již nejsou platné a je potřeba provést přepočet!.
        /// </summary>
        internal static string INVALID_CALCULATIONS {
            get {
                return ResourceManager.GetString("INVALID_CALCULATIONS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data již nejsou platná a je potřeba je přegenerovat!.
        /// </summary>
        internal static string INVALID_DATA {
            get {
                return ResourceManager.GetString("INVALID_DATA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zadaný klíč v grafu již existuje!.
        /// </summary>
        internal static string KEY_IS_ALREADY_EXISTS {
            get {
                return ResourceManager.GetString("KEY_IS_ALREADY_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cesta mezi body neexistuje!.
        /// </summary>
        internal static string ROUTE_NOT_EXISTS {
            get {
                return ResourceManager.GetString("ROUTE_NOT_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nebyl zadán klíč cílového bodu!.
        /// </summary>
        internal static string START_KEY_NOT_RECIEVE {
            get {
                return ResourceManager.GetString("START_KEY_NOT_RECIEVE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nebyl zadán klíč počátečního bodu!.
        /// </summary>
        internal static string TARGET_KEY_NOT_RECIEVE {
            get {
                return ResourceManager.GetString("TARGET_KEY_NOT_RECIEVE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zadaná položka v grafu již existuje!.
        /// </summary>
        internal static string VALUE_IS_ALREADY_EXISTS {
            get {
                return ResourceManager.GetString("VALUE_IS_ALREADY_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zadaná položka v grafu neexistuje!.
        /// </summary>
        internal static string VALUE_NOT_EXISTS {
            get {
                return ResourceManager.GetString("VALUE_NOT_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zadaný vrchol v grafu neexistuje!.
        /// </summary>
        internal static string VERTEX_NOT_EXISTS {
            get {
                return ResourceManager.GetString("VERTEX_NOT_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vrchol nebyl v grafu nalezen!.
        /// </summary>
        internal static string VERTEX_NOT_FOUND {
            get {
                return ResourceManager.GetString("VERTEX_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zvolené vrcholy v grafu neexistují!.
        /// </summary>
        internal static string VERTEXES_NOT_EXIST {
            get {
                return ResourceManager.GetString("VERTEXES_NOT_EXIST", resourceCulture);
            }
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bot {
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
    internal class ConstantStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConstantStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("bot.ConstantStrings", typeof(ConstantStrings).Assembly);
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
        ///   Looks up a localized string similar to Click here to get a joke.
        /// </summary>
        internal static string get_joke {
            get {
                return ResourceManager.GetString("get_joke", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://icanhazdadjoke.com/.
        /// </summary>
        internal static string joke_api_url {
            get {
                return ResourceManager.GetString("joke_api_url", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tell me a joke.
        /// </summary>
        internal static string joke_request {
            get {
                return ResourceManager.GetString("joke_request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No joke found.
        /// </summary>
        internal static string no_joke {
            get {
                return ResourceManager.GetString("no_joke", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Let&apos;s start over.
        /// </summary>
        internal static string return_message {
            get {
                return ResourceManager.GetString("return_message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clicking here brings back the welcome message.
        /// </summary>
        internal static string return_to_start {
            get {
                return ResourceManager.GetString("return_to_start", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to hi and welcome to the test bot. You can type something in to go to the submit actions adaptive card. It doesn&apos;t matter what..
        /// </summary>
        internal static string welcome_message {
            get {
                return ResourceManager.GetString("welcome_message", resourceCulture);
            }
        }
    }
}

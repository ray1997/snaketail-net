﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SnakeTail.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SnakeTail.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;TailConfig&gt;
        ///  &lt;TailFiles&gt;
        ///    &lt;TailFileConfig&gt;
        ///      &lt;FilePath&gt;C:\Users\Teerapong\AppData\Local\DeadByDaylight\Saved\Logs\DeadByDaylight.log&lt;/FilePath&gt;
        ///      &lt;FileEncoding&gt;System.Text.SBCSCodePageEncoding&lt;/FileEncoding&gt;
        ///      &lt;FileCacheSize&gt;1000&lt;/FileCacheSize&gt;
        ///      &lt;FileCheckInterval&gt;10&lt;/FileCheckInterval&gt;
        ///      &lt;FileChangeCheckInterval&gt;100&lt;/FileChangeCheckInterval&gt;
        ///      &lt;FileCheckPattern&gt;false&lt;/FileCheckPattern&gt;
        ///      &lt;TitleMatchFilename&gt;false&lt;/TitleMatc [rest of string was truncated]&quot;;.
        /// </summary>
        public static string dbd_session {
            get {
                return ResourceManager.GetString("dbd_session", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        public static System.Drawing.Icon GreenBulletIcon {
            get {
                object obj = ResourceManager.GetObject("GreenBulletIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        public static System.Drawing.Icon LogIcon {
            get {
                object obj = ResourceManager.GetObject("LogIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        public static System.Drawing.Icon SnakeIcon {
            get {
                object obj = ResourceManager.GetObject("SnakeIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        public static System.Drawing.Icon YellowBulletIcon {
            get {
                object obj = ResourceManager.GetObject("YellowBulletIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}

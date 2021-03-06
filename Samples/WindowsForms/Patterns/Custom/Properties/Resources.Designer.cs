﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomPlural.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CustomPlural.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {plural, one {{0} file} other {{0} files}}.
        /// </summary>
        internal static string MessagePlural {
            get {
                return ResourceManager.GetString("MessagePlural", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {plural, =0 {No files} =1 {One file} =2 {Two files} &lt;6 {Few files} &lt;=10 {Several files} ~12 {A dozen files} other {Lots of files}}.
        /// </summary>
        internal static string TextMessagePlural {
            get {
                return ResourceManager.GetString("TextMessagePlural", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {plural, =0 {No files} one {One file} =2 {Two files} other {{0} files}}.
        /// </summary>
        internal static string Two2MessagePlural {
            get {
                return ResourceManager.GetString("Two2MessagePlural", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {plural, zero {No files} one {One file} two {Two files} other {{0} files}}.
        /// </summary>
        internal static string TwoMessagePlural {
            get {
                return ResourceManager.GetString("TwoMessagePlural", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {plural, zero {No files} one {One file} other {{0} files}}.
        /// </summary>
        internal static string ZeroMessagePlural {
            get {
                return ResourceManager.GetString("ZeroMessagePlural", resourceCulture);
            }
        }
    }
}

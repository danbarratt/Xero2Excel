﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xero2Excel.Core {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class UserSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static UserSettings defaultInstance = ((UserSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new UserSettings())));
        
        public static UserSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("XFD6YPFECHUQRBQSTZECDRFJPXPEJA")]
        public string PublicConsumerKey {
            get {
                return ((string)(this["PublicConsumerKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("UVNBJOI9LPZ5UF7ZDX7MXVLT7OK33C")]
        public string PublicConsumerSecret {
            get {
                return ((string)(this["PublicConsumerSecret"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string RequestTokenJson {
            get {
                return ((string)(this["RequestTokenJson"]));
            }
            set {
                this["RequestTokenJson"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AccessTokenJson {
            get {
                return ((string)(this["AccessTokenJson"]));
            }
            set {
                this["AccessTokenJson"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string OrganisationJson {
            get {
                return ((string)(this["OrganisationJson"]));
            }
            set {
                this["OrganisationJson"] = value;
            }
        }
    }
}

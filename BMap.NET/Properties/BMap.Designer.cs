﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMap.NET.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class BMap : global::System.Configuration.ApplicationSettingsBase {
        
        private static BMap defaultInstance = ((BMap)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new BMap())));
        
        public static BMap Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TMzlZXetCzK9t9fSdKO7v35T")]
        public string ServiceAK {
            get {
                return ((string)(this["ServiceAK"]));
            }
            set {
                this["ServiceAK"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ServiceSK {
            get {
                return ((string)(this["ServiceSK"]));
            }
            set {
                this["ServiceSK"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int VerificationMode {
            get {
                return ((int)(this["VerificationMode"]));
            }
            set {
                this["VerificationMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int LoadMapMode {
            get {
                return ((int)(this["LoadMapMode"]));
            }
            set {
                this["LoadMapMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\maps\\")]
        public string MapCachePath {
            get {
                return ((string)(this["MapCachePath"]));
            }
            set {
                this["MapCachePath"] = value;
            }
        }
    }
}

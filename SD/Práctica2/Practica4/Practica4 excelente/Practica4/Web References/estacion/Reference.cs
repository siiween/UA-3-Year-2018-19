﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Practica4.estacion {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="StationSoap11Binding", Namespace="http://master")]
    public partial class Station : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback setLumOperationCompleted;
        
        private System.Threading.SendOrPostCallback setFichOperationCompleted;
        
        private System.Threading.SendOrPostCallback getFichOperationCompleted;
        
        private System.Threading.SendOrPostCallback getHumOperationCompleted;
        
        private System.Threading.SendOrPostCallback leerOperationCompleted;
        
        private System.Threading.SendOrPostCallback getLumOperationCompleted;
        
        private System.Threading.SendOrPostCallback setTemOperationCompleted;
        
        private System.Threading.SendOrPostCallback setPanOperationCompleted;
        
        private System.Threading.SendOrPostCallback setHumOperationCompleted;
        
        private System.Threading.SendOrPostCallback getTemOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPanOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Station() {
            this.Url = global::Practica4.Properties.Settings.Default.Practica4_estacion_Station;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event setLumCompletedEventHandler setLumCompleted;
        
        /// <remarks/>
        public event setFichCompletedEventHandler setFichCompleted;
        
        /// <remarks/>
        public event getFichCompletedEventHandler getFichCompleted;
        
        /// <remarks/>
        public event getHumCompletedEventHandler getHumCompleted;
        
        /// <remarks/>
        public event leerCompletedEventHandler leerCompleted;
        
        /// <remarks/>
        public event getLumCompletedEventHandler getLumCompleted;
        
        /// <remarks/>
        public event setTemCompletedEventHandler setTemCompleted;
        
        /// <remarks/>
        public event setPanCompletedEventHandler setPanCompleted;
        
        /// <remarks/>
        public event setHumCompletedEventHandler setHumCompleted;
        
        /// <remarks/>
        public event getTemCompletedEventHandler getTemCompleted;
        
        /// <remarks/>
        public event getPanCompletedEventHandler getPanCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setLum", RequestNamespace="http://master", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void setLum(int l, [System.Xml.Serialization.XmlIgnoreAttribute()] bool lSpecified) {
            this.Invoke("setLum", new object[] {
                        l,
                        lSpecified});
        }
        
        /// <remarks/>
        public void setLumAsync(int l, bool lSpecified) {
            this.setLumAsync(l, lSpecified, null);
        }
        
        /// <remarks/>
        public void setLumAsync(int l, bool lSpecified, object userState) {
            if ((this.setLumOperationCompleted == null)) {
                this.setLumOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetLumOperationCompleted);
            }
            this.InvokeAsync("setLum", new object[] {
                        l,
                        lSpecified}, this.setLumOperationCompleted, userState);
        }
        
        private void OnsetLumOperationCompleted(object arg) {
            if ((this.setLumCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setLumCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setFich", RequestNamespace="http://master", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void setFich([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string f) {
            this.Invoke("setFich", new object[] {
                        f});
        }
        
        /// <remarks/>
        public void setFichAsync(string f) {
            this.setFichAsync(f, null);
        }
        
        /// <remarks/>
        public void setFichAsync(string f, object userState) {
            if ((this.setFichOperationCompleted == null)) {
                this.setFichOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetFichOperationCompleted);
            }
            this.InvokeAsync("setFich", new object[] {
                        f}, this.setFichOperationCompleted, userState);
        }
        
        private void OnsetFichOperationCompleted(object arg) {
            if ((this.setFichCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setFichCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getFich", RequestNamespace="http://master", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void getFich([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string f) {
            this.Invoke("getFich", new object[] {
                        f});
        }
        
        /// <remarks/>
        public void getFichAsync(string f) {
            this.getFichAsync(f, null);
        }
        
        /// <remarks/>
        public void getFichAsync(string f, object userState) {
            if ((this.getFichOperationCompleted == null)) {
                this.getFichOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetFichOperationCompleted);
            }
            this.InvokeAsync("getFich", new object[] {
                        f}, this.getFichOperationCompleted, userState);
        }
        
        private void OngetFichOperationCompleted(object arg) {
            if ((this.getFichCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getFichCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getHum", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void getHum(out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified) {
            object[] results = this.Invoke("getHum", new object[0]);
            @return = ((int)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void getHumAsync() {
            this.getHumAsync(null);
        }
        
        /// <remarks/>
        public void getHumAsync(object userState) {
            if ((this.getHumOperationCompleted == null)) {
                this.getHumOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetHumOperationCompleted);
            }
            this.InvokeAsync("getHum", new object[0], this.getHumOperationCompleted, userState);
        }
        
        private void OngetHumOperationCompleted(object arg) {
            if ((this.getHumCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getHumCompleted(this, new getHumCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:leer", RequestNamespace="http://master", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void leer([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string f) {
            this.Invoke("leer", new object[] {
                        f});
        }
        
        /// <remarks/>
        public void leerAsync(string f) {
            this.leerAsync(f, null);
        }
        
        /// <remarks/>
        public void leerAsync(string f, object userState) {
            if ((this.leerOperationCompleted == null)) {
                this.leerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnleerOperationCompleted);
            }
            this.InvokeAsync("leer", new object[] {
                        f}, this.leerOperationCompleted, userState);
        }
        
        private void OnleerOperationCompleted(object arg) {
            if ((this.leerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.leerCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getLum", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void getLum(out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified) {
            object[] results = this.Invoke("getLum", new object[0]);
            @return = ((int)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void getLumAsync() {
            this.getLumAsync(null);
        }
        
        /// <remarks/>
        public void getLumAsync(object userState) {
            if ((this.getLumOperationCompleted == null)) {
                this.getLumOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetLumOperationCompleted);
            }
            this.InvokeAsync("getLum", new object[0], this.getLumOperationCompleted, userState);
        }
        
        private void OngetLumOperationCompleted(object arg) {
            if ((this.getLumCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getLumCompleted(this, new getLumCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setTem", RequestNamespace="http://master", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void setTem(int t, [System.Xml.Serialization.XmlIgnoreAttribute()] bool tSpecified) {
            this.Invoke("setTem", new object[] {
                        t,
                        tSpecified});
        }
        
        /// <remarks/>
        public void setTemAsync(int t, bool tSpecified) {
            this.setTemAsync(t, tSpecified, null);
        }
        
        /// <remarks/>
        public void setTemAsync(int t, bool tSpecified, object userState) {
            if ((this.setTemOperationCompleted == null)) {
                this.setTemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetTemOperationCompleted);
            }
            this.InvokeAsync("setTem", new object[] {
                        t,
                        tSpecified}, this.setTemOperationCompleted, userState);
        }
        
        private void OnsetTemOperationCompleted(object arg) {
            if ((this.setTemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setTemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setPan", RequestNamespace="http://master", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void setPan([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string p) {
            this.Invoke("setPan", new object[] {
                        p});
        }
        
        /// <remarks/>
        public void setPanAsync(string p) {
            this.setPanAsync(p, null);
        }
        
        /// <remarks/>
        public void setPanAsync(string p, object userState) {
            if ((this.setPanOperationCompleted == null)) {
                this.setPanOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetPanOperationCompleted);
            }
            this.InvokeAsync("setPan", new object[] {
                        p}, this.setPanOperationCompleted, userState);
        }
        
        private void OnsetPanOperationCompleted(object arg) {
            if ((this.setPanCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setPanCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setHum", RequestNamespace="http://master", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void setHum(int h, [System.Xml.Serialization.XmlIgnoreAttribute()] bool hSpecified) {
            this.Invoke("setHum", new object[] {
                        h,
                        hSpecified});
        }
        
        /// <remarks/>
        public void setHumAsync(int h, bool hSpecified) {
            this.setHumAsync(h, hSpecified, null);
        }
        
        /// <remarks/>
        public void setHumAsync(int h, bool hSpecified, object userState) {
            if ((this.setHumOperationCompleted == null)) {
                this.setHumOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetHumOperationCompleted);
            }
            this.InvokeAsync("setHum", new object[] {
                        h,
                        hSpecified}, this.setHumOperationCompleted, userState);
        }
        
        private void OnsetHumOperationCompleted(object arg) {
            if ((this.setHumCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setHumCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getTem", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void getTem(out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified) {
            object[] results = this.Invoke("getTem", new object[0]);
            @return = ((int)(results[0]));
            returnSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void getTemAsync() {
            this.getTemAsync(null);
        }
        
        /// <remarks/>
        public void getTemAsync(object userState) {
            if ((this.getTemOperationCompleted == null)) {
                this.getTemOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTemOperationCompleted);
            }
            this.InvokeAsync("getTem", new object[0], this.getTemOperationCompleted, userState);
        }
        
        private void OngetTemOperationCompleted(object arg) {
            if ((this.getTemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTemCompleted(this, new getTemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getPan", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string getPan() {
            object[] results = this.Invoke("getPan", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getPanAsync() {
            this.getPanAsync(null);
        }
        
        /// <remarks/>
        public void getPanAsync(object userState) {
            if ((this.getPanOperationCompleted == null)) {
                this.getPanOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPanOperationCompleted);
            }
            this.InvokeAsync("getPan", new object[0], this.getPanOperationCompleted, userState);
        }
        
        private void OngetPanOperationCompleted(object arg) {
            if ((this.getPanCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPanCompleted(this, new getPanCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void setLumCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void setFichCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getFichCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getHumCompletedEventHandler(object sender, getHumCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getHumCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getHumCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int @return {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool returnSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void leerCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getLumCompletedEventHandler(object sender, getLumCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getLumCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getLumCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int @return {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool returnSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void setTemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void setPanCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void setHumCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getTemCompletedEventHandler(object sender, getTemCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int @return {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool returnSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getPanCompletedEventHandler(object sender, getPanCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPanCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPanCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
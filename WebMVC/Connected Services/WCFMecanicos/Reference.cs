﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMVC.WCFMecanicos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TMecanicos", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class TMecanicos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CelularField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Primer_ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Primer_NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Segundo_ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Segundo_NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Tipo_DocumentoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Celular {
            get {
                return this.CelularField;
            }
            set {
                if ((object.ReferenceEquals(this.CelularField, value) != true)) {
                    this.CelularField = value;
                    this.RaisePropertyChanged("Celular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Documento {
            get {
                return this.DocumentoField;
            }
            set {
                if ((this.DocumentoField.Equals(value) != true)) {
                    this.DocumentoField = value;
                    this.RaisePropertyChanged("Documento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Primer_Apellido {
            get {
                return this.Primer_ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.Primer_ApellidoField, value) != true)) {
                    this.Primer_ApellidoField = value;
                    this.RaisePropertyChanged("Primer_Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Primer_Nombre {
            get {
                return this.Primer_NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.Primer_NombreField, value) != true)) {
                    this.Primer_NombreField = value;
                    this.RaisePropertyChanged("Primer_Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Segundo_Apellido {
            get {
                return this.Segundo_ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.Segundo_ApellidoField, value) != true)) {
                    this.Segundo_ApellidoField = value;
                    this.RaisePropertyChanged("Segundo_Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Segundo_Nombre {
            get {
                return this.Segundo_NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.Segundo_NombreField, value) != true)) {
                    this.Segundo_NombreField = value;
                    this.RaisePropertyChanged("Segundo_Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo_Documento {
            get {
                return this.Tipo_DocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.Tipo_DocumentoField, value) != true)) {
                    this.Tipo_DocumentoField = value;
                    this.RaisePropertyChanged("Tipo_Documento");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFMecanicos.IMecanicos")]
    public interface IMecanicos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanicos/ConsultarMecanicos", ReplyAction="http://tempuri.org/IMecanicos/ConsultarMecanicosResponse")]
        WebMVC.WCFMecanicos.TMecanicos[] ConsultarMecanicos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMecanicos/ConsultarMecanicos", ReplyAction="http://tempuri.org/IMecanicos/ConsultarMecanicosResponse")]
        System.Threading.Tasks.Task<WebMVC.WCFMecanicos.TMecanicos[]> ConsultarMecanicosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMecanicosChannel : WebMVC.WCFMecanicos.IMecanicos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MecanicosClient : System.ServiceModel.ClientBase<WebMVC.WCFMecanicos.IMecanicos>, WebMVC.WCFMecanicos.IMecanicos {
        
        public MecanicosClient() {
        }
        
        public MecanicosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MecanicosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MecanicosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MecanicosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebMVC.WCFMecanicos.TMecanicos[] ConsultarMecanicos() {
            return base.Channel.ConsultarMecanicos();
        }
        
        public System.Threading.Tasks.Task<WebMVC.WCFMecanicos.TMecanicos[]> ConsultarMecanicosAsync() {
            return base.Channel.ConsultarMecanicosAsync();
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI.WCFServiceClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tbCliente", Namespace="http://schemas.datacontract.org/2004/07/ModeloDatos")]
    [System.SerializableAttribute()]
    public partial class tbCliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
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
        public System.Nullable<System.DateTime> FechaNacimiento {
            get {
                return this.FechaNacimientoField;
            }
            set {
                if ((this.FechaNacimientoField.Equals(value) != true)) {
                    this.FechaNacimientoField = value;
                    this.RaisePropertyChanged("FechaNacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((this.IdClienteField.Equals(value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="procSelectClientes_Result", Namespace="http://schemas.datacontract.org/2004/07/ModeloDatos")]
    [System.SerializableAttribute()]
    public partial class procSelectClientes_Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
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
        public System.Nullable<System.DateTime> FechaNacimiento {
            get {
                return this.FechaNacimientoField;
            }
            set {
                if ((this.FechaNacimientoField.Equals(value) != true)) {
                    this.FechaNacimientoField = value;
                    this.RaisePropertyChanged("FechaNacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFServiceClient.IServiceCliente")]
    public interface IServiceCliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/insertCliente", ReplyAction="http://tempuri.org/IServiceCliente/insertClienteResponse")]
        string insertCliente(UI.WCFServiceClient.tbCliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/insertCliente", ReplyAction="http://tempuri.org/IServiceCliente/insertClienteResponse")]
        System.Threading.Tasks.Task<string> insertClienteAsync(UI.WCFServiceClient.tbCliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/updateCliente", ReplyAction="http://tempuri.org/IServiceCliente/updateClienteResponse")]
        string updateCliente(UI.WCFServiceClient.tbCliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/updateCliente", ReplyAction="http://tempuri.org/IServiceCliente/updateClienteResponse")]
        System.Threading.Tasks.Task<string> updateClienteAsync(UI.WCFServiceClient.tbCliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/deleteCliente", ReplyAction="http://tempuri.org/IServiceCliente/deleteClienteResponse")]
        string deleteCliente(UI.WCFServiceClient.tbCliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/deleteCliente", ReplyAction="http://tempuri.org/IServiceCliente/deleteClienteResponse")]
        System.Threading.Tasks.Task<string> deleteClienteAsync(UI.WCFServiceClient.tbCliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/selectCliente", ReplyAction="http://tempuri.org/IServiceCliente/selectClienteResponse")]
        UI.WCFServiceClient.procSelectClientes_Result[] selectCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/selectCliente", ReplyAction="http://tempuri.org/IServiceCliente/selectClienteResponse")]
        System.Threading.Tasks.Task<UI.WCFServiceClient.procSelectClientes_Result[]> selectClienteAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceClienteChannel : UI.WCFServiceClient.IServiceCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClienteClient : System.ServiceModel.ClientBase<UI.WCFServiceClient.IServiceCliente>, UI.WCFServiceClient.IServiceCliente {
        
        public ServiceClienteClient() {
        }
        
        public ServiceClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string insertCliente(UI.WCFServiceClient.tbCliente c) {
            return base.Channel.insertCliente(c);
        }
        
        public System.Threading.Tasks.Task<string> insertClienteAsync(UI.WCFServiceClient.tbCliente c) {
            return base.Channel.insertClienteAsync(c);
        }
        
        public string updateCliente(UI.WCFServiceClient.tbCliente c) {
            return base.Channel.updateCliente(c);
        }
        
        public System.Threading.Tasks.Task<string> updateClienteAsync(UI.WCFServiceClient.tbCliente c) {
            return base.Channel.updateClienteAsync(c);
        }
        
        public string deleteCliente(UI.WCFServiceClient.tbCliente c) {
            return base.Channel.deleteCliente(c);
        }
        
        public System.Threading.Tasks.Task<string> deleteClienteAsync(UI.WCFServiceClient.tbCliente c) {
            return base.Channel.deleteClienteAsync(c);
        }
        
        public UI.WCFServiceClient.procSelectClientes_Result[] selectCliente() {
            return base.Channel.selectCliente();
        }
        
        public System.Threading.Tasks.Task<UI.WCFServiceClient.procSelectClientes_Result[]> selectClienteAsync() {
            return base.Channel.selectClienteAsync();
        }
    }
}

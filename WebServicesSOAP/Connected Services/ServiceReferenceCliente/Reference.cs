﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServicesSOAP.ServiceReferenceCliente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfClientes", Namespace="http://tempuri.org/", ItemName="clientes")]
    [System.SerializableAttribute()]
    public class ArrayOfClientes : System.Collections.Generic.List<WebServicesSOAP.ServiceReferenceCliente.clientes> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clientes", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class clientes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nifField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string direccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nif {
            get {
                return this.nifField;
            }
            set {
                if ((object.ReferenceEquals(this.nifField, value) != true)) {
                    this.nifField = value;
                    this.RaisePropertyChanged("nif");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string apellidos {
            get {
                return this.apellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.apellidosField, value) != true)) {
                    this.apellidosField = value;
                    this.RaisePropertyChanged("apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.telefonoField, value) != true)) {
                    this.telefonoField = value;
                    this.RaisePropertyChanged("telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                if ((object.ReferenceEquals(this.direccionField, value) != true)) {
                    this.direccionField = value;
                    this.RaisePropertyChanged("direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCliente.WebServiceSOAPSoap")]
    public interface WebServiceSOAPSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ClienteResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Cliente", ReplyAction="*")]
        WebServicesSOAP.ServiceReferenceCliente.ClienteResponse Cliente(WebServicesSOAP.ServiceReferenceCliente.ClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Cliente", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServicesSOAP.ServiceReferenceCliente.ClienteResponse> ClienteAsync(WebServicesSOAP.ServiceReferenceCliente.ClienteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Cliente", Namespace="http://tempuri.org/", Order=0)]
        public WebServicesSOAP.ServiceReferenceCliente.ClienteRequestBody Body;
        
        public ClienteRequest() {
        }
        
        public ClienteRequest(WebServicesSOAP.ServiceReferenceCliente.ClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ClienteRequestBody {
        
        public ClienteRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ClienteResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServicesSOAP.ServiceReferenceCliente.ClienteResponseBody Body;
        
        public ClienteResponse() {
        }
        
        public ClienteResponse(WebServicesSOAP.ServiceReferenceCliente.ClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServicesSOAP.ServiceReferenceCliente.ArrayOfClientes ClienteResult;
        
        public ClienteResponseBody() {
        }
        
        public ClienteResponseBody(WebServicesSOAP.ServiceReferenceCliente.ArrayOfClientes ClienteResult) {
            this.ClienteResult = ClienteResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSOAPSoapChannel : WebServicesSOAP.ServiceReferenceCliente.WebServiceSOAPSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSOAPSoapClient : System.ServiceModel.ClientBase<WebServicesSOAP.ServiceReferenceCliente.WebServiceSOAPSoap>, WebServicesSOAP.ServiceReferenceCliente.WebServiceSOAPSoap {
        
        public WebServiceSOAPSoapClient() {
        }
        
        public WebServiceSOAPSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSOAPSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSOAPSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSOAPSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServicesSOAP.ServiceReferenceCliente.ClienteResponse WebServicesSOAP.ServiceReferenceCliente.WebServiceSOAPSoap.Cliente(WebServicesSOAP.ServiceReferenceCliente.ClienteRequest request) {
            return base.Channel.Cliente(request);
        }
        
        public WebServicesSOAP.ServiceReferenceCliente.ArrayOfClientes Cliente() {
            WebServicesSOAP.ServiceReferenceCliente.ClienteRequest inValue = new WebServicesSOAP.ServiceReferenceCliente.ClienteRequest();
            inValue.Body = new WebServicesSOAP.ServiceReferenceCliente.ClienteRequestBody();
            WebServicesSOAP.ServiceReferenceCliente.ClienteResponse retVal = ((WebServicesSOAP.ServiceReferenceCliente.WebServiceSOAPSoap)(this)).Cliente(inValue);
            return retVal.Body.ClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServicesSOAP.ServiceReferenceCliente.ClienteResponse> WebServicesSOAP.ServiceReferenceCliente.WebServiceSOAPSoap.ClienteAsync(WebServicesSOAP.ServiceReferenceCliente.ClienteRequest request) {
            return base.Channel.ClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServicesSOAP.ServiceReferenceCliente.ClienteResponse> ClienteAsync() {
            WebServicesSOAP.ServiceReferenceCliente.ClienteRequest inValue = new WebServicesSOAP.ServiceReferenceCliente.ClienteRequest();
            inValue.Body = new WebServicesSOAP.ServiceReferenceCliente.ClienteRequestBody();
            return ((WebServicesSOAP.ServiceReferenceCliente.WebServiceSOAPSoap)(this)).ClienteAsync(inValue);
        }
    }
}

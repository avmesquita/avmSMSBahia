﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace avmSMSBahia.wsSMSBahia {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsSMSBahia.wssmsSoap")]
    public interface wssmsSoap {
        
        // CODEGEN: Generating message contract since element name User from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Envios", ReplyAction="*")]
        avmSMSBahia.wsSMSBahia.EnviosResponse Envios(avmSMSBahia.wsSMSBahia.EnviosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Envios", ReplyAction="*")]
        System.Threading.Tasks.Task<avmSMSBahia.wsSMSBahia.EnviosResponse> EnviosAsync(avmSMSBahia.wsSMSBahia.EnviosRequest request);
        
        // CODEGEN: Generating message contract since element name serial from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Retornos", ReplyAction="*")]
        avmSMSBahia.wsSMSBahia.RetornosResponse Retornos(avmSMSBahia.wsSMSBahia.RetornosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Retornos", ReplyAction="*")]
        System.Threading.Tasks.Task<avmSMSBahia.wsSMSBahia.RetornosResponse> RetornosAsync(avmSMSBahia.wsSMSBahia.RetornosRequest request);
        
        // CODEGEN: Generating message contract since element name User from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Status", ReplyAction="*")]
        avmSMSBahia.wsSMSBahia.StatusResponse Status(avmSMSBahia.wsSMSBahia.StatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Status", ReplyAction="*")]
        System.Threading.Tasks.Task<avmSMSBahia.wsSMSBahia.StatusResponse> StatusAsync(avmSMSBahia.wsSMSBahia.StatusRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EnviosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Envios", Namespace="http://tempuri.org/", Order=0)]
        public avmSMSBahia.wsSMSBahia.EnviosRequestBody Body;
        
        public EnviosRequest() {
        }
        
        public EnviosRequest(avmSMSBahia.wsSMSBahia.EnviosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EnviosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int tipo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string User;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Token;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Json;
        
        public EnviosRequestBody() {
        }
        
        public EnviosRequestBody(int tipo, string User, string Token, string Json) {
            this.tipo = tipo;
            this.User = User;
            this.Token = Token;
            this.Json = Json;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EnviosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EnviosResponse", Namespace="http://tempuri.org/", Order=0)]
        public avmSMSBahia.wsSMSBahia.EnviosResponseBody Body;
        
        public EnviosResponse() {
        }
        
        public EnviosResponse(avmSMSBahia.wsSMSBahia.EnviosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EnviosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string EnviosResult;
        
        public EnviosResponseBody() {
        }
        
        public EnviosResponseBody(string EnviosResult) {
            this.EnviosResult = EnviosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RetornosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Retornos", Namespace="http://tempuri.org/", Order=0)]
        public avmSMSBahia.wsSMSBahia.RetornosRequestBody Body;
        
        public RetornosRequest() {
        }
        
        public RetornosRequest(avmSMSBahia.wsSMSBahia.RetornosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RetornosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string serial;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string conta;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string sub_conta;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Periodo_inicial;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Periodo_final;
        
        public RetornosRequestBody() {
        }
        
        public RetornosRequestBody(string serial, string conta, string sub_conta, string Periodo_inicial, string Periodo_final) {
            this.serial = serial;
            this.conta = conta;
            this.sub_conta = sub_conta;
            this.Periodo_inicial = Periodo_inicial;
            this.Periodo_final = Periodo_final;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RetornosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RetornosResponse", Namespace="http://tempuri.org/", Order=0)]
        public avmSMSBahia.wsSMSBahia.RetornosResponseBody Body;
        
        public RetornosResponse() {
        }
        
        public RetornosResponse(avmSMSBahia.wsSMSBahia.RetornosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RetornosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string RetornosResult;
        
        public RetornosResponseBody() {
        }
        
        public RetornosResponseBody(string RetornosResult) {
            this.RetornosResult = RetornosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StatusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Status", Namespace="http://tempuri.org/", Order=0)]
        public avmSMSBahia.wsSMSBahia.StatusRequestBody Body;
        
        public StatusRequest() {
        }
        
        public StatusRequest(avmSMSBahia.wsSMSBahia.StatusRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StatusRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string User;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Token;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string id;
        
        public StatusRequestBody() {
        }
        
        public StatusRequestBody(string User, string Token, string id) {
            this.User = User;
            this.Token = Token;
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StatusResponse", Namespace="http://tempuri.org/", Order=0)]
        public avmSMSBahia.wsSMSBahia.StatusResponseBody Body;
        
        public StatusResponse() {
        }
        
        public StatusResponse(avmSMSBahia.wsSMSBahia.StatusResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class StatusResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string StatusResult;
        
        public StatusResponseBody() {
        }
        
        public StatusResponseBody(string StatusResult) {
            this.StatusResult = StatusResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wssmsSoapChannel : avmSMSBahia.wsSMSBahia.wssmsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wssmsSoapClient : System.ServiceModel.ClientBase<avmSMSBahia.wsSMSBahia.wssmsSoap>, avmSMSBahia.wsSMSBahia.wssmsSoap {
        
        public wssmsSoapClient() {
        }
        
        public wssmsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wssmsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wssmsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wssmsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        avmSMSBahia.wsSMSBahia.EnviosResponse avmSMSBahia.wsSMSBahia.wssmsSoap.Envios(avmSMSBahia.wsSMSBahia.EnviosRequest request) {
            return base.Channel.Envios(request);
        }
        
        public string Envios(int tipo, string User, string Token, string Json) {
            avmSMSBahia.wsSMSBahia.EnviosRequest inValue = new avmSMSBahia.wsSMSBahia.EnviosRequest();
            inValue.Body = new avmSMSBahia.wsSMSBahia.EnviosRequestBody();
            inValue.Body.tipo = tipo;
            inValue.Body.User = User;
            inValue.Body.Token = Token;
            inValue.Body.Json = Json;
            avmSMSBahia.wsSMSBahia.EnviosResponse retVal = ((avmSMSBahia.wsSMSBahia.wssmsSoap)(this)).Envios(inValue);
            return retVal.Body.EnviosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<avmSMSBahia.wsSMSBahia.EnviosResponse> avmSMSBahia.wsSMSBahia.wssmsSoap.EnviosAsync(avmSMSBahia.wsSMSBahia.EnviosRequest request) {
            return base.Channel.EnviosAsync(request);
        }
        
        public System.Threading.Tasks.Task<avmSMSBahia.wsSMSBahia.EnviosResponse> EnviosAsync(int tipo, string User, string Token, string Json) {
            avmSMSBahia.wsSMSBahia.EnviosRequest inValue = new avmSMSBahia.wsSMSBahia.EnviosRequest();
            inValue.Body = new avmSMSBahia.wsSMSBahia.EnviosRequestBody();
            inValue.Body.tipo = tipo;
            inValue.Body.User = User;
            inValue.Body.Token = Token;
            inValue.Body.Json = Json;
            return ((avmSMSBahia.wsSMSBahia.wssmsSoap)(this)).EnviosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        avmSMSBahia.wsSMSBahia.RetornosResponse avmSMSBahia.wsSMSBahia.wssmsSoap.Retornos(avmSMSBahia.wsSMSBahia.RetornosRequest request) {
            return base.Channel.Retornos(request);
        }
        
        public string Retornos(string serial, string conta, string sub_conta, string Periodo_inicial, string Periodo_final) {
            avmSMSBahia.wsSMSBahia.RetornosRequest inValue = new avmSMSBahia.wsSMSBahia.RetornosRequest();
            inValue.Body = new avmSMSBahia.wsSMSBahia.RetornosRequestBody();
            inValue.Body.serial = serial;
            inValue.Body.conta = conta;
            inValue.Body.sub_conta = sub_conta;
            inValue.Body.Periodo_inicial = Periodo_inicial;
            inValue.Body.Periodo_final = Periodo_final;
            avmSMSBahia.wsSMSBahia.RetornosResponse retVal = ((avmSMSBahia.wsSMSBahia.wssmsSoap)(this)).Retornos(inValue);
            return retVal.Body.RetornosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<avmSMSBahia.wsSMSBahia.RetornosResponse> avmSMSBahia.wsSMSBahia.wssmsSoap.RetornosAsync(avmSMSBahia.wsSMSBahia.RetornosRequest request) {
            return base.Channel.RetornosAsync(request);
        }
        
        public System.Threading.Tasks.Task<avmSMSBahia.wsSMSBahia.RetornosResponse> RetornosAsync(string serial, string conta, string sub_conta, string Periodo_inicial, string Periodo_final) {
            avmSMSBahia.wsSMSBahia.RetornosRequest inValue = new avmSMSBahia.wsSMSBahia.RetornosRequest();
            inValue.Body = new avmSMSBahia.wsSMSBahia.RetornosRequestBody();
            inValue.Body.serial = serial;
            inValue.Body.conta = conta;
            inValue.Body.sub_conta = sub_conta;
            inValue.Body.Periodo_inicial = Periodo_inicial;
            inValue.Body.Periodo_final = Periodo_final;
            return ((avmSMSBahia.wsSMSBahia.wssmsSoap)(this)).RetornosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        avmSMSBahia.wsSMSBahia.StatusResponse avmSMSBahia.wsSMSBahia.wssmsSoap.Status(avmSMSBahia.wsSMSBahia.StatusRequest request) {
            return base.Channel.Status(request);
        }
        
        public string Status(string User, string Token, string id) {
            avmSMSBahia.wsSMSBahia.StatusRequest inValue = new avmSMSBahia.wsSMSBahia.StatusRequest();
            inValue.Body = new avmSMSBahia.wsSMSBahia.StatusRequestBody();
            inValue.Body.User = User;
            inValue.Body.Token = Token;
            inValue.Body.id = id;
            avmSMSBahia.wsSMSBahia.StatusResponse retVal = ((avmSMSBahia.wsSMSBahia.wssmsSoap)(this)).Status(inValue);
            return retVal.Body.StatusResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<avmSMSBahia.wsSMSBahia.StatusResponse> avmSMSBahia.wsSMSBahia.wssmsSoap.StatusAsync(avmSMSBahia.wsSMSBahia.StatusRequest request) {
            return base.Channel.StatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<avmSMSBahia.wsSMSBahia.StatusResponse> StatusAsync(string User, string Token, string id) {
            avmSMSBahia.wsSMSBahia.StatusRequest inValue = new avmSMSBahia.wsSMSBahia.StatusRequest();
            inValue.Body = new avmSMSBahia.wsSMSBahia.StatusRequestBody();
            inValue.Body.User = User;
            inValue.Body.Token = Token;
            inValue.Body.id = id;
            return ((avmSMSBahia.wsSMSBahia.wssmsSoap)(this)).StatusAsync(inValue);
        }
    }
}
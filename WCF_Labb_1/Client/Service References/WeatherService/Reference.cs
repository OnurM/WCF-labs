﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.WeatherService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeatherService.WeatherSoap")]
    public interface WeatherSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Client.WeatherService.HelloWorldResponse HelloWorld(Client.WeatherService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.WeatherService.HelloWorldResponse> HelloWorldAsync(Client.WeatherService.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name GetWeatherConditionResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetWeatherCondition", ReplyAction="*")]
        Client.WeatherService.GetWeatherConditionResponse GetWeatherCondition(Client.WeatherService.GetWeatherConditionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetWeatherCondition", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.WeatherService.GetWeatherConditionResponse> GetWeatherConditionAsync(Client.WeatherService.GetWeatherConditionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Client.WeatherService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Client.WeatherService.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.WeatherService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Client.WeatherService.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWeatherConditionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWeatherCondition", Namespace="http://tempuri.org/", Order=0)]
        public Client.WeatherService.GetWeatherConditionRequestBody Body;
        
        public GetWeatherConditionRequest() {
        }
        
        public GetWeatherConditionRequest(Client.WeatherService.GetWeatherConditionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetWeatherConditionRequestBody {
        
        public GetWeatherConditionRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWeatherConditionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWeatherConditionResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.WeatherService.GetWeatherConditionResponseBody Body;
        
        public GetWeatherConditionResponse() {
        }
        
        public GetWeatherConditionResponse(Client.WeatherService.GetWeatherConditionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetWeatherConditionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetWeatherConditionResult;
        
        public GetWeatherConditionResponseBody() {
        }
        
        public GetWeatherConditionResponseBody(string GetWeatherConditionResult) {
            this.GetWeatherConditionResult = GetWeatherConditionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WeatherSoapChannel : Client.WeatherService.WeatherSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherSoapClient : System.ServiceModel.ClientBase<Client.WeatherService.WeatherSoap>, Client.WeatherService.WeatherSoap {
        
        public WeatherSoapClient() {
        }
        
        public WeatherSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.WeatherService.HelloWorldResponse Client.WeatherService.WeatherSoap.HelloWorld(Client.WeatherService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Client.WeatherService.HelloWorldRequest inValue = new Client.WeatherService.HelloWorldRequest();
            inValue.Body = new Client.WeatherService.HelloWorldRequestBody();
            Client.WeatherService.HelloWorldResponse retVal = ((Client.WeatherService.WeatherSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.WeatherService.HelloWorldResponse> Client.WeatherService.WeatherSoap.HelloWorldAsync(Client.WeatherService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.WeatherService.HelloWorldResponse> HelloWorldAsync() {
            Client.WeatherService.HelloWorldRequest inValue = new Client.WeatherService.HelloWorldRequest();
            inValue.Body = new Client.WeatherService.HelloWorldRequestBody();
            return ((Client.WeatherService.WeatherSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.WeatherService.GetWeatherConditionResponse Client.WeatherService.WeatherSoap.GetWeatherCondition(Client.WeatherService.GetWeatherConditionRequest request) {
            return base.Channel.GetWeatherCondition(request);
        }
        
        public string GetWeatherCondition() {
            Client.WeatherService.GetWeatherConditionRequest inValue = new Client.WeatherService.GetWeatherConditionRequest();
            inValue.Body = new Client.WeatherService.GetWeatherConditionRequestBody();
            Client.WeatherService.GetWeatherConditionResponse retVal = ((Client.WeatherService.WeatherSoap)(this)).GetWeatherCondition(inValue);
            return retVal.Body.GetWeatherConditionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.WeatherService.GetWeatherConditionResponse> Client.WeatherService.WeatherSoap.GetWeatherConditionAsync(Client.WeatherService.GetWeatherConditionRequest request) {
            return base.Channel.GetWeatherConditionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.WeatherService.GetWeatherConditionResponse> GetWeatherConditionAsync() {
            Client.WeatherService.GetWeatherConditionRequest inValue = new Client.WeatherService.GetWeatherConditionRequest();
            inValue.Body = new Client.WeatherService.GetWeatherConditionRequestBody();
            return ((Client.WeatherService.WeatherSoap)(this)).GetWeatherConditionAsync(inValue);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF.Hobby.Client.SearchForChampionsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SearchForChampionsService.SearchForChampionsServiceSoap")]
    public interface SearchForChampionsServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetupDict", ReplyAction="*")]
        void SetupDict();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetupDict", ReplyAction="*")]
        System.Threading.Tasks.Task SetupDictAsync();
        
        // CODEGEN: Generating message contract since element name year from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetChampionsByYear", ReplyAction="*")]
        WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearResponse GetChampionsByYear(WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetChampionsByYear", ReplyAction="*")]
        System.Threading.Tasks.Task<WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearResponse> GetChampionsByYearAsync(WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetChampionsByYearRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetChampionsByYear", Namespace="http://tempuri.org/", Order=0)]
        public WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequestBody Body;
        
        public GetChampionsByYearRequest() {
        }
        
        public GetChampionsByYearRequest(WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetChampionsByYearRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string year;
        
        public GetChampionsByYearRequestBody() {
        }
        
        public GetChampionsByYearRequestBody(string year) {
            this.year = year;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetChampionsByYearResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetChampionsByYearResponse", Namespace="http://tempuri.org/", Order=0)]
        public WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearResponseBody Body;
        
        public GetChampionsByYearResponse() {
        }
        
        public GetChampionsByYearResponse(WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetChampionsByYearResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetChampionsByYearResult;
        
        public GetChampionsByYearResponseBody() {
        }
        
        public GetChampionsByYearResponseBody(string GetChampionsByYearResult) {
            this.GetChampionsByYearResult = GetChampionsByYearResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SearchForChampionsServiceSoapChannel : WCF.Hobby.Client.SearchForChampionsService.SearchForChampionsServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SearchForChampionsServiceSoapClient : System.ServiceModel.ClientBase<WCF.Hobby.Client.SearchForChampionsService.SearchForChampionsServiceSoap>, WCF.Hobby.Client.SearchForChampionsService.SearchForChampionsServiceSoap {
        
        public SearchForChampionsServiceSoapClient() {
        }
        
        public SearchForChampionsServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SearchForChampionsServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearchForChampionsServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearchForChampionsServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SetupDict() {
            base.Channel.SetupDict();
        }
        
        public System.Threading.Tasks.Task SetupDictAsync() {
            return base.Channel.SetupDictAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearResponse WCF.Hobby.Client.SearchForChampionsService.SearchForChampionsServiceSoap.GetChampionsByYear(WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequest request) {
            return base.Channel.GetChampionsByYear(request);
        }
        
        public string GetChampionsByYear(string year) {
            WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequest inValue = new WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequest();
            inValue.Body = new WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequestBody();
            inValue.Body.year = year;
            WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearResponse retVal = ((WCF.Hobby.Client.SearchForChampionsService.SearchForChampionsServiceSoap)(this)).GetChampionsByYear(inValue);
            return retVal.Body.GetChampionsByYearResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearResponse> WCF.Hobby.Client.SearchForChampionsService.SearchForChampionsServiceSoap.GetChampionsByYearAsync(WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequest request) {
            return base.Channel.GetChampionsByYearAsync(request);
        }
        
        public System.Threading.Tasks.Task<WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearResponse> GetChampionsByYearAsync(string year) {
            WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequest inValue = new WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequest();
            inValue.Body = new WCF.Hobby.Client.SearchForChampionsService.GetChampionsByYearRequestBody();
            inValue.Body.year = year;
            return ((WCF.Hobby.Client.SearchForChampionsService.SearchForChampionsServiceSoap)(this)).GetChampionsByYearAsync(inValue);
        }
    }
}

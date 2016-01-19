﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.AnimatedOscarWinnersService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AnimatedOscarWinnersService.AnimatedOscarWinningMovieSoap")]
    public interface AnimatedOscarWinningMovieSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetupOscarWinningMovies", ReplyAction="*")]
        void SetupOscarWinningMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetupOscarWinningMovies", ReplyAction="*")]
        System.Threading.Tasks.Task SetupOscarWinningMoviesAsync();
        
        // CODEGEN: Generating message contract since element name year from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMovieByYear", ReplyAction="*")]
        Client.AnimatedOscarWinnersService.GetMovieByYearResponse GetMovieByYear(Client.AnimatedOscarWinnersService.GetMovieByYearRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMovieByYear", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.AnimatedOscarWinnersService.GetMovieByYearResponse> GetMovieByYearAsync(Client.AnimatedOscarWinnersService.GetMovieByYearRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMovieByYearRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMovieByYear", Namespace="http://tempuri.org/", Order=0)]
        public Client.AnimatedOscarWinnersService.GetMovieByYearRequestBody Body;
        
        public GetMovieByYearRequest() {
        }
        
        public GetMovieByYearRequest(Client.AnimatedOscarWinnersService.GetMovieByYearRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMovieByYearRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string year;
        
        public GetMovieByYearRequestBody() {
        }
        
        public GetMovieByYearRequestBody(string year) {
            this.year = year;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMovieByYearResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMovieByYearResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.AnimatedOscarWinnersService.GetMovieByYearResponseBody Body;
        
        public GetMovieByYearResponse() {
        }
        
        public GetMovieByYearResponse(Client.AnimatedOscarWinnersService.GetMovieByYearResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMovieByYearResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetMovieByYearResult;
        
        public GetMovieByYearResponseBody() {
        }
        
        public GetMovieByYearResponseBody(string GetMovieByYearResult) {
            this.GetMovieByYearResult = GetMovieByYearResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AnimatedOscarWinningMovieSoapChannel : Client.AnimatedOscarWinnersService.AnimatedOscarWinningMovieSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AnimatedOscarWinningMovieSoapClient : System.ServiceModel.ClientBase<Client.AnimatedOscarWinnersService.AnimatedOscarWinningMovieSoap>, Client.AnimatedOscarWinnersService.AnimatedOscarWinningMovieSoap {
        
        public AnimatedOscarWinningMovieSoapClient() {
        }
        
        public AnimatedOscarWinningMovieSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AnimatedOscarWinningMovieSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnimatedOscarWinningMovieSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnimatedOscarWinningMovieSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SetupOscarWinningMovies() {
            base.Channel.SetupOscarWinningMovies();
        }
        
        public System.Threading.Tasks.Task SetupOscarWinningMoviesAsync() {
            return base.Channel.SetupOscarWinningMoviesAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.AnimatedOscarWinnersService.GetMovieByYearResponse Client.AnimatedOscarWinnersService.AnimatedOscarWinningMovieSoap.GetMovieByYear(Client.AnimatedOscarWinnersService.GetMovieByYearRequest request) {
            return base.Channel.GetMovieByYear(request);
        }
        
        public string GetMovieByYear(string year) {
            Client.AnimatedOscarWinnersService.GetMovieByYearRequest inValue = new Client.AnimatedOscarWinnersService.GetMovieByYearRequest();
            inValue.Body = new Client.AnimatedOscarWinnersService.GetMovieByYearRequestBody();
            inValue.Body.year = year;
            Client.AnimatedOscarWinnersService.GetMovieByYearResponse retVal = ((Client.AnimatedOscarWinnersService.AnimatedOscarWinningMovieSoap)(this)).GetMovieByYear(inValue);
            return retVal.Body.GetMovieByYearResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.AnimatedOscarWinnersService.GetMovieByYearResponse> Client.AnimatedOscarWinnersService.AnimatedOscarWinningMovieSoap.GetMovieByYearAsync(Client.AnimatedOscarWinnersService.GetMovieByYearRequest request) {
            return base.Channel.GetMovieByYearAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.AnimatedOscarWinnersService.GetMovieByYearResponse> GetMovieByYearAsync(string year) {
            Client.AnimatedOscarWinnersService.GetMovieByYearRequest inValue = new Client.AnimatedOscarWinnersService.GetMovieByYearRequest();
            inValue.Body = new Client.AnimatedOscarWinnersService.GetMovieByYearRequestBody();
            inValue.Body.year = year;
            return ((Client.AnimatedOscarWinnersService.AnimatedOscarWinningMovieSoap)(this)).GetMovieByYearAsync(inValue);
        }
    }
}
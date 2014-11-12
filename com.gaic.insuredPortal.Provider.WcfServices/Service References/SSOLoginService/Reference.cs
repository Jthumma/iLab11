﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sso.soapstation.actional.com", ConfigurationName="SSOLoginService.SSOLoginPort")]
    public interface SSOLoginPort {
        
        // CODEGEN: Generating message contract since element name loginReturn from namespace http://sso.soapstation.actional.com is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sso.soapstation.actional.com/login", ReplyAction="*")]
        com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginResponse login(com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sso.soapstation.actional.com/login", ReplyAction="*")]
        System.Threading.Tasks.Task<com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginResponse> loginAsync(com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class loginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="login", Namespace="http://sso.soapstation.actional.com", Order=0)]
        public com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequestBody Body;
        
        public loginRequest() {
        }
        
        public loginRequest(com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class loginRequestBody {
        
        public loginRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class loginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="loginResponse", Namespace="http://sso.soapstation.actional.com", Order=0)]
        public com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginResponseBody Body;
        
        public loginResponse() {
        }
        
        public loginResponse(com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sso.soapstation.actional.com")]
    public partial class loginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string loginReturn;
        
        public loginResponseBody() {
        }
        
        public loginResponseBody(string loginReturn) {
            this.loginReturn = loginReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SSOLoginPortChannel : com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.SSOLoginPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SSOLoginPortClient : System.ServiceModel.ClientBase<com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.SSOLoginPort>, com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.SSOLoginPort {
        
        public SSOLoginPortClient() {
        }
        
        public SSOLoginPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SSOLoginPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SSOLoginPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SSOLoginPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginResponse com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.SSOLoginPort.login(com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequest request) {
            return base.Channel.login(request);
        }
        
        public string login() {
            com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequest inValue = new com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequest();
            inValue.Body = new com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequestBody();
            com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginResponse retVal = ((com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.SSOLoginPort)(this)).login(inValue);
            return retVal.Body.loginReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginResponse> com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.SSOLoginPort.loginAsync(com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequest request) {
            return base.Channel.loginAsync(request);
        }
        
        public System.Threading.Tasks.Task<com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginResponse> loginAsync() {
            com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequest inValue = new com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequest();
            inValue.Body = new com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.loginRequestBody();
            return ((com.gaic.insuredPortal.Provider.WcfServices.SSOLoginService.SSOLoginPort)(this)).loginAsync(inValue);
        }
    }
}
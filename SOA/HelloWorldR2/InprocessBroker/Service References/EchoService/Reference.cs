﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InprocessBroker.EchoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EchoService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Echo", ReplyAction="http://tempuri.org/IService1/EchoResponse")]
        InprocessBroker.EchoService.EchoResponse Echo(InprocessBroker.EchoService.EchoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EchoDelay", ReplyAction="http://tempuri.org/IService1/EchoDelayResponse")]
        InprocessBroker.EchoService.EchoDelayResponse EchoDelay(InprocessBroker.EchoService.EchoDelayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EchoFault", ReplyAction="http://tempuri.org/IService1/EchoFaultResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.DivideByZeroException), Action="http://tempuri.org/IService1/EchoFaultDivideByZeroExceptionFault", Name="DivideByZeroException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.OutOfMemoryException), Action="http://tempuri.org/IService1/EchoFaultOutOfMemoryExceptionFault", Name="OutOfMemoryException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IService1/EchoFaultExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/IService1/EchoFaultArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentNullException), Action="http://tempuri.org/IService1/EchoFaultArgumentNullExceptionFault", Name="ArgumentNullException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        InprocessBroker.EchoService.EchoFaultResponse EchoFault(InprocessBroker.EchoService.EchoFaultRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EchoOnExit", ReplyAction="http://tempuri.org/IService1/EchoOnExitResponse")]
        InprocessBroker.EchoService.EchoOnExitResponse EchoOnExit(InprocessBroker.EchoService.EchoOnExitRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Echo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string input;
        
        public EchoRequest() {
        }
        
        public EchoRequest(string input) {
            this.input = input;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EchoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string EchoResult;
        
        public EchoResponse() {
        }
        
        public EchoResponse(string EchoResult) {
            this.EchoResult = EchoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EchoDelay", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoDelayRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int delayMs;
        
        public EchoDelayRequest() {
        }
        
        public EchoDelayRequest(int delayMs) {
            this.delayMs = delayMs;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EchoDelayResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoDelayResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int EchoDelayResult;
        
        public EchoDelayResponse() {
        }
        
        public EchoDelayResponse(int EchoDelayResult) {
            this.EchoDelayResult = EchoDelayResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EchoFault", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoFaultRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string exceptionType;
        
        public EchoFaultRequest() {
        }
        
        public EchoFaultRequest(string exceptionType) {
            this.exceptionType = exceptionType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EchoFaultResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoFaultResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string EchoFaultResult;
        
        public EchoFaultResponse() {
        }
        
        public EchoFaultResponse(string EchoFaultResult) {
            this.EchoFaultResult = EchoFaultResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EchoOnExit", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoOnExitRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.TimeSpan delay;
        
        public EchoOnExitRequest() {
        }
        
        public EchoOnExitRequest(System.TimeSpan delay) {
            this.delay = delay;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EchoOnExitResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EchoOnExitResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string EchoOnExitResult;
        
        public EchoOnExitResponse() {
        }
        
        public EchoOnExitResponse(string EchoOnExitResult) {
            this.EchoOnExitResult = EchoOnExitResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : InprocessBroker.EchoService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<InprocessBroker.EchoService.IService1>, InprocessBroker.EchoService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public InprocessBroker.EchoService.EchoResponse Echo(InprocessBroker.EchoService.EchoRequest request) {
            return base.Channel.Echo(request);
        }
        
        public InprocessBroker.EchoService.EchoDelayResponse EchoDelay(InprocessBroker.EchoService.EchoDelayRequest request) {
            return base.Channel.EchoDelay(request);
        }
        
        public InprocessBroker.EchoService.EchoFaultResponse EchoFault(InprocessBroker.EchoService.EchoFaultRequest request) {
            return base.Channel.EchoFault(request);
        }
        
        public InprocessBroker.EchoService.EchoOnExitResponse EchoOnExit(InprocessBroker.EchoService.EchoOnExitRequest request) {
            return base.Channel.EchoOnExit(request);
        }
    }
}
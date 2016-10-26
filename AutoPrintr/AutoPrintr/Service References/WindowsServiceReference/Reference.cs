﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoPrintr.WindowsServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WindowsServiceReference.IWindowsService", CallbackContract=typeof(AutoPrintr.WindowsServiceReference.IWindowsServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IWindowsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/Connect", ReplyAction="http://tempuri.org/IWindowsService/ConnectResponse")]
        void Connect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/Connect", ReplyAction="http://tempuri.org/IWindowsService/ConnectResponse")]
        System.Threading.Tasks.Task ConnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/Disconnect", ReplyAction="http://tempuri.org/IWindowsService/DisconnectResponse")]
        void Disconnect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/Disconnect", ReplyAction="http://tempuri.org/IWindowsService/DisconnectResponse")]
        System.Threading.Tasks.Task DisconnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/GetPrinters", ReplyAction="http://tempuri.org/IWindowsService/GetPrintersResponse")]
        AutoPrintr.Core.Models.Printer[] GetPrinters();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/GetPrinters", ReplyAction="http://tempuri.org/IWindowsService/GetPrintersResponse")]
        System.Threading.Tasks.Task<AutoPrintr.Core.Models.Printer[]> GetPrintersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/GetJobs", ReplyAction="http://tempuri.org/IWindowsService/GetJobsResponse")]
        AutoPrintr.Core.Models.Job[] GetJobs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/GetJobs", ReplyAction="http://tempuri.org/IWindowsService/GetJobsResponse")]
        System.Threading.Tasks.Task<AutoPrintr.Core.Models.Job[]> GetJobsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/Print", ReplyAction="http://tempuri.org/IWindowsService/PrintResponse")]
        void Print(AutoPrintr.Core.Models.Job job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/Print", ReplyAction="http://tempuri.org/IWindowsService/PrintResponse")]
        System.Threading.Tasks.Task PrintAsync(AutoPrintr.Core.Models.Job job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/DeleteJobs", ReplyAction="http://tempuri.org/IWindowsService/DeleteJobsResponse")]
        void DeleteJobs(AutoPrintr.Core.Models.Job[] jobs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/DeleteJobs", ReplyAction="http://tempuri.org/IWindowsService/DeleteJobsResponse")]
        System.Threading.Tasks.Task DeleteJobsAsync(AutoPrintr.Core.Models.Job[] jobs);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWindowsServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWindowsService/JobChanged", ReplyAction="http://tempuri.org/IWindowsService/JobChangedResponse")]
        void JobChanged(AutoPrintr.Core.Models.Job job);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWindowsServiceChannel : AutoPrintr.WindowsServiceReference.IWindowsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WindowsServiceClient : System.ServiceModel.DuplexClientBase<AutoPrintr.WindowsServiceReference.IWindowsService>, AutoPrintr.WindowsServiceReference.IWindowsService {
        
        public WindowsServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public WindowsServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public WindowsServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WindowsServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WindowsServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Connect() {
            base.Channel.Connect();
        }
        
        public System.Threading.Tasks.Task ConnectAsync() {
            return base.Channel.ConnectAsync();
        }
        
        public void Disconnect() {
            base.Channel.Disconnect();
        }
        
        public System.Threading.Tasks.Task DisconnectAsync() {
            return base.Channel.DisconnectAsync();
        }
        
        public AutoPrintr.Core.Models.Printer[] GetPrinters() {
            return base.Channel.GetPrinters();
        }
        
        public System.Threading.Tasks.Task<AutoPrintr.Core.Models.Printer[]> GetPrintersAsync() {
            return base.Channel.GetPrintersAsync();
        }
        
        public AutoPrintr.Core.Models.Job[] GetJobs() {
            return base.Channel.GetJobs();
        }
        
        public System.Threading.Tasks.Task<AutoPrintr.Core.Models.Job[]> GetJobsAsync() {
            return base.Channel.GetJobsAsync();
        }
        
        public void Print(AutoPrintr.Core.Models.Job job) {
            base.Channel.Print(job);
        }
        
        public System.Threading.Tasks.Task PrintAsync(AutoPrintr.Core.Models.Job job) {
            return base.Channel.PrintAsync(job);
        }
        
        public void DeleteJobs(AutoPrintr.Core.Models.Job[] jobs) {
            base.Channel.DeleteJobs(jobs);
        }
        
        public System.Threading.Tasks.Task DeleteJobsAsync(AutoPrintr.Core.Models.Job[] jobs) {
            return base.Channel.DeleteJobsAsync(jobs);
        }
    }
}
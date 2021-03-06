//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICustomerWcf")]
    public interface ICustomerWcf {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerWcf/getTheNewest10PublicFilesBySubject", ReplyAction="http://tempuri.org/ICustomerWcf/getTheNewest10PublicFilesBySubjectResponse")]
        System.Data.DataTable getTheNewest10PublicFilesBySubject(string subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerWcf/getTheNewest10PublicFilesBySubject", ReplyAction="http://tempuri.org/ICustomerWcf/getTheNewest10PublicFilesBySubjectResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> getTheNewest10PublicFilesBySubjectAsync(string subject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerWcf/getCustomersWith90Quota", ReplyAction="http://tempuri.org/ICustomerWcf/getCustomersWith90QuotaResponse")]
        System.Data.DataTable getCustomersWith90Quota();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerWcf/getCustomersWith90Quota", ReplyAction="http://tempuri.org/ICustomerWcf/getCustomersWith90QuotaResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> getCustomersWith90QuotaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerWcf/updateCustomerQuota", ReplyAction="http://tempuri.org/ICustomerWcf/updateCustomerQuotaResponse")]
        bool updateCustomerQuota(string newQuota, string customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerWcf/updateCustomerQuota", ReplyAction="http://tempuri.org/ICustomerWcf/updateCustomerQuotaResponse")]
        System.Threading.Tasks.Task<bool> updateCustomerQuotaAsync(string newQuota, string customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerWcf/updateFileAvailability", ReplyAction="http://tempuri.org/ICustomerWcf/updateFileAvailabilityResponse")]
        bool updateFileAvailability(string available, string fileId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerWcf/updateFileAvailability", ReplyAction="http://tempuri.org/ICustomerWcf/updateFileAvailabilityResponse")]
        System.Threading.Tasks.Task<bool> updateFileAvailabilityAsync(string available, string fileId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerWcf/checkAdmin", ReplyAction="http://tempuri.org/ICustomerWcf/checkAdminResponse")]
        bool checkAdmin(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerWcf/checkAdmin", ReplyAction="http://tempuri.org/ICustomerWcf/checkAdminResponse")]
        System.Threading.Tasks.Task<bool> checkAdminAsync(string userName, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerWcfChannel : WcfClient.ServiceReference1.ICustomerWcf, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerWcfClient : System.ServiceModel.ClientBase<WcfClient.ServiceReference1.ICustomerWcf>, WcfClient.ServiceReference1.ICustomerWcf {
        
        public CustomerWcfClient() {
        }
        
        public CustomerWcfClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerWcfClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerWcfClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerWcfClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable getTheNewest10PublicFilesBySubject(string subject) {
            return base.Channel.getTheNewest10PublicFilesBySubject(subject);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getTheNewest10PublicFilesBySubjectAsync(string subject) {
            return base.Channel.getTheNewest10PublicFilesBySubjectAsync(subject);
        }
        
        public System.Data.DataTable getCustomersWith90Quota() {
            return base.Channel.getCustomersWith90Quota();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getCustomersWith90QuotaAsync() {
            return base.Channel.getCustomersWith90QuotaAsync();
        }
        
        public bool updateCustomerQuota(string newQuota, string customerId) {
            return base.Channel.updateCustomerQuota(newQuota, customerId);
        }
        
        public System.Threading.Tasks.Task<bool> updateCustomerQuotaAsync(string newQuota, string customerId) {
            return base.Channel.updateCustomerQuotaAsync(newQuota, customerId);
        }
        
        public bool updateFileAvailability(string available, string fileId) {
            return base.Channel.updateFileAvailability(available, fileId);
        }
        
        public System.Threading.Tasks.Task<bool> updateFileAvailabilityAsync(string available, string fileId) {
            return base.Channel.updateFileAvailabilityAsync(available, fileId);
        }
        
        public bool checkAdmin(string userName, string password) {
            return base.Channel.checkAdmin(userName, password);
        }
        
        public System.Threading.Tasks.Task<bool> checkAdminAsync(string userName, string password) {
            return base.Channel.checkAdminAsync(userName, password);
        }
    }
}

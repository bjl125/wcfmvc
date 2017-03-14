﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFMVC.Web.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserModel", Namespace="http://schemas.datacontract.org/2004/07/WCFMVC.ModelObject.Models")]
    [System.SerializableAttribute()]
    public partial class UserModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public System.DateTime CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IUserServices")]
    public interface IUserServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetUserInfo", ReplyAction="http://tempuri.org/IUserServices/GetUserInfoResponse")]
        WCFMVC.Web.ServiceReference1.UserModel GetUserInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetUserInfo", ReplyAction="http://tempuri.org/IUserServices/GetUserInfoResponse")]
        System.Threading.Tasks.Task<WCFMVC.Web.ServiceReference1.UserModel> GetUserInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/UpdateUserName", ReplyAction="http://tempuri.org/IUserServices/UpdateUserNameResponse")]
        bool UpdateUserName(int userid, string usernewname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/UpdateUserName", ReplyAction="http://tempuri.org/IUserServices/UpdateUserNameResponse")]
        System.Threading.Tasks.Task<bool> UpdateUserNameAsync(int userid, string usernewname);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServicesChannel : WCFMVC.Web.ServiceReference1.IUserServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServicesClient : System.ServiceModel.ClientBase<WCFMVC.Web.ServiceReference1.IUserServices>, WCFMVC.Web.ServiceReference1.IUserServices {
        
        public UserServicesClient() {
        }
        
        public UserServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFMVC.Web.ServiceReference1.UserModel GetUserInfo() {
            return base.Channel.GetUserInfo();
        }
        
        public System.Threading.Tasks.Task<WCFMVC.Web.ServiceReference1.UserModel> GetUserInfoAsync() {
            return base.Channel.GetUserInfoAsync();
        }
        
        public bool UpdateUserName(int userid, string usernewname) {
            return base.Channel.UpdateUserName(userid, usernewname);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserNameAsync(int userid, string usernewname) {
            return base.Channel.UpdateUserNameAsync(userid, usernewname);
        }
    }
}
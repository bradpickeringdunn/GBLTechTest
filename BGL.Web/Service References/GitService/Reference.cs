﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BGL.Web.GitService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenericServiceResult", Namespace="http://schemas.datacontract.org/2004/07/Airborne.Services.ClientAdapter.Results")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Services.Api.Models.Result.GetGitRepositoriesResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Services.Api.Models.Result.GetGitUserResult))]
    public partial class GenericServiceResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BGL.Web.GitService.NotificationCollection NotificationsField;
        
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
        public BGL.Web.GitService.NotificationCollection Notifications {
            get {
                return this.NotificationsField;
            }
            set {
                if ((object.ReferenceEquals(this.NotificationsField, value) != true)) {
                    this.NotificationsField = value;
                    this.RaisePropertyChanged("Notifications");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NotificationCollection", Namespace="http://schemas.datacontract.org/2004/07/Airborne.Notifications")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Services.Api.Models.Request.GetGitUserRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Services.Api.Models.Request.GetGitRepositoriesRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Services.Api.Models.Result.GetGitUserResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Services.Api.Models.Result.GetGitRepositoriesResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Services.Api.Models.Dto.GitUserDto))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Services.Api.Models.Dto.GitRepositoryDto[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Services.Api.Models.Dto.GitRepositoryDto))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Web.GitService.GenericServiceResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Web.GitService.Notification[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Web.GitService.Notification))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BGL.Web.GitService.NotificationSeverity))]
    public partial class NotificationCollection : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object PayloadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BGL.Web.GitService.Notification[] messagesField;
        
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
        public object Payload {
            get {
                return this.PayloadField;
            }
            set {
                if ((object.ReferenceEquals(this.PayloadField, value) != true)) {
                    this.PayloadField = value;
                    this.RaisePropertyChanged("Payload");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BGL.Web.GitService.Notification[] messages {
            get {
                return this.messagesField;
            }
            set {
                if ((object.ReferenceEquals(this.messagesField, value) != true)) {
                    this.messagesField = value;
                    this.RaisePropertyChanged("messages");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Notification", Namespace="http://schemas.datacontract.org/2004/07/Airborne.Notifications")]
    [System.SerializableAttribute()]
    public partial class Notification : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BGL.Web.GitService.NotificationSeverity SeverityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
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
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BGL.Web.GitService.NotificationSeverity Severity {
            get {
                return this.SeverityField;
            }
            set {
                if ((this.SeverityField.Equals(value) != true)) {
                    this.SeverityField = value;
                    this.RaisePropertyChanged("Severity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NotificationSeverity", Namespace="http://schemas.datacontract.org/2004/07/Airborne.Notifications")]
    public enum NotificationSeverity : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Information = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Warning = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GitService.IGitService")]
    public interface IGitService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGitService/LoadGitUser", ReplyAction="http://tempuri.org/IGitService/LoadGitUserResponse")]
        BGL.Services.Api.Models.Result.GetGitUserResult LoadGitUser(BGL.Services.Api.Models.Request.GetGitUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGitService/LoadGitUser", ReplyAction="http://tempuri.org/IGitService/LoadGitUserResponse")]
        System.Threading.Tasks.Task<BGL.Services.Api.Models.Result.GetGitUserResult> LoadGitUserAsync(BGL.Services.Api.Models.Request.GetGitUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGitService/GetRepositories", ReplyAction="http://tempuri.org/IGitService/GetRepositoriesResponse")]
        BGL.Services.Api.Models.Result.GetGitRepositoriesResult GetRepositories(BGL.Services.Api.Models.Request.GetGitRepositoriesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGitService/GetRepositories", ReplyAction="http://tempuri.org/IGitService/GetRepositoriesResponse")]
        System.Threading.Tasks.Task<BGL.Services.Api.Models.Result.GetGitRepositoriesResult> GetRepositoriesAsync(BGL.Services.Api.Models.Request.GetGitRepositoriesRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGitServiceChannel : BGL.Web.GitService.IGitService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GitServiceClient : System.ServiceModel.ClientBase<BGL.Web.GitService.IGitService>, BGL.Web.GitService.IGitService {
        
        public GitServiceClient() {
        }
        
        public GitServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GitServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GitServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GitServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BGL.Services.Api.Models.Result.GetGitUserResult LoadGitUser(BGL.Services.Api.Models.Request.GetGitUserRequest request) {
            return base.Channel.LoadGitUser(request);
        }
        
        public System.Threading.Tasks.Task<BGL.Services.Api.Models.Result.GetGitUserResult> LoadGitUserAsync(BGL.Services.Api.Models.Request.GetGitUserRequest request) {
            return base.Channel.LoadGitUserAsync(request);
        }
        
        public BGL.Services.Api.Models.Result.GetGitRepositoriesResult GetRepositories(BGL.Services.Api.Models.Request.GetGitRepositoriesRequest request) {
            return base.Channel.GetRepositories(request);
        }
        
        public System.Threading.Tasks.Task<BGL.Services.Api.Models.Result.GetGitRepositoriesResult> GetRepositoriesAsync(BGL.Services.Api.Models.Request.GetGitRepositoriesRequest request) {
            return base.Channel.GetRepositoriesAsync(request);
        }
    }
}

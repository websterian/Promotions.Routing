﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PromotionSyncTest.SCPromotionsServiceGroup6.xsd {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CallContext", Namespace="http://schemas.microsoft.com/dynamics/2010/01/datacontracts")]
    [System.SerializableAttribute()]
    public partial class CallContext : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LanguageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogonAsUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PartitionKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> PropertyBagField;
        
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
        public string Company {
            get {
                return this.CompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyField, value) != true)) {
                    this.CompanyField = value;
                    this.RaisePropertyChanged("Company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Language {
            get {
                return this.LanguageField;
            }
            set {
                if ((object.ReferenceEquals(this.LanguageField, value) != true)) {
                    this.LanguageField = value;
                    this.RaisePropertyChanged("Language");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogonAsUser {
            get {
                return this.LogonAsUserField;
            }
            set {
                if ((object.ReferenceEquals(this.LogonAsUserField, value) != true)) {
                    this.LogonAsUserField = value;
                    this.RaisePropertyChanged("LogonAsUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MessageId {
            get {
                return this.MessageIdField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageIdField, value) != true)) {
                    this.MessageIdField = value;
                    this.RaisePropertyChanged("MessageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PartitionKey {
            get {
                return this.PartitionKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.PartitionKeyField, value) != true)) {
                    this.PartitionKeyField = value;
                    this.RaisePropertyChanged("PartitionKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> PropertyBag {
            get {
                return this.PropertyBagField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyBagField, value) != true)) {
                    this.PropertyBagField = value;
                    this.RaisePropertyChanged("PropertyBag");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SCPromotionContract", Namespace="http://schemas.datacontract.org/2004/07/Dynamics.Ax.Application")]
    [System.SerializableAttribute()]
    public partial class SCPromotionContract : PromotionSyncTest.SCPromotionsServiceGroup6.xsd.XppObjectBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parmConcurrencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parmCurrencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parmDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parmDisclaimerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parmDiscountNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime parmEndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parmIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parmPriceDiscountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string parmPromotionTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime parmStartDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parmConcurrency {
            get {
                return this.parmConcurrencyField;
            }
            set {
                if ((object.ReferenceEquals(this.parmConcurrencyField, value) != true)) {
                    this.parmConcurrencyField = value;
                    this.RaisePropertyChanged("parmConcurrency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parmCurrency {
            get {
                return this.parmCurrencyField;
            }
            set {
                if ((object.ReferenceEquals(this.parmCurrencyField, value) != true)) {
                    this.parmCurrencyField = value;
                    this.RaisePropertyChanged("parmCurrency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parmDescription {
            get {
                return this.parmDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.parmDescriptionField, value) != true)) {
                    this.parmDescriptionField = value;
                    this.RaisePropertyChanged("parmDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parmDisclaimer {
            get {
                return this.parmDisclaimerField;
            }
            set {
                if ((object.ReferenceEquals(this.parmDisclaimerField, value) != true)) {
                    this.parmDisclaimerField = value;
                    this.RaisePropertyChanged("parmDisclaimer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parmDiscountName {
            get {
                return this.parmDiscountNameField;
            }
            set {
                if ((object.ReferenceEquals(this.parmDiscountNameField, value) != true)) {
                    this.parmDiscountNameField = value;
                    this.RaisePropertyChanged("parmDiscountName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime parmEndDate {
            get {
                return this.parmEndDateField;
            }
            set {
                if ((this.parmEndDateField.Equals(value) != true)) {
                    this.parmEndDateField = value;
                    this.RaisePropertyChanged("parmEndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parmId {
            get {
                return this.parmIdField;
            }
            set {
                if ((object.ReferenceEquals(this.parmIdField, value) != true)) {
                    this.parmIdField = value;
                    this.RaisePropertyChanged("parmId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parmPriceDiscount {
            get {
                return this.parmPriceDiscountField;
            }
            set {
                if ((object.ReferenceEquals(this.parmPriceDiscountField, value) != true)) {
                    this.parmPriceDiscountField = value;
                    this.RaisePropertyChanged("parmPriceDiscount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parmPromotionType {
            get {
                return this.parmPromotionTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.parmPromotionTypeField, value) != true)) {
                    this.parmPromotionTypeField = value;
                    this.RaisePropertyChanged("parmPromotionType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime parmStartDate {
            get {
                return this.parmStartDateField;
            }
            set {
                if ((this.parmStartDateField.Equals(value) != true)) {
                    this.parmStartDateField = value;
                    this.RaisePropertyChanged("parmStartDate");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="XppObjectBase", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Dynamics.Ax.Xpp")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionContract))]
    public partial class XppObjectBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    [System.SerializableAttribute()]
    public partial class AifFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomDetailXmlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PromotionSyncTest.SCPromotionsServiceGroup6.xsd.FaultMessageList[] FaultMessageListArrayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PromotionSyncTest.SCPromotionsServiceGroup6.xsd.InfologMessage[] InfologMessageListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int XppExceptionTypeField;
        
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
        public string CustomDetailXml {
            get {
                return this.CustomDetailXmlField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomDetailXmlField, value) != true)) {
                    this.CustomDetailXmlField = value;
                    this.RaisePropertyChanged("CustomDetailXml");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PromotionSyncTest.SCPromotionsServiceGroup6.xsd.FaultMessageList[] FaultMessageListArray {
            get {
                return this.FaultMessageListArrayField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageListArrayField, value) != true)) {
                    this.FaultMessageListArrayField = value;
                    this.RaisePropertyChanged("FaultMessageListArray");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PromotionSyncTest.SCPromotionsServiceGroup6.xsd.InfologMessage[] InfologMessageList {
            get {
                return this.InfologMessageListField;
            }
            set {
                if ((object.ReferenceEquals(this.InfologMessageListField, value) != true)) {
                    this.InfologMessageListField = value;
                    this.RaisePropertyChanged("InfologMessageList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int XppExceptionType {
            get {
                return this.XppExceptionTypeField;
            }
            set {
                if ((this.XppExceptionTypeField.Equals(value) != true)) {
                    this.XppExceptionTypeField = value;
                    this.RaisePropertyChanged("XppExceptionType");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultMessageList", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    [System.SerializableAttribute()]
    public partial class FaultMessageList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentOperationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PromotionSyncTest.SCPromotionsServiceGroup6.xsd.FaultMessage[] FaultMessageArrayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceOperationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceOperationParameterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XmlLineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XmlPositionField;
        
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
        public string Document {
            get {
                return this.DocumentField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentField, value) != true)) {
                    this.DocumentField = value;
                    this.RaisePropertyChanged("Document");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocumentOperation {
            get {
                return this.DocumentOperationField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentOperationField, value) != true)) {
                    this.DocumentOperationField = value;
                    this.RaisePropertyChanged("DocumentOperation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PromotionSyncTest.SCPromotionsServiceGroup6.xsd.FaultMessage[] FaultMessageArray {
            get {
                return this.FaultMessageArrayField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageArrayField, value) != true)) {
                    this.FaultMessageArrayField = value;
                    this.RaisePropertyChanged("FaultMessageArray");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Field {
            get {
                return this.FieldField;
            }
            set {
                if ((object.ReferenceEquals(this.FieldField, value) != true)) {
                    this.FieldField = value;
                    this.RaisePropertyChanged("Field");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Service {
            get {
                return this.ServiceField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceField, value) != true)) {
                    this.ServiceField = value;
                    this.RaisePropertyChanged("Service");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceOperation {
            get {
                return this.ServiceOperationField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceOperationField, value) != true)) {
                    this.ServiceOperationField = value;
                    this.RaisePropertyChanged("ServiceOperation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceOperationParameter {
            get {
                return this.ServiceOperationParameterField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceOperationParameterField, value) != true)) {
                    this.ServiceOperationParameterField = value;
                    this.RaisePropertyChanged("ServiceOperationParameter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XPath {
            get {
                return this.XPathField;
            }
            set {
                if ((object.ReferenceEquals(this.XPathField, value) != true)) {
                    this.XPathField = value;
                    this.RaisePropertyChanged("XPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlLine {
            get {
                return this.XmlLineField;
            }
            set {
                if ((object.ReferenceEquals(this.XmlLineField, value) != true)) {
                    this.XmlLineField = value;
                    this.RaisePropertyChanged("XmlLine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlPosition {
            get {
                return this.XmlPositionField;
            }
            set {
                if ((object.ReferenceEquals(this.XmlPositionField, value) != true)) {
                    this.XmlPositionField = value;
                    this.RaisePropertyChanged("XmlPosition");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InfologMessage", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Dynamics.AX.Framework.Services")]
    [System.SerializableAttribute()]
    public partial class InfologMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PromotionSyncTest.SCPromotionsServiceGroup6.xsd.InfologMessageType InfologMessageTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public PromotionSyncTest.SCPromotionsServiceGroup6.xsd.InfologMessageType InfologMessageType {
            get {
                return this.InfologMessageTypeField;
            }
            set {
                if ((this.InfologMessageTypeField.Equals(value) != true)) {
                    this.InfologMessageTypeField = value;
                    this.RaisePropertyChanged("InfologMessageType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultMessage", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    [System.SerializableAttribute()]
    public partial class FaultMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InfologMessageType", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Dynamics.AX.Framework.Services")]
    public enum InfologMessageType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Info = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Warning = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="SCPromotionsServiceGroup6.xsd.SCPromotionService")]
    public interface SCPromotionService {
        
        // CODEGEN: Generating message contract since the wrapper name (SCPromotionServiceGetAllDiscountsRequest) of message SCPromotionServiceGetAllDiscountsRequest does not match the default value (GetAllDiscounts)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SCPromotionService/GetAllDiscounts", ReplyAction="http://tempuri.org/SCPromotionService/GetAllDiscountsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PromotionSyncTest.SCPromotionsServiceGroup6.xsd.AifFault), Action="http://tempuri.org/SCPromotionService/GetAllDiscountsAifFaultFault", Name="AifFault", Namespace="http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsResponse GetAllDiscounts(PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SCPromotionService/GetAllDiscounts", ReplyAction="http://tempuri.org/SCPromotionService/GetAllDiscountsResponse")]
        System.Threading.Tasks.Task<PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsResponse> GetAllDiscountsAsync(PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SCPromotionServiceGetAllDiscountsRequest", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SCPromotionServiceGetAllDiscountsRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://schemas.microsoft.com/dynamics/2010/01/datacontracts")]
        public PromotionSyncTest.SCPromotionsServiceGroup6.xsd.CallContext CallContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public long channelId;
        
        public SCPromotionServiceGetAllDiscountsRequest() {
        }
        
        public SCPromotionServiceGetAllDiscountsRequest(PromotionSyncTest.SCPromotionsServiceGroup6.xsd.CallContext CallContext, long channelId) {
            this.CallContext = CallContext;
            this.channelId = channelId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SCPromotionServiceGetAllDiscountsResponse", WrapperNamespace="http://tempuri.org", IsWrapped=true)]
    public partial class SCPromotionServiceGetAllDiscountsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org", Order=0)]
        public PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionContract[] response;
        
        public SCPromotionServiceGetAllDiscountsResponse() {
        }
        
        public SCPromotionServiceGetAllDiscountsResponse(PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionContract[] response) {
            this.response = response;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SCPromotionServiceChannel : PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SCPromotionServiceClient : System.ServiceModel.ClientBase<PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionService>, PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionService {
        
        public SCPromotionServiceClient() {
        }
        
        public SCPromotionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SCPromotionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SCPromotionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SCPromotionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsResponse PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionService.GetAllDiscounts(PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsRequest request) {
            return base.Channel.GetAllDiscounts(request);
        }
        
        public PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionContract[] GetAllDiscounts(PromotionSyncTest.SCPromotionsServiceGroup6.xsd.CallContext CallContext, long channelId) {
            PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsRequest inValue = new PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsRequest();
            inValue.CallContext = CallContext;
            inValue.channelId = channelId;
            PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsResponse retVal = ((PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionService)(this)).GetAllDiscounts(inValue);
            return retVal.response;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsResponse> PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionService.GetAllDiscountsAsync(PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsRequest request) {
            return base.Channel.GetAllDiscountsAsync(request);
        }
        
        public System.Threading.Tasks.Task<PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsResponse> GetAllDiscountsAsync(PromotionSyncTest.SCPromotionsServiceGroup6.xsd.CallContext CallContext, long channelId) {
            PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsRequest inValue = new PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionServiceGetAllDiscountsRequest();
            inValue.CallContext = CallContext;
            inValue.channelId = channelId;
            return ((PromotionSyncTest.SCPromotionsServiceGroup6.xsd.SCPromotionService)(this)).GetAllDiscountsAsync(inValue);
        }
    }
}
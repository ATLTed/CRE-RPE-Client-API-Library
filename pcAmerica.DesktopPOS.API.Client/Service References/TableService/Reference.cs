﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pcAmerica.DesktopPOS.API.Client.TableService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Context", Namespace="http://pcAmerica.com/DesktopPOS/General/DataContracts/2009/10/26")]
    [System.SerializableAttribute()]
    public partial class Context : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CashierIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StoreIDField;
        
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
        public string CashierID {
            get {
                return this.CashierIDField;
            }
            set {
                if ((object.ReferenceEquals(this.CashierIDField, value) != true)) {
                    this.CashierIDField = value;
                    this.RaisePropertyChanged("CashierID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StationID {
            get {
                return this.StationIDField;
            }
            set {
                if ((object.ReferenceEquals(this.StationIDField, value) != true)) {
                    this.StationIDField = value;
                    this.RaisePropertyChanged("StationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StoreID {
            get {
                return this.StoreIDField;
            }
            set {
                if ((object.ReferenceEquals(this.StoreIDField, value) != true)) {
                    this.StoreIDField = value;
                    this.RaisePropertyChanged("StoreID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TableInfo", Namespace="http://pcAmerica.com/DesktopPOS/TableService/DataContracts/2010/07/27")]
    [System.SerializableAttribute()]
    public partial class TableInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CashierIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdentifierField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long InvoiceNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool OccupiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OnHoldIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SectionIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TableNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TotalField;
        
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
        public string CashierID {
            get {
                return this.CashierIDField;
            }
            set {
                if ((object.ReferenceEquals(this.CashierIDField, value) != true)) {
                    this.CashierIDField = value;
                    this.RaisePropertyChanged("CashierID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Identifier {
            get {
                return this.IdentifierField;
            }
            set {
                if ((object.ReferenceEquals(this.IdentifierField, value) != true)) {
                    this.IdentifierField = value;
                    this.RaisePropertyChanged("Identifier");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long InvoiceNumber {
            get {
                return this.InvoiceNumberField;
            }
            set {
                if ((this.InvoiceNumberField.Equals(value) != true)) {
                    this.InvoiceNumberField = value;
                    this.RaisePropertyChanged("InvoiceNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Occupied {
            get {
                return this.OccupiedField;
            }
            set {
                if ((this.OccupiedField.Equals(value) != true)) {
                    this.OccupiedField = value;
                    this.RaisePropertyChanged("Occupied");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OnHoldID {
            get {
                return this.OnHoldIDField;
            }
            set {
                if ((object.ReferenceEquals(this.OnHoldIDField, value) != true)) {
                    this.OnHoldIDField = value;
                    this.RaisePropertyChanged("OnHoldID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SectionID {
            get {
                return this.SectionIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SectionIDField, value) != true)) {
                    this.SectionIDField = value;
                    this.RaisePropertyChanged("SectionID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TableNumber {
            get {
                return this.TableNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.TableNumberField, value) != true)) {
                    this.TableNumberField = value;
                    this.RaisePropertyChanged("TableNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://pcAmerica.com/DesktopPOS/TableService/ServiceContracts/2010/07/27", ConfigurationName="TableService.TableService")]
    public interface TableService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pcAmerica.com/DesktopPOS/TableService/ServiceContracts/2010/07/27/TableSer" +
            "vice/GetTables", ReplyAction="http://pcAmerica.com/DesktopPOS/TableService/ServiceContracts/2010/07/27/TableSer" +
            "vice/GetTablesResponse")]
        pcAmerica.DesktopPOS.API.Client.TableService.TableInfo[] GetTables(pcAmerica.DesktopPOS.API.Client.TableService.Context context);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TableServiceChannel : pcAmerica.DesktopPOS.API.Client.TableService.TableService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TableServiceClient : System.ServiceModel.ClientBase<pcAmerica.DesktopPOS.API.Client.TableService.TableService>, pcAmerica.DesktopPOS.API.Client.TableService.TableService {
        
        public TableServiceClient() {
        }
        
        public TableServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TableServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TableServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TableServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public pcAmerica.DesktopPOS.API.Client.TableService.TableInfo[] GetTables(pcAmerica.DesktopPOS.API.Client.TableService.Context context) {
            return base.Channel.GetTables(context);
        }
    }
}
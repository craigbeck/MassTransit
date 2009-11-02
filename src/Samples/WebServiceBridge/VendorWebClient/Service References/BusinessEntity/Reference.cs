﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VendorWebClient.BusinessEntity {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InventoryLevel", Namespace="http://masstransit.googlecode.com/Samples/BusinessWebService")]
    [System.SerializableAttribute()]
    public partial class InventoryLevel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PartNumberField;
        
        private int QuantityOnHandField;
        
        private int QuantityOnOrderField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string PartNumber {
            get {
                return this.PartNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PartNumberField, value) != true)) {
                    this.PartNumberField = value;
                    this.RaisePropertyChanged("PartNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int QuantityOnHand {
            get {
                return this.QuantityOnHandField;
            }
            set {
                if ((this.QuantityOnHandField.Equals(value) != true)) {
                    this.QuantityOnHandField = value;
                    this.RaisePropertyChanged("QuantityOnHand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int QuantityOnOrder {
            get {
                return this.QuantityOnOrderField;
            }
            set {
                if ((this.QuantityOnOrderField.Equals(value) != true)) {
                    this.QuantityOnOrderField = value;
                    this.RaisePropertyChanged("QuantityOnOrder");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://masstransit.googlecode.com/Samples/BusinessWebService", ConfigurationName="BusinessEntity.InventoryServiceSoap")]
    public interface InventoryServiceSoap {
        
        // CODEGEN: Generating message contract since element name partNumber from namespace http://masstransit.googlecode.com/Samples/BusinessWebService is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://masstransit.googlecode.com/Samples/BusinessWebService/CheckInventory", ReplyAction="*")]
        VendorWebClient.BusinessEntity.CheckInventoryResponse CheckInventory(VendorWebClient.BusinessEntity.CheckInventoryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://masstransit.googlecode.com/Samples/BusinessWebService/CheckInventory", ReplyAction="*")]
        System.IAsyncResult BeginCheckInventory(VendorWebClient.BusinessEntity.CheckInventoryRequest request, System.AsyncCallback callback, object asyncState);
        
        VendorWebClient.BusinessEntity.CheckInventoryResponse EndCheckInventory(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckInventoryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckInventory", Namespace="http://masstransit.googlecode.com/Samples/BusinessWebService", Order=0)]
        public VendorWebClient.BusinessEntity.CheckInventoryRequestBody Body;
        
        public CheckInventoryRequest() {
        }
        
        public CheckInventoryRequest(VendorWebClient.BusinessEntity.CheckInventoryRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://masstransit.googlecode.com/Samples/BusinessWebService")]
    public partial class CheckInventoryRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string partNumber;
        
        public CheckInventoryRequestBody() {
        }
        
        public CheckInventoryRequestBody(string partNumber) {
            this.partNumber = partNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckInventoryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckInventoryResponse", Namespace="http://masstransit.googlecode.com/Samples/BusinessWebService", Order=0)]
        public VendorWebClient.BusinessEntity.CheckInventoryResponseBody Body;
        
        public CheckInventoryResponse() {
        }
        
        public CheckInventoryResponse(VendorWebClient.BusinessEntity.CheckInventoryResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://masstransit.googlecode.com/Samples/BusinessWebService")]
    public partial class CheckInventoryResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public VendorWebClient.BusinessEntity.InventoryLevel CheckInventoryResult;
        
        public CheckInventoryResponseBody() {
        }
        
        public CheckInventoryResponseBody(VendorWebClient.BusinessEntity.InventoryLevel CheckInventoryResult) {
            this.CheckInventoryResult = CheckInventoryResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface InventoryServiceSoapChannel : VendorWebClient.BusinessEntity.InventoryServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class CheckInventoryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CheckInventoryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public VendorWebClient.BusinessEntity.InventoryLevel Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((VendorWebClient.BusinessEntity.InventoryLevel)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class InventoryServiceSoapClient : System.ServiceModel.ClientBase<VendorWebClient.BusinessEntity.InventoryServiceSoap>, VendorWebClient.BusinessEntity.InventoryServiceSoap {
        
        private BeginOperationDelegate onBeginCheckInventoryDelegate;
        
        private EndOperationDelegate onEndCheckInventoryDelegate;
        
        private System.Threading.SendOrPostCallback onCheckInventoryCompletedDelegate;
        
        public InventoryServiceSoapClient() {
        }
        
        public InventoryServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InventoryServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<CheckInventoryCompletedEventArgs> CheckInventoryCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VendorWebClient.BusinessEntity.CheckInventoryResponse VendorWebClient.BusinessEntity.InventoryServiceSoap.CheckInventory(VendorWebClient.BusinessEntity.CheckInventoryRequest request) {
            return base.Channel.CheckInventory(request);
        }
        
        public VendorWebClient.BusinessEntity.InventoryLevel CheckInventory(string partNumber) {
            VendorWebClient.BusinessEntity.CheckInventoryRequest inValue = new VendorWebClient.BusinessEntity.CheckInventoryRequest();
            inValue.Body = new VendorWebClient.BusinessEntity.CheckInventoryRequestBody();
            inValue.Body.partNumber = partNumber;
            VendorWebClient.BusinessEntity.CheckInventoryResponse retVal = ((VendorWebClient.BusinessEntity.InventoryServiceSoap)(this)).CheckInventory(inValue);
            return retVal.Body.CheckInventoryResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult VendorWebClient.BusinessEntity.InventoryServiceSoap.BeginCheckInventory(VendorWebClient.BusinessEntity.CheckInventoryRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCheckInventory(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginCheckInventory(string partNumber, System.AsyncCallback callback, object asyncState) {
            VendorWebClient.BusinessEntity.CheckInventoryRequest inValue = new VendorWebClient.BusinessEntity.CheckInventoryRequest();
            inValue.Body = new VendorWebClient.BusinessEntity.CheckInventoryRequestBody();
            inValue.Body.partNumber = partNumber;
            return ((VendorWebClient.BusinessEntity.InventoryServiceSoap)(this)).BeginCheckInventory(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VendorWebClient.BusinessEntity.CheckInventoryResponse VendorWebClient.BusinessEntity.InventoryServiceSoap.EndCheckInventory(System.IAsyncResult result) {
            return base.Channel.EndCheckInventory(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public VendorWebClient.BusinessEntity.InventoryLevel EndCheckInventory(System.IAsyncResult result) {
            VendorWebClient.BusinessEntity.CheckInventoryResponse retVal = ((VendorWebClient.BusinessEntity.InventoryServiceSoap)(this)).EndCheckInventory(result);
            return retVal.Body.CheckInventoryResult;
        }
        
        private System.IAsyncResult OnBeginCheckInventory(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string partNumber = ((string)(inValues[0]));
            return this.BeginCheckInventory(partNumber, callback, asyncState);
        }
        
        private object[] OnEndCheckInventory(System.IAsyncResult result) {
            VendorWebClient.BusinessEntity.InventoryLevel retVal = this.EndCheckInventory(result);
            return new object[] {
                    retVal};
        }
        
        private void OnCheckInventoryCompleted(object state) {
            if ((this.CheckInventoryCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CheckInventoryCompleted(this, new CheckInventoryCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CheckInventoryAsync(string partNumber) {
            this.CheckInventoryAsync(partNumber, null);
        }
        
        public void CheckInventoryAsync(string partNumber, object userState) {
            if ((this.onBeginCheckInventoryDelegate == null)) {
                this.onBeginCheckInventoryDelegate = new BeginOperationDelegate(this.OnBeginCheckInventory);
            }
            if ((this.onEndCheckInventoryDelegate == null)) {
                this.onEndCheckInventoryDelegate = new EndOperationDelegate(this.OnEndCheckInventory);
            }
            if ((this.onCheckInventoryCompletedDelegate == null)) {
                this.onCheckInventoryCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCheckInventoryCompleted);
            }
            base.InvokeAsync(this.onBeginCheckInventoryDelegate, new object[] {
                        partNumber}, this.onEndCheckInventoryDelegate, this.onCheckInventoryCompletedDelegate, userState);
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleWCFClient.WsdlSample {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataContractSample", Namespace="http://schemas.datacontract.org/2004/07/Sample")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SampleWCFClient.WsdlSample.InheritedContract))]
    public partial class DataContractSample : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SampleWCFClient.WsdlSample.ErrorCodes ErrorCodeFieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExtensionData1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Member1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WeirdNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        /// <summary> 
        /// An enum Field (Not a property) 
        /// </summary> 
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SampleWCFClient.WsdlSample.ErrorCodes ErrorCodeField {
            get {
                return this.ErrorCodeFieldField;
            }
            set {
                if ((this.ErrorCodeFieldField.Equals(value) != true)) {
                    this.ErrorCodeFieldField = value;
                    this.RaisePropertyChanged("ErrorCodeField");
                }
            }
        }
        
        /// <summary> 
        /// A member with a name that collides with the ExtensionData member 
        /// inherited from IExtensibleDataObject 
        /// </summary> 
        [System.Runtime.Serialization.DataMemberAttribute(Name="ExtensionData")]
        public string ExtensionData1 {
            get {
                return this.ExtensionData1Field;
            }
            set {
                if ((object.ReferenceEquals(this.ExtensionData1Field, value) != true)) {
                    this.ExtensionData1Field = value;
                    this.RaisePropertyChanged("ExtensionData1");
                }
            }
        }
        
        /// <summary> 
        /// A simple string member 
        /// </summary> 
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Member1 {
            get {
                return this.Member1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Member1Field, value) != true)) {
                    this.Member1Field = value;
                    this.RaisePropertyChanged("Member1");
                }
            }
        }
        
        /// <summary> 
        /// A member who's name was changed using the DataMember attribute. 
        /// Also note that the new member name has special chars. 
        /// This summary references <see cref="P:Member1">Member1</see> 
        /// </summary> 
        [System.Runtime.Serialization.DataMemberAttribute(Name="@WeirdName")]
        public int WeirdName {
            get {
                return this.WeirdNameField;
            }
            set {
                if ((this.WeirdNameField.Equals(value) != true)) {
                    this.WeirdNameField = value;
                    this.RaisePropertyChanged("WeirdName");
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
        
        /// <summary> 
        /// An class declared as an inner 
        /// </summary> 
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="DataContractSample.DataContractSampleInner", Namespace="http://schemas.datacontract.org/2004/07/Sample")]
        [System.SerializableAttribute()]
        public partial class DataContractSampleInner : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
            
            [System.NonSerializedAttribute()]
            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string Member1Field;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string Member2Field;
            
            public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
                get {
                    return this.extensionDataField;
                }
                set {
                    this.extensionDataField = value;
                }
            }
            
            /// <summary> 
            /// A member field of an inner class 
            /// </summary> 
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Member1 {
                get {
                    return this.Member1Field;
                }
                set {
                    if ((object.ReferenceEquals(this.Member1Field, value) != true)) {
                        this.Member1Field = value;
                        this.RaisePropertyChanged("Member1");
                    }
                }
            }
            
            /// <summary> 
            /// This summary references <see cref="P:Member1">Member1</see> 
            /// </summary> 
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Member2 {
                get {
                    return this.Member2Field;
                }
                set {
                    if ((object.ReferenceEquals(this.Member2Field, value) != true)) {
                        this.Member2Field = value;
                        this.RaisePropertyChanged("Member2");
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
    }
    
    /// <summary> 
    /// A data contract that inherits from DataContractSample. 
    /// </summary> 
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InheritedContract", Namespace="http://schemas.datacontract.org/2004/07/Sample")]
    [System.SerializableAttribute()]
    public partial class InheritedContract : SampleWCFClient.WsdlSample.DataContractSample {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyField;
        
        /// <summary> 
        /// Gets or sets the property. 
        /// </summary> 
        /// <value>The property.</value> 
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Property {
            get {
                return this.PropertyField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyField, value) != true)) {
                    this.PropertyField = value;
                    this.RaisePropertyChanged("Property");
                }
            }
        }
    }
    
    /// <summary> 
    /// An enum marked with a DataContract attribute 
    /// </summary> 
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorCodes", Namespace="http://schemas.datacontract.org/2004/07/Sample")]
    public enum ErrorCodes : int {
        
        /// <summary> 
        /// Unknown error has occoured 
        /// </summary> 
        [System.Runtime.Serialization.EnumMemberAttribute()]
        General = -1,
        
        /// <summary> 
        /// An enum member who's name was changed using the EnumMember attribute. 
        /// Also note that the new member name has special chars. 
        /// </summary> 
        /// <seealso cref="M:IWsdlSample.Operation2()" /> 
        [System.Runtime.Serialization.EnumMemberAttribute(Value="@FileNotFound")]
        FileNotFound = 1,
        
        /// <summary> 
        /// Out of memory see <see cref="M:IWsdlSample.Operation1" /> for more details 
        /// </summary> 
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OutOfMemory = 2,
    }
    
    /// <summary> 
    /// Structs can also be documented 
    /// </summary> 
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Struct", Namespace="http://schemas.datacontract.org/2004/07/Sample")]
    [System.SerializableAttribute()]
    public partial struct Struct : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string strField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        /// <summary> 
        /// And members of structs 
        /// </summary> 
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string str {
            get {
                return this.strField;
            }
            set {
                if ((object.ReferenceEquals(this.strField, value) != true)) {
                    this.strField = value;
                    this.RaisePropertyChanged("str");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <summary> 
    /// This is a "regular" enum without a DataContract attribute. 
    /// </summary> 
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegularEnum", Namespace="http://schemas.datacontract.org/2004/07/Sample")]
    public enum RegularEnum : int {
        
        /// <summary> 
        /// First value documentation 
        /// </summary> 
        /// see <see cref="T:ErrorCodes" /> and <see cref="F:ErrorCodes.FileNotFound" /> 
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FirstValue = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SecondValue = 2,
    }
    
    /// <summary> 
    /// This is a sample service contract that demonstrates how xml comments 
    /// can be placed anywhere in code are rendered to the result WSDL. 
    /// These comments will also be imported to the client generated proxy if the proxy configured correctly 
    /// </summary> 
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsdlSample.IWsdlSample")]
    public interface IWsdlSample {
        
        /// <summary> 
        /// This is a simple operation without input paramaters. 
        /// </summary> 
        /// <returns>The operations returns a string</returns> 
        /// <seealso cref="!:Unresolved.Reference" /> 
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsdlSample/Operation1", ReplyAction="http://tempuri.org/IWsdlSample/Operation1Response")]
        string Operation1();
        
        /// <summary> 
        /// Receives 2 parameters, both are data contracts 
        /// </summary> 
        /// <param name="data">Regular DataContract parameter</param> 
        /// <param name="innerData">This parameter is from a type declared as an inner class inside a 
        /// DataContract</param> 
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsdlSample/Operation2", ReplyAction="http://tempuri.org/IWsdlSample/Operation2Response")]
        void Operation2(SampleWCFClient.WsdlSample.InheritedContract data, SampleWCFClient.WsdlSample.DataContractSample.DataContractSampleInner innerData);
        
        /// This text is placed outside of any tag. It will not be rendered when using the Portable format 
        /// <summary> 
        /// Operation 3 - This is a <b>test</b> for very long xml comments. The rest of this line is just garbage: 
        /// Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec magna odio, imperdiet in, facilisis 
        /// vitae, congue vel, urna. Aliquam ullamcorper. Integer libero turpis, tempor quis, interdum ac, interdum 
        /// sed, lorem. Nam ipsum erat, interdum sed, pellentesque sed, faucibus sed, risus. In commodo ipsum eget 
        /// neque. Suspendisse ut nisl sit amet odio semper luctus. Maecenas sit amet nisl. Sed ac ligula eu nunc 
        /// lacinia pulvinar. Phasellus auctor aliquam diam. Curabitur at nibh id felis mattis ornare. Quisque ac 
        /// purus non odio aliquet condimentum. Curabitur gravida nisi a odio. In iaculis pede vitae dui. Nunc a mi. 
        /// Curabitur elementum ligula in odio. Nunc accumsan egestas odio 
        /// </summary> 
        /// <remarks> 
        /// This is a section of remarks. 
        /// This information will go into the HTML documentation 
        /// Remarks are not rendered when using Portable 
        /// </remarks> 
        /// seealso references are not renderd when using Portable 
        /// <param name="str">a Nullable parameter</param> 
        /// <param name="param1">this is 
        /// a 
        /// multiline 
        /// commnet 
        /// for param2</param> 
        /// <param name="param2">a parameter passed by reference</param> 
        /// <returns>this method returns a string</returns> 
        /// <custom>This is a custom XML comment tag</custom> 
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsdlSample/Operation3", ReplyAction="http://tempuri.org/IWsdlSample/Operation3Response")]
        string Operation3(out int param1, System.Nullable<SampleWCFClient.WsdlSample.Struct> str, ref long param2);
        
        /// <summary> 
        /// This operation uses an enum as a parameter. 
        /// </summary> 
        /// <param name="param1">A "regular" enum. This is an enum not marked with the [DataContract] 
        /// attribure</param> 
        /// <seealso cref="M:Operation3()" /> 
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsdlSample/Operation4", ReplyAction="http://tempuri.org/IWsdlSample/Operation4Response")]
        void Operation4(SampleWCFClient.WsdlSample.RegularEnum param1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWsdlSampleChannel : SampleWCFClient.WsdlSample.IWsdlSample, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WsdlSampleClient : System.ServiceModel.ClientBase<SampleWCFClient.WsdlSample.IWsdlSample>, SampleWCFClient.WsdlSample.IWsdlSample {
        
        public WsdlSampleClient() {
        }
        
        public WsdlSampleClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WsdlSampleClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsdlSampleClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsdlSampleClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Operation1() {
            return base.Channel.Operation1();
        }
        
        public void Operation2(SampleWCFClient.WsdlSample.InheritedContract data, SampleWCFClient.WsdlSample.DataContractSample.DataContractSampleInner innerData) {
            base.Channel.Operation2(data, innerData);
        }
        
        public string Operation3(out int param1, System.Nullable<SampleWCFClient.WsdlSample.Struct> str, ref long param2) {
            return base.Channel.Operation3(out param1, str, ref param2);
        }
        
        public void Operation4(SampleWCFClient.WsdlSample.RegularEnum param1) {
            base.Channel.Operation4(param1);
        }
    }
}

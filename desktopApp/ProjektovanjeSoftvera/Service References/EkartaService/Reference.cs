﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektovanjeSoftvera.EkartaService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ps", ConfigurationName="EkartaService.Ekarta_ServisPort")]
    public interface Ekarta_ServisPort {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps#Ekarta_Servis")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void Ekarta_Servis(ProjektovanjeSoftvera.EkartaService.Ekarta_Servis request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps#getKarta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Stanica))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Popust))]
        ProjektovanjeSoftvera.EkartaService.getKartaResponse getKarta(ProjektovanjeSoftvera.EkartaService.getKartaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps#sacuvajKartu")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Stanica))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Popust))]
        void sacuvajKartu(ProjektovanjeSoftvera.EkartaService.sacuvajKartu request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps#pronadjiKartu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Stanica))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Popust))]
        ProjektovanjeSoftvera.EkartaService.pronadjiKartuResponse pronadjiKartu(ProjektovanjeSoftvera.EkartaService.pronadjiKartuRequest request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps#otkaziKartu")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Stanica))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Popust))]
        void otkaziKartu(ProjektovanjeSoftvera.EkartaService.otkaziKartu request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps#popusti", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Stanica))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Popust))]
        ProjektovanjeSoftvera.EkartaService.popustiResponse popusti(ProjektovanjeSoftvera.EkartaService.popustiRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps#getRedVoznje", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Stanica))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Popust))]
        ProjektovanjeSoftvera.EkartaService.getRedVoznjeResponse getRedVoznje(ProjektovanjeSoftvera.EkartaService.getRedVoznjeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps#proveriVoznju", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Stanica))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Popust))]
        ProjektovanjeSoftvera.EkartaService.proveriVoznjuResponse proveriVoznju(ProjektovanjeSoftvera.EkartaService.proveriVoznjuRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps#stanicaUlazna", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Stanica))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Popust))]
        ProjektovanjeSoftvera.EkartaService.stanicaUlaznaResponse stanicaUlazna(ProjektovanjeSoftvera.EkartaService.stanicaUlaznaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps#stanicaIzlazna", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Stanica))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Popust))]
        ProjektovanjeSoftvera.EkartaService.stanicaIzlaznaResponse stanicaIzlazna(ProjektovanjeSoftvera.EkartaService.stanicaIzlaznaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps#pronadjiRutu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Stanica))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Application_Model_Popust))]
        ProjektovanjeSoftvera.EkartaService.pronadjiRutuResponse pronadjiRutu(ProjektovanjeSoftvera.EkartaService.pronadjiRutuRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Ekarta_Servis", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class Ekarta_Servis {
        
        public Ekarta_Servis() {
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1015")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://ps")]
    public partial class Application_Model_Karta : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1015")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://ps")]
    public partial class Application_Model_Stanica : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> _idStanicaField;
        
        private string _nazivField;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> _idStanica {
            get {
                return this._idStanicaField;
            }
            set {
                this._idStanicaField = value;
                this.RaisePropertyChanged("_idStanica");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string _naziv {
            get {
                return this._nazivField;
            }
            set {
                this._nazivField = value;
                this.RaisePropertyChanged("_naziv");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1015")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://ps")]
    public partial class Application_Model_Redvoznje : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1015")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://ps")]
    public partial class Application_Model_Popust : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getKarta", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class getKartaRequest {
        
        public getKartaRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getKartaResponse", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class getKartaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public ProjektovanjeSoftvera.EkartaService.Application_Model_Karta @return;
        
        public getKartaResponse() {
        }
        
        public getKartaResponse(ProjektovanjeSoftvera.EkartaService.Application_Model_Karta @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sacuvajKartu", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class sacuvajKartu {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public ProjektovanjeSoftvera.EkartaService.Application_Model_Karta @object;
        
        public sacuvajKartu() {
        }
        
        public sacuvajKartu(ProjektovanjeSoftvera.EkartaService.Application_Model_Karta @object) {
            this.@object = @object;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pronadjiKartu", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class pronadjiKartuRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int id;
        
        public pronadjiKartuRequest() {
        }
        
        public pronadjiKartuRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pronadjiKartuResponse", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class pronadjiKartuResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public ProjektovanjeSoftvera.EkartaService.Application_Model_Karta @return;
        
        public pronadjiKartuResponse() {
        }
        
        public pronadjiKartuResponse(ProjektovanjeSoftvera.EkartaService.Application_Model_Karta @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="otkaziKartu", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class otkaziKartu {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int id;
        
        public otkaziKartu() {
        }
        
        public otkaziKartu(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="popusti", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class popustiRequest {
        
        public popustiRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="popustiResponse", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class popustiResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public Application_Model_Popust[] @return;
        
        public popustiResponse() {
        }
        
        public popustiResponse(Application_Model_Popust[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRedVoznje", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class getRedVoznjeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object id;
        
        public getRedVoznjeRequest() {
        }
        
        public getRedVoznjeRequest(object id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRedVoznjeResponse", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class getRedVoznjeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public ProjektovanjeSoftvera.EkartaService.Application_Model_Redvoznje @return;
        
        public getRedVoznjeResponse() {
        }
        
        public getRedVoznjeResponse(ProjektovanjeSoftvera.EkartaService.Application_Model_Redvoznje @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="proveriVoznju", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class proveriVoznjuRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string @string;
        
        public proveriVoznjuRequest() {
        }
        
        public proveriVoznjuRequest(string @string) {
            this.@string = @string;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="proveriVoznjuResponse", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class proveriVoznjuResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public bool @return;
        
        public proveriVoznjuResponse() {
        }
        
        public proveriVoznjuResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="stanicaUlazna", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class stanicaUlaznaRequest {
        
        public stanicaUlaznaRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="stanicaUlaznaResponse", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class stanicaUlaznaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public Application_Model_Stanica[] @return;
        
        public stanicaUlaznaResponse() {
        }
        
        public stanicaUlaznaResponse(Application_Model_Stanica[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="stanicaIzlazna", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class stanicaIzlaznaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int ulaznaId;
        
        public stanicaIzlaznaRequest() {
        }
        
        public stanicaIzlaznaRequest(int ulaznaId) {
            this.ulaznaId = ulaznaId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="stanicaIzlaznaResponse", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class stanicaIzlaznaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public Application_Model_Stanica[] @return;
        
        public stanicaIzlaznaResponse() {
        }
        
        public stanicaIzlaznaResponse(Application_Model_Stanica[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pronadjiRutu", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class pronadjiRutuRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int idUlazna;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public int idIzlazna;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string datum;
        
        public pronadjiRutuRequest() {
        }
        
        public pronadjiRutuRequest(int idUlazna, int idIzlazna, string datum) {
            this.idUlazna = idUlazna;
            this.idIzlazna = idIzlazna;
            this.datum = datum;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pronadjiRutuResponse", WrapperNamespace="http://ps", IsWrapped=true)]
    public partial class pronadjiRutuResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public Application_Model_Redvoznje[] @return;
        
        public pronadjiRutuResponse() {
        }
        
        public pronadjiRutuResponse(Application_Model_Redvoznje[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Ekarta_ServisPortChannel : ProjektovanjeSoftvera.EkartaService.Ekarta_ServisPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Ekarta_ServisPortClient : System.ServiceModel.ClientBase<ProjektovanjeSoftvera.EkartaService.Ekarta_ServisPort>, ProjektovanjeSoftvera.EkartaService.Ekarta_ServisPort {
        
        public Ekarta_ServisPortClient() {
        }
        
        public Ekarta_ServisPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Ekarta_ServisPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Ekarta_ServisPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Ekarta_ServisPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Ekarta_Servis(ProjektovanjeSoftvera.EkartaService.Ekarta_Servis request) {
            base.Channel.Ekarta_Servis(request);
        }
        
        public ProjektovanjeSoftvera.EkartaService.getKartaResponse getKarta(ProjektovanjeSoftvera.EkartaService.getKartaRequest request) {
            return base.Channel.getKarta(request);
        }
        
        public void sacuvajKartu(ProjektovanjeSoftvera.EkartaService.sacuvajKartu request) {
            base.Channel.sacuvajKartu(request);
        }
        
        public ProjektovanjeSoftvera.EkartaService.pronadjiKartuResponse pronadjiKartu(ProjektovanjeSoftvera.EkartaService.pronadjiKartuRequest request) {
            return base.Channel.pronadjiKartu(request);
        }
        
        public void otkaziKartu(ProjektovanjeSoftvera.EkartaService.otkaziKartu request) {
            base.Channel.otkaziKartu(request);
        }
        
        public ProjektovanjeSoftvera.EkartaService.popustiResponse popusti(ProjektovanjeSoftvera.EkartaService.popustiRequest request) {
            return base.Channel.popusti(request);
        }
        
        public ProjektovanjeSoftvera.EkartaService.getRedVoznjeResponse getRedVoznje(ProjektovanjeSoftvera.EkartaService.getRedVoznjeRequest request) {
            return base.Channel.getRedVoznje(request);
        }
        
        public ProjektovanjeSoftvera.EkartaService.proveriVoznjuResponse proveriVoznju(ProjektovanjeSoftvera.EkartaService.proveriVoznjuRequest request) {
            return base.Channel.proveriVoznju(request);
        }
        
        public ProjektovanjeSoftvera.EkartaService.stanicaUlaznaResponse stanicaUlazna(ProjektovanjeSoftvera.EkartaService.stanicaUlaznaRequest request) {
            return base.Channel.stanicaUlazna(request);
        }
        
        public ProjektovanjeSoftvera.EkartaService.stanicaIzlaznaResponse stanicaIzlazna(ProjektovanjeSoftvera.EkartaService.stanicaIzlaznaRequest request) {
            return base.Channel.stanicaIzlazna(request);
        }
        
        public ProjektovanjeSoftvera.EkartaService.pronadjiRutuResponse pronadjiRutu(ProjektovanjeSoftvera.EkartaService.pronadjiRutuRequest request) {
            return base.Channel.pronadjiRutu(request);
        }
    }
}

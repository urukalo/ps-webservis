﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektovanjeSoftvera.AdminService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ps/Admin", ConfigurationName="AdminService.Ekarta_AdminPort")]
    public interface Ekarta_AdminPort {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#Ekarta_Admin")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void Ekarta_Admin();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#setPopust")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void setPopust(string @object);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getPopust", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getPopust(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#unsetPopust")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void unsetPopust(ProjektovanjeSoftvera.AdminService.Application_Model_Popust @object);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#setKarta")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void setKarta(string @object);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getKarta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getKarta(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#unsetKarta")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void unsetKarta(int idKarta);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#deactivate")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void deactivate(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#activate")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void activate(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#izracunajCenuKarte", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string izracunajCenuKarte(int idTrasa, int idPolazneStanice, int idDolazneStanice, int idPopust, int povratna);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#setStanica", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        int setStanica(string @object);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getStanice", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getStanice();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getStanicu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProjektovanjeSoftvera.AdminService.Application_Model_Stanica getStanicu(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#unsetStanica")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void unsetStanica(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#setTrasa")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void setTrasa(string @object);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getTrase", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getTrase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getTrasu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getTrasu(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#unsetTrasa")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void unsetTrasa(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#setRedVoznje")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void setRedVoznje(string @object);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getRedVoznje", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getRedVoznje();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getJedanRedVoznje", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getJedanRedVoznje(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#proveraDaLiPostoji", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool proveraDaLiPostoji(int idTrasa, int dan, string vreme);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#unsetRedVoznje")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void unsetRedVoznje(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#setOtkazanaVoznja")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void setOtkazanaVoznja(string @object);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getOtkazaneVoznje", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getOtkazaneVoznje();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getOtkazanaVoznja", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getOtkazanaVoznja(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#unsetOtkazanaVoznja")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void unsetOtkazanaVoznja(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#setTrasaStanica")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void setTrasaStanica(string @object);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getTrasaStanice", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getTrasaStanice();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getTrasaStanica", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getTrasaStanica(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://ps/Admin#unsetTrasaStanica")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        void unsetTrasaStanica(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getStaniceZaTrasu", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getStaniceZaTrasu(int idTrasa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getStaniceZaTrasuPosle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getStaniceZaTrasuPosle(int idTrasa, int idStanica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ps/Admin#getVremeZaDatum", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getVremeZaDatum(string @object);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1015")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://ps/Admin")]
    public partial class Application_Model_Popust : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://ps/Admin")]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Ekarta_AdminPortChannel : ProjektovanjeSoftvera.AdminService.Ekarta_AdminPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Ekarta_AdminPortClient : System.ServiceModel.ClientBase<ProjektovanjeSoftvera.AdminService.Ekarta_AdminPort>, ProjektovanjeSoftvera.AdminService.Ekarta_AdminPort {
        
        public Ekarta_AdminPortClient() {
        }
        
        public Ekarta_AdminPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Ekarta_AdminPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Ekarta_AdminPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Ekarta_AdminPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Ekarta_Admin() {
            base.Channel.Ekarta_Admin();
        }
        
        public void setPopust(string @object) {
            base.Channel.setPopust(@object);
        }
        
        public string getPopust(int id) {
            return base.Channel.getPopust(id);
        }
        
        public void unsetPopust(ProjektovanjeSoftvera.AdminService.Application_Model_Popust @object) {
            base.Channel.unsetPopust(@object);
        }
        
        public void setKarta(string @object) {
            base.Channel.setKarta(@object);
        }
        
        public string getKarta(int id) {
            return base.Channel.getKarta(id);
        }
        
        public void unsetKarta(int idKarta) {
            base.Channel.unsetKarta(idKarta);
        }
        
        public void deactivate(int id) {
            base.Channel.deactivate(id);
        }
        
        public void activate(int id) {
            base.Channel.activate(id);
        }
        
        public string izracunajCenuKarte(int idTrasa, int idPolazneStanice, int idDolazneStanice, int idPopust, int povratna) {
            return base.Channel.izracunajCenuKarte(idTrasa, idPolazneStanice, idDolazneStanice, idPopust, povratna);
        }
        
        public int setStanica(string @object) {
            return base.Channel.setStanica(@object);
        }
        
        public string getStanice() {
            return base.Channel.getStanice();
        }
        
        public ProjektovanjeSoftvera.AdminService.Application_Model_Stanica getStanicu(int id) {
            return base.Channel.getStanicu(id);
        }
        
        public void unsetStanica(int id) {
            base.Channel.unsetStanica(id);
        }
        
        public void setTrasa(string @object) {
            base.Channel.setTrasa(@object);
        }
        
        public string getTrase() {
            return base.Channel.getTrase();
        }
        
        public string getTrasu(int id) {
            return base.Channel.getTrasu(id);
        }
        
        public void unsetTrasa(int id) {
            base.Channel.unsetTrasa(id);
        }
        
        public void setRedVoznje(string @object) {
            base.Channel.setRedVoznje(@object);
        }
        
        public string getRedVoznje() {
            return base.Channel.getRedVoznje();
        }
        
        public string getJedanRedVoznje(int id) {
            return base.Channel.getJedanRedVoznje(id);
        }
        
        public bool proveraDaLiPostoji(int idTrasa, int dan, string vreme) {
            return base.Channel.proveraDaLiPostoji(idTrasa, dan, vreme);
        }
        
        public void unsetRedVoznje(int id) {
            base.Channel.unsetRedVoznje(id);
        }
        
        public void setOtkazanaVoznja(string @object) {
            base.Channel.setOtkazanaVoznja(@object);
        }
        
        public string getOtkazaneVoznje() {
            return base.Channel.getOtkazaneVoznje();
        }
        
        public string getOtkazanaVoznja(int id) {
            return base.Channel.getOtkazanaVoznja(id);
        }
        
        public void unsetOtkazanaVoznja(int id) {
            base.Channel.unsetOtkazanaVoznja(id);
        }
        
        public void setTrasaStanica(string @object) {
            base.Channel.setTrasaStanica(@object);
        }
        
        public string getTrasaStanice() {
            return base.Channel.getTrasaStanice();
        }
        
        public string getTrasaStanica(int id) {
            return base.Channel.getTrasaStanica(id);
        }
        
        public void unsetTrasaStanica(int id) {
            base.Channel.unsetTrasaStanica(id);
        }
        
        public string getStaniceZaTrasu(int idTrasa) {
            return base.Channel.getStaniceZaTrasu(idTrasa);
        }
        
        public string getStaniceZaTrasuPosle(int idTrasa, int idStanica) {
            return base.Channel.getStaniceZaTrasuPosle(idTrasa, idStanica);
        }
        
        public string getVremeZaDatum(string @object) {
            return base.Channel.getVremeZaDatum(@object);
        }
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Battery
    {
        
        private bool areBatteriesIncludedField;
        
        private bool areBatteriesIncludedFieldSpecified;
        
        private bool areBatteriesRequiredField;
        
        private bool areBatteriesRequiredFieldSpecified;
        
        private BatteryBatterySubgroup[] batterySubgroupField;
        
        /// <remarks/>
        public bool AreBatteriesIncluded
        {
            get
            {
                return this.areBatteriesIncludedField;
            }
            set
            {
                this.areBatteriesIncludedField = value;
                this.AreBatteriesIncludedSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AreBatteriesIncludedSpecified
        {
            get
            {
                return this.areBatteriesIncludedFieldSpecified;
            }
            set
            {
                this.areBatteriesIncludedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool AreBatteriesRequired
        {
            get
            {
                return this.areBatteriesRequiredField;
            }
            set
            {
                this.areBatteriesRequiredField = value;
                this.AreBatteriesRequiredSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AreBatteriesRequiredSpecified
        {
            get
            {
                return this.areBatteriesRequiredFieldSpecified;
            }
            set
            {
                this.areBatteriesRequiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatterySubgroup")]
        public BatteryBatterySubgroup[] BatterySubgroup
        {
            get
            {
                return this.batterySubgroupField;
            }
            set
            {
                this.batterySubgroupField = value;
            }
        }
    }
}

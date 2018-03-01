namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class DatedCompareAtPrice
    {
        
        private System.DateTime startDateField;
        
        private bool startDateFieldSpecified;
        
        private System.DateTime endDateField;
        
        private bool endDateFieldSpecified;
        
        private CurrencyAmount compareAtPriceField;
        
        private bool deleteField;
        
        private bool deleteFieldSpecified;
        
        /// <remarks/>
        public System.DateTime StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
                this.StartDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartDateSpecified
        {
            get
            {
                return this.startDateFieldSpecified;
            }
            set
            {
                this.startDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
                this.EndDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDateSpecified
        {
            get
            {
                return this.endDateFieldSpecified;
            }
            set
            {
                this.endDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CurrencyAmount CompareAtPrice
        {
            get
            {
                return this.compareAtPriceField;
            }
            set
            {
                this.compareAtPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool delete
        {
            get
            {
                return this.deleteField;
            }
            set
            {
                this.deleteField = value;
                this.deleteSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deleteSpecified
        {
            get
            {
                return this.deleteFieldSpecified;
            }
            set
            {
                this.deleteFieldSpecified = value;
            }
        }
    }
}

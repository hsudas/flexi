namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OverrideCurrencyAmountWithTax))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class OverrideCurrencyAmount : CurrencyAmountWithDefault
    {
        
        private bool zeroField;
        
        private bool zeroFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool zero
        {
            get
            {
                return this.zeroField;
            }
            set
            {
                this.zeroField = value;
                this.zeroSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool zeroSpecified
        {
            get
            {
                return this.zeroFieldSpecified;
            }
            set
            {
                this.zeroFieldSpecified = value;
            }
        }
    }
}

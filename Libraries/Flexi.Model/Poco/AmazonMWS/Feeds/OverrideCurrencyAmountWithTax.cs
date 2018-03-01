namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class OverrideCurrencyAmountWithTax : OverrideCurrencyAmount
    {
        
        private decimal valueWithoutTaxField;
        
        private bool valueWithoutTaxFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal valueWithoutTax
        {
            get
            {
                return this.valueWithoutTaxField;
            }
            set
            {
                this.valueWithoutTaxField = value;
                this.valueWithoutTaxSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valueWithoutTaxSpecified
        {
            get
            {
                return this.valueWithoutTaxFieldSpecified;
            }
            set
            {
                this.valueWithoutTaxFieldSpecified = value;
            }
        }
    }
}

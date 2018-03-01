namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PriceSale
    {
        
        private System.DateTime startDateField;
        
        private System.DateTime endDateField;
        
        private OverrideCurrencyAmount salePriceField;
        
        private string salePricePointsField;
        
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
            }
        }
        
        /// <remarks/>
        public OverrideCurrencyAmount SalePrice
        {
            get
            {
                return this.salePriceField;
            }
            set
            {
                this.salePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string SalePricePoints
        {
            get
            {
                return this.salePricePointsField;
            }
            set
            {
                this.salePricePointsField = value;
            }
        }
    }
}

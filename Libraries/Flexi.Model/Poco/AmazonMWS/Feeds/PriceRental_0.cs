namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PriceRental_0
    {
        
        private System.DateTime startDateField;
        
        private System.DateTime endDateField;
        
        private OverrideCurrencyAmountWithTax rentalPriceField;
        
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
        public OverrideCurrencyAmountWithTax RentalPrice
        {
            get
            {
                return this.rentalPriceField;
            }
            set
            {
                this.rentalPriceField = value;
            }
        }
    }
}

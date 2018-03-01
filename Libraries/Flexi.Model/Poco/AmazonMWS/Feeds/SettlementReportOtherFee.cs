namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SettlementReportOtherFee
    {
        
        private string amazonOrderIDField;
        
        private string merchantOrderIDField;
        
        private string marketplaceNameField;
        
        private string merchantFulfillmentIDField;
        
        private System.DateTime postedDateField;
        
        private CurrencyAmount amountField;
        
        private string reasonDescriptionField;
        
        /// <remarks/>
        public string AmazonOrderID
        {
            get
            {
                return this.amazonOrderIDField;
            }
            set
            {
                this.amazonOrderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantOrderID
        {
            get
            {
                return this.merchantOrderIDField;
            }
            set
            {
                this.merchantOrderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MarketplaceName
        {
            get
            {
                return this.marketplaceNameField;
            }
            set
            {
                this.marketplaceNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantFulfillmentID
        {
            get
            {
                return this.merchantFulfillmentIDField;
            }
            set
            {
                this.merchantFulfillmentIDField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime PostedDate
        {
            get
            {
                return this.postedDateField;
            }
            set
            {
                this.postedDateField = value;
            }
        }
        
        /// <remarks/>
        public CurrencyAmount Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ReasonDescription
        {
            get
            {
                return this.reasonDescriptionField;
            }
            set
            {
                this.reasonDescriptionField = value;
            }
        }
    }
}

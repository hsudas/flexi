namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SettlementReportAdjustment
    {
        
        private string amazonOrderIDField;
        
        private string merchantOrderIDField;
        
        private System.DateTime postedDateField;
        
        private bool postedDateFieldSpecified;
        
        private SettlementReportAdjustmentAdjustedItem[] adjustedItemField;
        
        private SettlementReportAdjustmentItem[] itemField;
        
        private DirectPaymentTypeComponent[] directPaymentField;
        
        private string adjustmentIDField;
        
        private string marketplaceNameField;
        
        private SettlementReportAdjustmentFulfillment fulfillmentField;
        
        private AmazonFeesFee[] orderFeeAdjustmentField;
        
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
        public System.DateTime PostedDate
        {
            get
            {
                return this.postedDateField;
            }
            set
            {
                this.postedDateField = value;
                this.PostedDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PostedDateSpecified
        {
            get
            {
                return this.postedDateFieldSpecified;
            }
            set
            {
                this.postedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdjustedItem")]
        public SettlementReportAdjustmentAdjustedItem[] AdjustedItem
        {
            get
            {
                return this.adjustedItemField;
            }
            set
            {
                this.adjustedItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public SettlementReportAdjustmentItem[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable=false)]
        public DirectPaymentTypeComponent[] DirectPayment
        {
            get
            {
                return this.directPaymentField;
            }
            set
            {
                this.directPaymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string AdjustmentID
        {
            get
            {
                return this.adjustmentIDField;
            }
            set
            {
                this.adjustmentIDField = value;
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
        public SettlementReportAdjustmentFulfillment Fulfillment
        {
            get
            {
                return this.fulfillmentField;
            }
            set
            {
                this.fulfillmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", typeof(AmazonFeesFee), IsNullable=false)]
        public AmazonFeesFee[] OrderFeeAdjustment
        {
            get
            {
                return this.orderFeeAdjustmentField;
            }
            set
            {
                this.orderFeeAdjustmentField = value;
            }
        }
    }
}

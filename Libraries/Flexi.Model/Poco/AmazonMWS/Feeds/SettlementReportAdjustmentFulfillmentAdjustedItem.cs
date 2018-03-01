namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SettlementReportAdjustmentFulfillmentAdjustedItem
    {
        
        private string amazonOrderItemCodeField;
        
        private string merchantOrderItemIDField;
        
        private string merchantAdjustmentItemIDField;
        
        private string sKUField;
        
        private BuyerPriceComponent[] itemPriceAdjustmentsField;
        
        private AmazonFeesFee[] itemFeeAdjustmentsField;
        
        private SettlementReportAdjustmentFulfillmentAdjustedItemPromotionAdjustment[] promotionAdjustmentField;
        
        /// <remarks/>
        public string AmazonOrderItemCode
        {
            get
            {
                return this.amazonOrderItemCodeField;
            }
            set
            {
                this.amazonOrderItemCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantOrderItemID
        {
            get
            {
                return this.merchantOrderItemIDField;
            }
            set
            {
                this.merchantOrderItemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantAdjustmentItemID
        {
            get
            {
                return this.merchantAdjustmentItemIDField;
            }
            set
            {
                this.merchantAdjustmentItemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable=false)]
        public BuyerPriceComponent[] ItemPriceAdjustments
        {
            get
            {
                return this.itemPriceAdjustmentsField;
            }
            set
            {
                this.itemPriceAdjustmentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable=false)]
        public AmazonFeesFee[] ItemFeeAdjustments
        {
            get
            {
                return this.itemFeeAdjustmentsField;
            }
            set
            {
                this.itemFeeAdjustmentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionAdjustment")]
        public SettlementReportAdjustmentFulfillmentAdjustedItemPromotionAdjustment[] PromotionAdjustment
        {
            get
            {
                return this.promotionAdjustmentField;
            }
            set
            {
                this.promotionAdjustmentField = value;
            }
        }
    }
}

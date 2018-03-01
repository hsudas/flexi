namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SettlementReportAdjustmentItem
    {
        
        private string amazonOrderItemCodeField;
        
        private bool merchantsAtOrderField;
        
        private bool merchantsAtOrderFieldSpecified;
        
        private string merchantOrderItemIDField;
        
        private string sKUField;
        
        private BuyerPriceComponent[] itemPriceAdjustmentsField;
        
        private AmazonFeesFee[] itemFeeAdjustmentsField;
        
        private PromotionDataType[] promotionAdjustmentsField;
        
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
        public bool MerchantsAtOrder
        {
            get
            {
                return this.merchantsAtOrderField;
            }
            set
            {
                this.merchantsAtOrderField = value;
                this.MerchantsAtOrderSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MerchantsAtOrderSpecified
        {
            get
            {
                return this.merchantsAtOrderFieldSpecified;
            }
            set
            {
                this.merchantsAtOrderFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PromotionAdjustments")]
        public PromotionDataType[] PromotionAdjustments
        {
            get
            {
                return this.promotionAdjustmentsField;
            }
            set
            {
                this.promotionAdjustmentsField = value;
            }
        }
    }
}

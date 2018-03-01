namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class OrderAdjustmentAdjustedItem
    {
        
        private string itemField;
        
        private ItemChoiceType2 itemElementNameField;
        
        private string merchantAdjustmentItemIDField;
        
        private OrderAdjustmentAdjustedItemAdjustmentReason adjustmentReasonField;
        
        private AdjustmentBuyerPriceComponent[] itemPriceAdjustmentsField;
        
        private OrderAdjustmentAdjustedItemPromotionAdjustments[] promotionAdjustmentsField;
        
        private AdjustmentDirectPaymentTypeComponent[] directPaymentAdjustmentsField;
        
        private string quantityCancelledField;
        
        private string quantityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AmazonOrderItemCode", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MerchantOrderItemID", typeof(string), DataType="normalizedString")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
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
        public OrderAdjustmentAdjustedItemAdjustmentReason AdjustmentReason
        {
            get
            {
                return this.adjustmentReasonField;
            }
            set
            {
                this.adjustmentReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable=false)]
        public AdjustmentBuyerPriceComponent[] ItemPriceAdjustments
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
        [System.Xml.Serialization.XmlElementAttribute("PromotionAdjustments")]
        public OrderAdjustmentAdjustedItemPromotionAdjustments[] PromotionAdjustments
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable=false)]
        public AdjustmentDirectPaymentTypeComponent[] DirectPaymentAdjustments
        {
            get
            {
                return this.directPaymentAdjustmentsField;
            }
            set
            {
                this.directPaymentAdjustmentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string QuantityCancelled
        {
            get
            {
                return this.quantityCancelledField;
            }
            set
            {
                this.quantityCancelledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }
}

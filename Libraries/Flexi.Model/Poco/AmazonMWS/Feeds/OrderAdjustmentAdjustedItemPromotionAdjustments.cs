namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class OrderAdjustmentAdjustedItemPromotionAdjustments
    {
        
        private string promotionClaimCodeField;
        
        private string merchantPromotionIDField;
        
        private OrderAdjustmentAdjustedItemPromotionAdjustmentsComponent[] componentField;
        
        /// <remarks/>
        public string PromotionClaimCode
        {
            get
            {
                return this.promotionClaimCodeField;
            }
            set
            {
                this.promotionClaimCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantPromotionID
        {
            get
            {
                return this.merchantPromotionIDField;
            }
            set
            {
                this.merchantPromotionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Component")]
        public OrderAdjustmentAdjustedItemPromotionAdjustmentsComponent[] Component
        {
            get
            {
                return this.componentField;
            }
            set
            {
                this.componentField = value;
            }
        }
    }
}

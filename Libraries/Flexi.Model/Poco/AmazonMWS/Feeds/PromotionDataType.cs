namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PromotionDataType
    {
        
        private string promotionClaimCodeField;
        
        private string merchantPromotionIDField;
        
        private PromotionDataTypeComponent[] componentField;
        
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
        public PromotionDataTypeComponent[] Component
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

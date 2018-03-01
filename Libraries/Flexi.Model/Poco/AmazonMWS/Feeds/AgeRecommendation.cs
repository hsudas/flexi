namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class AgeRecommendation
    {
        
        private MinimumAgeRecommendedDimension minimumManufacturerAgeRecommendedField;
        
        private AgeRecommendedDimension maximumManufacturerAgeRecommendedField;
        
        private MinimumAgeRecommendedDimension minimumMerchantAgeRecommendedField;
        
        private AgeRecommendedDimension maximumMerchantAgeRecommendedField;
        
        /// <remarks/>
        public MinimumAgeRecommendedDimension MinimumManufacturerAgeRecommended
        {
            get
            {
                return this.minimumManufacturerAgeRecommendedField;
            }
            set
            {
                this.minimumManufacturerAgeRecommendedField = value;
            }
        }
        
        /// <remarks/>
        public AgeRecommendedDimension MaximumManufacturerAgeRecommended
        {
            get
            {
                return this.maximumManufacturerAgeRecommendedField;
            }
            set
            {
                this.maximumManufacturerAgeRecommendedField = value;
            }
        }
        
        /// <remarks/>
        public MinimumAgeRecommendedDimension MinimumMerchantAgeRecommended
        {
            get
            {
                return this.minimumMerchantAgeRecommendedField;
            }
            set
            {
                this.minimumMerchantAgeRecommendedField = value;
            }
        }
        
        /// <remarks/>
        public AgeRecommendedDimension MaximumMerchantAgeRecommended
        {
            get
            {
                return this.maximumMerchantAgeRecommendedField;
            }
            set
            {
                this.maximumMerchantAgeRecommendedField = value;
            }
        }
    }
}

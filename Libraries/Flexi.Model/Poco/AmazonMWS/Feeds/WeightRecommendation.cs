namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class WeightRecommendation
    {
        
        private WeightIntegerDimension minimumManufacturerWeightRecommendedField;
        
        private WeightIntegerDimension maximumManufacturerWeightRecommendedField;
        
        /// <remarks/>
        public WeightIntegerDimension MinimumManufacturerWeightRecommended
        {
            get
            {
                return this.minimumManufacturerWeightRecommendedField;
            }
            set
            {
                this.minimumManufacturerWeightRecommendedField = value;
            }
        }
        
        /// <remarks/>
        public WeightIntegerDimension MaximumManufacturerWeightRecommended
        {
            get
            {
                return this.maximumManufacturerWeightRecommendedField;
            }
            set
            {
                this.maximumManufacturerWeightRecommendedField = value;
            }
        }
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class WeightRecommendationType
    {
        
        private PositiveWeightDimension maximumWeightRecommendationField;
        
        private PositiveWeightDimension minimumWeightRecommendationField;
        
        /// <remarks/>
        public PositiveWeightDimension MaximumWeightRecommendation
        {
            get
            {
                return this.maximumWeightRecommendationField;
            }
            set
            {
                this.maximumWeightRecommendationField = value;
            }
        }
        
        /// <remarks/>
        public PositiveWeightDimension MinimumWeightRecommendation
        {
            get
            {
                return this.minimumWeightRecommendationField;
            }
            set
            {
                this.minimumWeightRecommendationField = value;
            }
        }
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class HeightRecommendation
    {
        
        private LengthDimension minimumHeightRecommendedField;
        
        private LengthDimension maximumHeightRecommendedField;
        
        /// <remarks/>
        public LengthDimension MinimumHeightRecommended
        {
            get
            {
                return this.minimumHeightRecommendedField;
            }
            set
            {
                this.minimumHeightRecommendedField = value;
            }
        }
        
        /// <remarks/>
        public LengthDimension MaximumHeightRecommended
        {
            get
            {
                return this.maximumHeightRecommendedField;
            }
            set
            {
                this.maximumHeightRecommendedField = value;
            }
        }
    }
}

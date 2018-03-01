namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ProductDiscoveryData
    {
        
        private string priorityField;
        
        private bool browseExclusionField;
        
        private bool browseExclusionFieldSpecified;
        
        private bool recommendationExclusionField;
        
        private bool recommendationExclusionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }
        
        /// <remarks/>
        public bool BrowseExclusion
        {
            get
            {
                return this.browseExclusionField;
            }
            set
            {
                this.browseExclusionField = value;
                this.BrowseExclusionSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrowseExclusionSpecified
        {
            get
            {
                return this.browseExclusionFieldSpecified;
            }
            set
            {
                this.browseExclusionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool RecommendationExclusion
        {
            get
            {
                return this.recommendationExclusionField;
            }
            set
            {
                this.recommendationExclusionField = value;
                this.RecommendationExclusionSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecommendationExclusionSpecified
        {
            get
            {
                return this.recommendationExclusionFieldSpecified;
            }
            set
            {
                this.recommendationExclusionFieldSpecified = value;
            }
        }
    }
}

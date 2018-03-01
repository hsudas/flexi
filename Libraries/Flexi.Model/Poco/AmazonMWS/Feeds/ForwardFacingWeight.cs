namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ForwardFacingWeight
    {
        
        private WeightDimension forwardFacingMaximumWeightField;
        
        private WeightDimension forwardFacingMinimumWeightField;
        
        /// <remarks/>
        public WeightDimension ForwardFacingMaximumWeight
        {
            get
            {
                return this.forwardFacingMaximumWeightField;
            }
            set
            {
                this.forwardFacingMaximumWeightField = value;
            }
        }
        
        /// <remarks/>
        public WeightDimension ForwardFacingMinimumWeight
        {
            get
            {
                return this.forwardFacingMinimumWeightField;
            }
            set
            {
                this.forwardFacingMinimumWeightField = value;
            }
        }
    }
}

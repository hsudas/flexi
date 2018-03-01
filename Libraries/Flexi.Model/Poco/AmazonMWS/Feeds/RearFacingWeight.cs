namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class RearFacingWeight
    {
        
        private WeightDimension rearFacingMaximumWeightField;
        
        private WeightDimension rearFacingMinimumWeightField;
        
        /// <remarks/>
        public WeightDimension RearFacingMaximumWeight
        {
            get
            {
                return this.rearFacingMaximumWeightField;
            }
            set
            {
                this.rearFacingMaximumWeightField = value;
            }
        }
        
        /// <remarks/>
        public WeightDimension RearFacingMinimumWeight
        {
            get
            {
                return this.rearFacingMinimumWeightField;
            }
            set
            {
                this.rearFacingMinimumWeightField = value;
            }
        }
    }
}

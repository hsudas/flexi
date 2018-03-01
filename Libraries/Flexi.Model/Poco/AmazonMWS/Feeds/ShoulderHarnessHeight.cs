namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ShoulderHarnessHeight
    {
        
        private LengthDimension shoulderHarnessMaximumHeightField;
        
        private LengthDimension shoulderHarnessMinimumHeightField;
        
        /// <remarks/>
        public LengthDimension ShoulderHarnessMaximumHeight
        {
            get
            {
                return this.shoulderHarnessMaximumHeightField;
            }
            set
            {
                this.shoulderHarnessMaximumHeightField = value;
            }
        }
        
        /// <remarks/>
        public LengthDimension ShoulderHarnessMinimumHeight
        {
            get
            {
                return this.shoulderHarnessMinimumHeightField;
            }
            set
            {
                this.shoulderHarnessMinimumHeightField = value;
            }
        }
    }
}

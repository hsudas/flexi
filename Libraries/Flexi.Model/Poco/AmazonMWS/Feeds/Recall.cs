namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Recall
    {
        
        private bool isRecalledField;
        
        private string recallDescriptionField;
        
        /// <remarks/>
        public bool IsRecalled
        {
            get
            {
                return this.isRecalledField;
            }
            set
            {
                this.isRecalledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string RecallDescription
        {
            get
            {
                return this.recallDescriptionField;
            }
            set
            {
                this.recallDescriptionField = value;
            }
        }
    }
}

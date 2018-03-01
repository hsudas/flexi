namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Header
    {
        
        private string documentVersionField;
        
        private string merchantIdentifierField;
        
        private string overrideReleaseIdField;
        
        /// <remarks/>
        public string DocumentVersion
        {
            get
            {
                return this.documentVersionField;
            }
            set
            {
                this.documentVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantIdentifier
        {
            get
            {
                return this.merchantIdentifierField;
            }
            set
            {
                this.merchantIdentifierField = value;
            }
        }
        
        /// <remarks/>
        public string OverrideReleaseId
        {
            get
            {
                return this.overrideReleaseIdField;
            }
            set
            {
                this.overrideReleaseIdField = value;
            }
        }
    }
}

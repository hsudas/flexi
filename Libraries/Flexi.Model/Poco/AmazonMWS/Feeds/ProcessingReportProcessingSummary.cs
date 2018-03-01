namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ProcessingReportProcessingSummary
    {
        
        private string messagesProcessedField;
        
        private string messagesSuccessfulField;
        
        private string messagesWithErrorField;
        
        private string messagesWithWarningField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string MessagesProcessed
        {
            get
            {
                return this.messagesProcessedField;
            }
            set
            {
                this.messagesProcessedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string MessagesSuccessful
        {
            get
            {
                return this.messagesSuccessfulField;
            }
            set
            {
                this.messagesSuccessfulField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string MessagesWithError
        {
            get
            {
                return this.messagesWithErrorField;
            }
            set
            {
                this.messagesWithErrorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string MessagesWithWarning
        {
            get
            {
                return this.messagesWithWarningField;
            }
            set
            {
                this.messagesWithWarningField = value;
            }
        }
    }
}

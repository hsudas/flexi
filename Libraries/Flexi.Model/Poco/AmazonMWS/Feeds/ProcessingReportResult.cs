namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ProcessingReportResult
    {
        
        private string messageIDField;
        
        private ProcessingReportResultResultCode resultCodeField;
        
        private string resultMessageCodeField;
        
        private string resultDescriptionField;
        
        private ProcessingReportResultAdditionalInfo additionalInfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string MessageID
        {
            get
            {
                return this.messageIDField;
            }
            set
            {
                this.messageIDField = value;
            }
        }
        
        /// <remarks/>
        public ProcessingReportResultResultCode ResultCode
        {
            get
            {
                return this.resultCodeField;
            }
            set
            {
                this.resultCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string ResultMessageCode
        {
            get
            {
                return this.resultMessageCodeField;
            }
            set
            {
                this.resultMessageCodeField = value;
            }
        }
        
        /// <remarks/>
        public string ResultDescription
        {
            get
            {
                return this.resultDescriptionField;
            }
            set
            {
                this.resultDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public ProcessingReportResultAdditionalInfo AdditionalInfo
        {
            get
            {
                return this.additionalInfoField;
            }
            set
            {
                this.additionalInfoField = value;
            }
        }
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ProcessingReport
    {
        
        private string documentTransactionIDField;
        
        private ProcessingReportStatusCode statusCodeField;
        
        private ProcessingReportProcessingSummary processingSummaryField;
        
        private ProcessingReportResult[] resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string DocumentTransactionID
        {
            get
            {
                return this.documentTransactionIDField;
            }
            set
            {
                this.documentTransactionIDField = value;
            }
        }
        
        /// <remarks/>
        public ProcessingReportStatusCode StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }
        
        /// <remarks/>
        public ProcessingReportProcessingSummary ProcessingSummary
        {
            get
            {
                return this.processingSummaryField;
            }
            set
            {
                this.processingSummaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Result")]
        public ProcessingReportResult[] Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }
}

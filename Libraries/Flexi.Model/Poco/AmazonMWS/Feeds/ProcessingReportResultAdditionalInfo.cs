namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ProcessingReportResultAdditionalInfo
    {
        
        private string sKUField;
        
        private string fulfillmentCenterIDField;
        
        private string amazonOrderIDField;
        
        private string amazonOrderItemCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string FulfillmentCenterID
        {
            get
            {
                return this.fulfillmentCenterIDField;
            }
            set
            {
                this.fulfillmentCenterIDField = value;
            }
        }
        
        /// <remarks/>
        public string AmazonOrderID
        {
            get
            {
                return this.amazonOrderIDField;
            }
            set
            {
                this.amazonOrderIDField = value;
            }
        }
        
        /// <remarks/>
        public string AmazonOrderItemCode
        {
            get
            {
                return this.amazonOrderItemCodeField;
            }
            set
            {
                this.amazonOrderItemCodeField = value;
            }
        }
    }
}

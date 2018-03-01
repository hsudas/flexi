namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class OrderAcknowledgement
    {
        
        private string amazonOrderIDField;
        
        private string merchantOrderIDField;
        
        private OrderAcknowledgementStatusCode statusCodeField;
        
        private OrderAcknowledgementItem[] itemField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantOrderID
        {
            get
            {
                return this.merchantOrderIDField;
            }
            set
            {
                this.merchantOrderIDField = value;
            }
        }
        
        /// <remarks/>
        public OrderAcknowledgementStatusCode StatusCode
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
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public OrderAcknowledgementItem[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}

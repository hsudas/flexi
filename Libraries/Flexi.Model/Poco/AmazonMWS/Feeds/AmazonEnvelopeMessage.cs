namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class AmazonEnvelopeMessage
    {
        
        private string messageIDField;
        
        private AmazonEnvelopeMessageOperationType operationTypeField;
        
        private bool operationTypeFieldSpecified;
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
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
        public AmazonEnvelopeMessageOperationType OperationType
        {
            get
            {
                return this.operationTypeField;
            }
            set
            {
                this.operationTypeField = value;
                this.OperationTypeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OperationTypeSpecified
        {
            get
            {
                return this.operationTypeFieldSpecified;
            }
            set
            {
                this.operationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FulfillmentCenter", typeof(FulfillmentCenter))]
        [System.Xml.Serialization.XmlElementAttribute("Inventory", typeof(Inventory))]
        [System.Xml.Serialization.XmlElementAttribute("Listings", typeof(Listings))]
        [System.Xml.Serialization.XmlElementAttribute("OrderAcknowledgement", typeof(OrderAcknowledgement))]
        [System.Xml.Serialization.XmlElementAttribute("OrderAdjustment", typeof(OrderAdjustment))]
        [System.Xml.Serialization.XmlElementAttribute("OrderFulfillment", typeof(OrderFulfillment))]
        [System.Xml.Serialization.XmlElementAttribute("Override", typeof(Override))]
        [System.Xml.Serialization.XmlElementAttribute("Price", typeof(Price))]
        [System.Xml.Serialization.XmlElementAttribute("ProcessingReport", typeof(ProcessingReport))]
        [System.Xml.Serialization.XmlElementAttribute("Product", typeof(Product))]
        [System.Xml.Serialization.XmlElementAttribute("ProductImage", typeof(ProductImage))]
        [System.Xml.Serialization.XmlElementAttribute("Relationship", typeof(Relationship))]
        [System.Xml.Serialization.XmlElementAttribute("SettlementReport", typeof(SettlementReport))]
        public object Item
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

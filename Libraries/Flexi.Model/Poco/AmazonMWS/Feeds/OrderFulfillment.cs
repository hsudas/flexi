namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class OrderFulfillment
    {
        
        private string itemField;
        
        private ItemChoiceType3 itemElementNameField;
        
        private string merchantFulfillmentIDField;
        
        private System.DateTime fulfillmentDateField;
        
        private OrderFulfillmentFulfillmentData fulfillmentDataField;
        
        private OrderFulfillmentCODCollectionMethod cODCollectionMethodField;
        
        private bool cODCollectionMethodFieldSpecified;
        
        private OrderFulfillmentItem[] item1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AmazonOrderID", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MerchantOrderID", typeof(string), DataType="normalizedString")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string MerchantFulfillmentID
        {
            get
            {
                return this.merchantFulfillmentIDField;
            }
            set
            {
                this.merchantFulfillmentIDField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime FulfillmentDate
        {
            get
            {
                return this.fulfillmentDateField;
            }
            set
            {
                this.fulfillmentDateField = value;
            }
        }
        
        /// <remarks/>
        public OrderFulfillmentFulfillmentData FulfillmentData
        {
            get
            {
                return this.fulfillmentDataField;
            }
            set
            {
                this.fulfillmentDataField = value;
            }
        }
        
        /// <remarks/>
        public OrderFulfillmentCODCollectionMethod CODCollectionMethod
        {
            get
            {
                return this.cODCollectionMethodField;
            }
            set
            {
                this.cODCollectionMethodField = value;
                this.CODCollectionMethodSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CODCollectionMethodSpecified
        {
            get
            {
                return this.cODCollectionMethodFieldSpecified;
            }
            set
            {
                this.cODCollectionMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public OrderFulfillmentItem[] Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }
    }
}

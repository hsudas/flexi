namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class OrderFulfillmentItem
    {
        
        private string itemField;
        
        private ItemChoiceType4 itemElementNameField;
        
        private string merchantFulfillmentItemIDField;
        
        private string quantityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AmazonOrderItemCode", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MerchantOrderItemID", typeof(string), DataType="normalizedString")]
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
        public ItemChoiceType4 ItemElementName
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
        public string MerchantFulfillmentItemID
        {
            get
            {
                return this.merchantFulfillmentItemIDField;
            }
            set
            {
                this.merchantFulfillmentItemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Inventory
    {
        
        private string sKUField;
        
        private string fulfillmentCenterIDField;
        
        private object itemField;
        
        private System.DateTime restockDateField;
        
        private bool restockDateFieldSpecified;
        
        private string fulfillmentLatencyField;
        
        private InventorySwitchFulfillmentTo switchFulfillmentToField;
        
        private bool switchFulfillmentToFieldSpecified;
        
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
        [System.Xml.Serialization.XmlElementAttribute("Available", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("Lookup", typeof(InventoryLookup))]
        [System.Xml.Serialization.XmlElementAttribute("Quantity", typeof(string), DataType="nonNegativeInteger")]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime RestockDate
        {
            get
            {
                return this.restockDateField;
            }
            set
            {
                this.restockDateField = value;
                this.RestockDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RestockDateSpecified
        {
            get
            {
                return this.restockDateFieldSpecified;
            }
            set
            {
                this.restockDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string FulfillmentLatency
        {
            get
            {
                return this.fulfillmentLatencyField;
            }
            set
            {
                this.fulfillmentLatencyField = value;
            }
        }
        
        /// <remarks/>
        public InventorySwitchFulfillmentTo SwitchFulfillmentTo
        {
            get
            {
                return this.switchFulfillmentToField;
            }
            set
            {
                this.switchFulfillmentToField = value;
                this.SwitchFulfillmentToSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SwitchFulfillmentToSpecified
        {
            get
            {
                return this.switchFulfillmentToFieldSpecified;
            }
            set
            {
                this.switchFulfillmentToFieldSpecified = value;
            }
        }
    }
}

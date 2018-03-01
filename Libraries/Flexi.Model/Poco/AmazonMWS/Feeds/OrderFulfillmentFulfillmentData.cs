namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class OrderFulfillmentFulfillmentData
    {
        
        private object itemField;
        
        private string shippingMethodField;
        
        private string shipperTrackingNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarrierCode", typeof(CarrierCode))]
        [System.Xml.Serialization.XmlElementAttribute("CarrierName", typeof(string), DataType="normalizedString")]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ShippingMethod
        {
            get
            {
                return this.shippingMethodField;
            }
            set
            {
                this.shippingMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ShipperTrackingNumber
        {
            get
            {
                return this.shipperTrackingNumberField;
            }
            set
            {
                this.shipperTrackingNumberField = value;
            }
        }
    }
}

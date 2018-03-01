namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class FulfillmentCenter
    {
        
        private string fulfillmentCenterIDField;
        
        private bool supportsInStorePickupField;
        
        private FulfillmentCenterOperatingHours operatingHoursField;
        
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
        public bool SupportsInStorePickup
        {
            get
            {
                return this.supportsInStorePickupField;
            }
            set
            {
                this.supportsInStorePickupField = value;
            }
        }
        
        /// <remarks/>
        public FulfillmentCenterOperatingHours OperatingHours
        {
            get
            {
                return this.operatingHoursField;
            }
            set
            {
                this.operatingHoursField = value;
            }
        }
    }
}

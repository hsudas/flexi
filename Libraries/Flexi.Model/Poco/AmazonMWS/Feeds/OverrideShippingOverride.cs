namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class OverrideShippingOverride
    {
        
        private string shipOptionField;
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ShipOption
        {
            get
            {
                return this.shipOptionField;
            }
            set
            {
                this.shipOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IsShippingRestricted", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("ShipAmount", typeof(CurrencyAmount))]
        [System.Xml.Serialization.XmlElementAttribute("Type", typeof(OverrideShippingOverrideType))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}

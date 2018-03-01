namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class FoodAndBeveragesProductType
    {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlcoholicBeverages", typeof(AlcoholicBeverages))]
        [System.Xml.Serialization.XmlElementAttribute("Beer", typeof(Beer))]
        [System.Xml.Serialization.XmlElementAttribute("Beverages", typeof(Beverages))]
        [System.Xml.Serialization.XmlElementAttribute("Food", typeof(Food))]
        [System.Xml.Serialization.XmlElementAttribute("HardLiquor", typeof(HardLiquor))]
        [System.Xml.Serialization.XmlElementAttribute("HouseholdSupplies", typeof(HouseholdSupplies))]
        [System.Xml.Serialization.XmlElementAttribute("Spirits", typeof(Spirits))]
        [System.Xml.Serialization.XmlElementAttribute("Wine", typeof(Wine))]
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

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ToysProductType
    {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CollectibleCard", typeof(CollectibleCard))]
        [System.Xml.Serialization.XmlElementAttribute("Costume", typeof(Costume))]
        [System.Xml.Serialization.XmlElementAttribute("Hobbies", typeof(Hobbies))]
        [System.Xml.Serialization.XmlElementAttribute("ToysAndGames", typeof(ToysAndGames))]
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

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class HardLiquorNutritionalFactsGroup
    {
        
        private AllergenInformation[] allergenInformationField;
        
        private string[] specialIngredientsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllergenInformation")]
        public AllergenInformation[] AllergenInformation
        {
            get
            {
                return this.allergenInformationField;
            }
            set
            {
                this.allergenInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialIngredients", DataType="normalizedString")]
        public string[] SpecialIngredients
        {
            get
            {
                return this.specialIngredientsField;
            }
            set
            {
                this.specialIngredientsField = value;
            }
        }
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class AlcoholicBeveragesVariationData
    {
        
        private AlcoholicBeveragesVariationDataParentage parentageField;
        
        private AlcoholicBeveragesVariationDataVariationTheme variationThemeField;
        
        private bool variationThemeFieldSpecified;
        
        private string sizeField;
        
        private string flavorField;
        
        private string patternNameField;
        
        /// <remarks/>
        public AlcoholicBeveragesVariationDataParentage Parentage
        {
            get
            {
                return this.parentageField;
            }
            set
            {
                this.parentageField = value;
            }
        }
        
        /// <remarks/>
        public AlcoholicBeveragesVariationDataVariationTheme VariationTheme
        {
            get
            {
                return this.variationThemeField;
            }
            set
            {
                this.variationThemeField = value;
                this.VariationThemeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VariationThemeSpecified
        {
            get
            {
                return this.variationThemeFieldSpecified;
            }
            set
            {
                this.variationThemeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Flavor
        {
            get
            {
                return this.flavorField;
            }
            set
            {
                this.flavorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string PatternName
        {
            get
            {
                return this.patternNameField;
            }
            set
            {
                this.patternNameField = value;
            }
        }
    }
}

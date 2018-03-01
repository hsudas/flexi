namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Toys
    {
        
        private ToysVariationData variationDataField;
        
        private ToysProductType productTypeField;
        
        private Battery batteryField;
        
        private string assemblyInstructionsField;
        
        private AgeRecommendation ageRecommendationField;
        
        private AssemblyTimeDimension assemblyTimeField;
        
        private ColorSpecification colorSpecificationField;
        
        private string editionField;
        
        private bool isAdultProductField;
        
        private bool isAdultProductFieldSpecified;
        
        private bool isAssemblyRequiredField;
        
        private bool isAssemblyRequiredFieldSpecified;
        
        private string manufacturerSafetyWarningField;
        
        private string manufacturerWarrantyDescriptionField;
        
        private WeightRecommendation weightRecommendationField;
        
        private string numberOfPiecesField;
        
        private string numberOfPlayersField;
        
        private string partNumberField;
        
        private Recall recallField;
        
        private string sizeField;
        
        private string sizeMapField;
        
        private string styleNameField;
        
        private string[] subjectCharacterField;
        
        /// <remarks/>
        public ToysVariationData VariationData
        {
            get
            {
                return this.variationDataField;
            }
            set
            {
                this.variationDataField = value;
            }
        }
        
        /// <remarks/>
        public ToysProductType ProductType
        {
            get
            {
                return this.productTypeField;
            }
            set
            {
                this.productTypeField = value;
            }
        }
        
        /// <remarks/>
        public Battery Battery
        {
            get
            {
                return this.batteryField;
            }
            set
            {
                this.batteryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string AssemblyInstructions
        {
            get
            {
                return this.assemblyInstructionsField;
            }
            set
            {
                this.assemblyInstructionsField = value;
            }
        }
        
        /// <remarks/>
        public AgeRecommendation AgeRecommendation
        {
            get
            {
                return this.ageRecommendationField;
            }
            set
            {
                this.ageRecommendationField = value;
            }
        }
        
        /// <remarks/>
        public AssemblyTimeDimension AssemblyTime
        {
            get
            {
                return this.assemblyTimeField;
            }
            set
            {
                this.assemblyTimeField = value;
            }
        }
        
        /// <remarks/>
        public ColorSpecification ColorSpecification
        {
            get
            {
                return this.colorSpecificationField;
            }
            set
            {
                this.colorSpecificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Edition
        {
            get
            {
                return this.editionField;
            }
            set
            {
                this.editionField = value;
            }
        }
        
        /// <remarks/>
        public bool IsAdultProduct
        {
            get
            {
                return this.isAdultProductField;
            }
            set
            {
                this.isAdultProductField = value;
                this.IsAdultProductSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAdultProductSpecified
        {
            get
            {
                return this.isAdultProductFieldSpecified;
            }
            set
            {
                this.isAdultProductFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool IsAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
                this.IsAssemblyRequiredSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAssemblyRequiredSpecified
        {
            get
            {
                return this.isAssemblyRequiredFieldSpecified;
            }
            set
            {
                this.isAssemblyRequiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ManufacturerSafetyWarning
        {
            get
            {
                return this.manufacturerSafetyWarningField;
            }
            set
            {
                this.manufacturerSafetyWarningField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ManufacturerWarrantyDescription
        {
            get
            {
                return this.manufacturerWarrantyDescriptionField;
            }
            set
            {
                this.manufacturerWarrantyDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public WeightRecommendation WeightRecommendation
        {
            get
            {
                return this.weightRecommendationField;
            }
            set
            {
                this.weightRecommendationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string NumberOfPieces
        {
            get
            {
                return this.numberOfPiecesField;
            }
            set
            {
                this.numberOfPiecesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string NumberOfPlayers
        {
            get
            {
                return this.numberOfPlayersField;
            }
            set
            {
                this.numberOfPlayersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string PartNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        public Recall Recall
        {
            get
            {
                return this.recallField;
            }
            set
            {
                this.recallField = value;
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
        public string SizeMap
        {
            get
            {
                return this.sizeMapField;
            }
            set
            {
                this.sizeMapField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string StyleName
        {
            get
            {
                return this.styleNameField;
            }
            set
            {
                this.styleNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubjectCharacter", DataType="normalizedString")]
        public string[] SubjectCharacter
        {
            get
            {
                return this.subjectCharacterField;
            }
            set
            {
                this.subjectCharacterField = value;
            }
        }
    }
}

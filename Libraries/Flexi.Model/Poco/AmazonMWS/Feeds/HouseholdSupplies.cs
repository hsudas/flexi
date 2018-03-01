namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class HouseholdSupplies
    {
        
        private HouseholdSuppliesVariationData variationDataField;
        
        private string countryProducedInField;
        
        private string countryOfOriginField;
        
        private string regionOfOriginField;
        
        private string prefectureField;
        
        private string itemFormField;
        
        private string ingredientsField;
        
        private string nutritionalFactsField;
        
        private string[] kosherCertificationField;
        
        private string[] organicCertificationField;
        
        private string[] tokuhoCertificationField;
        
        private string[] itemSpecialtyField;
        
        private string caffeineContentField;
        
        private string warningsField;
        
        private bool isPerishableField;
        
        private bool isPerishableFieldSpecified;
        
        private string storageInstructionsField;
        
        private string directionsField;
        
        private string occasionField;
        
        private string[] awardsWonField;
        
        private string ageRangeDescriptionField;
        
        private string itemPackageQuantityField;
        
        private string numberOfItemsField;
        
        private LengthDimension displayLengthField;
        
        private WeightDimension displayWeightField;
        
        private VolumeDimension displayVolumeField;
        
        private string containerTypeField;
        
        private HouseholdSuppliesUnitCount unitCountField;
        
        private NutritionalFactsGroup nutritionalFactsGroupField;
        
        private string containerMaterialTypeField;
        
        private string containerVolumeField;
        
        private string cuisineField;
        
        private string useByRecommendationField;
        
        private bool isExpirationDatedProductField;
        
        private bool isExpirationDatedProductFieldSpecified;
        
        /// <remarks/>
        public HouseholdSuppliesVariationData VariationData
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string CountryProducedIn
        {
            get
            {
                return this.countryProducedInField;
            }
            set
            {
                this.countryProducedInField = value;
            }
        }
        
        /// <remarks/>
        public string CountryOfOrigin
        {
            get
            {
                return this.countryOfOriginField;
            }
            set
            {
                this.countryOfOriginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string RegionOfOrigin
        {
            get
            {
                return this.regionOfOriginField;
            }
            set
            {
                this.regionOfOriginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Prefecture
        {
            get
            {
                return this.prefectureField;
            }
            set
            {
                this.prefectureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ItemForm
        {
            get
            {
                return this.itemFormField;
            }
            set
            {
                this.itemFormField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Ingredients
        {
            get
            {
                return this.ingredientsField;
            }
            set
            {
                this.ingredientsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string NutritionalFacts
        {
            get
            {
                return this.nutritionalFactsField;
            }
            set
            {
                this.nutritionalFactsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KosherCertification", DataType="normalizedString")]
        public string[] KosherCertification
        {
            get
            {
                return this.kosherCertificationField;
            }
            set
            {
                this.kosherCertificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganicCertification", DataType="normalizedString")]
        public string[] OrganicCertification
        {
            get
            {
                return this.organicCertificationField;
            }
            set
            {
                this.organicCertificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TokuhoCertification", DataType="normalizedString")]
        public string[] TokuhoCertification
        {
            get
            {
                return this.tokuhoCertificationField;
            }
            set
            {
                this.tokuhoCertificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemSpecialty", DataType="normalizedString")]
        public string[] ItemSpecialty
        {
            get
            {
                return this.itemSpecialtyField;
            }
            set
            {
                this.itemSpecialtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string CaffeineContent
        {
            get
            {
                return this.caffeineContentField;
            }
            set
            {
                this.caffeineContentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
            }
        }
        
        /// <remarks/>
        public bool IsPerishable
        {
            get
            {
                return this.isPerishableField;
            }
            set
            {
                this.isPerishableField = value;
                this.IsPerishableSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsPerishableSpecified
        {
            get
            {
                return this.isPerishableFieldSpecified;
            }
            set
            {
                this.isPerishableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string StorageInstructions
        {
            get
            {
                return this.storageInstructionsField;
            }
            set
            {
                this.storageInstructionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Directions
        {
            get
            {
                return this.directionsField;
            }
            set
            {
                this.directionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Occasion
        {
            get
            {
                return this.occasionField;
            }
            set
            {
                this.occasionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AwardsWon", DataType="normalizedString")]
        public string[] AwardsWon
        {
            get
            {
                return this.awardsWonField;
            }
            set
            {
                this.awardsWonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string AgeRangeDescription
        {
            get
            {
                return this.ageRangeDescriptionField;
            }
            set
            {
                this.ageRangeDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string ItemPackageQuantity
        {
            get
            {
                return this.itemPackageQuantityField;
            }
            set
            {
                this.itemPackageQuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string NumberOfItems
        {
            get
            {
                return this.numberOfItemsField;
            }
            set
            {
                this.numberOfItemsField = value;
            }
        }
        
        /// <remarks/>
        public LengthDimension DisplayLength
        {
            get
            {
                return this.displayLengthField;
            }
            set
            {
                this.displayLengthField = value;
            }
        }
        
        /// <remarks/>
        public WeightDimension DisplayWeight
        {
            get
            {
                return this.displayWeightField;
            }
            set
            {
                this.displayWeightField = value;
            }
        }
        
        /// <remarks/>
        public VolumeDimension DisplayVolume
        {
            get
            {
                return this.displayVolumeField;
            }
            set
            {
                this.displayVolumeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ContainerType
        {
            get
            {
                return this.containerTypeField;
            }
            set
            {
                this.containerTypeField = value;
            }
        }
        
        /// <remarks/>
        public HouseholdSuppliesUnitCount UnitCount
        {
            get
            {
                return this.unitCountField;
            }
            set
            {
                this.unitCountField = value;
            }
        }
        
        /// <remarks/>
        public NutritionalFactsGroup NutritionalFactsGroup
        {
            get
            {
                return this.nutritionalFactsGroupField;
            }
            set
            {
                this.nutritionalFactsGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ContainerMaterialType
        {
            get
            {
                return this.containerMaterialTypeField;
            }
            set
            {
                this.containerMaterialTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string ContainerVolume
        {
            get
            {
                return this.containerVolumeField;
            }
            set
            {
                this.containerVolumeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Cuisine
        {
            get
            {
                return this.cuisineField;
            }
            set
            {
                this.cuisineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string UseByRecommendation
        {
            get
            {
                return this.useByRecommendationField;
            }
            set
            {
                this.useByRecommendationField = value;
            }
        }
        
        /// <remarks/>
        public bool IsExpirationDatedProduct
        {
            get
            {
                return this.isExpirationDatedProductField;
            }
            set
            {
                this.isExpirationDatedProductField = value;
                this.IsExpirationDatedProductSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsExpirationDatedProductSpecified
        {
            get
            {
                return this.isExpirationDatedProductFieldSpecified;
            }
            set
            {
                this.isExpirationDatedProductFieldSpecified = value;
            }
        }
    }
}

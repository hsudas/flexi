namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Spirits
    {
        
        private SpiritsVariationData variationDataField;
        
        private string ingredientsField;
        
        private string directionsField;
        
        private string prefectureField;
        
        private string storageInstructionsField;
        
        private string[] itemSpecialtyField;
        
        private string[] kosherCertificationField;
        
        private string occasionField;
        
        private string occasionTypeField;
        
        private string itemFormField;
        
        private string caffeineContentField;
        
        private bool containsFoodOrBeverageField;
        
        private bool containsFoodOrBeverageFieldSpecified;
        
        private string medicineClassificationField;
        
        private string containerTypeField;
        
        private string ageRangeDescriptionField;
        
        private bool isPerishableField;
        
        private bool isPerishableFieldSpecified;
        
        private string bodyDescriptionField;
        
        private string tasteDescriptionField;
        
        private string[] awardsWonField;
        
        private string recommendedServingInstructionsField;
        
        private string cuisineField;
        
        private string useByRecommendationField;
        
        private NutritionalFactsGroup nutritionalFactsGroupField;
        
        private SpiritsUnitCount unitCountField;
        
        private string containerMaterialTypeField;
        
        private string vintageField;
        
        private SpiritsAlcoholContent alcoholContentField;
        
        private string varietalCompositionField;
        
        private string varietalDesignationField;
        
        private string alcoholTypeField;
        
        private DateIntegerDimension barrelAgingTimeField;
        
        private string warningsField;
        
        private string countryProducedInField;
        
        private string regionOfOriginField;
        
        private LengthDimension displayLengthField;
        
        private WeightDimension displayWeightField;
        
        private VolumeDimension displayVolumeField;
        
        private string itemTypeNameField;
        
        private WeightDimension saltPerServingField;
        
        private string primaryIngredientCountryOfOriginField;
        
        private string primaryIngredientLocationProducedField;
        
        private WeightDimension solidNetWeightField;
        
        private string manufacturerContactInformationField;
        
        private string liquidPackagingSealField;
        
        private string designationField;
        
        private string jamesHallidayRatingField;
        
        private string jamesSucklingRatingField;
        
        private string sweetnessDescriptionField;
        
        private string wineSpiritsRatingField;
        
        /// <remarks/>
        public SpiritsVariationData VariationData
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string OccasionType
        {
            get
            {
                return this.occasionTypeField;
            }
            set
            {
                this.occasionTypeField = value;
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
        public bool ContainsFoodOrBeverage
        {
            get
            {
                return this.containsFoodOrBeverageField;
            }
            set
            {
                this.containsFoodOrBeverageField = value;
                this.ContainsFoodOrBeverageSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContainsFoodOrBeverageSpecified
        {
            get
            {
                return this.containsFoodOrBeverageFieldSpecified;
            }
            set
            {
                this.containsFoodOrBeverageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MedicineClassification
        {
            get
            {
                return this.medicineClassificationField;
            }
            set
            {
                this.medicineClassificationField = value;
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
        public string BodyDescription
        {
            get
            {
                return this.bodyDescriptionField;
            }
            set
            {
                this.bodyDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string TasteDescription
        {
            get
            {
                return this.tasteDescriptionField;
            }
            set
            {
                this.tasteDescriptionField = value;
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
        public string RecommendedServingInstructions
        {
            get
            {
                return this.recommendedServingInstructionsField;
            }
            set
            {
                this.recommendedServingInstructionsField = value;
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
        public SpiritsUnitCount UnitCount
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
        public string Vintage
        {
            get
            {
                return this.vintageField;
            }
            set
            {
                this.vintageField = value;
            }
        }
        
        /// <remarks/>
        public SpiritsAlcoholContent AlcoholContent
        {
            get
            {
                return this.alcoholContentField;
            }
            set
            {
                this.alcoholContentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string VarietalComposition
        {
            get
            {
                return this.varietalCompositionField;
            }
            set
            {
                this.varietalCompositionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string VarietalDesignation
        {
            get
            {
                return this.varietalDesignationField;
            }
            set
            {
                this.varietalDesignationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string AlcoholType
        {
            get
            {
                return this.alcoholTypeField;
            }
            set
            {
                this.alcoholTypeField = value;
            }
        }
        
        /// <remarks/>
        public DateIntegerDimension BarrelAgingTime
        {
            get
            {
                return this.barrelAgingTimeField;
            }
            set
            {
                this.barrelAgingTimeField = value;
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
        public string ItemTypeName
        {
            get
            {
                return this.itemTypeNameField;
            }
            set
            {
                this.itemTypeNameField = value;
            }
        }
        
        /// <remarks/>
        public WeightDimension SaltPerServing
        {
            get
            {
                return this.saltPerServingField;
            }
            set
            {
                this.saltPerServingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string PrimaryIngredientCountryOfOrigin
        {
            get
            {
                return this.primaryIngredientCountryOfOriginField;
            }
            set
            {
                this.primaryIngredientCountryOfOriginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string PrimaryIngredientLocationProduced
        {
            get
            {
                return this.primaryIngredientLocationProducedField;
            }
            set
            {
                this.primaryIngredientLocationProducedField = value;
            }
        }
        
        /// <remarks/>
        public WeightDimension SolidNetWeight
        {
            get
            {
                return this.solidNetWeightField;
            }
            set
            {
                this.solidNetWeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ManufacturerContactInformation
        {
            get
            {
                return this.manufacturerContactInformationField;
            }
            set
            {
                this.manufacturerContactInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string LiquidPackagingSeal
        {
            get
            {
                return this.liquidPackagingSealField;
            }
            set
            {
                this.liquidPackagingSealField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Designation
        {
            get
            {
                return this.designationField;
            }
            set
            {
                this.designationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string JamesHallidayRating
        {
            get
            {
                return this.jamesHallidayRatingField;
            }
            set
            {
                this.jamesHallidayRatingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string JamesSucklingRating
        {
            get
            {
                return this.jamesSucklingRatingField;
            }
            set
            {
                this.jamesSucklingRatingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string SweetnessDescription
        {
            get
            {
                return this.sweetnessDescriptionField;
            }
            set
            {
                this.sweetnessDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string WineSpiritsRating
        {
            get
            {
                return this.wineSpiritsRatingField;
            }
            set
            {
                this.wineSpiritsRatingField = value;
            }
        }
    }
}

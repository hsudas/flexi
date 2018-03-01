namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class BeautyMisc
    {
        
        private BeautyMiscVariationData variationDataField;
        
        private BeautyMiscUnitCount unitCountField;
        
        private string countField;
        
        private string numberOfItemsField;
        
        private decimal batteryAverageLifeField;
        
        private bool batteryAverageLifeFieldSpecified;
        
        private BatteryCellTypeValues batteryCellCompositionField;
        
        private bool batteryCellCompositionFieldSpecified;
        
        private decimal batteryAverageLifeStandbyField;
        
        private bool batteryAverageLifeStandbyFieldSpecified;
        
        private decimal batteryChargeTimeField;
        
        private bool batteryChargeTimeFieldSpecified;
        
        private string batteryDescriptionField;
        
        private string batteryFormFactorField;
        
        private BatteryPowerIntegerDimension batteryPowerField;
        
        private LengthDimension displayLengthField;
        
        private WeightDimension displayWeightField;
        
        private VolumeDimension displayVolumeField;
        
        private string[] skinTypeField;
        
        private string[] skinToneField;
        
        private string[] hairTypeField;
        
        private string includedComponentsField;
        
        private string ingredientsField;
        
        private string manufacturerWarrantyTypeField;
        
        private string[] materialTypeField;
        
        private string mfrWarrantyDescriptionLaborField;
        
        private string mfrWarrantyDescriptionPartsField;
        
        private string modelNameField;
        
        private string indicationsField;
        
        private string directionsField;
        
        private string warningsField;
        
        private string itemFormField;
        
        private string itemPackageQuantityField;
        
        private string flavorField;
        
        private string coverageField;
        
        private string[] finishTypeField;
        
        private string[] itemSpecialtyField;
        
        private string patternNameField;
        
        private string powerSourceField;
        
        private bool isAdultProductField;
        
        private bool isAdultProductFieldSpecified;
        
        private BeautyMiscTargetGender targetGenderField;
        
        private bool targetGenderFieldSpecified;
        
        private string countryOfOriginField;
        
        private string sellerWarrantyDescriptionField;
        
        private string sizeMapField;
        
        private Battery batteryField;
        
        private string brandRegionOfOriginField;
        
        private string specialFeaturesField;
        
        private string targetAudienceBaseField;
        
        public BeautyMisc()
        {
            this.itemPackageQuantityField = "1";
        }
        
        /// <remarks/>
        public BeautyMiscVariationData VariationData
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
        public BeautyMiscUnitCount UnitCount
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
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
        public decimal BatteryAverageLife
        {
            get
            {
                return this.batteryAverageLifeField;
            }
            set
            {
                this.batteryAverageLifeField = value;
                this.BatteryAverageLifeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatteryAverageLifeSpecified
        {
            get
            {
                return this.batteryAverageLifeFieldSpecified;
            }
            set
            {
                this.batteryAverageLifeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public BatteryCellTypeValues BatteryCellComposition
        {
            get
            {
                return this.batteryCellCompositionField;
            }
            set
            {
                this.batteryCellCompositionField = value;
                this.BatteryCellCompositionSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatteryCellCompositionSpecified
        {
            get
            {
                return this.batteryCellCompositionFieldSpecified;
            }
            set
            {
                this.batteryCellCompositionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal BatteryAverageLifeStandby
        {
            get
            {
                return this.batteryAverageLifeStandbyField;
            }
            set
            {
                this.batteryAverageLifeStandbyField = value;
                this.BatteryAverageLifeStandbySpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatteryAverageLifeStandbySpecified
        {
            get
            {
                return this.batteryAverageLifeStandbyFieldSpecified;
            }
            set
            {
                this.batteryAverageLifeStandbyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal BatteryChargeTime
        {
            get
            {
                return this.batteryChargeTimeField;
            }
            set
            {
                this.batteryChargeTimeField = value;
                this.BatteryChargeTimeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatteryChargeTimeSpecified
        {
            get
            {
                return this.batteryChargeTimeFieldSpecified;
            }
            set
            {
                this.batteryChargeTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string BatteryDescription
        {
            get
            {
                return this.batteryDescriptionField;
            }
            set
            {
                this.batteryDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string BatteryFormFactor
        {
            get
            {
                return this.batteryFormFactorField;
            }
            set
            {
                this.batteryFormFactorField = value;
            }
        }
        
        /// <remarks/>
        public BatteryPowerIntegerDimension BatteryPower
        {
            get
            {
                return this.batteryPowerField;
            }
            set
            {
                this.batteryPowerField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SkinType", DataType="normalizedString")]
        public string[] SkinType
        {
            get
            {
                return this.skinTypeField;
            }
            set
            {
                this.skinTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SkinTone", DataType="normalizedString")]
        public string[] SkinTone
        {
            get
            {
                return this.skinToneField;
            }
            set
            {
                this.skinToneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HairType", DataType="normalizedString")]
        public string[] HairType
        {
            get
            {
                return this.hairTypeField;
            }
            set
            {
                this.hairTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string IncludedComponents
        {
            get
            {
                return this.includedComponentsField;
            }
            set
            {
                this.includedComponentsField = value;
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
        public string ManufacturerWarrantyType
        {
            get
            {
                return this.manufacturerWarrantyTypeField;
            }
            set
            {
                this.manufacturerWarrantyTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialType", DataType="normalizedString")]
        public string[] MaterialType
        {
            get
            {
                return this.materialTypeField;
            }
            set
            {
                this.materialTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MfrWarrantyDescriptionLabor
        {
            get
            {
                return this.mfrWarrantyDescriptionLaborField;
            }
            set
            {
                this.mfrWarrantyDescriptionLaborField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MfrWarrantyDescriptionParts
        {
            get
            {
                return this.mfrWarrantyDescriptionPartsField;
            }
            set
            {
                this.mfrWarrantyDescriptionPartsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ModelName
        {
            get
            {
                return this.modelNameField;
            }
            set
            {
                this.modelNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Indications
        {
            get
            {
                return this.indicationsField;
            }
            set
            {
                this.indicationsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
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
        public string Coverage
        {
            get
            {
                return this.coverageField;
            }
            set
            {
                this.coverageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FinishType", DataType="normalizedString")]
        public string[] FinishType
        {
            get
            {
                return this.finishTypeField;
            }
            set
            {
                this.finishTypeField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string PowerSource
        {
            get
            {
                return this.powerSourceField;
            }
            set
            {
                this.powerSourceField = value;
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
        public BeautyMiscTargetGender TargetGender
        {
            get
            {
                return this.targetGenderField;
            }
            set
            {
                this.targetGenderField = value;
                this.TargetGenderSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TargetGenderSpecified
        {
            get
            {
                return this.targetGenderFieldSpecified;
            }
            set
            {
                this.targetGenderFieldSpecified = value;
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
        public string SellerWarrantyDescription
        {
            get
            {
                return this.sellerWarrantyDescriptionField;
            }
            set
            {
                this.sellerWarrantyDescriptionField = value;
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
        public string BrandRegionOfOrigin
        {
            get
            {
                return this.brandRegionOfOriginField;
            }
            set
            {
                this.brandRegionOfOriginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string SpecialFeatures
        {
            get
            {
                return this.specialFeaturesField;
            }
            set
            {
                this.specialFeaturesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string TargetAudienceBase
        {
            get
            {
                return this.targetAudienceBaseField;
            }
            set
            {
                this.targetAudienceBaseField = value;
            }
        }
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ToysAndGames
    {
        
        private string awardsWonField;
        
        private TimeDimension batteryAverageLifeField;
        
        private TimeDimension batteryAverageLifeStandbyField;
        
        private TimeDimension batteryChargeTimeField;
        
        private string colorField;
        
        private string colorMapField;
        
        private string directionsField;
        
        private EnergyConsumptionDimension lithiumBatteryEnergyContentField;
        
        private ToysAndGamesLithiumBatteryPackaging lithiumBatteryPackagingField;
        
        private bool lithiumBatteryPackagingFieldSpecified;
        
        private VoltageDecimalDimension lithiumBatteryVoltageField;
        
        private WeightDimension lithiumBatteryWeightField;
        
        private string numberOfLithiumIonCellsField;
        
        private string numberOfLithiumMetalCellsField;
        
        private string numberOfFrequencyChannelsField;
        
        private string numberOfControlChannelsField;
        
        private string frequencyBandsSupportedField;
        
        private LanguageStringType languageField;
        
        private bool languageFieldSpecified;
        
        private bool includesRemoteField;
        
        private bool includesRemoteFieldSpecified;
        
        private string ingredientsField;
        
        private string powerSourceTypeField;
        
        private string recommendedUseField;
        
        private string remoteControlTechnologyField;
        
        private string railGaugeField;
        
        private string regionOfOriginField;
        
        private string countryOfOriginField;
        
        private string educationalObjectiveField;
        
        private string engineTypeField;
        
        private bool isElectricField;
        
        private bool isElectricFieldSpecified;
        
        private string materialTypeField;
        
        private string materialCompositionField;
        
        private string mfrWarrantyDescriptionLaborField;
        
        private string mfrWarrantyDescriptionPartsField;
        
        private string mfrWarrantyDescriptionTypeField;
        
        private string[] careInstructionsField;
        
        private string[] specialFeaturesField;
        
        private LengthDimension handleHeightField;
        
        private LengthDimension seatLengthField;
        
        private LengthDimension seatWidthField;
        
        private string tireMaterialField;
        
        private LengthDimension tireDiameterField;
        
        private string sellerWarrantyDescriptionField;
        
        private ToysAndGamesTargetGender targetGenderField;
        
        private bool targetGenderFieldSpecified;
        
        private LengthDimension displayLengthField;
        
        private VolumeDimension displayVolumeField;
        
        private WeightDimension displayWeightField;
        
        private string animalTypeField;
        
        private string publisherField;
        
        private string skillLevelField;
        
        private string[] styleKeywordsField;
        
        private string productThemeField;
        
        private ToyAwardType[] toyAwardNameField;
        
        private string publisherContributorField;
        
        private string warrantyDescriptionField;
        
        private string unknownSubjectField;
        
        private string scaleNameField;
        
        private string batteryTypeLithiumIonField;
        
        private string batteryTypeLithiumMetalField;
        
        private string specificationMetField;
        
        private DistributionDesignationValues distributionDesignationField;
        
        private bool distributionDesignationFieldSpecified;
        
        private string countryStringField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string AwardsWon
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
        public TimeDimension BatteryAverageLife
        {
            get
            {
                return this.batteryAverageLifeField;
            }
            set
            {
                this.batteryAverageLifeField = value;
            }
        }
        
        /// <remarks/>
        public TimeDimension BatteryAverageLifeStandby
        {
            get
            {
                return this.batteryAverageLifeStandbyField;
            }
            set
            {
                this.batteryAverageLifeStandbyField = value;
            }
        }
        
        /// <remarks/>
        public TimeDimension BatteryChargeTime
        {
            get
            {
                return this.batteryChargeTimeField;
            }
            set
            {
                this.batteryChargeTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ColorMap
        {
            get
            {
                return this.colorMapField;
            }
            set
            {
                this.colorMapField = value;
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
        public EnergyConsumptionDimension LithiumBatteryEnergyContent
        {
            get
            {
                return this.lithiumBatteryEnergyContentField;
            }
            set
            {
                this.lithiumBatteryEnergyContentField = value;
            }
        }
        
        /// <remarks/>
        public ToysAndGamesLithiumBatteryPackaging LithiumBatteryPackaging
        {
            get
            {
                return this.lithiumBatteryPackagingField;
            }
            set
            {
                this.lithiumBatteryPackagingField = value;
                this.LithiumBatteryPackagingSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LithiumBatteryPackagingSpecified
        {
            get
            {
                return this.lithiumBatteryPackagingFieldSpecified;
            }
            set
            {
                this.lithiumBatteryPackagingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public VoltageDecimalDimension LithiumBatteryVoltage
        {
            get
            {
                return this.lithiumBatteryVoltageField;
            }
            set
            {
                this.lithiumBatteryVoltageField = value;
            }
        }
        
        /// <remarks/>
        public WeightDimension LithiumBatteryWeight
        {
            get
            {
                return this.lithiumBatteryWeightField;
            }
            set
            {
                this.lithiumBatteryWeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string NumberOfLithiumIonCells
        {
            get
            {
                return this.numberOfLithiumIonCellsField;
            }
            set
            {
                this.numberOfLithiumIonCellsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string NumberOfLithiumMetalCells
        {
            get
            {
                return this.numberOfLithiumMetalCellsField;
            }
            set
            {
                this.numberOfLithiumMetalCellsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string NumberOfFrequencyChannels
        {
            get
            {
                return this.numberOfFrequencyChannelsField;
            }
            set
            {
                this.numberOfFrequencyChannelsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string NumberOfControlChannels
        {
            get
            {
                return this.numberOfControlChannelsField;
            }
            set
            {
                this.numberOfControlChannelsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string FrequencyBandsSupported
        {
            get
            {
                return this.frequencyBandsSupportedField;
            }
            set
            {
                this.frequencyBandsSupportedField = value;
            }
        }
        
        /// <remarks/>
        public LanguageStringType Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
                this.LanguageSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LanguageSpecified
        {
            get
            {
                return this.languageFieldSpecified;
            }
            set
            {
                this.languageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool IncludesRemote
        {
            get
            {
                return this.includesRemoteField;
            }
            set
            {
                this.includesRemoteField = value;
                this.IncludesRemoteSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludesRemoteSpecified
        {
            get
            {
                return this.includesRemoteFieldSpecified;
            }
            set
            {
                this.includesRemoteFieldSpecified = value;
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
        public string PowerSourceType
        {
            get
            {
                return this.powerSourceTypeField;
            }
            set
            {
                this.powerSourceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string RecommendedUse
        {
            get
            {
                return this.recommendedUseField;
            }
            set
            {
                this.recommendedUseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string RemoteControlTechnology
        {
            get
            {
                return this.remoteControlTechnologyField;
            }
            set
            {
                this.remoteControlTechnologyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string RailGauge
        {
            get
            {
                return this.railGaugeField;
            }
            set
            {
                this.railGaugeField = value;
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
        public string EducationalObjective
        {
            get
            {
                return this.educationalObjectiveField;
            }
            set
            {
                this.educationalObjectiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string EngineType
        {
            get
            {
                return this.engineTypeField;
            }
            set
            {
                this.engineTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool IsElectric
        {
            get
            {
                return this.isElectricField;
            }
            set
            {
                this.isElectricField = value;
                this.IsElectricSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsElectricSpecified
        {
            get
            {
                return this.isElectricFieldSpecified;
            }
            set
            {
                this.isElectricFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MaterialType
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
        public string MaterialComposition
        {
            get
            {
                return this.materialCompositionField;
            }
            set
            {
                this.materialCompositionField = value;
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
        public string MfrWarrantyDescriptionType
        {
            get
            {
                return this.mfrWarrantyDescriptionTypeField;
            }
            set
            {
                this.mfrWarrantyDescriptionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CareInstructions", DataType="normalizedString")]
        public string[] CareInstructions
        {
            get
            {
                return this.careInstructionsField;
            }
            set
            {
                this.careInstructionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialFeatures", DataType="normalizedString")]
        public string[] SpecialFeatures
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
        public LengthDimension HandleHeight
        {
            get
            {
                return this.handleHeightField;
            }
            set
            {
                this.handleHeightField = value;
            }
        }
        
        /// <remarks/>
        public LengthDimension SeatLength
        {
            get
            {
                return this.seatLengthField;
            }
            set
            {
                this.seatLengthField = value;
            }
        }
        
        /// <remarks/>
        public LengthDimension SeatWidth
        {
            get
            {
                return this.seatWidthField;
            }
            set
            {
                this.seatWidthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string TireMaterial
        {
            get
            {
                return this.tireMaterialField;
            }
            set
            {
                this.tireMaterialField = value;
            }
        }
        
        /// <remarks/>
        public LengthDimension TireDiameter
        {
            get
            {
                return this.tireDiameterField;
            }
            set
            {
                this.tireDiameterField = value;
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
        public ToysAndGamesTargetGender TargetGender
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string AnimalType
        {
            get
            {
                return this.animalTypeField;
            }
            set
            {
                this.animalTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Publisher
        {
            get
            {
                return this.publisherField;
            }
            set
            {
                this.publisherField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string SkillLevel
        {
            get
            {
                return this.skillLevelField;
            }
            set
            {
                this.skillLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StyleKeywords", DataType="normalizedString")]
        public string[] StyleKeywords
        {
            get
            {
                return this.styleKeywordsField;
            }
            set
            {
                this.styleKeywordsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ProductTheme
        {
            get
            {
                return this.productThemeField;
            }
            set
            {
                this.productThemeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ToyAwardName")]
        public ToyAwardType[] ToyAwardName
        {
            get
            {
                return this.toyAwardNameField;
            }
            set
            {
                this.toyAwardNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string PublisherContributor
        {
            get
            {
                return this.publisherContributorField;
            }
            set
            {
                this.publisherContributorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string WarrantyDescription
        {
            get
            {
                return this.warrantyDescriptionField;
            }
            set
            {
                this.warrantyDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string UnknownSubject
        {
            get
            {
                return this.unknownSubjectField;
            }
            set
            {
                this.unknownSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ScaleName
        {
            get
            {
                return this.scaleNameField;
            }
            set
            {
                this.scaleNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string BatteryTypeLithiumIon
        {
            get
            {
                return this.batteryTypeLithiumIonField;
            }
            set
            {
                this.batteryTypeLithiumIonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string BatteryTypeLithiumMetal
        {
            get
            {
                return this.batteryTypeLithiumMetalField;
            }
            set
            {
                this.batteryTypeLithiumMetalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string SpecificationMet
        {
            get
            {
                return this.specificationMetField;
            }
            set
            {
                this.specificationMetField = value;
            }
        }
        
        /// <remarks/>
        public DistributionDesignationValues DistributionDesignation
        {
            get
            {
                return this.distributionDesignationField;
            }
            set
            {
                this.distributionDesignationField = value;
                this.DistributionDesignationSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DistributionDesignationSpecified
        {
            get
            {
                return this.distributionDesignationFieldSpecified;
            }
            set
            {
                this.distributionDesignationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string CountryString
        {
            get
            {
                return this.countryStringField;
            }
            set
            {
                this.countryStringField = value;
            }
        }
    }
}

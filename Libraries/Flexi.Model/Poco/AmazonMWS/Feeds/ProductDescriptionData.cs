namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ProductDescriptionData
    {
        
        private string titleField;
        
        private string brandField;
        
        private string designerField;
        
        private string descriptionField;
        
        private string[] bulletPointField;
        
        private Dimensions itemDimensionsField;
        
        private Dimensions packageDimensionsField;
        
        private PositiveWeightDimension packageWeightField;
        
        private PositiveWeightDimension shippingWeightField;
        
        private string merchantCatalogNumberField;
        
        private CurrencyAmount mSRPField;
        
        private CurrencyAmount mSRPWithTaxField;
        
        private string maxOrderQuantityField;
        
        private bool serialNumberRequiredField;
        
        private bool serialNumberRequiredFieldSpecified;
        
        private bool prop65Field;
        
        private bool prop65FieldSpecified;
        
        private ProductDescriptionDataCPSIAWarning[] cPSIAWarningField;
        
        private string cPSIAWarningDescriptionField;
        
        private string legalDisclaimerField;
        
        private string manufacturerField;
        
        private string mfrPartNumberField;
        
        private string[] searchTermsField;
        
        private string[] platinumKeywordsField;
        
        private bool memorabiliaField;
        
        private bool memorabiliaFieldSpecified;
        
        private bool autographedField;
        
        private bool autographedFieldSpecified;
        
        private string[] usedForField;
        
        private string itemTypeField;
        
        private string[] otherItemAttributesField;
        
        private string[] targetAudienceField;
        
        private string[] subjectContentField;
        
        private bool isGiftWrapAvailableField;
        
        private bool isGiftWrapAvailableFieldSpecified;
        
        private bool isGiftMessageAvailableField;
        
        private bool isGiftMessageAvailableFieldSpecified;
        
        private string[] promotionKeywordsField;
        
        private bool isDiscontinuedByManufacturerField;
        
        private bool isDiscontinuedByManufacturerFieldSpecified;
        
        private string deliveryScheduleGroupIDField;
        
        private DeliveryChannel[] deliveryChannelField;
        
        private string externalProductInformationField;
        
        private string maxAggregateShipQuantityField;
        
        private string[] recommendedBrowseNodeField;
        
        private string merchantShippingGroupNameField;
        
        private string fEDAS_IDField;
        
        private ProductDescriptionDataTSDAgeWarning tSDAgeWarningField;
        
        private bool tSDAgeWarningFieldSpecified;
        
        private ProductDescriptionDataTSDWarning[] tSDWarningField;
        
        private ProductDescriptionDataTSDLanguage[] tSDLanguageField;
        
        private ProductDescriptionDataOptionalPaymentTypeExclusion optionalPaymentTypeExclusionField;
        
        private bool optionalPaymentTypeExclusionFieldSpecified;
        
        private DistributionDesignationValues distributionDesignationField;
        
        private bool distributionDesignationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Designer
        {
            get
            {
                return this.designerField;
            }
            set
            {
                this.designerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BulletPoint", DataType="normalizedString")]
        public string[] BulletPoint
        {
            get
            {
                return this.bulletPointField;
            }
            set
            {
                this.bulletPointField = value;
            }
        }
        
        /// <remarks/>
        public Dimensions ItemDimensions
        {
            get
            {
                return this.itemDimensionsField;
            }
            set
            {
                this.itemDimensionsField = value;
            }
        }
        
        /// <remarks/>
        public Dimensions PackageDimensions
        {
            get
            {
                return this.packageDimensionsField;
            }
            set
            {
                this.packageDimensionsField = value;
            }
        }
        
        /// <remarks/>
        public PositiveWeightDimension PackageWeight
        {
            get
            {
                return this.packageWeightField;
            }
            set
            {
                this.packageWeightField = value;
            }
        }
        
        /// <remarks/>
        public PositiveWeightDimension ShippingWeight
        {
            get
            {
                return this.shippingWeightField;
            }
            set
            {
                this.shippingWeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantCatalogNumber
        {
            get
            {
                return this.merchantCatalogNumberField;
            }
            set
            {
                this.merchantCatalogNumberField = value;
            }
        }
        
        /// <remarks/>
        public CurrencyAmount MSRP
        {
            get
            {
                return this.mSRPField;
            }
            set
            {
                this.mSRPField = value;
            }
        }
        
        /// <remarks/>
        public CurrencyAmount MSRPWithTax
        {
            get
            {
                return this.mSRPWithTaxField;
            }
            set
            {
                this.mSRPWithTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string MaxOrderQuantity
        {
            get
            {
                return this.maxOrderQuantityField;
            }
            set
            {
                this.maxOrderQuantityField = value;
            }
        }
        
        /// <remarks/>
        public bool SerialNumberRequired
        {
            get
            {
                return this.serialNumberRequiredField;
            }
            set
            {
                this.serialNumberRequiredField = value;
                this.SerialNumberRequiredSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SerialNumberRequiredSpecified
        {
            get
            {
                return this.serialNumberRequiredFieldSpecified;
            }
            set
            {
                this.serialNumberRequiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool Prop65
        {
            get
            {
                return this.prop65Field;
            }
            set
            {
                this.prop65Field = value;
                this.Prop65Specified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Prop65Specified
        {
            get
            {
                return this.prop65FieldSpecified;
            }
            set
            {
                this.prop65FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CPSIAWarning")]
        public ProductDescriptionDataCPSIAWarning[] CPSIAWarning
        {
            get
            {
                return this.cPSIAWarningField;
            }
            set
            {
                this.cPSIAWarningField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string CPSIAWarningDescription
        {
            get
            {
                return this.cPSIAWarningDescriptionField;
            }
            set
            {
                this.cPSIAWarningDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string LegalDisclaimer
        {
            get
            {
                return this.legalDisclaimerField;
            }
            set
            {
                this.legalDisclaimerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MfrPartNumber
        {
            get
            {
                return this.mfrPartNumberField;
            }
            set
            {
                this.mfrPartNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SearchTerms", DataType="normalizedString")]
        public string[] SearchTerms
        {
            get
            {
                return this.searchTermsField;
            }
            set
            {
                this.searchTermsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlatinumKeywords", DataType="normalizedString")]
        public string[] PlatinumKeywords
        {
            get
            {
                return this.platinumKeywordsField;
            }
            set
            {
                this.platinumKeywordsField = value;
            }
        }
        
        /// <remarks/>
        public bool Memorabilia
        {
            get
            {
                return this.memorabiliaField;
            }
            set
            {
                this.memorabiliaField = value;
                this.MemorabiliaSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MemorabiliaSpecified
        {
            get
            {
                return this.memorabiliaFieldSpecified;
            }
            set
            {
                this.memorabiliaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool Autographed
        {
            get
            {
                return this.autographedField;
            }
            set
            {
                this.autographedField = value;
                this.AutographedSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutographedSpecified
        {
            get
            {
                return this.autographedFieldSpecified;
            }
            set
            {
                this.autographedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedFor", DataType="normalizedString")]
        public string[] UsedFor
        {
            get
            {
                return this.usedForField;
            }
            set
            {
                this.usedForField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ItemType
        {
            get
            {
                return this.itemTypeField;
            }
            set
            {
                this.itemTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherItemAttributes", DataType="normalizedString")]
        public string[] OtherItemAttributes
        {
            get
            {
                return this.otherItemAttributesField;
            }
            set
            {
                this.otherItemAttributesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TargetAudience", DataType="normalizedString")]
        public string[] TargetAudience
        {
            get
            {
                return this.targetAudienceField;
            }
            set
            {
                this.targetAudienceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubjectContent", DataType="normalizedString")]
        public string[] SubjectContent
        {
            get
            {
                return this.subjectContentField;
            }
            set
            {
                this.subjectContentField = value;
            }
        }
        
        /// <remarks/>
        public bool IsGiftWrapAvailable
        {
            get
            {
                return this.isGiftWrapAvailableField;
            }
            set
            {
                this.isGiftWrapAvailableField = value;
                this.IsGiftWrapAvailableSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsGiftWrapAvailableSpecified
        {
            get
            {
                return this.isGiftWrapAvailableFieldSpecified;
            }
            set
            {
                this.isGiftWrapAvailableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool IsGiftMessageAvailable
        {
            get
            {
                return this.isGiftMessageAvailableField;
            }
            set
            {
                this.isGiftMessageAvailableField = value;
                this.IsGiftMessageAvailableSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsGiftMessageAvailableSpecified
        {
            get
            {
                return this.isGiftMessageAvailableFieldSpecified;
            }
            set
            {
                this.isGiftMessageAvailableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionKeywords", DataType="normalizedString")]
        public string[] PromotionKeywords
        {
            get
            {
                return this.promotionKeywordsField;
            }
            set
            {
                this.promotionKeywordsField = value;
            }
        }
        
        /// <remarks/>
        public bool IsDiscontinuedByManufacturer
        {
            get
            {
                return this.isDiscontinuedByManufacturerField;
            }
            set
            {
                this.isDiscontinuedByManufacturerField = value;
                this.IsDiscontinuedByManufacturerSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDiscontinuedByManufacturerSpecified
        {
            get
            {
                return this.isDiscontinuedByManufacturerFieldSpecified;
            }
            set
            {
                this.isDiscontinuedByManufacturerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string DeliveryScheduleGroupID
        {
            get
            {
                return this.deliveryScheduleGroupIDField;
            }
            set
            {
                this.deliveryScheduleGroupIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryChannel")]
        public DeliveryChannel[] DeliveryChannel
        {
            get
            {
                return this.deliveryChannelField;
            }
            set
            {
                this.deliveryChannelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ExternalProductInformation
        {
            get
            {
                return this.externalProductInformationField;
            }
            set
            {
                this.externalProductInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string MaxAggregateShipQuantity
        {
            get
            {
                return this.maxAggregateShipQuantityField;
            }
            set
            {
                this.maxAggregateShipQuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecommendedBrowseNode", DataType="positiveInteger")]
        public string[] RecommendedBrowseNode
        {
            get
            {
                return this.recommendedBrowseNodeField;
            }
            set
            {
                this.recommendedBrowseNodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantShippingGroupName
        {
            get
            {
                return this.merchantShippingGroupNameField;
            }
            set
            {
                this.merchantShippingGroupNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string FEDAS_ID
        {
            get
            {
                return this.fEDAS_IDField;
            }
            set
            {
                this.fEDAS_IDField = value;
            }
        }
        
        /// <remarks/>
        public ProductDescriptionDataTSDAgeWarning TSDAgeWarning
        {
            get
            {
                return this.tSDAgeWarningField;
            }
            set
            {
                this.tSDAgeWarningField = value;
                this.TSDAgeWarningSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TSDAgeWarningSpecified
        {
            get
            {
                return this.tSDAgeWarningFieldSpecified;
            }
            set
            {
                this.tSDAgeWarningFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TSDWarning")]
        public ProductDescriptionDataTSDWarning[] TSDWarning
        {
            get
            {
                return this.tSDWarningField;
            }
            set
            {
                this.tSDWarningField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TSDLanguage")]
        public ProductDescriptionDataTSDLanguage[] TSDLanguage
        {
            get
            {
                return this.tSDLanguageField;
            }
            set
            {
                this.tSDLanguageField = value;
            }
        }
        
        /// <remarks/>
        public ProductDescriptionDataOptionalPaymentTypeExclusion OptionalPaymentTypeExclusion
        {
            get
            {
                return this.optionalPaymentTypeExclusionField;
            }
            set
            {
                this.optionalPaymentTypeExclusionField = value;
                this.OptionalPaymentTypeExclusionSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OptionalPaymentTypeExclusionSpecified
        {
            get
            {
                return this.optionalPaymentTypeExclusionFieldSpecified;
            }
            set
            {
                this.optionalPaymentTypeExclusionFieldSpecified = value;
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
    }
}

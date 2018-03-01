// ------------------------------------------------------------------------------
// By Eren Cetin - 05-10-2016
// ------------------------------------------------------------------------------
namespace Flexi.Model.Poco.Walmart.Api
{
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.Serialization;

    public partial class MPItemFeedHeader
    {

        private MPItemFeedHeaderVersion versionField;

        private string requestIdField;

        private string requestBatchIdField;

        private System.DateTime feedDateField;

        private bool feedDateFieldSpecified;

        public MPItemFeedHeader()
        {

            this.versionField = MPItemFeedHeaderVersion.Item21;
        }

        public MPItemFeedHeaderVersion version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        public string requestId
        {
            get
            {
                return this.requestIdField;
            }
            set
            {
                this.requestIdField = value;
            }
        }

        public string requestBatchId
        {
            get
            {
                return this.requestBatchIdField;
            }
            set
            {
                this.requestBatchIdField = value;
            }
        }

        public System.DateTime feedDate
        {
            get
            {
                return this.feedDateField;
            }
            set
            {
                this.feedDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool feedDateSpecified
        {
            get
            {
                return this.feedDateFieldSpecified;
            }
            set
            {
                this.feedDateFieldSpecified = value;
            }
        }
    }

    public enum MPItemFeedHeaderVersion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2.1")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.4.1")]
        Item141,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.4")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.3.2")]
        Item132,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.3.1")]
        Item131,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.3")]
        Item13,
    }

    public partial class MPItem
    {

        private Mart martField;

        private bool martFieldSpecified;

        private string skuField;

        private string wpidField;

        private MPProduct productField;

        private System.DateTime launchDateField;

        private bool launchDateFieldSpecified;

        private System.DateTime discontinueDateField;

        private bool discontinueDateFieldSpecified;

        private Money priceField;

        private Money minAdvertisedPriceField;

        private bool isMustShipAloneField;

        private WeightMeasure shippingWeightField;

        private List<MPItemShippingOverride> shippingOverridesField;

        public MPItem()
        {

        }

        public Mart mart
        {
            get
            {
                return this.martField;
            }
            set
            {
                this.martField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool martSpecified
        {
            get
            {
                return this.martFieldSpecified;
            }
            set
            {
                this.martFieldSpecified = value;
            }
        }

        public string sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        public string wpid
        {
            get
            {
                return this.wpidField;
            }
            set
            {
                this.wpidField = value;
            }
        }

        public MPProduct Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        public System.DateTime launchDate
        {
            get
            {
                return this.launchDateField;
            }
            set
            {
                this.launchDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool launchDateSpecified
        {
            get
            {
                return this.launchDateFieldSpecified;
            }
            set
            {
                this.launchDateFieldSpecified = value;
            }
        }

        public System.DateTime discontinueDate
        {
            get
            {
                return this.discontinueDateField;
            }
            set
            {
                this.discontinueDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discontinueDateSpecified
        {
            get
            {
                return this.discontinueDateFieldSpecified;
            }
            set
            {
                this.discontinueDateFieldSpecified = value;
            }
        }

        public Money price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        public Money minAdvertisedPrice
        {
            get
            {
                return this.minAdvertisedPriceField;
            }
            set
            {
                this.minAdvertisedPriceField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isMustShipAlone
        {
            get
            {
                return this.isMustShipAloneField;
            }
            set
            {
                this.isMustShipAloneField = value;
            }
        }

        public WeightMeasure shippingWeight
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

        [System.Xml.Serialization.XmlArrayItemAttribute("shippingOverride", IsNullable = false)]
        public List<MPItemShippingOverride> shippingOverrides
        {
            get
            {
                return this.shippingOverridesField;
            }
            set
            {
                this.shippingOverridesField = value;
            }
        }
    }

    public enum Mart
    {

        /// <remarks/>
        WALMART_US,

        /// <remarks/>
        ASDA_GM,
    }

    public partial class MPProduct
    {

        private string productNameField;

        // private System.Xml.XmlCDataSection longDescriptionField;

        //private string shelfDescriptionField;

        private string shortDescriptionField;

        private MainImage mainImageField;

        private List<additionalAsset> additionalAssetsField;

        private List<productIdentifier> productIdentifiersField;

        private CurrencyUnit msrpField;

        private string unitsPerConsumerUnitField;

        private List<string> featuresField;

        private List<certificationsAndClaim> certificationsAndClaimsField;

        private LengthUnit assembledProductLengthField;

        private LengthUnit assembledProductWidthField;

        private LengthUnit assembledProductHeightField;

        private WeightUnit assembledProductWeightField;

        private List<string> sportsLeagueField;

        private string productTaxCodeField;

        private List<string> sportsTeamField;

        private List<string> athleteField;

        private MPProductCountryOfOriginAssembly countryOfOriginAssemblyField;

        private bool countryOfOriginAssemblyFieldSpecified;

        private MPProductCountryOfOriginComponents countryOfOriginComponentsField;

        private bool countryOfOriginComponentsFieldSpecified;

        private bool autographedField;

        private bool autographedFieldSpecified;

        private string autographedByField;

        private bool hasBatteriesField;

        private bool hasBatteriesFieldSpecified;

        private List<batteryTypeAndQuantityValue> batteryTypeAndQuantityField;

        private PPUUnit pricePerUnitQuantityField;

        private bool hasExpirationField;

        private bool hasExpirationFieldSpecified;

        private bool hasWarningsField;

        private bool hasWarningsFieldSpecified;

        private string warningTextField;

        private bool hasWarrantyField;

        private bool hasWarrantyFieldSpecified;

        private string warrantyURLField;

        private string warrantyTextField;

        private bool isProp65WarningRequiredField;

        private bool isProp65WarningRequiredFieldSpecified;

        private List<string> smallPartsWarningsField;

        private bool isControlledSubstanceField;

        private bool isControlledSubstanceFieldSpecified;

        private string warrantyLengthField;

        private string prop65WarningTextField;

        private List<additionalProductAttribute> additionalProductAttributesField;

        private object itemField;

        public MPProduct()
        {


        }

        public string productName
        {
            get
            {
                return this.productNameField;
            }
            set
            {
                this.productNameField = value;
            }
        }

        [XmlElement("longDescription")]
        public System.Xml.XmlCDataSection longDescriptionCDATA
        {
            get
            {
                return new System.Xml.XmlDocument().CreateCDataSection(LongDescription);

            }
            set
            {
                this.LongDescription = value.Value;
            }
        }
        [XmlIgnore]
        public string LongDescription { get; set; }
        [XmlIgnore]
        public string ShelfDescription { get; set; }
        [XmlElement("shelfDescription")]
        public System.Xml.XmlCDataSection shelfDescriptionCDATA
        {
            get
            {
                return new System.Xml.XmlDocument().CreateCDataSection(ShelfDescription);
            }
            set
            {
                this.ShelfDescription = value.Value;
            }
        }

        public string shortDescription
        {
            get
            {
                return this.shortDescriptionField;
            }
            set
            {
                this.shortDescriptionField = value;
            }
        }

        public MainImage mainImage
        {
            get
            {
                return this.mainImageField;
            }
            set
            {
                this.mainImageField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<additionalAsset> additionalAssets
        {
            get
            {
                return this.additionalAssetsField;
            }
            set
            {
                this.additionalAssetsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<productIdentifier> productIdentifiers
        {
            get
            {
                return this.productIdentifiersField;
            }
            set
            {
                this.productIdentifiersField = value;
            }
        }

        public CurrencyUnit msrp
        {
            get
            {
                return this.msrpField;
            }
            set
            {
                this.msrpField = value;
            }
        }

        public string unitsPerConsumerUnit
        {
            get
            {
                return this.unitsPerConsumerUnitField;
            }
            set
            {
                this.unitsPerConsumerUnitField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("feature", IsNullable = false)]
        public List<string> features
        {
            get
            {
                return this.featuresField;
            }
            set
            {
                this.featuresField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<certificationsAndClaim> certificationsAndClaims
        {
            get
            {
                return this.certificationsAndClaimsField;
            }
            set
            {
                this.certificationsAndClaimsField = value;
            }
        }

        public LengthUnit assembledProductLength
        {
            get
            {
                return this.assembledProductLengthField;
            }
            set
            {
                this.assembledProductLengthField = value;
            }
        }

        public LengthUnit assembledProductWidth
        {
            get
            {
                return this.assembledProductWidthField;
            }
            set
            {
                this.assembledProductWidthField = value;
            }
        }

        public LengthUnit assembledProductHeight
        {
            get
            {
                return this.assembledProductHeightField;
            }
            set
            {
                this.assembledProductHeightField = value;
            }
        }

        public WeightUnit assembledProductWeight
        {
            get
            {
                return this.assembledProductWeightField;
            }
            set
            {
                this.assembledProductWeightField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("sportsLeagueValue", IsNullable = false)]
        public List<string> sportsLeague
        {
            get
            {
                return this.sportsLeagueField;
            }
            set
            {
                this.sportsLeagueField = value;
            }
        }

        public string productTaxCode
        {
            get
            {
                return this.productTaxCodeField;
            }
            set
            {
                this.productTaxCodeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("sportsTeamValue", IsNullable = false)]
        public List<string> sportsTeam
        {
            get
            {
                return this.sportsTeamField;
            }
            set
            {
                this.sportsTeamField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("athleteValue", IsNullable = false)]
        public List<string> athlete
        {
            get
            {
                return this.athleteField;
            }
            set
            {
                this.athleteField = value;
            }
        }

        public MPProductCountryOfOriginAssembly countryOfOriginAssembly
        {
            get
            {
                return this.countryOfOriginAssemblyField;
            }
            set
            {
                this.countryOfOriginAssemblyField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countryOfOriginAssemblySpecified
        {
            get
            {
                return this.countryOfOriginAssemblyFieldSpecified;
            }
            set
            {
                this.countryOfOriginAssemblyFieldSpecified = value;
            }
        }

        public MPProductCountryOfOriginComponents countryOfOriginComponents
        {
            get
            {
                return this.countryOfOriginComponentsField;
            }
            set
            {
                this.countryOfOriginComponentsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countryOfOriginComponentsSpecified
        {
            get
            {
                return this.countryOfOriginComponentsFieldSpecified;
            }
            set
            {
                this.countryOfOriginComponentsFieldSpecified = value;
            }
        }

        public bool autographed
        {
            get
            {
                return this.autographedField;
            }
            set
            {
                this.autographedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autographedSpecified
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

        public string autographedBy
        {
            get
            {
                return this.autographedByField;
            }
            set
            {
                this.autographedByField = value;
            }
        }

        public bool hasBatteries
        {
            get
            {
                return this.hasBatteriesField;
            }
            set
            {
                this.hasBatteriesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasBatteriesSpecified
        {
            get
            {
                return this.hasBatteriesFieldSpecified;
            }
            set
            {
                this.hasBatteriesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<batteryTypeAndQuantityValue> batteryTypeAndQuantity
        {
            get
            {
                return this.batteryTypeAndQuantityField;
            }
            set
            {
                this.batteryTypeAndQuantityField = value;
            }
        }

        public PPUUnit pricePerUnitQuantity
        {
            get
            {
                return this.pricePerUnitQuantityField;
            }
            set
            {
                this.pricePerUnitQuantityField = value;
            }
        }

        public bool hasExpiration
        {
            get
            {
                return this.hasExpirationField;
            }
            set
            {
                this.hasExpirationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasExpirationSpecified
        {
            get
            {
                return this.hasExpirationFieldSpecified;
            }
            set
            {
                this.hasExpirationFieldSpecified = value;
            }
        }

        public bool hasWarnings
        {
            get
            {
                return this.hasWarningsField;
            }
            set
            {
                this.hasWarningsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWarningsSpecified
        {
            get
            {
                return this.hasWarningsFieldSpecified;
            }
            set
            {
                this.hasWarningsFieldSpecified = value;
            }
        }

        public string warningText
        {
            get
            {
                return this.warningTextField;
            }
            set
            {
                this.warningTextField = value;
            }
        }

        public bool hasWarranty
        {
            get
            {
                return this.hasWarrantyField;
            }
            set
            {
                this.hasWarrantyField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWarrantySpecified
        {
            get
            {
                return this.hasWarrantyFieldSpecified;
            }
            set
            {
                this.hasWarrantyFieldSpecified = value;
            }
        }

        public string warrantyURL
        {
            get
            {
                return this.warrantyURLField;
            }
            set
            {
                this.warrantyURLField = value;
            }
        }

        public string warrantyText
        {
            get
            {
                return this.warrantyTextField;
            }
            set
            {
                this.warrantyTextField = value;
            }
        }

        public bool isProp65WarningRequired
        {
            get
            {
                return this.isProp65WarningRequiredField;
            }
            set
            {
                this.isProp65WarningRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isProp65WarningRequiredSpecified
        {
            get
            {
                return this.isProp65WarningRequiredFieldSpecified;
            }
            set
            {
                this.isProp65WarningRequiredFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("smallPartsWarning", DataType = "integer", IsNullable = false)]
        public List<string> smallPartsWarnings
        {
            get
            {
                return this.smallPartsWarningsField;
            }
            set
            {
                this.smallPartsWarningsField = value;
            }
        }

        public bool isControlledSubstance
        {
            get
            {
                return this.isControlledSubstanceField;
            }
            set
            {
                this.isControlledSubstanceField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isControlledSubstanceSpecified
        {
            get
            {
                return this.isControlledSubstanceFieldSpecified;
            }
            set
            {
                this.isControlledSubstanceFieldSpecified = value;
            }
        }

        public string warrantyLength
        {
            get
            {
                return this.warrantyLengthField;
            }
            set
            {
                this.warrantyLengthField = value;
            }
        }

        public string prop65WarningText
        {
            get
            {
                return this.prop65WarningTextField;
            }
            set
            {
                this.prop65WarningTextField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<additionalProductAttribute> additionalProductAttributes
        {
            get
            {
                return this.additionalProductAttributesField;
            }
            set
            {
                this.additionalProductAttributesField = value;
            }
        }

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
        [XmlElement("FoodAndBeverage")]
        public FoodAndBeverage FoodAndBeverageField { get; set; }

        [XmlElement("HealthAndBeauty")]
        public HealthAndBeauty HealthAndBeautyField { get; set; }

        [XmlElement("Animal")]
        public Animal AnimalField { get; set; }
        [XmlElement("ArtAndCraft")]
        public ArtAndCraft ArtAndCraftField { get; set; }
        [XmlElement("Baby")]
        public Baby BabyField { get; set; }

        [XmlElement("CarriersAndAccessories")]
        public CarriersAndAccessories CarriersAndAccessoriesField { get; set; }
        [XmlElement("Clothing")]
        public Clothing ClothingField { get; set; }
        [XmlElement("Electronics")]
        public Electronics ElectronicsField { get; set; }
        [XmlElement("Footwear")]
        public Footwear FootwearField { get; set; }
        [XmlElement("Furniture")]
        public Furniture FurnitureField { get; set; }
        [XmlElement("GardenAndPatio")]
        public GardenAndPatio GardenAndPatioField { get; set; }
        [XmlElement("Home")]
        public Home HomeField { get; set; }
        [XmlElement("Jewelry")]
        public Jewelry JewelryField { get; set; }
        [XmlElement("Media")]
        public Media MediaField { get; set; }
        [XmlElement("MusicalInstrument")]
        public MusicalInstrument MusicalInstrumentField { get; set; }
        [XmlElement("OccasionAndSeasonal")]
        public OccasionAndSeasonal OccasionAndSeasonalField { get; set; }

        [XmlElement("Office")]
        public Office OfficeField { get; set; }

        [XmlElement("Other")]
        public Other OtherField { get; set; }
        [XmlElement("Photography")]
        public Photography PhotographyField { get; set; }

        [XmlElement("SportAndRecreation")]
        public SportAndRecreation SportAndRecreationField { get; set; }
        [XmlElement("ToolsAndHardware")]
        public ToolsAndHardware ToolsAndHardwareField { get; set; }
        [XmlElement("Toy")]
        public Toy ToyField { get; set; }

        [XmlElement("Vehicle")]
        public Vehicle VehicleField { get; set; }

        [XmlElement("Watches")]
        public Watches WatchesField { get; set; }

        /*
Amazon Devices 
Apparel 
Audible 
Automotive 
Automotive Parts and Accessories 
Baby Product 
Beauty 
BISS 
Book 
CE 
Classical 
Digital Music Album 
Digital Music Artist 
Digital Music Track 
Digital Text Feeds 
DVD 
eBooks 
Furniture 
Gourmet 
Grocery 
Health and Beauty 
Home 
Home Improvement 
Jewelry 
KindleStore 
Kitchen 
Lawn & Patio 
Loose Diamonds 
Magazine 
Miscellaneous 
Movie 
Music 
Musical Instruments 
Office Product 
Personal Computer 
Pet Products 
PetSupplies 
Photography 
Ring Setting 
Shoes 
Single Detail Page Misc 
Software 
Sports 
Toy 
TV Series Episode Video on Demand 
TV Series Video on Demand 
Video 
Video Games 
Watch 
Wireless 
         */

    }

    public partial class MainImage
    {

        private string mainImageUrlField;

        private string altTextField;

        public string mainImageUrl
        {
            get
            {
                return this.mainImageUrlField;
            }
            set
            {
                this.mainImageUrlField = value;
            }
        }

        public string altText
        {
            get
            {
                return this.altTextField;
            }
            set
            {
                this.altTextField = value;
            }
        }
    }

    public partial class additionalAsset
    {

        private string altTextField;

        private string assetUrlField;

        private string assetTypeField;

        private List<additionalAssetAttribute> additionalAssetAttributesField;

        public additionalAsset()
        {
            this.additionalAssetAttributesField = new List<additionalAssetAttribute>();
        }

        public string altText
        {
            get
            {
                return this.altTextField;
            }
            set
            {
                this.altTextField = value;
            }
        }

        public string assetUrl
        {
            get
            {
                return this.assetUrlField;
            }
            set
            {
                this.assetUrlField = value;
            }
        }

        public string assetType
        {
            get
            {
                return this.assetTypeField;
            }
            set
            {
                this.assetTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<additionalAssetAttribute> additionalAssetAttributes
        {
            get
            {
                return this.additionalAssetAttributesField;
            }
            set
            {
                this.additionalAssetAttributesField = value;
            }
        }
    }

    public partial class additionalAssetAttribute
    {

        private string attributeNameField;

        private string attributeValueField;

        public string attributeName
        {
            get
            {
                return this.attributeNameField;
            }
            set
            {
                this.attributeNameField = value;
            }
        }

        public string attributeValue
        {
            get
            {
                return this.attributeValueField;
            }
            set
            {
                this.attributeValueField = value;
            }
        }
    }

    public partial class productIdentifier
    {

        private productIdentifierProductIdType productIdTypeField;

        private string productIdField;

        public productIdentifierProductIdType productIdType
        {
            get
            {
                return this.productIdTypeField;
            }
            set
            {
                this.productIdTypeField = value;
            }
        }

        public string productId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }
    }

    public enum productIdentifierProductIdType
    {

        /// <remarks/>
        UPC,

        /// <remarks/>
        GTIN,

        /// <remarks/>
        EAN,

        /// <remarks/>
        ISSN,

        /// <remarks/>
        ISBN,
    }

    public partial class CurrencyUnit
    {

        private CurrencyUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private double measureField;

        private bool measureFieldSpecified;

        public CurrencyUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public double measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum CurrencyUnitOfMeasure
    {

        /// <remarks/>
        USD,
    }

    public partial class certificationsAndClaim
    {

        private string certificationAndClaimTypeField;

        private string certifyingAgentField;

        public string certificationAndClaimType
        {
            get
            {
                return this.certificationAndClaimTypeField;
            }
            set
            {
                this.certificationAndClaimTypeField = value;
            }
        }

        public string certifyingAgent
        {
            get
            {
                return this.certifyingAgentField;
            }
            set
            {
                this.certifyingAgentField = value;
            }
        }
    }

    public partial class LengthUnit
    {

        private LengthUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public LengthUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum LengthUnitOfMeasure
    {

        /// <remarks/>
        Inches,

        /// <remarks/>
        Micrometers,

        /// <remarks/>
        Feet,

        /// <remarks/>
        Millimeters,

        /// <remarks/>
        Centimeters,

        /// <remarks/>
        Meters,

        /// <remarks/>
        Yards,

        /// <remarks/>
        French,

        /// <remarks/>
        Miles,

        /// <remarks/>
        Mil,
    }

    public partial class WeightUnit
    {

        private WeightUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private double measureField;

        private bool measureFieldSpecified;

        public WeightUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public double measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum WeightUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Kilograms Per Meter")]
        KilogramsPerMeter,

        /// <remarks/>
        Kilograms,

        /// <remarks/>
        Milligrams,

        /// <remarks/>
        Ounces,

        /// <remarks/>
        Pounds,

        /// <remarks/>
        Grams,

        /// <remarks/>
        Carat,
    }

    public enum MPProductCountryOfOriginAssembly
    {

        /// <remarks/>
        FK,

        /// <remarks/>
        GS,

        /// <remarks/>
        HM,

        /// <remarks/>
        IO,

        /// <remarks/>
        PM,

        /// <remarks/>
        TF,

        /// <remarks/>
        UM,

        /// <remarks/>
        VC,

        /// <remarks/>
        WF,

        /// <remarks/>
        AE,

        /// <remarks/>
        AG,

        /// <remarks/>
        AN,

        /// <remarks/>
        BA,

        /// <remarks/>
        BN,

        /// <remarks/>
        CC,

        /// <remarks/>
        CD,

        /// <remarks/>
        CF,

        /// <remarks/>
        CX,

        /// <remarks/>
        DO,

        /// <remarks/>
        FX,

        /// <remarks/>
        GQ,

        /// <remarks/>
        KN,

        /// <remarks/>
        LY,

        /// <remarks/>
        MH,

        /// <remarks/>
        MP,

        /// <remarks/>
        PF,

        /// <remarks/>
        PG,

        /// <remarks/>
        RU,

        /// <remarks/>
        SB,

        /// <remarks/>
        SJ,

        /// <remarks/>
        ST,

        /// <remarks/>
        SY,

        /// <remarks/>
        TC,

        /// <remarks/>
        TT,

        /// <remarks/>
        VA,

        /// <remarks/>
        VG,

        /// <remarks/>
        VI,

        /// <remarks/>
        AD,

        /// <remarks/>
        AF,

        /// <remarks/>
        AI,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AO,

        /// <remarks/>
        AQ,

        /// <remarks/>
        AR,

        /// <remarks/>
        AS,

        /// <remarks/>
        AT,

        /// <remarks/>
        AU,

        /// <remarks/>
        AW,

        /// <remarks/>
        AZ,

        /// <remarks/>
        BB,

        /// <remarks/>
        BD,

        /// <remarks/>
        BE,

        /// <remarks/>
        BF,

        /// <remarks/>
        BG,

        /// <remarks/>
        BH,

        /// <remarks/>
        BI,

        /// <remarks/>
        BJ,

        /// <remarks/>
        BM,

        /// <remarks/>
        BO,

        /// <remarks/>
        BR,

        /// <remarks/>
        BS,

        /// <remarks/>
        BT,

        /// <remarks/>
        BV,

        /// <remarks/>
        BW,

        /// <remarks/>
        BY,

        /// <remarks/>
        BZ,

        /// <remarks/>
        CA,

        /// <remarks/>
        CG,

        /// <remarks/>
        CH,

        /// <remarks/>
        CI,

        /// <remarks/>
        CK,

        /// <remarks/>
        CL,

        /// <remarks/>
        CM,

        /// <remarks/>
        CN,

        /// <remarks/>
        CO,

        /// <remarks/>
        CR,

        /// <remarks/>
        CV,

        /// <remarks/>
        CY,

        /// <remarks/>
        CZ,

        /// <remarks/>
        DE,

        /// <remarks/>
        DJ,

        /// <remarks/>
        DK,

        /// <remarks/>
        DM,

        /// <remarks/>
        DZ,

        /// <remarks/>
        EC,

        /// <remarks/>
        EE,

        /// <remarks/>
        EG,

        /// <remarks/>
        EH,

        /// <remarks/>
        ER,

        /// <remarks/>
        ES,

        /// <remarks/>
        ET,

        /// <remarks/>
        FI,

        /// <remarks/>
        FM,

        /// <remarks/>
        FO,

        /// <remarks/>
        FR,

        /// <remarks/>
        GA,

        /// <remarks/>
        GB,

        /// <remarks/>
        GD,

        /// <remarks/>
        GE,

        /// <remarks/>
        GF,

        /// <remarks/>
        GH,

        /// <remarks/>
        GI,

        /// <remarks/>
        GL,

        /// <remarks/>
        GM,

        /// <remarks/>
        GN,

        /// <remarks/>
        GP,

        /// <remarks/>
        GR,

        /// <remarks/>
        GT,

        /// <remarks/>
        GW,

        /// <remarks/>
        GY,

        /// <remarks/>
        HK,

        /// <remarks/>
        HN,

        /// <remarks/>
        HR,

        /// <remarks/>
        HT,

        /// <remarks/>
        HU,

        /// <remarks/>
        ID,

        /// <remarks/>
        IE,

        /// <remarks/>
        IL,

        /// <remarks/>
        IN,

        /// <remarks/>
        IS,

        /// <remarks/>
        IT,

        /// <remarks/>
        JM,

        /// <remarks/>
        JO,

        /// <remarks/>
        JP,

        /// <remarks/>
        KE,

        /// <remarks/>
        KG,

        /// <remarks/>
        KH,

        /// <remarks/>
        KI,

        /// <remarks/>
        KM,

        /// <remarks/>
        KP,

        /// <remarks/>
        KR,

        /// <remarks/>
        KW,

        /// <remarks/>
        KY,

        /// <remarks/>
        KZ,

        /// <remarks/>
        LB,

        /// <remarks/>
        LC,

        /// <remarks/>
        LI,

        /// <remarks/>
        LK,

        /// <remarks/>
        LR,

        /// <remarks/>
        LS,

        /// <remarks/>
        LT,

        /// <remarks/>
        LU,

        /// <remarks/>
        LV,

        /// <remarks/>
        MA,

        /// <remarks/>
        MC,

        /// <remarks/>
        MD,

        /// <remarks/>
        MG,

        /// <remarks/>
        MK,

        /// <remarks/>
        MM,

        /// <remarks/>
        MN,

        /// <remarks/>
        MO,

        /// <remarks/>
        MQ,

        /// <remarks/>
        MR,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        MU,

        /// <remarks/>
        MV,

        /// <remarks/>
        MW,

        /// <remarks/>
        MX,

        /// <remarks/>
        MY,

        /// <remarks/>
        MZ,

        /// <remarks/>
        NA,

        /// <remarks/>
        NC,

        /// <remarks/>
        NE,

        /// <remarks/>
        NF,

        /// <remarks/>
        NG,

        /// <remarks/>
        NI,

        /// <remarks/>
        NL,

        /// <remarks/>
        NO,

        /// <remarks/>
        NP,

        /// <remarks/>
        NR,

        /// <remarks/>
        NZ,

        /// <remarks/>
        PA,

        /// <remarks/>
        PH,

        /// <remarks/>
        PK,

        /// <remarks/>
        PL,

        /// <remarks/>
        PN,

        /// <remarks/>
        PR,

        /// <remarks/>
        PS,

        /// <remarks/>
        PT,

        /// <remarks/>
        PW,

        /// <remarks/>
        PY,

        /// <remarks/>
        QA,

        /// <remarks/>
        RE,

        /// <remarks/>
        RO,

        /// <remarks/>
        RW,

        /// <remarks/>
        SA,

        /// <remarks/>
        SC,

        /// <remarks/>
        SD,

        /// <remarks/>
        SE,

        /// <remarks/>
        SG,

        /// <remarks/>
        SH,

        /// <remarks/>
        SI,

        /// <remarks/>
        SK,

        /// <remarks/>
        SL,

        /// <remarks/>
        SM,

        /// <remarks/>
        SN,

        /// <remarks/>
        SO,

        /// <remarks/>
        SR,

        /// <remarks/>
        SV,

        /// <remarks/>
        SZ,

        /// <remarks/>
        TH,

        /// <remarks/>
        TJ,

        /// <remarks/>
        TK,

        /// <remarks/>
        TM,

        /// <remarks/>
        TN,

        /// <remarks/>
        TO,

        /// <remarks/>
        TP,

        /// <remarks/>
        TR,

        /// <remarks/>
        TV,

        /// <remarks/>
        TW,

        /// <remarks/>
        TZ,

        /// <remarks/>
        UA,

        /// <remarks/>
        UG,

        /// <remarks/>
        US,

        /// <remarks/>
        UY,

        /// <remarks/>
        UZ,

        /// <remarks/>
        VE,

        /// <remarks/>
        VN,

        /// <remarks/>
        VU,

        /// <remarks/>
        WS,

        /// <remarks/>
        YE,

        /// <remarks/>
        YT,

        /// <remarks/>
        YU,

        /// <remarks/>
        ZA,

        /// <remarks/>
        ZM,

        /// <remarks/>
        ZR,

        /// <remarks/>
        ZW,

        /// <remarks/>
        CU,

        /// <remarks/>
        FJ,

        /// <remarks/>
        GU,

        /// <remarks/>
        IQ,

        /// <remarks/>
        IR,

        /// <remarks/>
        LA,

        /// <remarks/>
        ML,

        /// <remarks/>
        NU,

        /// <remarks/>
        OM,

        /// <remarks/>
        PE,

        /// <remarks/>
        TD,

        /// <remarks/>
        TG,
    }

    public enum MPProductCountryOfOriginComponents
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("USA and Imported")]
        USAandImported,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("USA or Imported")]
        USAorImported,

        /// <remarks/>
        Imported,

        /// <remarks/>
        USA,
    }

    public partial class batteryTypeAndQuantityValue
    {

        private batteryTypeAndQuantityValueBatteryTechnologyType batteryTechnologyTypeField;

        private bool batteryTechnologyTypeFieldSpecified;

        private string numberOfBatteriesField;

        public batteryTypeAndQuantityValueBatteryTechnologyType batteryTechnologyType
        {
            get
            {
                return this.batteryTechnologyTypeField;
            }
            set
            {
                this.batteryTechnologyTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteryTechnologyTypeSpecified
        {
            get
            {
                return this.batteryTechnologyTypeFieldSpecified;
            }
            set
            {
                this.batteryTechnologyTypeFieldSpecified = value;
            }
        }

        public string numberOfBatteries
        {
            get
            {
                return this.numberOfBatteriesField;
            }
            set
            {
                this.numberOfBatteriesField = value;
            }
        }
    }

    public enum batteryTypeAndQuantityValueBatteryTechnologyType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Lithium Ion")]
        LithiumIon,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Nickel Metal Hydride")]
        NickelMetalHydride,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Does Not Contain a Battery")]
        DoesNotContainaBattery,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Lead Acid (Non-Spillable)")]
        LeadAcidNonSpillable,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Lithium Primary")]
        LithiumPrimary,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Multiple Types")]
        MultipleTypes,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carbon Zinc")]
        CarbonZinc,

        /// <remarks/>
        Magnesium,

        /// <remarks/>
        Mercury,

        /// <remarks/>
        Thermal,

        /// <remarks/>
        Other,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Nickel Cadmium")]
        NickelCadmium,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Lead Acid")]
        LeadAcid,

        /// <remarks/>
        Silver,

        /// <remarks/>
        Alkaline,
    }

    public partial class PPUUnit
    {

        private PPUUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public PPUUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum PPUUnitOfMeasure
    {

        /// <remarks/>
        Inch,

        /// <remarks/>
        Kilogram,

        /// <remarks/>
        Each,

        /// <remarks/>
        Ounce,

        /// <remarks/>
        Centimeter,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per 100 Sheet")]
        Per100Sheet,

        /// <remarks/>
        Pound,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Square Foot")]
        SquareFoot,

        /// <remarks/>
        Milliliter,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cubic Foot")]
        CubicFoot,

        /// <remarks/>
        Pint,

        /// <remarks/>
        Foot,

        /// <remarks/>
        Gram,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per 100 Count")]
        Per100Count,

        /// <remarks/>
        Quart,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Fluid Ounce")]
        FluidOunce,

        /// <remarks/>
        Gallon,

        /// <remarks/>
        Liter,
    }

    public partial class additionalProductAttribute
    {

        private string productAttributeNameField;

        private string productAttributeValueField;

        public string productAttributeName
        {
            get
            {
                return this.productAttributeNameField;
            }
            set
            {
                this.productAttributeNameField = value;
            }
        }

        public string productAttributeValue
        {
            get
            {
                return this.productAttributeValueField;
            }
            set
            {
                this.productAttributeValueField = value;
            }
        }
    }

    public partial class Animal
    {

        private string animalBreedField;

        private List<swatchImage> swatchImagesField;

        private string animalLifestageField;

        private WeightUnit minimumWeightField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private List<string> colorField;

        private string animalTypeField;

        private List<string> materialField;

        private List<string> patternField;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private WeightUnit maximumWeightField;

        private string petSizeField;

        private object itemField;

        public Animal()
        {
            this.maximumWeightField = new WeightUnit();
            this.patternField = new List<string>();
            this.materialField = new List<string>();
            this.colorField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.minimumWeightField = new WeightUnit();
            this.swatchImagesField = new List<swatchImage>();
        }

        public string animalBreed
        {
            get
            {
                return this.animalBreedField;
            }
            set
            {
                this.animalBreedField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public string animalLifestage
        {
            get
            {
                return this.animalLifestageField;
            }
            set
            {
                this.animalLifestageField = value;
            }
        }

        public WeightUnit minimumWeight
        {
            get
            {
                return this.minimumWeightField;
            }
            set
            {
                this.minimumWeightField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        public string animalType
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

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        public string petSize
        {
            get
            {
                return this.petSizeField;
            }
            set
            {
                this.petSizeField = value;
            }
        }

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

    public partial class swatchImage
    {

        private string swatchImageUrlField;

        private string swatchVariantAttributeField;

        public string swatchImageUrl
        {
            get
            {
                return this.swatchImageUrlField;
            }
            set
            {
                this.swatchImageUrlField = value;
            }
        }

        public string swatchVariantAttribute
        {
            get
            {
                return this.swatchVariantAttributeField;
            }
            set
            {
                this.swatchVariantAttributeField = value;
            }
        }
    }

    public partial class fabricContentValue
    {

        private string materialNameField;

        private decimal materialPercentageField;

        private bool materialPercentageFieldSpecified;

        public string materialName
        {
            get
            {
                return this.materialNameField;
            }
            set
            {
                this.materialNameField = value;
            }
        }

        public decimal materialPercentage
        {
            get
            {
                return this.materialPercentageField;
            }
            set
            {
                this.materialPercentageField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool materialPercentageSpecified
        {
            get
            {
                return this.materialPercentageFieldSpecified;
            }
            set
            {
                this.materialPercentageFieldSpecified = value;
            }
        }
    }

    public partial class AnimalAccessories
    {

        private string conditionField;

        private TemperatureUnit minimumTemperatureField;

        private string clothingSizeField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private List<string> characterField;

        private bool isRetractableField;

        private bool isRetractableFieldSpecified;

        private bool isReflectiveField;

        private bool isReflectiveFieldSpecified;

        private bool makesNoiseField;

        private bool makesNoiseFieldSpecified;

        private TemperatureUnit maximumTemperatureField;

        private string capacityField;

        private string shapeField;

        public AnimalAccessories()
        {
            this.maximumTemperatureField = new TemperatureUnit();
            this.characterField = new List<string>();
            this.minimumTemperatureField = new TemperatureUnit();
        }

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public TemperatureUnit minimumTemperature
        {
            get
            {
                return this.minimumTemperatureField;
            }
            set
            {
                this.minimumTemperatureField = value;
            }
        }

        public string clothingSize
        {
            get
            {
                return this.clothingSizeField;
            }
            set
            {
                this.clothingSizeField = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public bool isRetractable
        {
            get
            {
                return this.isRetractableField;
            }
            set
            {
                this.isRetractableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRetractableSpecified
        {
            get
            {
                return this.isRetractableFieldSpecified;
            }
            set
            {
                this.isRetractableFieldSpecified = value;
            }
        }

        public bool isReflective
        {
            get
            {
                return this.isReflectiveField;
            }
            set
            {
                this.isReflectiveField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReflectiveSpecified
        {
            get
            {
                return this.isReflectiveFieldSpecified;
            }
            set
            {
                this.isReflectiveFieldSpecified = value;
            }
        }

        public bool makesNoise
        {
            get
            {
                return this.makesNoiseField;
            }
            set
            {
                this.makesNoiseField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool makesNoiseSpecified
        {
            get
            {
                return this.makesNoiseFieldSpecified;
            }
            set
            {
                this.makesNoiseFieldSpecified = value;
            }
        }

        public TemperatureUnit maximumTemperature
        {
            get
            {
                return this.maximumTemperatureField;
            }
            set
            {
                this.maximumTemperatureField = value;
            }
        }

        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }
    }

    public partial class TemperatureUnit
    {

        private TemperatureUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public TemperatureUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum TemperatureUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Degrees Fahrenheit")]
        DegreesFahrenheit,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Degrees Celsius")]
        DegreesCelsius,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Degrees Centigrade")]
        DegreesCentigrade,

        /// <remarks/>
        Kelvin,
    }

    public partial class AnimalFood
    {

        private string flavorField;

        private string petFoodFormField;

        private List<string> nutrientContentClaimsField;

        private bool isGrainFreeField;

        private bool isGrainFreeFieldSpecified;

        private string feedingInstructionsField;

        private string animalHealthConcernField;

        private string ingredientsField;

        public AnimalFood()
        {
            this.nutrientContentClaimsField = new List<string>();
        }

        public string flavor
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

        public string petFoodForm
        {
            get
            {
                return this.petFoodFormField;
            }
            set
            {
                this.petFoodFormField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("nutrientContentClaim", IsNullable = false)]
        public List<string> nutrientContentClaims
        {
            get
            {
                return this.nutrientContentClaimsField;
            }
            set
            {
                this.nutrientContentClaimsField = value;
            }
        }

        public bool isGrainFree
        {
            get
            {
                return this.isGrainFreeField;
            }
            set
            {
                this.isGrainFreeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isGrainFreeSpecified
        {
            get
            {
                return this.isGrainFreeFieldSpecified;
            }
            set
            {
                this.isGrainFreeFieldSpecified = value;
            }
        }

        public string feedingInstructions
        {
            get
            {
                return this.feedingInstructionsField;
            }
            set
            {
                this.feedingInstructionsField = value;
            }
        }

        public string animalHealthConcern
        {
            get
            {
                return this.animalHealthConcernField;
            }
            set
            {
                this.animalHealthConcernField = value;
            }
        }

        public string ingredients
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
    }

    public partial class AnimalHealthAndGrooming
    {

        private string conditionField;

        private bool isDisposableField;

        private bool isDisposableFieldSpecified;

        private string powerTypeField;

        private string animalHealthConcernField;

        private List<string> hairLengthField;

        private string scentField;

        private bool isDrugFactsLabelRequiredField;

        private bool isDrugFactsLabelRequiredFieldSpecified;

        private string drugFactsLabelField;

        private List<activeIngredient> activeIngredientsField;

        private List<string> inactiveIngredientsField;

        private string formField;

        private string instructionsField;

        private string dosageField;

        private List<string> stopUseIndicationsField;

        private string petSizeField;

        public AnimalHealthAndGrooming()
        {
            this.stopUseIndicationsField = new List<string>();
            this.inactiveIngredientsField = new List<string>();
            this.activeIngredientsField = new List<activeIngredient>();
            this.hairLengthField = new List<string>();
        }

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public bool isDisposable
        {
            get
            {
                return this.isDisposableField;
            }
            set
            {
                this.isDisposableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDisposableSpecified
        {
            get
            {
                return this.isDisposableFieldSpecified;
            }
            set
            {
                this.isDisposableFieldSpecified = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public string animalHealthConcern
        {
            get
            {
                return this.animalHealthConcernField;
            }
            set
            {
                this.animalHealthConcernField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("hairLengthValue", IsNullable = false)]
        public List<string> hairLength
        {
            get
            {
                return this.hairLengthField;
            }
            set
            {
                this.hairLengthField = value;
            }
        }

        public string scent
        {
            get
            {
                return this.scentField;
            }
            set
            {
                this.scentField = value;
            }
        }

        public bool isDrugFactsLabelRequired
        {
            get
            {
                return this.isDrugFactsLabelRequiredField;
            }
            set
            {
                this.isDrugFactsLabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDrugFactsLabelRequiredSpecified
        {
            get
            {
                return this.isDrugFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isDrugFactsLabelRequiredFieldSpecified = value;
            }
        }

        public string drugFactsLabel
        {
            get
            {
                return this.drugFactsLabelField;
            }
            set
            {
                this.drugFactsLabelField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<activeIngredient> activeIngredients
        {
            get
            {
                return this.activeIngredientsField;
            }
            set
            {
                this.activeIngredientsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("inactiveIngredient", IsNullable = false)]
        public List<string> inactiveIngredients
        {
            get
            {
                return this.inactiveIngredientsField;
            }
            set
            {
                this.inactiveIngredientsField = value;
            }
        }

        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        public string instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
            }
        }

        public string dosage
        {
            get
            {
                return this.dosageField;
            }
            set
            {
                this.dosageField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("stopUseIndication", IsNullable = false)]
        public List<string> stopUseIndications
        {
            get
            {
                return this.stopUseIndicationsField;
            }
            set
            {
                this.stopUseIndicationsField = value;
            }
        }

        public string petSize
        {
            get
            {
                return this.petSizeField;
            }
            set
            {
                this.petSizeField = value;
            }
        }
    }

    public partial class activeIngredient
    {

        private string activeIngredientNameField;

        private decimal activeIngredientPercentageField;

        private bool activeIngredientPercentageFieldSpecified;

        public string activeIngredientName
        {
            get
            {
                return this.activeIngredientNameField;
            }
            set
            {
                this.activeIngredientNameField = value;
            }
        }

        public decimal activeIngredientPercentage
        {
            get
            {
                return this.activeIngredientPercentageField;
            }
            set
            {
                this.activeIngredientPercentageField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activeIngredientPercentageSpecified
        {
            get
            {
                return this.activeIngredientPercentageFieldSpecified;
            }
            set
            {
                this.activeIngredientPercentageFieldSpecified = value;
            }
        }
    }

    public partial class ArtAndCraft
    {

        private string metalField;

        private bool isRefillableField;

        private bool isRefillableFieldSpecified;

        private string platingField;

        private List<swatchImage> swatchImagesField;

        private ArtAndCraftAgeRange ageRangeField;

        private bool ageRangeFieldSpecified;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private string finishField;

        private bool isRecyclableField;

        private bool isRecyclableFieldSpecified;

        private string culturalStyleField;

        private LengthUnit chainLengthField;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string conditionField;

        private string manufacturerField;

        private List<string> themeField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private ArtAndCraftGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private List<string> ageGroupField;

        private bool isBulkField;

        private bool isBulkFieldSpecified;

        private bool isReusableField;

        private bool isReusableFieldSpecified;

        private bool isDisposableField;

        private bool isDisposableFieldSpecified;

        private bool isAntiqueField;

        private bool isAntiqueFieldSpecified;

        private List<string> patternField;

        private List<string> materialField;

        private bool isAntitarnishField;

        private bool isAntitarnishFieldSpecified;

        private string numberOfPiecesField;

        private List<string> characterField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string powerTypeField;

        private List<string> occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private string artPaintTypeField;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private List<string> recommendedUsesField;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private bool isRetractableField;

        private bool isRetractableFieldSpecified;

        private bool gotsCertificationField;

        private bool gotsCertificationFieldSpecified;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private bool isCollectibleField;

        private bool isCollectibleFieldSpecified;

        private bool isHandmadeField;

        private bool isHandmadeFieldSpecified;

        private LengthUnit diameterField;

        private string skillLevelField;

        private bool isSelfAdhesiveField;

        private bool isSelfAdhesiveFieldSpecified;

        private List<string> recommendedSurfacesField;

        private string capacityField;

        private string subjectField;

        private string scentField;

        private string formField;

        private List<string> organicCertificationsField;

        private string shapeField;

        public ArtAndCraft()
        {
            this.organicCertificationsField = new List<string>();
            this.recommendedSurfacesField = new List<string>();
            this.diameterField = new LengthUnit();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.recommendedUsesField = new List<string>();
            this.occasionField = new List<string>();
            this.characterField = new List<string>();
            this.materialField = new List<string>();
            this.patternField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.themeField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.chainLengthField = new LengthUnit();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        public string metal
        {
            get
            {
                return this.metalField;
            }
            set
            {
                this.metalField = value;
            }
        }

        public bool isRefillable
        {
            get
            {
                return this.isRefillableField;
            }
            set
            {
                this.isRefillableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRefillableSpecified
        {
            get
            {
                return this.isRefillableFieldSpecified;
            }
            set
            {
                this.isRefillableFieldSpecified = value;
            }
        }

        public string plating
        {
            get
            {
                return this.platingField;
            }
            set
            {
                this.platingField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public ArtAndCraftAgeRange ageRange
        {
            get
            {
                return this.ageRangeField;
            }
            set
            {
                this.ageRangeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ageRangeSpecified
        {
            get
            {
                return this.ageRangeFieldSpecified;
            }
            set
            {
                this.ageRangeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public bool isRecyclable
        {
            get
            {
                return this.isRecyclableField;
            }
            set
            {
                this.isRecyclableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRecyclableSpecified
        {
            get
            {
                return this.isRecyclableFieldSpecified;
            }
            set
            {
                this.isRecyclableFieldSpecified = value;
            }
        }

        public string culturalStyle
        {
            get
            {
                return this.culturalStyleField;
            }
            set
            {
                this.culturalStyleField = value;
            }
        }

        public LengthUnit chainLength
        {
            get
            {
                return this.chainLengthField;
            }
            set
            {
                this.chainLengthField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public string manufacturer
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

        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public List<string> theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public ArtAndCraftGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public bool isBulk
        {
            get
            {
                return this.isBulkField;
            }
            set
            {
                this.isBulkField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBulkSpecified
        {
            get
            {
                return this.isBulkFieldSpecified;
            }
            set
            {
                this.isBulkFieldSpecified = value;
            }
        }

        public bool isReusable
        {
            get
            {
                return this.isReusableField;
            }
            set
            {
                this.isReusableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReusableSpecified
        {
            get
            {
                return this.isReusableFieldSpecified;
            }
            set
            {
                this.isReusableFieldSpecified = value;
            }
        }

        public bool isDisposable
        {
            get
            {
                return this.isDisposableField;
            }
            set
            {
                this.isDisposableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDisposableSpecified
        {
            get
            {
                return this.isDisposableFieldSpecified;
            }
            set
            {
                this.isDisposableFieldSpecified = value;
            }
        }

        public bool isAntique
        {
            get
            {
                return this.isAntiqueField;
            }
            set
            {
                this.isAntiqueField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAntiqueSpecified
        {
            get
            {
                return this.isAntiqueFieldSpecified;
            }
            set
            {
                this.isAntiqueFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        public bool isAntitarnish
        {
            get
            {
                return this.isAntitarnishField;
            }
            set
            {
                this.isAntitarnishField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAntitarnishSpecified
        {
            get
            {
                return this.isAntitarnishFieldSpecified;
            }
            set
            {
                this.isAntitarnishFieldSpecified = value;
            }
        }

        public string numberOfPieces
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

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public string artPaintType
        {
            get
            {
                return this.artPaintTypeField;
            }
            set
            {
                this.artPaintTypeField = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        public bool isRetractable
        {
            get
            {
                return this.isRetractableField;
            }
            set
            {
                this.isRetractableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRetractableSpecified
        {
            get
            {
                return this.isRetractableFieldSpecified;
            }
            set
            {
                this.isRetractableFieldSpecified = value;
            }
        }

        public bool gotsCertification
        {
            get
            {
                return this.gotsCertificationField;
            }
            set
            {
                this.gotsCertificationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool gotsCertificationSpecified
        {
            get
            {
                return this.gotsCertificationFieldSpecified;
            }
            set
            {
                this.gotsCertificationFieldSpecified = value;
            }
        }

        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        public bool isCollectible
        {
            get
            {
                return this.isCollectibleField;
            }
            set
            {
                this.isCollectibleField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCollectibleSpecified
        {
            get
            {
                return this.isCollectibleFieldSpecified;
            }
            set
            {
                this.isCollectibleFieldSpecified = value;
            }
        }

        public bool isHandmade
        {
            get
            {
                return this.isHandmadeField;
            }
            set
            {
                this.isHandmadeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isHandmadeSpecified
        {
            get
            {
                return this.isHandmadeFieldSpecified;
            }
            set
            {
                this.isHandmadeFieldSpecified = value;
            }
        }

        public LengthUnit diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
            }
        }

        public string skillLevel
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

        public bool isSelfAdhesive
        {
            get
            {
                return this.isSelfAdhesiveField;
            }
            set
            {
                this.isSelfAdhesiveField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSelfAdhesiveSpecified
        {
            get
            {
                return this.isSelfAdhesiveFieldSpecified;
            }
            set
            {
                this.isSelfAdhesiveFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedSurface", IsNullable = false)]
        public List<string> recommendedSurfaces
        {
            get
            {
                return this.recommendedSurfacesField;
            }
            set
            {
                this.recommendedSurfacesField = value;
            }
        }

        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        public string subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        public string scent
        {
            get
            {
                return this.scentField;
            }
            set
            {
                this.scentField = value;
            }
        }

        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("organicCertification", IsNullable = false)]
        public List<string> organicCertifications
        {
            get
            {
                return this.organicCertificationsField;
            }
            set
            {
                this.organicCertificationsField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }
    }

    public enum ArtAndCraftAgeRange
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0-12 Months")]
        Item012Months,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12-24 Months")]
        Item1224Months,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2-4 Years")]
        Item24Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5-7 Years")]
        Item57Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8-11 Years")]
        Item811Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12  Up")]
        Item12Up,
    }

    public enum ArtAndCraftGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class recycledMaterialContentValue
    {

        private string recycledMaterialField;

        private decimal percentageOfRecycledMaterialField;

        private bool percentageOfRecycledMaterialFieldSpecified;

        public string recycledMaterial
        {
            get
            {
                return this.recycledMaterialField;
            }
            set
            {
                this.recycledMaterialField = value;
            }
        }

        public decimal percentageOfRecycledMaterial
        {
            get
            {
                return this.percentageOfRecycledMaterialField;
            }
            set
            {
                this.percentageOfRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentageOfRecycledMaterialSpecified
        {
            get
            {
                return this.percentageOfRecycledMaterialFieldSpecified;
            }
            set
            {
                this.percentageOfRecycledMaterialFieldSpecified = value;
            }
        }
    }

    public partial class Baby
    {

        private List<swatchImage> swatchImagesField;

        private BabyAgeRange ageRangeField;

        private bool ageRangeFieldSpecified;

        private WeightUnit minimumWeightField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string conditionField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private BabyGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private List<string> ageGroupField;

        private bool isReusableField;

        private bool isReusableFieldSpecified;

        private bool isDisposableField;

        private bool isDisposableFieldSpecified;

        private List<string> patternField;

        private List<string> materialField;

        private string numberOfPiecesField;

        private List<string> characterField;

        private List<string> occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private List<string> recommendedUsesField;

        private string numberOfChannelsField;

        private bool isFairTradeField;

        private bool isFairTradeFieldSpecified;

        private TimeUnit maximumRecommendedAgeField;

        private TimeUnit minimumRecommendedAgeField;

        private List<string> sportField;

        private WeightUnit maximumWeightField;

        private List<string> diaposableBabyDiaperTypeField;

        private string capacityField;

        private string scentField;

        private List<string> organicCertificationsField;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        private object itemField;

        public Baby()
        {
            this.screenSizeField = new LengthUnit();
            this.organicCertificationsField = new List<string>();
            this.diaposableBabyDiaperTypeField = new List<string>();
            this.maximumWeightField = new WeightUnit();
            this.sportField = new List<string>();
            this.minimumRecommendedAgeField = new TimeUnit();
            this.maximumRecommendedAgeField = new TimeUnit();
            this.recommendedUsesField = new List<string>();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.occasionField = new List<string>();
            this.characterField = new List<string>();
            this.materialField = new List<string>();
            this.patternField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.minimumWeightField = new WeightUnit();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public BabyAgeRange ageRange
        {
            get
            {
                return this.ageRangeField;
            }
            set
            {
                this.ageRangeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ageRangeSpecified
        {
            get
            {
                return this.ageRangeFieldSpecified;
            }
            set
            {
                this.ageRangeFieldSpecified = value;
            }
        }

        public WeightUnit minimumWeight
        {
            get
            {
                return this.minimumWeightField;
            }
            set
            {
                this.minimumWeightField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public BabyGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public bool isReusable
        {
            get
            {
                return this.isReusableField;
            }
            set
            {
                this.isReusableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReusableSpecified
        {
            get
            {
                return this.isReusableFieldSpecified;
            }
            set
            {
                this.isReusableFieldSpecified = value;
            }
        }

        public bool isDisposable
        {
            get
            {
                return this.isDisposableField;
            }
            set
            {
                this.isDisposableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDisposableSpecified
        {
            get
            {
                return this.isDisposableFieldSpecified;
            }
            set
            {
                this.isDisposableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        public string numberOfPieces
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

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        public string numberOfChannels
        {
            get
            {
                return this.numberOfChannelsField;
            }
            set
            {
                this.numberOfChannelsField = value;
            }
        }

        public bool isFairTrade
        {
            get
            {
                return this.isFairTradeField;
            }
            set
            {
                this.isFairTradeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFairTradeSpecified
        {
            get
            {
                return this.isFairTradeFieldSpecified;
            }
            set
            {
                this.isFairTradeFieldSpecified = value;
            }
        }

        public TimeUnit maximumRecommendedAge
        {
            get
            {
                return this.maximumRecommendedAgeField;
            }
            set
            {
                this.maximumRecommendedAgeField = value;
            }
        }

        public TimeUnit minimumRecommendedAge
        {
            get
            {
                return this.minimumRecommendedAgeField;
            }
            set
            {
                this.minimumRecommendedAgeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("sportValue", IsNullable = false)]
        public List<string> sport
        {
            get
            {
                return this.sportField;
            }
            set
            {
                this.sportField = value;
            }
        }

        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("diaposableBabyDiaperTypeValue", IsNullable = false)]
        public List<string> diaposableBabyDiaperType
        {
            get
            {
                return this.diaposableBabyDiaperTypeField;
            }
            set
            {
                this.diaposableBabyDiaperTypeField = value;
            }
        }

        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        public string scent
        {
            get
            {
                return this.scentField;
            }
            set
            {
                this.scentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("organicCertification", IsNullable = false)]
        public List<string> organicCertifications
        {
            get
            {
                return this.organicCertificationsField;
            }
            set
            {
                this.organicCertificationsField = value;
            }
        }

        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

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

    public enum BabyAgeRange
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0-12 Months")]
        Item012Months,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12-24 Months")]
        Item1224Months,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2-4 Years")]
        Item24Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5-7 Years")]
        Item57Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8-11 Years")]
        Item811Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12  Up")]
        Item12Up,
    }

    public enum BabyGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class TimeUnit
    {

        private TimeUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private string measureField;

        public TimeUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public string measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }
    }

    public enum TimeUnitOfMeasure
    {

        /// <remarks/>
        Minutes,

        /// <remarks/>
        Seconds,

        /// <remarks/>
        Months,

        /// <remarks/>
        Hours,

        /// <remarks/>
        Milliseconds,

        /// <remarks/>
        Days,

        /// <remarks/>
        Years,
    }

    public partial class BabyClothing
    {

        private List<fabricContentValue> fabricContentField;

        private List<string> fabricCareInstructionsField;

        private BabyClothingGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private List<string> ageGroupField;

        private BabyClothingApparelCategory apparelCategoryField;

        private bool apparelCategoryFieldSpecified;

        private List<string> seasonField;

        private string babyClothingSizeField;

        public BabyClothing()
        {
            this.seasonField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public BabyClothingGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public BabyClothingApparelCategory apparelCategory
        {
            get
            {
                return this.apparelCategoryField;
            }
            set
            {
                this.apparelCategoryField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool apparelCategorySpecified
        {
            get
            {
                return this.apparelCategoryFieldSpecified;
            }
            set
            {
                this.apparelCategoryFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("seasonValue", IsNullable = false)]
        public List<string> season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        public string babyClothingSize
        {
            get
            {
                return this.babyClothingSizeField;
            }
            set
            {
                this.babyClothingSizeField = value;
            }
        }
    }

    public enum BabyClothingGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public enum BabyClothingApparelCategory
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Young Men\'s")]
        YoungMens,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Maternity Plus")]
        MaternityPlus,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("School Uniforms")]
        SchoolUniforms,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Men\'s Big  Tall")]
        MensBigTall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Women\'s Plus")]
        WomensPlus,

        /// <remarks/>
        Petites,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Maternity Wear")]
        MaternityWear,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Newborn Girl")]
        NewbornGirl,

        /// <remarks/>
        Boys,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Baby Boy")]
        BabyBoy,

        /// <remarks/>
        Girls,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Baby Girl")]
        BabyGirl,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Newborn Boy")]
        NewbornBoy,

        /// <remarks/>
        Juniors,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,
    }

    public partial class BabyFood
    {

        private string flavorField;

        private List<string> nutrientContentClaimsField;

        private string servingSizeField;

        private decimal servingsPerContainerField;

        private bool servingsPerContainerFieldSpecified;

        private bool isBabyFormulaLabelRequiredField;

        private bool isBabyFormulaLabelRequiredFieldSpecified;

        private string babyFormulaLabelField;

        private bool isChildrenUnder2LabelRequiredField;

        private bool isChildrenUnder2LabelRequiredFieldSpecified;

        private string childrenUnder2LabelField;

        private bool isChildrenUnder4LabelRequiredField;

        private bool isChildrenUnder4LabelRequiredFieldSpecified;

        private string childrenUnder4LabelField;

        private VolumeUnit fluidOuncesSupplying100CaloriesField;

        private decimal caloriesField;

        private bool caloriesFieldSpecified;

        private WeightUnit caloriesFromFatField;

        private WeightUnit totalFatField;

        private PercentageUnit totalFatPercentageDailyValueField;

        private WeightUnit totalCarbohydrateField;

        private PercentageUnit totalCarbohydratePercentageDailyValueField;

        private List<nutrient> nutrientsField;

        public BabyFood()
        {
            this.nutrientsField = new List<nutrient>();
            this.totalCarbohydratePercentageDailyValueField = new PercentageUnit();
            this.totalCarbohydrateField = new WeightUnit();
            this.totalFatPercentageDailyValueField = new PercentageUnit();
            this.totalFatField = new WeightUnit();
            this.caloriesFromFatField = new WeightUnit();
            this.fluidOuncesSupplying100CaloriesField = new VolumeUnit();
            this.nutrientContentClaimsField = new List<string>();
        }

        public string flavor
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

        [System.Xml.Serialization.XmlArrayItemAttribute("nutrientContentClaim", IsNullable = false)]
        public List<string> nutrientContentClaims
        {
            get
            {
                return this.nutrientContentClaimsField;
            }
            set
            {
                this.nutrientContentClaimsField = value;
            }
        }

        public string servingSize
        {
            get
            {
                return this.servingSizeField;
            }
            set
            {
                this.servingSizeField = value;
            }
        }

        public decimal servingsPerContainer
        {
            get
            {
                return this.servingsPerContainerField;
            }
            set
            {
                this.servingsPerContainerField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool servingsPerContainerSpecified
        {
            get
            {
                return this.servingsPerContainerFieldSpecified;
            }
            set
            {
                this.servingsPerContainerFieldSpecified = value;
            }
        }

        public bool isBabyFormulaLabelRequired
        {
            get
            {
                return this.isBabyFormulaLabelRequiredField;
            }
            set
            {
                this.isBabyFormulaLabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBabyFormulaLabelRequiredSpecified
        {
            get
            {
                return this.isBabyFormulaLabelRequiredFieldSpecified;
            }
            set
            {
                this.isBabyFormulaLabelRequiredFieldSpecified = value;
            }
        }

        public string babyFormulaLabel
        {
            get
            {
                return this.babyFormulaLabelField;
            }
            set
            {
                this.babyFormulaLabelField = value;
            }
        }

        public bool isChildrenUnder2LabelRequired
        {
            get
            {
                return this.isChildrenUnder2LabelRequiredField;
            }
            set
            {
                this.isChildrenUnder2LabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isChildrenUnder2LabelRequiredSpecified
        {
            get
            {
                return this.isChildrenUnder2LabelRequiredFieldSpecified;
            }
            set
            {
                this.isChildrenUnder2LabelRequiredFieldSpecified = value;
            }
        }

        public string childrenUnder2Label
        {
            get
            {
                return this.childrenUnder2LabelField;
            }
            set
            {
                this.childrenUnder2LabelField = value;
            }
        }

        public bool isChildrenUnder4LabelRequired
        {
            get
            {
                return this.isChildrenUnder4LabelRequiredField;
            }
            set
            {
                this.isChildrenUnder4LabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isChildrenUnder4LabelRequiredSpecified
        {
            get
            {
                return this.isChildrenUnder4LabelRequiredFieldSpecified;
            }
            set
            {
                this.isChildrenUnder4LabelRequiredFieldSpecified = value;
            }
        }

        public string childrenUnder4Label
        {
            get
            {
                return this.childrenUnder4LabelField;
            }
            set
            {
                this.childrenUnder4LabelField = value;
            }
        }

        public VolumeUnit fluidOuncesSupplying100Calories
        {
            get
            {
                return this.fluidOuncesSupplying100CaloriesField;
            }
            set
            {
                this.fluidOuncesSupplying100CaloriesField = value;
            }
        }

        public decimal calories
        {
            get
            {
                return this.caloriesField;
            }
            set
            {
                this.caloriesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool caloriesSpecified
        {
            get
            {
                return this.caloriesFieldSpecified;
            }
            set
            {
                this.caloriesFieldSpecified = value;
            }
        }

        public WeightUnit caloriesFromFat
        {
            get
            {
                return this.caloriesFromFatField;
            }
            set
            {
                this.caloriesFromFatField = value;
            }
        }

        public WeightUnit totalFat
        {
            get
            {
                return this.totalFatField;
            }
            set
            {
                this.totalFatField = value;
            }
        }

        public PercentageUnit totalFatPercentageDailyValue
        {
            get
            {
                return this.totalFatPercentageDailyValueField;
            }
            set
            {
                this.totalFatPercentageDailyValueField = value;
            }
        }

        public WeightUnit totalCarbohydrate
        {
            get
            {
                return this.totalCarbohydrateField;
            }
            set
            {
                this.totalCarbohydrateField = value;
            }
        }

        public PercentageUnit totalCarbohydratePercentageDailyValue
        {
            get
            {
                return this.totalCarbohydratePercentageDailyValueField;
            }
            set
            {
                this.totalCarbohydratePercentageDailyValueField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<nutrient> nutrients
        {
            get
            {
                return this.nutrientsField;
            }
            set
            {
                this.nutrientsField = value;
            }
        }
    }

    public partial class VolumeUnit
    {

        private VolumeUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public VolumeUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum VolumeUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("US Gallons")]
        USGallons,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Imperial (UK) Gallons")]
        ImperialUKGallons,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cubic Feet")]
        CubicFeet,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cubic Inches")]
        CubicInches,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cubic Centimeters")]
        CubicCentimeters,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cubic Meters")]
        CubicMeters,

        /// <remarks/>
        Milliliters,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cubic Yards")]
        CubicYards,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Fluid Ounces")]
        FluidOunces,

        /// <remarks/>
        Quarts,

        /// <remarks/>
        Liters,

        /// <remarks/>
        Pints,
    }

    public partial class PercentageUnit
    {

        private PercentageUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public PercentageUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum PercentageUnitOfMeasure
    {

        /// <remarks/>
        Percentage,
    }

    public partial class nutrient
    {

        private string nutrientNameField;

        private decimal nutrientAmountField;

        private bool nutrientAmountFieldSpecified;

        private decimal nutrientPercentageDailyValueField;

        private bool nutrientPercentageDailyValueFieldSpecified;

        public string nutrientName
        {
            get
            {
                return this.nutrientNameField;
            }
            set
            {
                this.nutrientNameField = value;
            }
        }

        public decimal nutrientAmount
        {
            get
            {
                return this.nutrientAmountField;
            }
            set
            {
                this.nutrientAmountField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nutrientAmountSpecified
        {
            get
            {
                return this.nutrientAmountFieldSpecified;
            }
            set
            {
                this.nutrientAmountFieldSpecified = value;
            }
        }

        public decimal nutrientPercentageDailyValue
        {
            get
            {
                return this.nutrientPercentageDailyValueField;
            }
            set
            {
                this.nutrientPercentageDailyValueField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nutrientPercentageDailyValueSpecified
        {
            get
            {
                return this.nutrientPercentageDailyValueFieldSpecified;
            }
            set
            {
                this.nutrientPercentageDailyValueFieldSpecified = value;
            }
        }
    }

    public partial class BabyFootwear
    {

        private string shoeCategoryField;

        private string shoeSizeField;

        private string shoeWidthField;

        private BabyFootwearGender genderField;

        private bool genderFieldSpecified;

        private string shoeStyleField;

        private List<string> ageGroupField;

        private string shoeClosureField;

        public BabyFootwear()
        {
            this.ageGroupField = new List<string>();
        }

        public string shoeCategory
        {
            get
            {
                return this.shoeCategoryField;
            }
            set
            {
                this.shoeCategoryField = value;
            }
        }

        public string shoeSize
        {
            get
            {
                return this.shoeSizeField;
            }
            set
            {
                this.shoeSizeField = value;
            }
        }

        public string shoeWidth
        {
            get
            {
                return this.shoeWidthField;
            }
            set
            {
                this.shoeWidthField = value;
            }
        }

        public BabyFootwearGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        public string shoeStyle
        {
            get
            {
                return this.shoeStyleField;
            }
            set
            {
                this.shoeStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public string shoeClosure
        {
            get
            {
                return this.shoeClosureField;
            }
            set
            {
                this.shoeClosureField = value;
            }
        }
    }

    public enum BabyFootwearGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class BabyFurniture
    {

        private string collectionField;

        private string finishField;

        private string homeDecorStyleField;

        private List<string> materialField;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private string assemblyInstructionsField;

        private string mattressFirmnessField;

        private List<string> fillMaterialField;

        private string bedSizeField;

        private string shapeField;

        public BabyFurniture()
        {
            this.fillMaterialField = new List<string>();
            this.materialField = new List<string>();
        }

        public string collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        public bool isWheeled
        {
            get
            {
                return this.isWheeledField;
            }
            set
            {
                this.isWheeledField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWheeledSpecified
        {
            get
            {
                return this.isWheeledFieldSpecified;
            }
            set
            {
                this.isWheeledFieldSpecified = value;
            }
        }

        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
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

        public string assemblyInstructions
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

        public string mattressFirmness
        {
            get
            {
                return this.mattressFirmnessField;
            }
            set
            {
                this.mattressFirmnessField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fillMaterialValue", IsNullable = false)]
        public List<string> fillMaterial
        {
            get
            {
                return this.fillMaterialField;
            }
            set
            {
                this.fillMaterialField = value;
            }
        }

        public string bedSize
        {
            get
            {
                return this.bedSizeField;
            }
            set
            {
                this.bedSizeField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }
    }

    public partial class BabyToys
    {

        private string animalBreedField;

        private BabyToysAgeRange ageRangeField;

        private bool ageRangeFieldSpecified;

        private List<string> themeField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private List<string> awardsWonField;

        private string animalTypeField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string powerTypeField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private bool makesNoiseField;

        private bool makesNoiseFieldSpecified;

        private List<string> fillMaterialField;

        private List<string> educationalFocusField;

        public BabyToys()
        {
            this.educationalFocusField = new List<string>();
            this.fillMaterialField = new List<string>();
            this.awardsWonField = new List<string>();
            this.themeField = new List<string>();
        }

        public string animalBreed
        {
            get
            {
                return this.animalBreedField;
            }
            set
            {
                this.animalBreedField = value;
            }
        }

        public BabyToysAgeRange ageRange
        {
            get
            {
                return this.ageRangeField;
            }
            set
            {
                this.ageRangeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ageRangeSpecified
        {
            get
            {
                return this.ageRangeFieldSpecified;
            }
            set
            {
                this.ageRangeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public List<string> theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("awardsWonValue", IsNullable = false)]
        public List<string> awardsWon
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

        public string animalType
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

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public bool isRemoteControlIncluded
        {
            get
            {
                return this.isRemoteControlIncludedField;
            }
            set
            {
                this.isRemoteControlIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRemoteControlIncludedSpecified
        {
            get
            {
                return this.isRemoteControlIncludedFieldSpecified;
            }
            set
            {
                this.isRemoteControlIncludedFieldSpecified = value;
            }
        }

        public bool makesNoise
        {
            get
            {
                return this.makesNoiseField;
            }
            set
            {
                this.makesNoiseField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool makesNoiseSpecified
        {
            get
            {
                return this.makesNoiseFieldSpecified;
            }
            set
            {
                this.makesNoiseFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fillMaterialValue", IsNullable = false)]
        public List<string> fillMaterial
        {
            get
            {
                return this.fillMaterialField;
            }
            set
            {
                this.fillMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("educationalFocu", IsNullable = false)]
        public List<string> educationalFocus
        {
            get
            {
                return this.educationalFocusField;
            }
            set
            {
                this.educationalFocusField = value;
            }
        }
    }

    public enum BabyToysAgeRange
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0-12 Months")]
        Item012Months,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12-24 Months")]
        Item1224Months,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2-4 Years")]
        Item24Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5-7 Years")]
        Item57Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8-11 Years")]
        Item811Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12  Up")]
        Item12Up,
    }

    public partial class ChildCarSeats
    {

        private string childCarSeatTypeField;

        private string facingDirectionField;

        private WeightUnit forwardFacingMinimumWeightField;

        private WeightUnit forwardFacingMaximumWeightField;

        private WeightUnit rearFacingMinimumWeightField;

        private WeightUnit rearFacingMaximumWeightField;

        private bool hasLatchSystemField;

        private bool hasLatchSystemFieldSpecified;

        public ChildCarSeats()
        {
            this.rearFacingMaximumWeightField = new WeightUnit();
            this.rearFacingMinimumWeightField = new WeightUnit();
            this.forwardFacingMaximumWeightField = new WeightUnit();
            this.forwardFacingMinimumWeightField = new WeightUnit();
        }

        public string childCarSeatType
        {
            get
            {
                return this.childCarSeatTypeField;
            }
            set
            {
                this.childCarSeatTypeField = value;
            }
        }

        public string facingDirection
        {
            get
            {
                return this.facingDirectionField;
            }
            set
            {
                this.facingDirectionField = value;
            }
        }

        public WeightUnit forwardFacingMinimumWeight
        {
            get
            {
                return this.forwardFacingMinimumWeightField;
            }
            set
            {
                this.forwardFacingMinimumWeightField = value;
            }
        }

        public WeightUnit forwardFacingMaximumWeight
        {
            get
            {
                return this.forwardFacingMaximumWeightField;
            }
            set
            {
                this.forwardFacingMaximumWeightField = value;
            }
        }

        public WeightUnit rearFacingMinimumWeight
        {
            get
            {
                return this.rearFacingMinimumWeightField;
            }
            set
            {
                this.rearFacingMinimumWeightField = value;
            }
        }

        public WeightUnit rearFacingMaximumWeight
        {
            get
            {
                return this.rearFacingMaximumWeightField;
            }
            set
            {
                this.rearFacingMaximumWeightField = value;
            }
        }

        public bool hasLatchSystem
        {
            get
            {
                return this.hasLatchSystemField;
            }
            set
            {
                this.hasLatchSystemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasLatchSystemSpecified
        {
            get
            {
                return this.hasLatchSystemFieldSpecified;
            }
            set
            {
                this.hasLatchSystemFieldSpecified = value;
            }
        }
    }

    public partial class Strollers
    {

        private string seatingCapacityField;

        private string strollerTypeField;

        public string seatingCapacity
        {
            get
            {
                return this.seatingCapacityField;
            }
            set
            {
                this.seatingCapacityField = value;
            }
        }

        public string strollerType
        {
            get
            {
                return this.strollerTypeField;
            }
            set
            {
                this.strollerTypeField = value;
            }
        }
    }

    public partial class CarriersAndAccessories
    {

        private List<swatchImage> swatchImagesField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private bool isWeatherResistantField;

        private bool isWeatherResistantFieldSpecified;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string dimensionsField;

        private string conditionField;

        private bool isLinedField;

        private bool isLinedFieldSpecified;

        private string manufacturerField;

        private string numberOfWheelsField;

        private string modelNumberField;

        private List<string> handleMaterialField;

        private string manufacturerPartNumberField;

        private CarriersAndAccessoriesGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private string handleTypeField;

        private List<string> ageGroupField;

        private string designerField;

        private string leatherGradeField;

        private List<string> materialField;

        private List<string> patternField;

        private List<string> characterField;

        private string monogramLetterField;

        private string numberOfPiecesField;

        private string zipperMaterialField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private string lockingMechanismField;

        private bool hardOrSoftCaseField;

        private bool hardOrSoftCaseFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private bool isFairTradeField;

        private bool isFairTradeFieldSpecified;

        private string capacityField;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private CasesAndBags itemField;

        public CarriersAndAccessories()
        {
            this.itemField = new CasesAndBags();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.characterField = new List<string>();
            this.patternField = new List<string>();
            this.materialField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.handleMaterialField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public bool isWeatherResistant
        {
            get
            {
                return this.isWeatherResistantField;
            }
            set
            {
                this.isWeatherResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWeatherResistantSpecified
        {
            get
            {
                return this.isWeatherResistantFieldSpecified;
            }
            set
            {
                this.isWeatherResistantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string dimensions
        {
            get
            {
                return this.dimensionsField;
            }
            set
            {
                this.dimensionsField = value;
            }
        }

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public bool isLined
        {
            get
            {
                return this.isLinedField;
            }
            set
            {
                this.isLinedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLinedSpecified
        {
            get
            {
                return this.isLinedFieldSpecified;
            }
            set
            {
                this.isLinedFieldSpecified = value;
            }
        }

        public string manufacturer
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

        public string numberOfWheels
        {
            get
            {
                return this.numberOfWheelsField;
            }
            set
            {
                this.numberOfWheelsField = value;
            }
        }

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("handleMaterialValue", IsNullable = false)]
        public List<string> handleMaterial
        {
            get
            {
                return this.handleMaterialField;
            }
            set
            {
                this.handleMaterialField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public CarriersAndAccessoriesGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        public string handleType
        {
            get
            {
                return this.handleTypeField;
            }
            set
            {
                this.handleTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public string designer
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

        public string leatherGrade
        {
            get
            {
                return this.leatherGradeField;
            }
            set
            {
                this.leatherGradeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public string monogramLetter
        {
            get
            {
                return this.monogramLetterField;
            }
            set
            {
                this.monogramLetterField = value;
            }
        }

        public string numberOfPieces
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

        public string zipperMaterial
        {
            get
            {
                return this.zipperMaterialField;
            }
            set
            {
                this.zipperMaterialField = value;
            }
        }

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public string lockingMechanism
        {
            get
            {
                return this.lockingMechanismField;
            }
            set
            {
                this.lockingMechanismField = value;
            }
        }

        public bool hardOrSoftCase
        {
            get
            {
                return this.hardOrSoftCaseField;
            }
            set
            {
                this.hardOrSoftCaseField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hardOrSoftCaseSpecified
        {
            get
            {
                return this.hardOrSoftCaseFieldSpecified;
            }
            set
            {
                this.hardOrSoftCaseFieldSpecified = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        public bool isWheeled
        {
            get
            {
                return this.isWheeledField;
            }
            set
            {
                this.isWheeledField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWheeledSpecified
        {
            get
            {
                return this.isWheeledFieldSpecified;
            }
            set
            {
                this.isWheeledFieldSpecified = value;
            }
        }

        public bool isFairTrade
        {
            get
            {
                return this.isFairTradeField;
            }
            set
            {
                this.isFairTradeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFairTradeSpecified
        {
            get
            {
                return this.isFairTradeFieldSpecified;
            }
            set
            {
                this.isFairTradeFieldSpecified = value;
            }
        }

        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        public bool isWaterproof
        {
            get
            {
                return this.isWaterproofField;
            }
            set
            {
                this.isWaterproofField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterproofSpecified
        {
            get
            {
                return this.isWaterproofFieldSpecified;
            }
            set
            {
                this.isWaterproofFieldSpecified = value;
            }
        }

        public CasesAndBags Item
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

    public enum CarriersAndAccessoriesGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class CasesAndBags
    {

        private string finishField;

        private bool isReusableField;

        private bool isReusableFieldSpecified;

        private List<string> occasionField;

        private List<string> recommendedUsesField;

        private string bagStyleField;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private string fastenerTypeField;

        private string numberOfCompartmentsField;

        private bool hasRemovableStrapField;

        private bool hasRemovableStrapFieldSpecified;

        private bool isTsaApprovedField;

        private bool isTsaApprovedFieldSpecified;

        private List<string> sportField;

        private WeightUnit maximumWeightField;

        private string shapeField;

        private LengthUnit screenSizeField;

        private List<string> compatibleBrandsField;

        private List<string> compatibleDevicesField;

        public CasesAndBags()
        {
            this.compatibleDevicesField = new List<string>();
            this.compatibleBrandsField = new List<string>();
            this.screenSizeField = new LengthUnit();
            this.maximumWeightField = new WeightUnit();
            this.sportField = new List<string>();
            this.recommendedUsesField = new List<string>();
            this.occasionField = new List<string>();
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public bool isReusable
        {
            get
            {
                return this.isReusableField;
            }
            set
            {
                this.isReusableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReusableSpecified
        {
            get
            {
                return this.isReusableFieldSpecified;
            }
            set
            {
                this.isReusableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        public string bagStyle
        {
            get
            {
                return this.bagStyleField;
            }
            set
            {
                this.bagStyleField = value;
            }
        }

        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        public string fastenerType
        {
            get
            {
                return this.fastenerTypeField;
            }
            set
            {
                this.fastenerTypeField = value;
            }
        }

        public string numberOfCompartments
        {
            get
            {
                return this.numberOfCompartmentsField;
            }
            set
            {
                this.numberOfCompartmentsField = value;
            }
        }

        public bool hasRemovableStrap
        {
            get
            {
                return this.hasRemovableStrapField;
            }
            set
            {
                this.hasRemovableStrapField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasRemovableStrapSpecified
        {
            get
            {
                return this.hasRemovableStrapFieldSpecified;
            }
            set
            {
                this.hasRemovableStrapFieldSpecified = value;
            }
        }

        public bool isTsaApproved
        {
            get
            {
                return this.isTsaApprovedField;
            }
            set
            {
                this.isTsaApprovedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTsaApprovedSpecified
        {
            get
            {
                return this.isTsaApprovedFieldSpecified;
            }
            set
            {
                this.isTsaApprovedFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("sportValue", IsNullable = false)]
        public List<string> sport
        {
            get
            {
                return this.sportField;
            }
            set
            {
                this.sportField = value;
            }
        }

        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleBrand", IsNullable = false)]
        public List<string> compatibleBrands
        {
            get
            {
                return this.compatibleBrandsField;
            }
            set
            {
                this.compatibleBrandsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleDevice", IsNullable = false)]
        public List<string> compatibleDevices
        {
            get
            {
                return this.compatibleDevicesField;
            }
            set
            {
                this.compatibleDevicesField = value;
            }
        }
    }

    public partial class Clothing
    {

        private List<swatchImage> swatchImagesField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string clothingSizeField;

        private ClothingGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private List<string> ageGroupField;

        private ClothingClothingSizeType clothingSizeTypeField;

        private bool clothingSizeTypeFieldSpecified;

        private bool isMaternityField;

        private bool isMaternityFieldSpecified;

        private List<string> patternField;

        private List<string> characterField;

        private List<string> occasionField;

        private ClothingApparelCategory apparelCategoryField;

        private bool apparelCategoryFieldSpecified;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private bool gotsCertificationField;

        private bool gotsCertificationFieldSpecified;

        private List<string> seasonField;

        private List<string> sportField;

        private object itemField;

        public Clothing()
        {
            this.sportField = new List<string>();
            this.seasonField = new List<string>();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.occasionField = new List<string>();
            this.characterField = new List<string>();
            this.patternField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string clothingSize
        {
            get
            {
                return this.clothingSizeField;
            }
            set
            {
                this.clothingSizeField = value;
            }
        }

        public ClothingGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public ClothingClothingSizeType clothingSizeType
        {
            get
            {
                return this.clothingSizeTypeField;
            }
            set
            {
                this.clothingSizeTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool clothingSizeTypeSpecified
        {
            get
            {
                return this.clothingSizeTypeFieldSpecified;
            }
            set
            {
                this.clothingSizeTypeFieldSpecified = value;
            }
        }

        public bool isMaternity
        {
            get
            {
                return this.isMaternityField;
            }
            set
            {
                this.isMaternityField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMaternitySpecified
        {
            get
            {
                return this.isMaternityFieldSpecified;
            }
            set
            {
                this.isMaternityFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public ClothingApparelCategory apparelCategory
        {
            get
            {
                return this.apparelCategoryField;
            }
            set
            {
                this.apparelCategoryField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool apparelCategorySpecified
        {
            get
            {
                return this.apparelCategoryFieldSpecified;
            }
            set
            {
                this.apparelCategoryFieldSpecified = value;
            }
        }

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        public bool gotsCertification
        {
            get
            {
                return this.gotsCertificationField;
            }
            set
            {
                this.gotsCertificationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool gotsCertificationSpecified
        {
            get
            {
                return this.gotsCertificationFieldSpecified;
            }
            set
            {
                this.gotsCertificationFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("seasonValue", IsNullable = false)]
        public List<string> season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("sportValue", IsNullable = false)]
        public List<string> sport
        {
            get
            {
                return this.sportField;
            }
            set
            {
                this.sportField = value;
            }
        }

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

    public enum ClothingGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public enum ClothingClothingSizeType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Junior Plus")]
        JuniorPlus,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Petite Plus")]
        PetitePlus,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Big  Tall")]
        BigTall,

        /// <remarks/>
        Plus,

        /// <remarks/>
        Juniors,

        /// <remarks/>
        Regular,

        /// <remarks/>
        Big,

        /// <remarks/>
        Husky,

        /// <remarks/>
        Slim,

        /// <remarks/>
        Tall,

        /// <remarks/>
        Petite,
    }

    public enum ClothingApparelCategory
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Young Men\'s")]
        YoungMens,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Maternity Plus")]
        MaternityPlus,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("School Uniforms")]
        SchoolUniforms,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Men\'s Big  Tall")]
        MensBigTall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Women\'s Plus")]
        WomensPlus,

        /// <remarks/>
        Petites,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Maternity Wear")]
        MaternityWear,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Newborn Girl")]
        NewbornGirl,

        /// <remarks/>
        Boys,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Baby Boy")]
        BabyBoy,

        /// <remarks/>
        Girls,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Baby Girl")]
        BabyGirl,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Newborn Boy")]
        NewbornBoy,

        /// <remarks/>
        Juniors,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,
    }

    public partial class Bras
    {

        private string braStyleField;

        private BraSize braSizeField;

        public Bras()
        {
            this.braSizeField = new BraSize();
        }

        public string braStyle
        {
            get
            {
                return this.braStyleField;
            }
            set
            {
                this.braStyleField = value;
            }
        }

        public BraSize braSize
        {
            get
            {
                return this.braSizeField;
            }
            set
            {
                this.braSizeField = value;
            }
        }
    }

    public partial class BraSize
    {

        private decimal braBandSizeField;

        private bool braBandSizeFieldSpecified;

        private string braCupSizeField;

        public decimal braBandSize
        {
            get
            {
                return this.braBandSizeField;
            }
            set
            {
                this.braBandSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool braBandSizeSpecified
        {
            get
            {
                return this.braBandSizeFieldSpecified;
            }
            set
            {
                this.braBandSizeFieldSpecified = value;
            }
        }

        public string braCupSize
        {
            get
            {
                return this.braCupSizeField;
            }
            set
            {
                this.braCupSizeField = value;
            }
        }
    }

    public partial class ClothingAccessories
    {

        private List<string> materialField;

        public ClothingAccessories()
        {
            this.materialField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }
    }

    public partial class DressShirts
    {

        private DressShirtSize dressShirtSizeField;

        private string collarTypeField;

        private string sleeveStyleField;

        public DressShirts()
        {
            this.dressShirtSizeField = new DressShirtSize();
        }

        public DressShirtSize dressShirtSize
        {
            get
            {
                return this.dressShirtSizeField;
            }
            set
            {
                this.dressShirtSizeField = value;
            }
        }

        public string collarType
        {
            get
            {
                return this.collarTypeField;
            }
            set
            {
                this.collarTypeField = value;
            }
        }

        public string sleeveStyle
        {
            get
            {
                return this.sleeveStyleField;
            }
            set
            {
                this.sleeveStyleField = value;
            }
        }
    }

    public partial class DressShirtSize
    {

        private decimal neckSizeField;

        private decimal sleeveLengthField;

        private bool sleeveLengthFieldSpecified;

        public decimal neckSize
        {
            get
            {
                return this.neckSizeField;
            }
            set
            {
                this.neckSizeField = value;
            }
        }

        public decimal sleeveLength
        {
            get
            {
                return this.sleeveLengthField;
            }
            set
            {
                this.sleeveLengthField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sleeveLengthSpecified
        {
            get
            {
                return this.sleeveLengthFieldSpecified;
            }
            set
            {
                this.sleeveLengthFieldSpecified = value;
            }
        }
    }

    public partial class Dresses
    {

        private string skirtAndDressCutField;

        private string dressStyleField;

        private string sleeveStyleField;

        public string skirtAndDressCut
        {
            get
            {
                return this.skirtAndDressCutField;
            }
            set
            {
                this.skirtAndDressCutField = value;
            }
        }

        public string dressStyle
        {
            get
            {
                return this.dressStyleField;
            }
            set
            {
                this.dressStyleField = value;
            }
        }

        public string sleeveStyle
        {
            get
            {
                return this.sleeveStyleField;
            }
            set
            {
                this.sleeveStyleField = value;
            }
        }
    }

    public partial class Panties
    {

        private string pantySizeField;

        private string pantyStyleField;

        public string pantySize
        {
            get
            {
                return this.pantySizeField;
            }
            set
            {
                this.pantySizeField = value;
            }
        }

        public string pantyStyle
        {
            get
            {
                return this.pantyStyleField;
            }
            set
            {
                this.pantyStyleField = value;
            }
        }
    }

    public partial class PantsAndShorts
    {

        private PantSize pantSizeField;

        private string pantRiseField;

        private string pantStyleField;

        private string pantPanelStyleField;

        public PantsAndShorts()
        {
            this.pantSizeField = new PantSize();
        }

        public PantSize pantSize
        {
            get
            {
                return this.pantSizeField;
            }
            set
            {
                this.pantSizeField = value;
            }
        }

        public string pantRise
        {
            get
            {
                return this.pantRiseField;
            }
            set
            {
                this.pantRiseField = value;
            }
        }

        public string pantStyle
        {
            get
            {
                return this.pantStyleField;
            }
            set
            {
                this.pantStyleField = value;
            }
        }

        public string pantPanelStyle
        {
            get
            {
                return this.pantPanelStyleField;
            }
            set
            {
                this.pantPanelStyleField = value;
            }
        }
    }

    public partial class PantSize
    {

        private decimal inseamField;

        private bool inseamFieldSpecified;

        private LengthUnit waistSizeField;

        public PantSize()
        {
            this.waistSizeField = new LengthUnit();
        }

        public decimal inseam
        {
            get
            {
                return this.inseamField;
            }
            set
            {
                this.inseamField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inseamSpecified
        {
            get
            {
                return this.inseamFieldSpecified;
            }
            set
            {
                this.inseamFieldSpecified = value;
            }
        }

        public LengthUnit waistSize
        {
            get
            {
                return this.waistSizeField;
            }
            set
            {
                this.waistSizeField = value;
            }
        }
    }

    public partial class ShirtsAndTops
    {

        private string shirtSizeField;

        private string shirtNeckStyleField;

        private string sleeveStyleField;

        public string shirtSize
        {
            get
            {
                return this.shirtSizeField;
            }
            set
            {
                this.shirtSizeField = value;
            }
        }

        public string shirtNeckStyle
        {
            get
            {
                return this.shirtNeckStyleField;
            }
            set
            {
                this.shirtNeckStyleField = value;
            }
        }

        public string sleeveStyle
        {
            get
            {
                return this.sleeveStyleField;
            }
            set
            {
                this.sleeveStyleField = value;
            }
        }
    }

    public partial class Skirts
    {

        private LengthUnit waistSizeField;

        private string skirtAndDressCutField;

        public Skirts()
        {
            this.waistSizeField = new LengthUnit();
        }

        public LengthUnit waistSize
        {
            get
            {
                return this.waistSizeField;
            }
            set
            {
                this.waistSizeField = value;
            }
        }

        public string skirtAndDressCut
        {
            get
            {
                return this.skirtAndDressCutField;
            }
            set
            {
                this.skirtAndDressCutField = value;
            }
        }
    }

    public partial class Socks
    {

        private string sockSizeField;

        private string sockStyleField;

        public string sockSize
        {
            get
            {
                return this.sockSizeField;
            }
            set
            {
                this.sockSizeField = value;
            }
        }

        public string sockStyle
        {
            get
            {
                return this.sockStyleField;
            }
            set
            {
                this.sockStyleField = value;
            }
        }
    }

    public partial class WomensSwimsuits
    {

        private BraSize braSizeField;

        private string swimsuitStyleField;

        public WomensSwimsuits()
        {
            this.braSizeField = new BraSize();
        }

        public BraSize braSize
        {
            get
            {
                return this.braSizeField;
            }
            set
            {
                this.braSizeField = value;
            }
        }

        public string swimsuitStyle
        {
            get
            {
                return this.swimsuitStyleField;
            }
            set
            {
                this.swimsuitStyleField = value;
            }
        }
    }

    public partial class Electronics
    {

        private List<swatchImage> swatchImagesField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private bool isEnergyGuideLabelRequiredField;

        private bool isEnergyGuideLabelRequiredFieldSpecified;

        private string energyGuideLabelField;

        private bool hasSignalBoosterField;

        private bool hasSignalBoosterFieldSpecified;

        private bool hasWirelessMicrophoneField;

        private bool hasWirelessMicrophoneFieldSpecified;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private List<string> colorField;

        private List<string> ageGroupField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private List<string> connectionsField;

        private List<string> materialField;

        private string numberOfPiecesField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private bool isCordlessField;

        private bool isCordlessFieldSpecified;

        private List<string> recommendedUsesField;

        private List<string> recommendedLocationsField;

        private string audioPowerOutputField;

        private PowerUnit peakAudioPowerCapacityField;

        private List<string> audioFeaturesField;

        private string numberOfChannelsField;

        private string resolutionField;

        private string platformField;

        private object itemField;

        public Electronics()
        {
            this.audioFeaturesField = new List<string>();
            this.peakAudioPowerCapacityField = new PowerUnit();
            this.recommendedLocationsField = new List<string>();
            this.recommendedUsesField = new List<string>();
            this.materialField = new List<string>();
            this.connectionsField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        public bool isEnergyGuideLabelRequired
        {
            get
            {
                return this.isEnergyGuideLabelRequiredField;
            }
            set
            {
                this.isEnergyGuideLabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyGuideLabelRequiredSpecified
        {
            get
            {
                return this.isEnergyGuideLabelRequiredFieldSpecified;
            }
            set
            {
                this.isEnergyGuideLabelRequiredFieldSpecified = value;
            }
        }

        public string energyGuideLabel
        {
            get
            {
                return this.energyGuideLabelField;
            }
            set
            {
                this.energyGuideLabelField = value;
            }
        }

        public bool hasSignalBooster
        {
            get
            {
                return this.hasSignalBoosterField;
            }
            set
            {
                this.hasSignalBoosterField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSignalBoosterSpecified
        {
            get
            {
                return this.hasSignalBoosterFieldSpecified;
            }
            set
            {
                this.hasSignalBoosterFieldSpecified = value;
            }
        }

        public bool hasWirelessMicrophone
        {
            get
            {
                return this.hasWirelessMicrophoneField;
            }
            set
            {
                this.hasWirelessMicrophoneField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWirelessMicrophoneSpecified
        {
            get
            {
                return this.hasWirelessMicrophoneFieldSpecified;
            }
            set
            {
                this.hasWirelessMicrophoneFieldSpecified = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public bool isEnergyStarCertified
        {
            get
            {
                return this.isEnergyStarCertifiedField;
            }
            set
            {
                this.isEnergyStarCertifiedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyStarCertifiedSpecified
        {
            get
            {
                return this.isEnergyStarCertifiedFieldSpecified;
            }
            set
            {
                this.isEnergyStarCertifiedFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("connection", IsNullable = false)]
        public List<string> connections
        {
            get
            {
                return this.connectionsField;
            }
            set
            {
                this.connectionsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        public string numberOfPieces
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

        public bool isRemoteControlIncluded
        {
            get
            {
                return this.isRemoteControlIncludedField;
            }
            set
            {
                this.isRemoteControlIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRemoteControlIncludedSpecified
        {
            get
            {
                return this.isRemoteControlIncludedFieldSpecified;
            }
            set
            {
                this.isRemoteControlIncludedFieldSpecified = value;
            }
        }

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        public bool isCordless
        {
            get
            {
                return this.isCordlessField;
            }
            set
            {
                this.isCordlessField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCordlessSpecified
        {
            get
            {
                return this.isCordlessFieldSpecified;
            }
            set
            {
                this.isCordlessFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedLocation", IsNullable = false)]
        public List<string> recommendedLocations
        {
            get
            {
                return this.recommendedLocationsField;
            }
            set
            {
                this.recommendedLocationsField = value;
            }
        }

        public string audioPowerOutput
        {
            get
            {
                return this.audioPowerOutputField;
            }
            set
            {
                this.audioPowerOutputField = value;
            }
        }

        public PowerUnit peakAudioPowerCapacity
        {
            get
            {
                return this.peakAudioPowerCapacityField;
            }
            set
            {
                this.peakAudioPowerCapacityField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("audioFeature", IsNullable = false)]
        public List<string> audioFeatures
        {
            get
            {
                return this.audioFeaturesField;
            }
            set
            {
                this.audioFeaturesField = value;
            }
        }

        public string numberOfChannels
        {
            get
            {
                return this.numberOfChannelsField;
            }
            set
            {
                this.numberOfChannelsField = value;
            }
        }

        public string resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }

        public string platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }

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

    public partial class PowerUnit
    {

        private PowerUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public PowerUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum PowerUnitOfMeasure
    {

        /// <remarks/>
        Horsepower,

        /// <remarks/>
        Joules,

        /// <remarks/>
        Decibels,

        /// <remarks/>
        Watts,
    }

    public partial class CellPhones
    {

        private string cellPhoneTypeField;

        private string resolutionField;

        private LengthUnit screenSizeField;

        private List<string> mobileOperatingSystemField;

        private string modelNameField;

        private string displayTechnologyField;

        private bool hasBluetoothField;

        private bool hasBluetoothFieldSpecified;

        private TimeUnit batteryLifeField;

        private string cellPhoneServiceProviderField;

        private string cellularNetworkTechnologyField;

        private ResolutionUnit frontFacingCameraMegapixelsField;

        private bool hasFlashField;

        private bool hasFlashFieldSpecified;

        private TimeUnit standbyTimeField;

        private TimeUnit talkTimeField;

        private ResolutionUnit rearCameraMegapixelsField;

        private DigitalCapacityUnit maximumRamSupportedField;

        private FrequencyUnit processorSpeedField;

        private List<string> processorTypeField;

        private DigitalCapacityUnit ramMemoryField;

        private List<string> wirelessTechnologiesField;

        public CellPhones()
        {
            this.wirelessTechnologiesField = new List<string>();
            this.ramMemoryField = new DigitalCapacityUnit();
            this.processorTypeField = new List<string>();
            this.processorSpeedField = new FrequencyUnit();
            this.maximumRamSupportedField = new DigitalCapacityUnit();
            this.rearCameraMegapixelsField = new ResolutionUnit();
            this.talkTimeField = new TimeUnit();
            this.standbyTimeField = new TimeUnit();
            this.frontFacingCameraMegapixelsField = new ResolutionUnit();
            this.batteryLifeField = new TimeUnit();
            this.mobileOperatingSystemField = new List<string>();
            this.screenSizeField = new LengthUnit();
        }

        public string cellPhoneType
        {
            get
            {
                return this.cellPhoneTypeField;
            }
            set
            {
                this.cellPhoneTypeField = value;
            }
        }

        public string resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }

        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("mobileOperatingSystemValue", IsNullable = false)]
        public List<string> mobileOperatingSystem
        {
            get
            {
                return this.mobileOperatingSystemField;
            }
            set
            {
                this.mobileOperatingSystemField = value;
            }
        }

        public string modelName
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

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        public bool hasBluetooth
        {
            get
            {
                return this.hasBluetoothField;
            }
            set
            {
                this.hasBluetoothField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasBluetoothSpecified
        {
            get
            {
                return this.hasBluetoothFieldSpecified;
            }
            set
            {
                this.hasBluetoothFieldSpecified = value;
            }
        }

        public TimeUnit batteryLife
        {
            get
            {
                return this.batteryLifeField;
            }
            set
            {
                this.batteryLifeField = value;
            }
        }

        public string cellPhoneServiceProvider
        {
            get
            {
                return this.cellPhoneServiceProviderField;
            }
            set
            {
                this.cellPhoneServiceProviderField = value;
            }
        }

        public string cellularNetworkTechnology
        {
            get
            {
                return this.cellularNetworkTechnologyField;
            }
            set
            {
                this.cellularNetworkTechnologyField = value;
            }
        }

        public ResolutionUnit frontFacingCameraMegapixels
        {
            get
            {
                return this.frontFacingCameraMegapixelsField;
            }
            set
            {
                this.frontFacingCameraMegapixelsField = value;
            }
        }

        public bool hasFlash
        {
            get
            {
                return this.hasFlashField;
            }
            set
            {
                this.hasFlashField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasFlashSpecified
        {
            get
            {
                return this.hasFlashFieldSpecified;
            }
            set
            {
                this.hasFlashFieldSpecified = value;
            }
        }

        public TimeUnit standbyTime
        {
            get
            {
                return this.standbyTimeField;
            }
            set
            {
                this.standbyTimeField = value;
            }
        }

        public TimeUnit talkTime
        {
            get
            {
                return this.talkTimeField;
            }
            set
            {
                this.talkTimeField = value;
            }
        }

        public ResolutionUnit rearCameraMegapixels
        {
            get
            {
                return this.rearCameraMegapixelsField;
            }
            set
            {
                this.rearCameraMegapixelsField = value;
            }
        }

        public DigitalCapacityUnit maximumRamSupported
        {
            get
            {
                return this.maximumRamSupportedField;
            }
            set
            {
                this.maximumRamSupportedField = value;
            }
        }

        public FrequencyUnit processorSpeed
        {
            get
            {
                return this.processorSpeedField;
            }
            set
            {
                this.processorSpeedField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("processorTypeValue", IsNullable = false)]
        public List<string> processorType
        {
            get
            {
                return this.processorTypeField;
            }
            set
            {
                this.processorTypeField = value;
            }
        }

        public DigitalCapacityUnit ramMemory
        {
            get
            {
                return this.ramMemoryField;
            }
            set
            {
                this.ramMemoryField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }

    public partial class ResolutionUnit
    {

        private ResolutionUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public ResolutionUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum ResolutionUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dots Per Square Inch")]
        DotsPerSquareInch,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Pixels Per Inch")]
        PixelsPerInch,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Volumetric Pixels")]
        VolumetricPixels,

        /// <remarks/>
        Megapixels,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Resolution Element")]
        ResolutionElement,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Surface Element")]
        SurfaceElement,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dots Per Inch")]
        DotsPerInch,

        /// <remarks/>
        Texels,
    }

    public partial class DigitalCapacityUnit
    {

        private DigitalCapacityUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public DigitalCapacityUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum DigitalCapacityUnitOfMeasure
    {

        /// <remarks/>
        Terabytes,

        /// <remarks/>
        Kibibytes,

        /// <remarks/>
        Mebibytes,

        /// <remarks/>
        Gibibytes,

        /// <remarks/>
        Kilobytes,

        /// <remarks/>
        Gigabytes,

        /// <remarks/>
        Tebibytes,

        /// <remarks/>
        Megabyte,
    }

    public partial class FrequencyUnit
    {

        private FrequencyUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public FrequencyUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum FrequencyUnitOfMeasure
    {

        /// <remarks/>
        Kilohertz,

        /// <remarks/>
        Gigahertz,

        /// <remarks/>
        Megahertz,

        /// <remarks/>
        Hertz,
    }

    public partial class ComputerComponents
    {

        private ComputerComponentsInternalExternal internalExternalField;

        private bool internalExternalFieldSpecified;

        private DigitalCapacityUnit hardDriveCapacityField;

        private List<string> cpuSocketTypeField;

        private List<string> motherboardFormFactorField;

        private DigitalCapacityUnit maximumRamSupportedField;

        private FrequencyUnit processorSpeedField;

        private List<string> processorTypeField;

        private DigitalCapacityUnit ramMemoryField;

        private List<string> wirelessTechnologiesField;

        public ComputerComponents()
        {
            this.wirelessTechnologiesField = new List<string>();
            this.ramMemoryField = new DigitalCapacityUnit();
            this.processorTypeField = new List<string>();
            this.processorSpeedField = new FrequencyUnit();
            this.maximumRamSupportedField = new DigitalCapacityUnit();
            this.motherboardFormFactorField = new List<string>();
            this.cpuSocketTypeField = new List<string>();
            this.hardDriveCapacityField = new DigitalCapacityUnit();
        }

        public ComputerComponentsInternalExternal internalExternal
        {
            get
            {
                return this.internalExternalField;
            }
            set
            {
                this.internalExternalField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool internalExternalSpecified
        {
            get
            {
                return this.internalExternalFieldSpecified;
            }
            set
            {
                this.internalExternalFieldSpecified = value;
            }
        }

        public DigitalCapacityUnit hardDriveCapacity
        {
            get
            {
                return this.hardDriveCapacityField;
            }
            set
            {
                this.hardDriveCapacityField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("cpuSocketTypeValue", IsNullable = false)]
        public List<string> cpuSocketType
        {
            get
            {
                return this.cpuSocketTypeField;
            }
            set
            {
                this.cpuSocketTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("motherboardFormFactorValue", IsNullable = false)]
        public List<string> motherboardFormFactor
        {
            get
            {
                return this.motherboardFormFactorField;
            }
            set
            {
                this.motherboardFormFactorField = value;
            }
        }

        public DigitalCapacityUnit maximumRamSupported
        {
            get
            {
                return this.maximumRamSupportedField;
            }
            set
            {
                this.maximumRamSupportedField = value;
            }
        }

        public FrequencyUnit processorSpeed
        {
            get
            {
                return this.processorSpeedField;
            }
            set
            {
                this.processorSpeedField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("processorTypeValue", IsNullable = false)]
        public List<string> processorType
        {
            get
            {
                return this.processorTypeField;
            }
            set
            {
                this.processorTypeField = value;
            }
        }

        public DigitalCapacityUnit ramMemory
        {
            get
            {
                return this.ramMemoryField;
            }
            set
            {
                this.ramMemoryField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }

    public enum ComputerComponentsInternalExternal
    {

        /// <remarks/>
        Internal,

        /// <remarks/>
        External,
    }

    public partial class Computers
    {

        private List<string> operatingSystemField;

        private bool hasFrontFacingCameraField;

        private bool hasFrontFacingCameraFieldSpecified;

        private string graphicsInformationField;

        private string opticalDriveField;

        private string formFactorField;

        private bool hasTouchscreenField;

        private bool hasTouchscreenFieldSpecified;

        private string resolutionField;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        private bool hasBluetoothField;

        private bool hasBluetoothFieldSpecified;

        private TimeUnit batteryLifeField;

        private ResolutionUnit frontFacingCameraMegapixelsField;

        private ResolutionUnit rearCameraMegapixelsField;

        private DigitalCapacityUnit hardDriveCapacityField;

        private DigitalCapacityUnit maximumRamSupportedField;

        private FrequencyUnit processorSpeedField;

        private List<string> processorTypeField;

        private DigitalCapacityUnit ramMemoryField;

        private List<string> wirelessTechnologiesField;

        public Computers()
        {
            this.wirelessTechnologiesField = new List<string>();
            this.ramMemoryField = new DigitalCapacityUnit();
            this.processorTypeField = new List<string>();
            this.processorSpeedField = new FrequencyUnit();
            this.maximumRamSupportedField = new DigitalCapacityUnit();
            this.hardDriveCapacityField = new DigitalCapacityUnit();
            this.rearCameraMegapixelsField = new ResolutionUnit();
            this.frontFacingCameraMegapixelsField = new ResolutionUnit();
            this.batteryLifeField = new TimeUnit();
            this.screenSizeField = new LengthUnit();
            this.operatingSystemField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("operatingSystemValue", IsNullable = false)]
        public List<string> operatingSystem
        {
            get
            {
                return this.operatingSystemField;
            }
            set
            {
                this.operatingSystemField = value;
            }
        }

        public bool hasFrontFacingCamera
        {
            get
            {
                return this.hasFrontFacingCameraField;
            }
            set
            {
                this.hasFrontFacingCameraField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasFrontFacingCameraSpecified
        {
            get
            {
                return this.hasFrontFacingCameraFieldSpecified;
            }
            set
            {
                this.hasFrontFacingCameraFieldSpecified = value;
            }
        }

        public string graphicsInformation
        {
            get
            {
                return this.graphicsInformationField;
            }
            set
            {
                this.graphicsInformationField = value;
            }
        }

        public string opticalDrive
        {
            get
            {
                return this.opticalDriveField;
            }
            set
            {
                this.opticalDriveField = value;
            }
        }

        public string formFactor
        {
            get
            {
                return this.formFactorField;
            }
            set
            {
                this.formFactorField = value;
            }
        }

        public bool hasTouchscreen
        {
            get
            {
                return this.hasTouchscreenField;
            }
            set
            {
                this.hasTouchscreenField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasTouchscreenSpecified
        {
            get
            {
                return this.hasTouchscreenFieldSpecified;
            }
            set
            {
                this.hasTouchscreenFieldSpecified = value;
            }
        }

        public string resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }

        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        public bool hasBluetooth
        {
            get
            {
                return this.hasBluetoothField;
            }
            set
            {
                this.hasBluetoothField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasBluetoothSpecified
        {
            get
            {
                return this.hasBluetoothFieldSpecified;
            }
            set
            {
                this.hasBluetoothFieldSpecified = value;
            }
        }

        public TimeUnit batteryLife
        {
            get
            {
                return this.batteryLifeField;
            }
            set
            {
                this.batteryLifeField = value;
            }
        }

        public ResolutionUnit frontFacingCameraMegapixels
        {
            get
            {
                return this.frontFacingCameraMegapixelsField;
            }
            set
            {
                this.frontFacingCameraMegapixelsField = value;
            }
        }

        public ResolutionUnit rearCameraMegapixels
        {
            get
            {
                return this.rearCameraMegapixelsField;
            }
            set
            {
                this.rearCameraMegapixelsField = value;
            }
        }

        public DigitalCapacityUnit hardDriveCapacity
        {
            get
            {
                return this.hardDriveCapacityField;
            }
            set
            {
                this.hardDriveCapacityField = value;
            }
        }

        public DigitalCapacityUnit maximumRamSupported
        {
            get
            {
                return this.maximumRamSupportedField;
            }
            set
            {
                this.maximumRamSupportedField = value;
            }
        }

        public FrequencyUnit processorSpeed
        {
            get
            {
                return this.processorSpeedField;
            }
            set
            {
                this.processorSpeedField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("processorTypeValue", IsNullable = false)]
        public List<string> processorType
        {
            get
            {
                return this.processorTypeField;
            }
            set
            {
                this.processorTypeField = value;
            }
        }

        public DigitalCapacityUnit ramMemory
        {
            get
            {
                return this.ramMemoryField;
            }
            set
            {
                this.ramMemoryField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }

    public partial class ElectronicsAccessories
    {

        private List<string> recordableMediaFormatsField;

        private List<string> compatibleBrandsField;

        private List<string> compatibleDevicesField;

        private List<string> wirelessTechnologiesField;

        private string tvAndMonitorMountTypeField;

        private LengthUnit minimumScreenSizeField;

        private LengthUnit maximumScreenSizeField;

        private WeightUnit maximumLoadWeightField;

        private List<string> headphoneFeaturesField;

        public ElectronicsAccessories()
        {
            this.headphoneFeaturesField = new List<string>();
            this.maximumLoadWeightField = new WeightUnit();
            this.maximumScreenSizeField = new LengthUnit();
            this.minimumScreenSizeField = new LengthUnit();
            this.wirelessTechnologiesField = new List<string>();
            this.compatibleDevicesField = new List<string>();
            this.compatibleBrandsField = new List<string>();
            this.recordableMediaFormatsField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recordableMediaFormat", IsNullable = false)]
        public List<string> recordableMediaFormats
        {
            get
            {
                return this.recordableMediaFormatsField;
            }
            set
            {
                this.recordableMediaFormatsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleBrand", IsNullable = false)]
        public List<string> compatibleBrands
        {
            get
            {
                return this.compatibleBrandsField;
            }
            set
            {
                this.compatibleBrandsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleDevice", IsNullable = false)]
        public List<string> compatibleDevices
        {
            get
            {
                return this.compatibleDevicesField;
            }
            set
            {
                this.compatibleDevicesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }

        public string tvAndMonitorMountType
        {
            get
            {
                return this.tvAndMonitorMountTypeField;
            }
            set
            {
                this.tvAndMonitorMountTypeField = value;
            }
        }

        public LengthUnit minimumScreenSize
        {
            get
            {
                return this.minimumScreenSizeField;
            }
            set
            {
                this.minimumScreenSizeField = value;
            }
        }

        public LengthUnit maximumScreenSize
        {
            get
            {
                return this.maximumScreenSizeField;
            }
            set
            {
                this.maximumScreenSizeField = value;
            }
        }

        public WeightUnit maximumLoadWeight
        {
            get
            {
                return this.maximumLoadWeightField;
            }
            set
            {
                this.maximumLoadWeightField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("headphoneFeature", IsNullable = false)]
        public List<string> headphoneFeatures
        {
            get
            {
                return this.headphoneFeaturesField;
            }
            set
            {
                this.headphoneFeaturesField = value;
            }
        }
    }

    public partial class ElectronicsCables
    {

        private string connectorFinishField;

        private LengthUnit cableLengthField;

        private string numberOfTwistedPairsPerCableField;

        private List<string> compatibleDevicesField;

        public ElectronicsCables()
        {
            this.compatibleDevicesField = new List<string>();
            this.cableLengthField = new LengthUnit();
        }

        public string connectorFinish
        {
            get
            {
                return this.connectorFinishField;
            }
            set
            {
                this.connectorFinishField = value;
            }
        }

        public LengthUnit cableLength
        {
            get
            {
                return this.cableLengthField;
            }
            set
            {
                this.cableLengthField = value;
            }
        }

        public string numberOfTwistedPairsPerCable
        {
            get
            {
                return this.numberOfTwistedPairsPerCableField;
            }
            set
            {
                this.numberOfTwistedPairsPerCableField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleDevice", IsNullable = false)]
        public List<string> compatibleDevices
        {
            get
            {
                return this.compatibleDevicesField;
            }
            set
            {
                this.compatibleDevicesField = value;
            }
        }
    }

    public partial class PrintersScannersAndImaging
    {

        private bool hasAutomaticDocumentFeederField;

        private bool hasAutomaticDocumentFeederFieldSpecified;

        private bool hasAutomaticTwoSidedPrintingField;

        private bool hasAutomaticTwoSidedPrintingFieldSpecified;

        private decimal colorPagesPerMinuteField;

        private bool colorPagesPerMinuteFieldSpecified;

        private string maximumDocumentSizeField;

        private ResolutionUnit maximumPrintResolutionField;

        private ResolutionUnit maximumScannerResolutionField;

        private PrintersScannersAndImagingMonochromeColor monochromeColorField;

        private bool monochromeColorFieldSpecified;

        private string printingTechnologyField;

        private decimal monochromePagesPerMinuteField;

        private bool monochromePagesPerMinuteFieldSpecified;

        private List<string> wirelessTechnologiesField;

        public PrintersScannersAndImaging()
        {
            this.wirelessTechnologiesField = new List<string>();
            this.maximumScannerResolutionField = new ResolutionUnit();
            this.maximumPrintResolutionField = new ResolutionUnit();
        }

        public bool hasAutomaticDocumentFeeder
        {
            get
            {
                return this.hasAutomaticDocumentFeederField;
            }
            set
            {
                this.hasAutomaticDocumentFeederField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticDocumentFeederSpecified
        {
            get
            {
                return this.hasAutomaticDocumentFeederFieldSpecified;
            }
            set
            {
                this.hasAutomaticDocumentFeederFieldSpecified = value;
            }
        }

        public bool hasAutomaticTwoSidedPrinting
        {
            get
            {
                return this.hasAutomaticTwoSidedPrintingField;
            }
            set
            {
                this.hasAutomaticTwoSidedPrintingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticTwoSidedPrintingSpecified
        {
            get
            {
                return this.hasAutomaticTwoSidedPrintingFieldSpecified;
            }
            set
            {
                this.hasAutomaticTwoSidedPrintingFieldSpecified = value;
            }
        }

        public decimal colorPagesPerMinute
        {
            get
            {
                return this.colorPagesPerMinuteField;
            }
            set
            {
                this.colorPagesPerMinuteField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colorPagesPerMinuteSpecified
        {
            get
            {
                return this.colorPagesPerMinuteFieldSpecified;
            }
            set
            {
                this.colorPagesPerMinuteFieldSpecified = value;
            }
        }

        public string maximumDocumentSize
        {
            get
            {
                return this.maximumDocumentSizeField;
            }
            set
            {
                this.maximumDocumentSizeField = value;
            }
        }

        public ResolutionUnit maximumPrintResolution
        {
            get
            {
                return this.maximumPrintResolutionField;
            }
            set
            {
                this.maximumPrintResolutionField = value;
            }
        }

        public ResolutionUnit maximumScannerResolution
        {
            get
            {
                return this.maximumScannerResolutionField;
            }
            set
            {
                this.maximumScannerResolutionField = value;
            }
        }

        public PrintersScannersAndImagingMonochromeColor monochromeColor
        {
            get
            {
                return this.monochromeColorField;
            }
            set
            {
                this.monochromeColorField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monochromeColorSpecified
        {
            get
            {
                return this.monochromeColorFieldSpecified;
            }
            set
            {
                this.monochromeColorFieldSpecified = value;
            }
        }

        public string printingTechnology
        {
            get
            {
                return this.printingTechnologyField;
            }
            set
            {
                this.printingTechnologyField = value;
            }
        }

        public decimal monochromePagesPerMinute
        {
            get
            {
                return this.monochromePagesPerMinuteField;
            }
            set
            {
                this.monochromePagesPerMinuteField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monochromePagesPerMinuteSpecified
        {
            get
            {
                return this.monochromePagesPerMinuteFieldSpecified;
            }
            set
            {
                this.monochromePagesPerMinuteFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }

    public enum PrintersScannersAndImagingMonochromeColor
    {

        /// <remarks/>
        Monochrome,

        /// <remarks/>
        Color,
    }

    public partial class Software
    {

        private List<string> softwareCategoryField;

        private List<string> systemRequirementsField;

        private string versionField;

        private string numberOfUsersField;

        private string softwareFormatField;

        private string requiredPeripheralsField;

        private List<string> educationalFocusField;

        private List<string> operatingSystemField;

        public Software()
        {
            this.operatingSystemField = new List<string>();
            this.educationalFocusField = new List<string>();
            this.systemRequirementsField = new List<string>();
            this.softwareCategoryField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("softwareCategoryValue", IsNullable = false)]
        public List<string> softwareCategory
        {
            get
            {
                return this.softwareCategoryField;
            }
            set
            {
                this.softwareCategoryField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("systemRequirement", IsNullable = false)]
        public List<string> systemRequirements
        {
            get
            {
                return this.systemRequirementsField;
            }
            set
            {
                this.systemRequirementsField = value;
            }
        }

        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        public string numberOfUsers
        {
            get
            {
                return this.numberOfUsersField;
            }
            set
            {
                this.numberOfUsersField = value;
            }
        }

        public string softwareFormat
        {
            get
            {
                return this.softwareFormatField;
            }
            set
            {
                this.softwareFormatField = value;
            }
        }

        public string requiredPeripherals
        {
            get
            {
                return this.requiredPeripheralsField;
            }
            set
            {
                this.requiredPeripheralsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("educationalFocu", IsNullable = false)]
        public List<string> educationalFocus
        {
            get
            {
                return this.educationalFocusField;
            }
            set
            {
                this.educationalFocusField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("operatingSystemValue", IsNullable = false)]
        public List<string> operatingSystem
        {
            get
            {
                return this.operatingSystemField;
            }
            set
            {
                this.operatingSystemField = value;
            }
        }
    }

    public partial class TVsAndVideoDisplays
    {

        private List<string> televisionTypeField;

        private bool hasTouchscreenField;

        private bool hasTouchscreenFieldSpecified;

        private string backlightTypeField;

        private FrequencyUnit refreshRateField;

        private TimeUnit responseTimeField;

        private string aspectRatioField;

        private string nativeResolutionField;

        private string maximumContrastRatioField;

        private List<inputsAndOutput> inputsAndOutputsField;

        private bool hasIntegratedSpeakersField;

        private bool hasIntegratedSpeakersFieldSpecified;

        private string resolutionField;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        private List<string> wirelessTechnologiesField;

        public TVsAndVideoDisplays()
        {
            this.wirelessTechnologiesField = new List<string>();
            this.screenSizeField = new LengthUnit();
            this.inputsAndOutputsField = new List<inputsAndOutput>();
            this.responseTimeField = new TimeUnit();
            this.refreshRateField = new FrequencyUnit();
            this.televisionTypeField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("televisionTypeValue", IsNullable = false)]
        public List<string> televisionType
        {
            get
            {
                return this.televisionTypeField;
            }
            set
            {
                this.televisionTypeField = value;
            }
        }

        public bool hasTouchscreen
        {
            get
            {
                return this.hasTouchscreenField;
            }
            set
            {
                this.hasTouchscreenField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasTouchscreenSpecified
        {
            get
            {
                return this.hasTouchscreenFieldSpecified;
            }
            set
            {
                this.hasTouchscreenFieldSpecified = value;
            }
        }

        public string backlightType
        {
            get
            {
                return this.backlightTypeField;
            }
            set
            {
                this.backlightTypeField = value;
            }
        }

        public FrequencyUnit refreshRate
        {
            get
            {
                return this.refreshRateField;
            }
            set
            {
                this.refreshRateField = value;
            }
        }

        public TimeUnit responseTime
        {
            get
            {
                return this.responseTimeField;
            }
            set
            {
                this.responseTimeField = value;
            }
        }

        public string aspectRatio
        {
            get
            {
                return this.aspectRatioField;
            }
            set
            {
                this.aspectRatioField = value;
            }
        }

        public string nativeResolution
        {
            get
            {
                return this.nativeResolutionField;
            }
            set
            {
                this.nativeResolutionField = value;
            }
        }

        public string maximumContrastRatio
        {
            get
            {
                return this.maximumContrastRatioField;
            }
            set
            {
                this.maximumContrastRatioField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<inputsAndOutput> inputsAndOutputs
        {
            get
            {
                return this.inputsAndOutputsField;
            }
            set
            {
                this.inputsAndOutputsField = value;
            }
        }

        public bool hasIntegratedSpeakers
        {
            get
            {
                return this.hasIntegratedSpeakersField;
            }
            set
            {
                this.hasIntegratedSpeakersField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasIntegratedSpeakersSpecified
        {
            get
            {
                return this.hasIntegratedSpeakersFieldSpecified;
            }
            set
            {
                this.hasIntegratedSpeakersFieldSpecified = value;
            }
        }

        public string resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }

        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }

    public partial class inputsAndOutput
    {

        private string inputOutputTypeField;

        private string inputOutputQuantityField;

        public string inputOutputType
        {
            get
            {
                return this.inputOutputTypeField;
            }
            set
            {
                this.inputOutputTypeField = value;
            }
        }

        public string inputOutputQuantity
        {
            get
            {
                return this.inputOutputQuantityField;
            }
            set
            {
                this.inputOutputQuantityField = value;
            }
        }
    }

    public partial class VideoGames
    {

        private string videoGameGenreField;

        private VideoGamesEsrbRating esrbRatingField;

        private List<string> sportField;

        private List<string> targetAudienceField;

        private bool isOnlineMultiplayerAvailableField;

        private bool isOnlineMultiplayerAvailableFieldSpecified;

        private bool isDownloadableContentAvailableField;

        private bool isDownloadableContentAvailableFieldSpecified;

        private string editionField;

        private string videoGameCollectionField;

        private string requiredPeripheralsField;

        private string platformField;

        public VideoGames()
        {
            this.targetAudienceField = new List<string>();
            this.sportField = new List<string>();
        }

        public string videoGameGenre
        {
            get
            {
                return this.videoGameGenreField;
            }
            set
            {
                this.videoGameGenreField = value;
            }
        }

        public VideoGamesEsrbRating esrbRating
        {
            get
            {
                return this.esrbRatingField;
            }
            set
            {
                this.esrbRatingField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("sportValue", IsNullable = false)]
        public List<string> sport
        {
            get
            {
                return this.sportField;
            }
            set
            {
                this.sportField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("targetAudienceValue", IsNullable = false)]
        public List<string> targetAudience
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

        public bool isOnlineMultiplayerAvailable
        {
            get
            {
                return this.isOnlineMultiplayerAvailableField;
            }
            set
            {
                this.isOnlineMultiplayerAvailableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOnlineMultiplayerAvailableSpecified
        {
            get
            {
                return this.isOnlineMultiplayerAvailableFieldSpecified;
            }
            set
            {
                this.isOnlineMultiplayerAvailableFieldSpecified = value;
            }
        }

        public bool isDownloadableContentAvailable
        {
            get
            {
                return this.isDownloadableContentAvailableField;
            }
            set
            {
                this.isDownloadableContentAvailableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDownloadableContentAvailableSpecified
        {
            get
            {
                return this.isDownloadableContentAvailableFieldSpecified;
            }
            set
            {
                this.isDownloadableContentAvailableFieldSpecified = value;
            }
        }

        public string edition
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

        public string videoGameCollection
        {
            get
            {
                return this.videoGameCollectionField;
            }
            set
            {
                this.videoGameCollectionField = value;
            }
        }

        public string requiredPeripherals
        {
            get
            {
                return this.requiredPeripheralsField;
            }
            set
            {
                this.requiredPeripheralsField = value;
            }
        }

        public string platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }
    }

    public enum VideoGamesEsrbRating
    {

        /// <remarks/>
        Pending,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Adults Only")]
        AdultsOnly,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Everyone 10+")]
        Everyone10,

        /// <remarks/>
        Everyone,

        /// <remarks/>
        Mature,

        /// <remarks/>
        Teen,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Early Childhood")]
        EarlyChildhood,

        /// <remarks/>
        Unrated,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Not Rated")]
        NotRated,
    }

    public partial class VideoProjectors
    {

        private string aspectRatioField;

        private BrightnessUnit brightnessField;

        private string nativeResolutionField;

        private string maximumContrastRatioField;

        private string throwRatioField;

        private TimeUnit lampLifeField;

        private bool has3dCapabilitiesField;

        private bool has3dCapabilitiesFieldSpecified;

        private List<inputsAndOutput> inputsAndOutputsField;

        private bool hasIntegratedSpeakersField;

        private bool hasIntegratedSpeakersFieldSpecified;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        private List<string> wirelessTechnologiesField;

        public VideoProjectors()
        {
            this.wirelessTechnologiesField = new List<string>();
            this.screenSizeField = new LengthUnit();
            this.inputsAndOutputsField = new List<inputsAndOutput>();
            this.lampLifeField = new TimeUnit();
            this.brightnessField = new BrightnessUnit();
        }

        public string aspectRatio
        {
            get
            {
                return this.aspectRatioField;
            }
            set
            {
                this.aspectRatioField = value;
            }
        }

        public BrightnessUnit brightness
        {
            get
            {
                return this.brightnessField;
            }
            set
            {
                this.brightnessField = value;
            }
        }

        public string nativeResolution
        {
            get
            {
                return this.nativeResolutionField;
            }
            set
            {
                this.nativeResolutionField = value;
            }
        }

        public string maximumContrastRatio
        {
            get
            {
                return this.maximumContrastRatioField;
            }
            set
            {
                this.maximumContrastRatioField = value;
            }
        }

        public string throwRatio
        {
            get
            {
                return this.throwRatioField;
            }
            set
            {
                this.throwRatioField = value;
            }
        }

        public TimeUnit lampLife
        {
            get
            {
                return this.lampLifeField;
            }
            set
            {
                this.lampLifeField = value;
            }
        }

        public bool has3dCapabilities
        {
            get
            {
                return this.has3dCapabilitiesField;
            }
            set
            {
                this.has3dCapabilitiesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool has3dCapabilitiesSpecified
        {
            get
            {
                return this.has3dCapabilitiesFieldSpecified;
            }
            set
            {
                this.has3dCapabilitiesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<inputsAndOutput> inputsAndOutputs
        {
            get
            {
                return this.inputsAndOutputsField;
            }
            set
            {
                this.inputsAndOutputsField = value;
            }
        }

        public bool hasIntegratedSpeakers
        {
            get
            {
                return this.hasIntegratedSpeakersField;
            }
            set
            {
                this.hasIntegratedSpeakersField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasIntegratedSpeakersSpecified
        {
            get
            {
                return this.hasIntegratedSpeakersFieldSpecified;
            }
            set
            {
                this.hasIntegratedSpeakersFieldSpecified = value;
            }
        }

        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }

    public partial class BrightnessUnit
    {

        private BrightnessUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public BrightnessUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum BrightnessUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Lumen Seconds Per Meter")]
        LumenSecondsPerMeter,

        /// <remarks/>
        Lumens,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Candelas Per Square Meter")]
        CandelasPerSquareMeter,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Lumens Per Watt")]
        LumensPerWatt,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Lux Seconds")]
        LuxSeconds,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Lumen Seconds")]
        LumenSeconds,

        /// <remarks/>
        Candelas,

        /// <remarks/>
        Lux,
    }

    public partial class FoodAndBeverage
    {

        private bool isNutritionFactsLabelRequiredField;


        private string nutritionFactsLabelField;

        private string foodFormField;

        private bool isImitationField;

        private bool isImitationFieldSpecified;

        private List<string> foodAllergenStatementsField;

        private bool usdaInspectedField;

        private bool usdaInspectedFieldSpecified;

        private string vintageField;

        private TimeUnit timeAgedField;

        private List<string> variantAttributeNamesField;

        private bool isGmoFreeField;

        private bool isGmoFreeFieldSpecified;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private bool isBpaFreeField;

        private bool isBpaFreeFieldSpecified;

        private bool isPotentiallyHazardousFoodField;

        private bool isPotentiallyHazardousFoodFieldSpecified;

        private bool isReadyToEatField;

        private bool isReadyToEatFieldSpecified;

        private string caffeineDesignationField;

        private string brandField;

        private string manufacturerField;

        private string spiceLevelField;

        private string flavorField;

        private string beefCutField;

        private string poultryCutField;

        private List<string> colorField;

        private bool isMadeInHomeKitchenField;

        private bool isMadeInHomeKitchenFieldSpecified;

        private List<string> nutrientContentClaimsField;

        private string safeHandlingInstructionsField;

        private List<string> characterField;

        private List<string> occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private decimal fatCaloriesPerGramField;

        private bool fatCaloriesPerGramFieldSpecified;

        private List<string> recommendedUsesField;

        private decimal carbohydrateCaloriesPerGramField;

        private bool carbohydrateCaloriesPerGramFieldSpecified;

        private WeightUnit totalProteinField;

        private PercentageUnit totalProteinPercentageDailyValueField;

        private decimal proteinCaloriesPerGramField;

        private bool proteinCaloriesPerGramFieldSpecified;

        private bool isFairTradeField;

        private bool isFairTradeFieldSpecified;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private string ingredientsField;

        private System.DateTime releaseDateField;

        private bool releaseDateFieldSpecified;

        private string servingSizeField;

        private decimal servingsPerContainerField;

        private bool servingsPerContainerFieldSpecified;

        private List<string> organicCertificationsField;

        private string instructionsField;

        private decimal caloriesField;

        private bool caloriesFieldSpecified;

        private WeightUnit caloriesFromFatField;

        private WeightUnit totalFatField;

        private PercentageUnit totalFatPercentageDailyValueField;

        private WeightUnit totalCarbohydrateField;

        private PercentageUnit totalCarbohydratePercentageDailyValueField;

        private List<nutrient> nutrientsField;

        private AlcoholicBeverages itemField;

        public FoodAndBeverage()
        {

        }

        public bool isNutritionFactsLabelRequired
        {
            get
            {
                return this.isNutritionFactsLabelRequiredField;
            }
            set
            {
                this.isNutritionFactsLabelRequiredField = value;
            }
        }
        /*
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isNutritionFactsLabelRequiredSpecified
        {
            get
            {
                return this.isNutritionFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isNutritionFactsLabelRequiredFieldSpecified = value;
            }
        }
        */
        public string nutritionFactsLabel
        {
            get
            {
                return this.nutritionFactsLabelField;
            }
            set
            {
                this.nutritionFactsLabelField = value;
            }
        }

        public string foodForm
        {
            get
            {
                return this.foodFormField;
            }
            set
            {
                this.foodFormField = value;
            }
        }

        public bool isImitation
        {
            get
            {
                return this.isImitationField;
            }
            set
            {
                this.isImitationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isImitationSpecified
        {
            get
            {
                return this.isImitationFieldSpecified;
            }
            set
            {
                this.isImitationFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("foodAllergenStatement", IsNullable = false)]
        public List<string> foodAllergenStatements
        {
            get
            {
                return this.foodAllergenStatementsField;
            }
            set
            {
                this.foodAllergenStatementsField = value;
            }
        }

        public bool usdaInspected
        {
            get
            {
                return this.usdaInspectedField;
            }
            set
            {
                this.usdaInspectedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usdaInspectedSpecified
        {
            get
            {
                return this.usdaInspectedFieldSpecified;
            }
            set
            {
                this.usdaInspectedFieldSpecified = value;
            }
        }

        public string vintage
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

        public TimeUnit timeAged
        {
            get
            {
                return this.timeAgedField;
            }
            set
            {
                this.timeAgedField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public bool isGmoFree
        {
            get
            {
                return this.isGmoFreeField;
            }
            set
            {
                this.isGmoFreeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isGmoFreeSpecified
        {
            get
            {
                return this.isGmoFreeFieldSpecified;
            }
            set
            {
                this.isGmoFreeFieldSpecified = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        public bool isBpaFree
        {
            get
            {
                return this.isBpaFreeField;
            }
            set
            {
                this.isBpaFreeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBpaFreeSpecified
        {
            get
            {
                return this.isBpaFreeFieldSpecified;
            }
            set
            {
                this.isBpaFreeFieldSpecified = value;
            }
        }

        public bool isPotentiallyHazardousFood
        {
            get
            {
                return this.isPotentiallyHazardousFoodField;
            }
            set
            {
                this.isPotentiallyHazardousFoodField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPotentiallyHazardousFoodSpecified
        {
            get
            {
                return this.isPotentiallyHazardousFoodFieldSpecified;
            }
            set
            {
                this.isPotentiallyHazardousFoodFieldSpecified = value;
            }
        }

        public bool isReadyToEat
        {
            get
            {
                return this.isReadyToEatField;
            }
            set
            {
                this.isReadyToEatField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReadyToEatSpecified
        {
            get
            {
                return this.isReadyToEatFieldSpecified;
            }
            set
            {
                this.isReadyToEatFieldSpecified = value;
            }
        }

        public string caffeineDesignation
        {
            get
            {
                return this.caffeineDesignationField;
            }
            set
            {
                this.caffeineDesignationField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        public string spiceLevel
        {
            get
            {
                return this.spiceLevelField;
            }
            set
            {
                this.spiceLevelField = value;
            }
        }

        public string flavor
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

        public string beefCut
        {
            get
            {
                return this.beefCutField;
            }
            set
            {
                this.beefCutField = value;
            }
        }

        public string poultryCut
        {
            get
            {
                return this.poultryCutField;
            }
            set
            {
                this.poultryCutField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        public bool isMadeInHomeKitchen
        {
            get
            {
                return this.isMadeInHomeKitchenField;
            }
            set
            {
                this.isMadeInHomeKitchenField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeInHomeKitchenSpecified
        {
            get
            {
                return this.isMadeInHomeKitchenFieldSpecified;
            }
            set
            {
                this.isMadeInHomeKitchenFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("nutrientContentClaim", IsNullable = false)]
        public List<string> nutrientContentClaims
        {
            get
            {
                return this.nutrientContentClaimsField;
            }
            set
            {
                this.nutrientContentClaimsField = value;
            }
        }

        public string safeHandlingInstructions
        {
            get
            {
                return this.safeHandlingInstructionsField;
            }
            set
            {
                this.safeHandlingInstructionsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public decimal fatCaloriesPerGram
        {
            get
            {
                return this.fatCaloriesPerGramField;
            }
            set
            {
                this.fatCaloriesPerGramField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fatCaloriesPerGramSpecified
        {
            get
            {
                return this.fatCaloriesPerGramFieldSpecified;
            }
            set
            {
                this.fatCaloriesPerGramFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        public decimal carbohydrateCaloriesPerGram
        {
            get
            {
                return this.carbohydrateCaloriesPerGramField;
            }
            set
            {
                this.carbohydrateCaloriesPerGramField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool carbohydrateCaloriesPerGramSpecified
        {
            get
            {
                return this.carbohydrateCaloriesPerGramFieldSpecified;
            }
            set
            {
                this.carbohydrateCaloriesPerGramFieldSpecified = value;
            }
        }

        public WeightUnit totalProtein
        {
            get
            {
                return this.totalProteinField;
            }
            set
            {
                this.totalProteinField = value;
            }
        }

        public PercentageUnit totalProteinPercentageDailyValue
        {
            get
            {
                return this.totalProteinPercentageDailyValueField;
            }
            set
            {
                this.totalProteinPercentageDailyValueField = value;
            }
        }

        public decimal proteinCaloriesPerGram
        {
            get
            {
                return this.proteinCaloriesPerGramField;
            }
            set
            {
                this.proteinCaloriesPerGramField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool proteinCaloriesPerGramSpecified
        {
            get
            {
                return this.proteinCaloriesPerGramFieldSpecified;
            }
            set
            {
                this.proteinCaloriesPerGramFieldSpecified = value;
            }
        }

        public bool isFairTrade
        {
            get
            {
                return this.isFairTradeField;
            }
            set
            {
                this.isFairTradeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFairTradeSpecified
        {
            get
            {
                return this.isFairTradeFieldSpecified;
            }
            set
            {
                this.isFairTradeFieldSpecified = value;
            }
        }

        public bool isIndustrial
        {
            get
            {
                return this.isIndustrialField;
            }
            set
            {
                this.isIndustrialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIndustrialSpecified
        {
            get
            {
                return this.isIndustrialFieldSpecified;
            }
            set
            {
                this.isIndustrialFieldSpecified = value;
            }
        }

        public string ingredients
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

        public System.DateTime releaseDate
        {
            get
            {
                return this.releaseDateField;
            }
            set
            {
                this.releaseDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseDateSpecified
        {
            get
            {
                return this.releaseDateFieldSpecified;
            }
            set
            {
                this.releaseDateFieldSpecified = value;
            }
        }

        public string servingSize
        {
            get
            {
                return this.servingSizeField;
            }
            set
            {
                this.servingSizeField = value;
            }
        }

        public decimal servingsPerContainer
        {
            get
            {
                return this.servingsPerContainerField;
            }
            set
            {
                this.servingsPerContainerField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool servingsPerContainerSpecified
        {
            get
            {
                return this.servingsPerContainerFieldSpecified;
            }
            set
            {
                this.servingsPerContainerFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("organicCertification", IsNullable = false)]
        public List<string> organicCertifications
        {
            get
            {
                return this.organicCertificationsField;
            }
            set
            {
                this.organicCertificationsField = value;
            }
        }

        public string instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
            }
        }

        public decimal calories
        {
            get
            {
                return this.caloriesField;
            }
            set
            {
                this.caloriesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool caloriesSpecified
        {
            get
            {
                return this.caloriesFieldSpecified;
            }
            set
            {
                this.caloriesFieldSpecified = value;
            }
        }

        public WeightUnit caloriesFromFat
        {
            get
            {
                return this.caloriesFromFatField;
            }
            set
            {
                this.caloriesFromFatField = value;
            }
        }

        public WeightUnit totalFat
        {
            get
            {
                return this.totalFatField;
            }
            set
            {
                this.totalFatField = value;
            }
        }

        public PercentageUnit totalFatPercentageDailyValue
        {
            get
            {
                return this.totalFatPercentageDailyValueField;
            }
            set
            {
                this.totalFatPercentageDailyValueField = value;
            }
        }

        public WeightUnit totalCarbohydrate
        {
            get
            {
                return this.totalCarbohydrateField;
            }
            set
            {
                this.totalCarbohydrateField = value;
            }
        }

        public PercentageUnit totalCarbohydratePercentageDailyValue
        {
            get
            {
                return this.totalCarbohydratePercentageDailyValueField;
            }
            set
            {
                this.totalCarbohydratePercentageDailyValueField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<nutrient> nutrients
        {
            get
            {
                return this.nutrientsField;
            }
            set
            {
                this.nutrientsField = value;
            }
        }

        public AlcoholicBeverages Item
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

    public partial class AlcoholicBeverages
    {

        private string alcoholContentByVolumeField;

        private string alcoholProofField;

        private string alcoholClassAndTypeField;

        private string neutralSpiritsColoringAndFlavoringField;

        private string whiskeyPercentageField;

        private bool isEstateBottledField;

        private bool isEstateBottledFieldSpecified;

        private string wineAppellationField;

        private string wineVarietalField;

        private bool containsSulfitesField;

        private bool containsSulfitesFieldSpecified;

        private bool isNonGrapeField;

        private bool isNonGrapeFieldSpecified;

        public string alcoholContentByVolume
        {
            get
            {
                return this.alcoholContentByVolumeField;
            }
            set
            {
                this.alcoholContentByVolumeField = value;
            }
        }

        public string alcoholProof
        {
            get
            {
                return this.alcoholProofField;
            }
            set
            {
                this.alcoholProofField = value;
            }
        }

        public string alcoholClassAndType
        {
            get
            {
                return this.alcoholClassAndTypeField;
            }
            set
            {
                this.alcoholClassAndTypeField = value;
            }
        }

        public string neutralSpiritsColoringAndFlavoring
        {
            get
            {
                return this.neutralSpiritsColoringAndFlavoringField;
            }
            set
            {
                this.neutralSpiritsColoringAndFlavoringField = value;
            }
        }

        public string whiskeyPercentage
        {
            get
            {
                return this.whiskeyPercentageField;
            }
            set
            {
                this.whiskeyPercentageField = value;
            }
        }

        public bool isEstateBottled
        {
            get
            {
                return this.isEstateBottledField;
            }
            set
            {
                this.isEstateBottledField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEstateBottledSpecified
        {
            get
            {
                return this.isEstateBottledFieldSpecified;
            }
            set
            {
                this.isEstateBottledFieldSpecified = value;
            }
        }

        public string wineAppellation
        {
            get
            {
                return this.wineAppellationField;
            }
            set
            {
                this.wineAppellationField = value;
            }
        }

        public string wineVarietal
        {
            get
            {
                return this.wineVarietalField;
            }
            set
            {
                this.wineVarietalField = value;
            }
        }

        public bool containsSulfites
        {
            get
            {
                return this.containsSulfitesField;
            }
            set
            {
                this.containsSulfitesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool containsSulfitesSpecified
        {
            get
            {
                return this.containsSulfitesFieldSpecified;
            }
            set
            {
                this.containsSulfitesFieldSpecified = value;
            }
        }

        public bool isNonGrape
        {
            get
            {
                return this.isNonGrapeField;
            }
            set
            {
                this.isNonGrapeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isNonGrapeSpecified
        {
            get
            {
                return this.isNonGrapeFieldSpecified;
            }
            set
            {
                this.isNonGrapeFieldSpecified = value;
            }
        }
    }

    public partial class Footwear
    {

        private List<swatchImage> swatchImagesField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private string finishField;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private FootwearGender genderField;

        private List<string> colorField;

        private List<string> ageGroupField;

        private List<string> materialField;

        private List<string> patternField;

        private List<string> characterField;

        private List<string> occasionField;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private List<string> recommendedLocationsField;

        private List<string> sportField;

        private Shoes itemField;

        public Footwear()
        {
            this.itemField = new Shoes();
            this.sportField = new List<string>();
            this.recommendedLocationsField = new List<string>();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.occasionField = new List<string>();
            this.characterField = new List<string>();
            this.patternField = new List<string>();
            this.materialField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public FootwearGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedLocation", IsNullable = false)]
        public List<string> recommendedLocations
        {
            get
            {
                return this.recommendedLocationsField;
            }
            set
            {
                this.recommendedLocationsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("sportValue", IsNullable = false)]
        public List<string> sport
        {
            get
            {
                return this.sportField;
            }
            set
            {
                this.sportField = value;
            }
        }

        public Shoes Item
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

    public enum FootwearGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class Shoes
    {

        private string shoeCategoryField;

        private string shoeSizeField;

        private string shoeWidthField;

        private LengthUnit heelHeightField;

        private string shoeStyleField;

        private string casualAndDressShoeTypeField;

        private string shoeClosureField;

        private bool isWaterResistantField;

        private bool isWaterResistantFieldSpecified;

        private bool isOrthopedicField;

        private bool isOrthopedicFieldSpecified;

        public Shoes()
        {
            this.heelHeightField = new LengthUnit();
        }

        public string shoeCategory
        {
            get
            {
                return this.shoeCategoryField;
            }
            set
            {
                this.shoeCategoryField = value;
            }
        }

        public string shoeSize
        {
            get
            {
                return this.shoeSizeField;
            }
            set
            {
                this.shoeSizeField = value;
            }
        }

        public string shoeWidth
        {
            get
            {
                return this.shoeWidthField;
            }
            set
            {
                this.shoeWidthField = value;
            }
        }

        public LengthUnit heelHeight
        {
            get
            {
                return this.heelHeightField;
            }
            set
            {
                this.heelHeightField = value;
            }
        }

        public string shoeStyle
        {
            get
            {
                return this.shoeStyleField;
            }
            set
            {
                this.shoeStyleField = value;
            }
        }

        public string casualAndDressShoeType
        {
            get
            {
                return this.casualAndDressShoeTypeField;
            }
            set
            {
                this.casualAndDressShoeTypeField = value;
            }
        }

        public string shoeClosure
        {
            get
            {
                return this.shoeClosureField;
            }
            set
            {
                this.shoeClosureField = value;
            }
        }

        public bool isWaterResistant
        {
            get
            {
                return this.isWaterResistantField;
            }
            set
            {
                this.isWaterResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterResistantSpecified
        {
            get
            {
                return this.isWaterResistantFieldSpecified;
            }
            set
            {
                this.isWaterResistantFieldSpecified = value;
            }
        }

        public bool isOrthopedic
        {
            get
            {
                return this.isOrthopedicField;
            }
            set
            {
                this.isOrthopedicField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOrthopedicSpecified
        {
            get
            {
                return this.isOrthopedicFieldSpecified;
            }
            set
            {
                this.isOrthopedicFieldSpecified = value;
            }
        }
    }

    public partial class Furniture
    {

        private List<swatchImage> swatchImagesField;

        private string collectionField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private string finishField;

        private string homeDecorStyleField;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private List<string> themeField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private FurnitureGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private List<string> ageGroupField;

        private List<string> recommendedRoomsField;

        private List<string> mountTypeField;

        private bool isAntiqueField;

        private bool isAntiqueFieldSpecified;

        private List<string> patternField;

        private List<string> materialField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string numberOfPiecesField;

        private List<string> characterField;

        private string powerTypeField;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private List<string> recommendedUsesField;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private List<string> recommendedLocationsField;

        private string seatingCapacityField;

        private bool isInflatableField;

        private bool isInflatableFieldSpecified;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private string numberOfDrawersField;

        private string numberOfShelvesField;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private string assemblyInstructionsField;

        private List<string> fillMaterialField;

        private string shapeField;

        private object itemField;

        public Furniture()
        {
            this.fillMaterialField = new List<string>();
            this.recommendedLocationsField = new List<string>();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.recommendedUsesField = new List<string>();
            this.characterField = new List<string>();
            this.materialField = new List<string>();
            this.patternField = new List<string>();
            this.mountTypeField = new List<string>();
            this.recommendedRoomsField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.themeField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public string collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public List<string> theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public FurnitureGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedRoom", IsNullable = false)]
        public List<string> recommendedRooms
        {
            get
            {
                return this.recommendedRoomsField;
            }
            set
            {
                this.recommendedRoomsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("mountTypeValue", IsNullable = false)]
        public List<string> mountType
        {
            get
            {
                return this.mountTypeField;
            }
            set
            {
                this.mountTypeField = value;
            }
        }

        public bool isAntique
        {
            get
            {
                return this.isAntiqueField;
            }
            set
            {
                this.isAntiqueField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAntiqueSpecified
        {
            get
            {
                return this.isAntiqueFieldSpecified;
            }
            set
            {
                this.isAntiqueFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        public string numberOfPieces
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

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedLocation", IsNullable = false)]
        public List<string> recommendedLocations
        {
            get
            {
                return this.recommendedLocationsField;
            }
            set
            {
                this.recommendedLocationsField = value;
            }
        }

        public string seatingCapacity
        {
            get
            {
                return this.seatingCapacityField;
            }
            set
            {
                this.seatingCapacityField = value;
            }
        }

        public bool isInflatable
        {
            get
            {
                return this.isInflatableField;
            }
            set
            {
                this.isInflatableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInflatableSpecified
        {
            get
            {
                return this.isInflatableFieldSpecified;
            }
            set
            {
                this.isInflatableFieldSpecified = value;
            }
        }

        public bool isWheeled
        {
            get
            {
                return this.isWheeledField;
            }
            set
            {
                this.isWheeledField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWheeledSpecified
        {
            get
            {
                return this.isWheeledFieldSpecified;
            }
            set
            {
                this.isWheeledFieldSpecified = value;
            }
        }

        public string numberOfDrawers
        {
            get
            {
                return this.numberOfDrawersField;
            }
            set
            {
                this.numberOfDrawersField = value;
            }
        }

        public string numberOfShelves
        {
            get
            {
                return this.numberOfShelvesField;
            }
            set
            {
                this.numberOfShelvesField = value;
            }
        }

        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        public bool isIndustrial
        {
            get
            {
                return this.isIndustrialField;
            }
            set
            {
                this.isIndustrialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIndustrialSpecified
        {
            get
            {
                return this.isIndustrialFieldSpecified;
            }
            set
            {
                this.isIndustrialFieldSpecified = value;
            }
        }

        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
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

        public string assemblyInstructions
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

        [System.Xml.Serialization.XmlArrayItemAttribute("fillMaterialValue", IsNullable = false)]
        public List<string> fillMaterial
        {
            get
            {
                return this.fillMaterialField;
            }
            set
            {
                this.fillMaterialField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

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

    public enum FurnitureGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class Beds
    {

        private string bedStyleField;

        private string bedSizeField;

        public string bedStyle
        {
            get
            {
                return this.bedStyleField;
            }
            set
            {
                this.bedStyleField = value;
            }
        }

        public string bedSize
        {
            get
            {
                return this.bedSizeField;
            }
            set
            {
                this.bedSizeField = value;
            }
        }
    }

    public partial class Mattresses
    {

        private string mattressFirmnessField;

        private LengthUnit mattressThicknessField;

        private bool pumpIncludedField;

        private bool pumpIncludedFieldSpecified;

        private string bedSizeField;

        public Mattresses()
        {
            this.mattressThicknessField = new LengthUnit();
        }

        public string mattressFirmness
        {
            get
            {
                return this.mattressFirmnessField;
            }
            set
            {
                this.mattressFirmnessField = value;
            }
        }

        public LengthUnit mattressThickness
        {
            get
            {
                return this.mattressThicknessField;
            }
            set
            {
                this.mattressThicknessField = value;
            }
        }

        public bool pumpIncluded
        {
            get
            {
                return this.pumpIncludedField;
            }
            set
            {
                this.pumpIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pumpIncludedSpecified
        {
            get
            {
                return this.pumpIncludedFieldSpecified;
            }
            set
            {
                this.pumpIncludedFieldSpecified = value;
            }
        }

        public string bedSize
        {
            get
            {
                return this.bedSizeField;
            }
            set
            {
                this.bedSizeField = value;
            }
        }
    }

    public partial class Seating
    {

        private LengthUnit seatBackHeightField;

        private string seatMaterialField;

        private LengthUnit seatHeightField;

        private List<string> frameMaterialField;

        public Seating()
        {
            this.frameMaterialField = new List<string>();
            this.seatHeightField = new LengthUnit();
            this.seatBackHeightField = new LengthUnit();
        }

        public LengthUnit seatBackHeight
        {
            get
            {
                return this.seatBackHeightField;
            }
            set
            {
                this.seatBackHeightField = value;
            }
        }

        public string seatMaterial
        {
            get
            {
                return this.seatMaterialField;
            }
            set
            {
                this.seatMaterialField = value;
            }
        }

        public LengthUnit seatHeight
        {
            get
            {
                return this.seatHeightField;
            }
            set
            {
                this.seatHeightField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("frameMaterialValue", IsNullable = false)]
        public List<string> frameMaterial
        {
            get
            {
                return this.frameMaterialField;
            }
            set
            {
                this.frameMaterialField = value;
            }
        }
    }

    public partial class TVFurniture
    {

        private LengthUnit maximumScreenSizeField;

        public TVFurniture()
        {
            this.maximumScreenSizeField = new LengthUnit();
        }

        public LengthUnit maximumScreenSize
        {
            get
            {
                return this.maximumScreenSizeField;
            }
            set
            {
                this.maximumScreenSizeField = value;
            }
        }
    }

    public partial class GardenAndPatio
    {

        private List<swatchImage> swatchImagesField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private bool isWeatherResistantField;

        private bool isWeatherResistantFieldSpecified;

        private string finishField;

        private string homeDecorStyleField;

        private string plantCategoryField;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string conditionField;

        private string manufacturerField;

        private List<string> themeField;

        private TemperatureUnit minimumTemperatureField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private List<string> colorField;

        private bool isBulkField;

        private bool isBulkFieldSpecified;

        private List<string> ageGroupField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private bool isAntiqueField;

        private bool isAntiqueFieldSpecified;

        private List<string> materialField;

        private List<string> patternField;

        private string numberOfPiecesField;

        private List<string> characterField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string powerTypeField;

        private List<string> occasionField;

        private AreaUnit coverageAreaField;

        private string cleaningCareAndMaintenanceField;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private List<string> recommendedUsesField;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private VolumetricFlowRateUnit flowRateField;

        private List<string> recommendedLocationsField;

        private bool hasRadiantHeatField;

        private bool hasRadiantHeatFieldSpecified;

        private List<string> seasonField;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private WeightUnit maximumWeightField;

        private bool isTearResistantField;

        private bool isTearResistantFieldSpecified;

        private string installationTypeField;

        private string capacityField;

        private string fuelTypeField;

        private ElectricalMeasurementUnit voltsField;

        private PowerUnit wattsField;

        private string btuField;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private bool hasAutomaticShutoffField;

        private bool hasAutomaticShutoffFieldSpecified;

        private List<string> frameMaterialField;

        private string shapeField;

        private string displayTechnologyField;

        private string lightBulbTypeField;

        private GrillsAndOutdoorCooking itemField;

        public GardenAndPatio()
        {
            this.itemField = new GrillsAndOutdoorCooking();
            this.frameMaterialField = new List<string>();
            this.wattsField = new PowerUnit();
            this.voltsField = new ElectricalMeasurementUnit();
            this.maximumWeightField = new WeightUnit();
            this.seasonField = new List<string>();
            this.recommendedLocationsField = new List<string>();
            this.flowRateField = new VolumetricFlowRateUnit();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.recommendedUsesField = new List<string>();
            this.coverageAreaField = new AreaUnit();
            this.occasionField = new List<string>();
            this.characterField = new List<string>();
            this.patternField = new List<string>();
            this.materialField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.minimumTemperatureField = new TemperatureUnit();
            this.themeField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public bool isWeatherResistant
        {
            get
            {
                return this.isWeatherResistantField;
            }
            set
            {
                this.isWeatherResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWeatherResistantSpecified
        {
            get
            {
                return this.isWeatherResistantFieldSpecified;
            }
            set
            {
                this.isWeatherResistantFieldSpecified = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        public string plantCategory
        {
            get
            {
                return this.plantCategoryField;
            }
            set
            {
                this.plantCategoryField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public string manufacturer
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

        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public List<string> theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        public TemperatureUnit minimumTemperature
        {
            get
            {
                return this.minimumTemperatureField;
            }
            set
            {
                this.minimumTemperatureField = value;
            }
        }

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        public bool isBulk
        {
            get
            {
                return this.isBulkField;
            }
            set
            {
                this.isBulkField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBulkSpecified
        {
            get
            {
                return this.isBulkFieldSpecified;
            }
            set
            {
                this.isBulkFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public bool isEnergyStarCertified
        {
            get
            {
                return this.isEnergyStarCertifiedField;
            }
            set
            {
                this.isEnergyStarCertifiedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyStarCertifiedSpecified
        {
            get
            {
                return this.isEnergyStarCertifiedFieldSpecified;
            }
            set
            {
                this.isEnergyStarCertifiedFieldSpecified = value;
            }
        }

        public bool isAntique
        {
            get
            {
                return this.isAntiqueField;
            }
            set
            {
                this.isAntiqueField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAntiqueSpecified
        {
            get
            {
                return this.isAntiqueFieldSpecified;
            }
            set
            {
                this.isAntiqueFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        public string numberOfPieces
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

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public AreaUnit coverageArea
        {
            get
            {
                return this.coverageAreaField;
            }
            set
            {
                this.coverageAreaField = value;
            }
        }

        public string cleaningCareAndMaintenance
        {
            get
            {
                return this.cleaningCareAndMaintenanceField;
            }
            set
            {
                this.cleaningCareAndMaintenanceField = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        public VolumetricFlowRateUnit flowRate
        {
            get
            {
                return this.flowRateField;
            }
            set
            {
                this.flowRateField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedLocation", IsNullable = false)]
        public List<string> recommendedLocations
        {
            get
            {
                return this.recommendedLocationsField;
            }
            set
            {
                this.recommendedLocationsField = value;
            }
        }

        public bool hasRadiantHeat
        {
            get
            {
                return this.hasRadiantHeatField;
            }
            set
            {
                this.hasRadiantHeatField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasRadiantHeatSpecified
        {
            get
            {
                return this.hasRadiantHeatFieldSpecified;
            }
            set
            {
                this.hasRadiantHeatFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("seasonValue", IsNullable = false)]
        public List<string> season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        public bool isWheeled
        {
            get
            {
                return this.isWheeledField;
            }
            set
            {
                this.isWheeledField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWheeledSpecified
        {
            get
            {
                return this.isWheeledFieldSpecified;
            }
            set
            {
                this.isWheeledFieldSpecified = value;
            }
        }

        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        public bool isIndustrial
        {
            get
            {
                return this.isIndustrialField;
            }
            set
            {
                this.isIndustrialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIndustrialSpecified
        {
            get
            {
                return this.isIndustrialFieldSpecified;
            }
            set
            {
                this.isIndustrialFieldSpecified = value;
            }
        }

        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        public bool isTearResistant
        {
            get
            {
                return this.isTearResistantField;
            }
            set
            {
                this.isTearResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTearResistantSpecified
        {
            get
            {
                return this.isTearResistantFieldSpecified;
            }
            set
            {
                this.isTearResistantFieldSpecified = value;
            }
        }

        public string installationType
        {
            get
            {
                return this.installationTypeField;
            }
            set
            {
                this.installationTypeField = value;
            }
        }

        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        public string fuelType
        {
            get
            {
                return this.fuelTypeField;
            }
            set
            {
                this.fuelTypeField = value;
            }
        }

        public ElectricalMeasurementUnit volts
        {
            get
            {
                return this.voltsField;
            }
            set
            {
                this.voltsField = value;
            }
        }

        public PowerUnit watts
        {
            get
            {
                return this.wattsField;
            }
            set
            {
                this.wattsField = value;
            }
        }

        public string btu
        {
            get
            {
                return this.btuField;
            }
            set
            {
                this.btuField = value;
            }
        }

        public bool isWaterproof
        {
            get
            {
                return this.isWaterproofField;
            }
            set
            {
                this.isWaterproofField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterproofSpecified
        {
            get
            {
                return this.isWaterproofFieldSpecified;
            }
            set
            {
                this.isWaterproofFieldSpecified = value;
            }
        }

        public bool hasAutomaticShutoff
        {
            get
            {
                return this.hasAutomaticShutoffField;
            }
            set
            {
                this.hasAutomaticShutoffField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticShutoffSpecified
        {
            get
            {
                return this.hasAutomaticShutoffFieldSpecified;
            }
            set
            {
                this.hasAutomaticShutoffFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("frameMaterialValue", IsNullable = false)]
        public List<string> frameMaterial
        {
            get
            {
                return this.frameMaterialField;
            }
            set
            {
                this.frameMaterialField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        public string lightBulbType
        {
            get
            {
                return this.lightBulbTypeField;
            }
            set
            {
                this.lightBulbTypeField = value;
            }
        }

        public GrillsAndOutdoorCooking Item
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

    public partial class AreaUnit
    {

        private AreaUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public AreaUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum AreaUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Square Centimeters")]
        SquareCentimeters,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Square Millimeters")]
        SquareMillimeters,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Square Feet")]
        SquareFeet,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Square Inches")]
        SquareInches,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Square Meters")]
        SquareMeters,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Square Yards")]
        SquareYards,
    }

    public partial class VolumetricFlowRateUnit
    {

        private VolumetricFlowRateUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public VolumetricFlowRateUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum VolumetricFlowRateUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("liters per second")]
        literspersecond,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cubic meters per second")]
        cubicmeterspersecond,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cubic feet per second")]
        cubicfeetpersecond,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cubic meters per minute")]
        cubicmetersperminute,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("gallons per second")]
        gallonspersecond,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cubic feet per minute")]
        cubicfeetperminute,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("liters per minute")]
        litersperminute,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("gallons per minute")]
        gallonsperminute,
    }

    public partial class ElectricalMeasurementUnit
    {

        private ElectricalMeasurementUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private string measureField;

        public ElectricalMeasurementUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public string measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }
    }

    public enum ElectricalMeasurementUnitOfMeasure
    {

        /// <remarks/>
        Volts,

        /// <remarks/>
        Coulombs,

        /// <remarks/>
        Amps,
    }

    public partial class GrillsAndOutdoorCooking
    {

        private string flavorField;

        private string numberOfBurnersField;

        private bool hasSideShelfField;

        private bool hasSideShelfFieldSpecified;

        private bool hasCharcoalBasketField;

        private bool hasCharcoalBasketFieldSpecified;

        private AreaUnit totalCookingAreaField;

        private AreaUnit sideBurnerSizeField;

        private bool hasTankTrayField;

        private bool hasTankTrayFieldSpecified;

        private string lifespanField;

        public GrillsAndOutdoorCooking()
        {
            this.sideBurnerSizeField = new AreaUnit();
            this.totalCookingAreaField = new AreaUnit();
        }

        public string flavor
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

        public string numberOfBurners
        {
            get
            {
                return this.numberOfBurnersField;
            }
            set
            {
                this.numberOfBurnersField = value;
            }
        }

        public bool hasSideShelf
        {
            get
            {
                return this.hasSideShelfField;
            }
            set
            {
                this.hasSideShelfField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSideShelfSpecified
        {
            get
            {
                return this.hasSideShelfFieldSpecified;
            }
            set
            {
                this.hasSideShelfFieldSpecified = value;
            }
        }

        public bool hasCharcoalBasket
        {
            get
            {
                return this.hasCharcoalBasketField;
            }
            set
            {
                this.hasCharcoalBasketField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCharcoalBasketSpecified
        {
            get
            {
                return this.hasCharcoalBasketFieldSpecified;
            }
            set
            {
                this.hasCharcoalBasketFieldSpecified = value;
            }
        }

        public AreaUnit totalCookingArea
        {
            get
            {
                return this.totalCookingAreaField;
            }
            set
            {
                this.totalCookingAreaField = value;
            }
        }

        public AreaUnit sideBurnerSize
        {
            get
            {
                return this.sideBurnerSizeField;
            }
            set
            {
                this.sideBurnerSizeField = value;
            }
        }

        public bool hasTankTray
        {
            get
            {
                return this.hasTankTrayField;
            }
            set
            {
                this.hasTankTrayField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasTankTraySpecified
        {
            get
            {
                return this.hasTankTrayFieldSpecified;
            }
            set
            {
                this.hasTankTrayFieldSpecified = value;
            }
        }

        public string lifespan
        {
            get
            {
                return this.lifespanField;
            }
            set
            {
                this.lifespanField = value;
            }
        }
    }

    public partial class HealthAndBeauty
    {

        private List<swatchImage> swatchImagesField;

        private string collectionField;

        private List<string> variantAttributeNamesField;

        private bool flexibleSpendingAccountEligibleField;

        private bool flexibleSpendingAccountEligibleFieldSpecified;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private bool isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private HealthAndBeautyGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private List<string> ageGroupField;

        private bool isReusableField;

        private bool isReusableFieldSpecified;

        private bool isDisposableField;

        private bool isDisposableFieldSpecified;

        private List<string> materialField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string numberOfPiecesField;

        private List<string> characterField;

        private string powerTypeField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private List<string> bodyPartsField;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private string cleaningCareAndMaintenanceField;

        private bool isSetField;

        private bool isSetFieldSpecified;

        private bool isTravelSizeField;

        private bool isTravelSizeFieldSpecified;

        private List<string> recommendedUsesField;

        private string shapeField;

        private List<string> compatibleBrandsField;

        private object itemField;

        public HealthAndBeauty()
        {
            this.compatibleBrandsField = new List<string>();
            this.recommendedUsesField = new List<string>();
            this.bodyPartsField = new List<string>();
            this.characterField = new List<string>();
            this.materialField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public string collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public bool flexibleSpendingAccountEligible
        {
            get
            {
                return this.flexibleSpendingAccountEligibleField;
            }
            set
            {
                this.flexibleSpendingAccountEligibleField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool flexibleSpendingAccountEligibleSpecified
        {
            get
            {
                return this.flexibleSpendingAccountEligibleFieldSpecified;
            }
            set
            {
                this.flexibleSpendingAccountEligibleFieldSpecified = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public bool isAdultProduct
        {
            get
            {
                return this.isAdultProductField;
            }
            set
            {
                this.isAdultProductField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdultProductSpecified
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

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public HealthAndBeautyGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public bool isReusable
        {
            get
            {
                return this.isReusableField;
            }
            set
            {
                this.isReusableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReusableSpecified
        {
            get
            {
                return this.isReusableFieldSpecified;
            }
            set
            {
                this.isReusableFieldSpecified = value;
            }
        }

        public bool isDisposable
        {
            get
            {
                return this.isDisposableField;
            }
            set
            {
                this.isDisposableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDisposableSpecified
        {
            get
            {
                return this.isDisposableFieldSpecified;
            }
            set
            {
                this.isDisposableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        public string numberOfPieces
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

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("bodyPart", IsNullable = false)]
        public List<string> bodyParts
        {
            get
            {
                return this.bodyPartsField;
            }
            set
            {
                this.bodyPartsField = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        public string cleaningCareAndMaintenance
        {
            get
            {
                return this.cleaningCareAndMaintenanceField;
            }
            set
            {
                this.cleaningCareAndMaintenanceField = value;
            }
        }

        public bool isSet
        {
            get
            {
                return this.isSetField;
            }
            set
            {
                this.isSetField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSetSpecified
        {
            get
            {
                return this.isSetFieldSpecified;
            }
            set
            {
                this.isSetFieldSpecified = value;
            }
        }

        public bool isTravelSize
        {
            get
            {
                return this.isTravelSizeField;
            }
            set
            {
                this.isTravelSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTravelSizeSpecified
        {
            get
            {
                return this.isTravelSizeFieldSpecified;
            }
            set
            {
                this.isTravelSizeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleBrand", IsNullable = false)]
        public List<string> compatibleBrands
        {
            get
            {
                return this.compatibleBrandsField;
            }
            set
            {
                this.compatibleBrandsField = value;
            }
        }

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

    public enum HealthAndBeautyGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class HealthAndBeautyElectronics
    {

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private List<string> connectionsField;

        private bool isCordlessField;

        private bool isCordlessFieldSpecified;

        private bool hasAutomaticShutoffField;

        private bool hasAutomaticShutoffFieldSpecified;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        public HealthAndBeautyElectronics()
        {
            this.screenSizeField = new LengthUnit();
            this.connectionsField = new List<string>();
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("connection", IsNullable = false)]
        public List<string> connections
        {
            get
            {
                return this.connectionsField;
            }
            set
            {
                this.connectionsField = value;
            }
        }

        public bool isCordless
        {
            get
            {
                return this.isCordlessField;
            }
            set
            {
                this.isCordlessField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCordlessSpecified
        {
            get
            {
                return this.isCordlessFieldSpecified;
            }
            set
            {
                this.isCordlessFieldSpecified = value;
            }
        }

        public bool hasAutomaticShutoff
        {
            get
            {
                return this.hasAutomaticShutoffField;
            }
            set
            {
                this.hasAutomaticShutoffField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticShutoffSpecified
        {
            get
            {
                return this.hasAutomaticShutoffFieldSpecified;
            }
            set
            {
                this.hasAutomaticShutoffFieldSpecified = value;
            }
        }

        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }
    }

    public partial class MedicalAids
    {

        private bool isInflatableField;

        private bool isInflatableFieldSpecified;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private LengthUnit diameterField;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private string assemblyInstructionsField;

        private WeightUnit maximumWeightField;

        private bool isLatexFreeField;

        private bool isLatexFreeFieldSpecified;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private List<string> healthConcernsField;

        public MedicalAids()
        {
            this.healthConcernsField = new List<string>();
            this.maximumWeightField = new WeightUnit();
            this.diameterField = new LengthUnit();
        }

        public bool isInflatable
        {
            get
            {
                return this.isInflatableField;
            }
            set
            {
                this.isInflatableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInflatableSpecified
        {
            get
            {
                return this.isInflatableFieldSpecified;
            }
            set
            {
                this.isInflatableFieldSpecified = value;
            }
        }

        public bool isWheeled
        {
            get
            {
                return this.isWheeledField;
            }
            set
            {
                this.isWheeledField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWheeledSpecified
        {
            get
            {
                return this.isWheeledFieldSpecified;
            }
            set
            {
                this.isWheeledFieldSpecified = value;
            }
        }

        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        public bool isIndustrial
        {
            get
            {
                return this.isIndustrialField;
            }
            set
            {
                this.isIndustrialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIndustrialSpecified
        {
            get
            {
                return this.isIndustrialFieldSpecified;
            }
            set
            {
                this.isIndustrialFieldSpecified = value;
            }
        }

        public LengthUnit diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
            }
        }

        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
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

        public string assemblyInstructions
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

        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        public bool isLatexFree
        {
            get
            {
                return this.isLatexFreeField;
            }
            set
            {
                this.isLatexFreeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLatexFreeSpecified
        {
            get
            {
                return this.isLatexFreeFieldSpecified;
            }
            set
            {
                this.isLatexFreeFieldSpecified = value;
            }
        }

        public bool isWaterproof
        {
            get
            {
                return this.isWaterproofField;
            }
            set
            {
                this.isWaterproofField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterproofSpecified
        {
            get
            {
                return this.isWaterproofFieldSpecified;
            }
            set
            {
                this.isWaterproofFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("healthConcern", IsNullable = false)]
        public List<string> healthConcerns
        {
            get
            {
                return this.healthConcernsField;
            }
            set
            {
                this.healthConcernsField = value;
            }
        }
    }

    public partial class MedicineAndSupplements
    {

        private bool isDrugFactsLabelRequiredField;

        private bool isDrugFactsLabelRequiredFieldSpecified;

        private string drugFactsLabelField;

        private bool isSupplementFactsLabelRequiredField;

        private bool isSupplementFactsLabelRequiredFieldSpecified;

        private string supplementFactsLabelField;

        private string servingSizeField;

        private decimal servingsPerContainerField;

        private bool servingsPerContainerFieldSpecified;

        private List<activeIngredient> activeIngredientsField;

        private List<string> inactiveIngredientsField;

        private List<string> healthConcernsField;

        private string formField;

        private List<string> organicCertificationsField;

        private string instructionsField;

        private string dosageField;

        private List<string> stopUseIndicationsField;

        public MedicineAndSupplements()
        {
            this.stopUseIndicationsField = new List<string>();
            this.organicCertificationsField = new List<string>();
            this.healthConcernsField = new List<string>();
            this.inactiveIngredientsField = new List<string>();
            this.activeIngredientsField = new List<activeIngredient>();
        }

        public bool isDrugFactsLabelRequired
        {
            get
            {
                return this.isDrugFactsLabelRequiredField;
            }
            set
            {
                this.isDrugFactsLabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDrugFactsLabelRequiredSpecified
        {
            get
            {
                return this.isDrugFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isDrugFactsLabelRequiredFieldSpecified = value;
            }
        }

        public string drugFactsLabel
        {
            get
            {
                return this.drugFactsLabelField;
            }
            set
            {
                this.drugFactsLabelField = value;
            }
        }

        public bool isSupplementFactsLabelRequired
        {
            get
            {
                return this.isSupplementFactsLabelRequiredField;
            }
            set
            {
                this.isSupplementFactsLabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSupplementFactsLabelRequiredSpecified
        {
            get
            {
                return this.isSupplementFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isSupplementFactsLabelRequiredFieldSpecified = value;
            }
        }

        public string supplementFactsLabel
        {
            get
            {
                return this.supplementFactsLabelField;
            }
            set
            {
                this.supplementFactsLabelField = value;
            }
        }

        public string servingSize
        {
            get
            {
                return this.servingSizeField;
            }
            set
            {
                this.servingSizeField = value;
            }
        }

        public decimal servingsPerContainer
        {
            get
            {
                return this.servingsPerContainerField;
            }
            set
            {
                this.servingsPerContainerField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool servingsPerContainerSpecified
        {
            get
            {
                return this.servingsPerContainerFieldSpecified;
            }
            set
            {
                this.servingsPerContainerFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<activeIngredient> activeIngredients
        {
            get
            {
                return this.activeIngredientsField;
            }
            set
            {
                this.activeIngredientsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("inactiveIngredient", IsNullable = false)]
        public List<string> inactiveIngredients
        {
            get
            {
                return this.inactiveIngredientsField;
            }
            set
            {
                this.inactiveIngredientsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("healthConcern", IsNullable = false)]
        public List<string> healthConcerns
        {
            get
            {
                return this.healthConcernsField;
            }
            set
            {
                this.healthConcernsField = value;
            }
        }

        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("organicCertification", IsNullable = false)]
        public List<string> organicCertifications
        {
            get
            {
                return this.organicCertificationsField;
            }
            set
            {
                this.organicCertificationsField = value;
            }
        }

        public string instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
            }
        }

        public string dosage
        {
            get
            {
                return this.dosageField;
            }
            set
            {
                this.dosageField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("stopUseIndication", IsNullable = false)]
        public List<string> stopUseIndications
        {
            get
            {
                return this.stopUseIndicationsField;
            }
            set
            {
                this.stopUseIndicationsField = value;
            }
        }
    }

    public partial class Optical
    {

        private List<string> frameMaterialField;

        private string shapeField;

        private string eyewearFrameStyleField;

        private string lensMaterialField;

        private string eyewearFrameSizeField;

        private string uvRatingField;

        private bool isPolarizedField;

        private bool isPolarizedFieldSpecified;

        private string lensTintField;

        private bool isScratchResistantField;

        private bool isScratchResistantFieldSpecified;

        private bool hasAdaptiveLensesField;

        private bool hasAdaptiveLensesFieldSpecified;

        private List<string> lensTypeField;

        public Optical()
        {
            this.lensTypeField = new List<string>();
            this.frameMaterialField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("frameMaterialValue", IsNullable = false)]
        public List<string> frameMaterial
        {
            get
            {
                return this.frameMaterialField;
            }
            set
            {
                this.frameMaterialField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        public string eyewearFrameStyle
        {
            get
            {
                return this.eyewearFrameStyleField;
            }
            set
            {
                this.eyewearFrameStyleField = value;
            }
        }

        public string lensMaterial
        {
            get
            {
                return this.lensMaterialField;
            }
            set
            {
                this.lensMaterialField = value;
            }
        }

        public string eyewearFrameSize
        {
            get
            {
                return this.eyewearFrameSizeField;
            }
            set
            {
                this.eyewearFrameSizeField = value;
            }
        }

        public string uvRating
        {
            get
            {
                return this.uvRatingField;
            }
            set
            {
                this.uvRatingField = value;
            }
        }

        public bool isPolarized
        {
            get
            {
                return this.isPolarizedField;
            }
            set
            {
                this.isPolarizedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPolarizedSpecified
        {
            get
            {
                return this.isPolarizedFieldSpecified;
            }
            set
            {
                this.isPolarizedFieldSpecified = value;
            }
        }

        public string lensTint
        {
            get
            {
                return this.lensTintField;
            }
            set
            {
                this.lensTintField = value;
            }
        }

        public bool isScratchResistant
        {
            get
            {
                return this.isScratchResistantField;
            }
            set
            {
                this.isScratchResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isScratchResistantSpecified
        {
            get
            {
                return this.isScratchResistantFieldSpecified;
            }
            set
            {
                this.isScratchResistantFieldSpecified = value;
            }
        }

        public bool hasAdaptiveLenses
        {
            get
            {
                return this.hasAdaptiveLensesField;
            }
            set
            {
                this.hasAdaptiveLensesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAdaptiveLensesSpecified
        {
            get
            {
                return this.hasAdaptiveLensesFieldSpecified;
            }
            set
            {
                this.hasAdaptiveLensesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("lensTypeValue", IsNullable = false)]
        public List<string> lensType
        {
            get
            {
                return this.lensTypeField;
            }
            set
            {
                this.lensTypeField = value;
            }
        }
    }

    public partial class PersonalCare
    {

        private List<string> ingredientClaimField;

        private bool isLatexFreeField;

        private bool isLatexFreeFieldSpecified;

        private string absorbencyField;

        private TimeUnit resultTimeField;

        private string skinCareConcernField;

        private string skinTypeField;

        private string hairTypeField;

        private string skinToneField;

        private string spfValueField;

        private bool isAntiAgingField;

        private bool isAntiAgingFieldSpecified;

        private bool isHypoallergenicField;

        private bool isHypoallergenicFieldSpecified;

        private bool isOilFreeField;

        private bool isOilFreeFieldSpecified;

        private bool isParabenFreeField;

        private bool isParabenFreeFieldSpecified;

        private bool isNoncomodegenicField;

        private bool isNoncomodegenicFieldSpecified;

        private string scentField;

        private bool isUnscentedField;

        private bool isUnscentedFieldSpecified;

        private bool isVeganField;

        private bool isVeganFieldSpecified;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private bool isTintedField;

        private bool isTintedFieldSpecified;

        private bool isSelfTanningField;

        private bool isSelfTanningFieldSpecified;

        private bool isDrugFactsLabelRequiredField;

        private bool isDrugFactsLabelRequiredFieldSpecified;

        private string drugFactsLabelField;

        private List<activeIngredient> activeIngredientsField;

        private List<string> inactiveIngredientsField;

        private string formField;

        private List<string> organicCertificationsField;

        private string instructionsField;

        private List<string> stopUseIndicationsField;

        public PersonalCare()
        {
            this.stopUseIndicationsField = new List<string>();
            this.organicCertificationsField = new List<string>();
            this.inactiveIngredientsField = new List<string>();
            this.activeIngredientsField = new List<activeIngredient>();
            this.resultTimeField = new TimeUnit();
            this.ingredientClaimField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("ingredientClaimValue", IsNullable = false)]
        public List<string> ingredientClaim
        {
            get
            {
                return this.ingredientClaimField;
            }
            set
            {
                this.ingredientClaimField = value;
            }
        }

        public bool isLatexFree
        {
            get
            {
                return this.isLatexFreeField;
            }
            set
            {
                this.isLatexFreeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLatexFreeSpecified
        {
            get
            {
                return this.isLatexFreeFieldSpecified;
            }
            set
            {
                this.isLatexFreeFieldSpecified = value;
            }
        }

        public string absorbency
        {
            get
            {
                return this.absorbencyField;
            }
            set
            {
                this.absorbencyField = value;
            }
        }

        public TimeUnit resultTime
        {
            get
            {
                return this.resultTimeField;
            }
            set
            {
                this.resultTimeField = value;
            }
        }

        public string skinCareConcern
        {
            get
            {
                return this.skinCareConcernField;
            }
            set
            {
                this.skinCareConcernField = value;
            }
        }

        public string skinType
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

        public string hairType
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

        public string skinTone
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

        public string spfValue
        {
            get
            {
                return this.spfValueField;
            }
            set
            {
                this.spfValueField = value;
            }
        }

        public bool isAntiAging
        {
            get
            {
                return this.isAntiAgingField;
            }
            set
            {
                this.isAntiAgingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAntiAgingSpecified
        {
            get
            {
                return this.isAntiAgingFieldSpecified;
            }
            set
            {
                this.isAntiAgingFieldSpecified = value;
            }
        }

        public bool isHypoallergenic
        {
            get
            {
                return this.isHypoallergenicField;
            }
            set
            {
                this.isHypoallergenicField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isHypoallergenicSpecified
        {
            get
            {
                return this.isHypoallergenicFieldSpecified;
            }
            set
            {
                this.isHypoallergenicFieldSpecified = value;
            }
        }

        public bool isOilFree
        {
            get
            {
                return this.isOilFreeField;
            }
            set
            {
                this.isOilFreeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOilFreeSpecified
        {
            get
            {
                return this.isOilFreeFieldSpecified;
            }
            set
            {
                this.isOilFreeFieldSpecified = value;
            }
        }

        public bool isParabenFree
        {
            get
            {
                return this.isParabenFreeField;
            }
            set
            {
                this.isParabenFreeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isParabenFreeSpecified
        {
            get
            {
                return this.isParabenFreeFieldSpecified;
            }
            set
            {
                this.isParabenFreeFieldSpecified = value;
            }
        }

        public bool isNoncomodegenic
        {
            get
            {
                return this.isNoncomodegenicField;
            }
            set
            {
                this.isNoncomodegenicField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isNoncomodegenicSpecified
        {
            get
            {
                return this.isNoncomodegenicFieldSpecified;
            }
            set
            {
                this.isNoncomodegenicFieldSpecified = value;
            }
        }

        public string scent
        {
            get
            {
                return this.scentField;
            }
            set
            {
                this.scentField = value;
            }
        }

        public bool isUnscented
        {
            get
            {
                return this.isUnscentedField;
            }
            set
            {
                this.isUnscentedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isUnscentedSpecified
        {
            get
            {
                return this.isUnscentedFieldSpecified;
            }
            set
            {
                this.isUnscentedFieldSpecified = value;
            }
        }

        public bool isVegan
        {
            get
            {
                return this.isVeganField;
            }
            set
            {
                this.isVeganField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isVeganSpecified
        {
            get
            {
                return this.isVeganFieldSpecified;
            }
            set
            {
                this.isVeganFieldSpecified = value;
            }
        }

        public bool isWaterproof
        {
            get
            {
                return this.isWaterproofField;
            }
            set
            {
                this.isWaterproofField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterproofSpecified
        {
            get
            {
                return this.isWaterproofFieldSpecified;
            }
            set
            {
                this.isWaterproofFieldSpecified = value;
            }
        }

        public bool isTinted
        {
            get
            {
                return this.isTintedField;
            }
            set
            {
                this.isTintedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTintedSpecified
        {
            get
            {
                return this.isTintedFieldSpecified;
            }
            set
            {
                this.isTintedFieldSpecified = value;
            }
        }

        public bool isSelfTanning
        {
            get
            {
                return this.isSelfTanningField;
            }
            set
            {
                this.isSelfTanningField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSelfTanningSpecified
        {
            get
            {
                return this.isSelfTanningFieldSpecified;
            }
            set
            {
                this.isSelfTanningFieldSpecified = value;
            }
        }

        public bool isDrugFactsLabelRequired
        {
            get
            {
                return this.isDrugFactsLabelRequiredField;
            }
            set
            {
                this.isDrugFactsLabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDrugFactsLabelRequiredSpecified
        {
            get
            {
                return this.isDrugFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isDrugFactsLabelRequiredFieldSpecified = value;
            }
        }

        public string drugFactsLabel
        {
            get
            {
                return this.drugFactsLabelField;
            }
            set
            {
                this.drugFactsLabelField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<activeIngredient> activeIngredients
        {
            get
            {
                return this.activeIngredientsField;
            }
            set
            {
                this.activeIngredientsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("inactiveIngredient", IsNullable = false)]
        public List<string> inactiveIngredients
        {
            get
            {
                return this.inactiveIngredientsField;
            }
            set
            {
                this.inactiveIngredientsField = value;
            }
        }

        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("organicCertification", IsNullable = false)]
        public List<string> organicCertifications
        {
            get
            {
                return this.organicCertificationsField;
            }
            set
            {
                this.organicCertificationsField = value;
            }
        }

        public string instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("stopUseIndication", IsNullable = false)]
        public List<string> stopUseIndications
        {
            get
            {
                return this.stopUseIndicationsField;
            }
            set
            {
                this.stopUseIndicationsField = value;
            }
        }
    }

    public partial class Home
    {

        private List<swatchImage> swatchImagesField;

        private string collectionField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private string finishField;

        private string homeDecorStyleField;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private List<string> themeField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private HomeGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private List<string> ageGroupField;

        private List<string> recommendedRoomsField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool isReusableField;

        private bool isReusableFieldSpecified;

        private bool isDisposableField;

        private bool isDisposableFieldSpecified;

        private bool isAntiqueField;

        private bool isAntiqueFieldSpecified;

        private List<string> materialField;

        private List<string> patternField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string numberOfPiecesField;

        private List<string> characterField;

        private string powerTypeField;

        private List<string> occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private string cleaningCareAndMaintenanceField;

        private bool isCordlessField;

        private bool isCordlessFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private bool isSetField;

        private bool isSetFieldSpecified;

        private List<string> recommendedUsesField;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private bool isRetractableField;

        private bool isRetractableFieldSpecified;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private string assemblyInstructionsField;

        private string shapeField;

        private object itemField;

        public Home()
        {
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.recommendedUsesField = new List<string>();
            this.occasionField = new List<string>();
            this.characterField = new List<string>();
            this.patternField = new List<string>();
            this.materialField = new List<string>();
            this.recommendedRoomsField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.themeField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public string collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public List<string> theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public HomeGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedRoom", IsNullable = false)]
        public List<string> recommendedRooms
        {
            get
            {
                return this.recommendedRoomsField;
            }
            set
            {
                this.recommendedRoomsField = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public bool isReusable
        {
            get
            {
                return this.isReusableField;
            }
            set
            {
                this.isReusableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReusableSpecified
        {
            get
            {
                return this.isReusableFieldSpecified;
            }
            set
            {
                this.isReusableFieldSpecified = value;
            }
        }

        public bool isDisposable
        {
            get
            {
                return this.isDisposableField;
            }
            set
            {
                this.isDisposableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDisposableSpecified
        {
            get
            {
                return this.isDisposableFieldSpecified;
            }
            set
            {
                this.isDisposableFieldSpecified = value;
            }
        }

        public bool isAntique
        {
            get
            {
                return this.isAntiqueField;
            }
            set
            {
                this.isAntiqueField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAntiqueSpecified
        {
            get
            {
                return this.isAntiqueFieldSpecified;
            }
            set
            {
                this.isAntiqueFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        public string numberOfPieces
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

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        public string cleaningCareAndMaintenance
        {
            get
            {
                return this.cleaningCareAndMaintenanceField;
            }
            set
            {
                this.cleaningCareAndMaintenanceField = value;
            }
        }

        public bool isCordless
        {
            get
            {
                return this.isCordlessField;
            }
            set
            {
                this.isCordlessField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCordlessSpecified
        {
            get
            {
                return this.isCordlessFieldSpecified;
            }
            set
            {
                this.isCordlessFieldSpecified = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        public bool isSet
        {
            get
            {
                return this.isSetField;
            }
            set
            {
                this.isSetField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSetSpecified
        {
            get
            {
                return this.isSetFieldSpecified;
            }
            set
            {
                this.isSetFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        public bool isRetractable
        {
            get
            {
                return this.isRetractableField;
            }
            set
            {
                this.isRetractableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRetractableSpecified
        {
            get
            {
                return this.isRetractableFieldSpecified;
            }
            set
            {
                this.isRetractableFieldSpecified = value;
            }
        }

        public bool isWheeled
        {
            get
            {
                return this.isWheeledField;
            }
            set
            {
                this.isWheeledField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWheeledSpecified
        {
            get
            {
                return this.isWheeledFieldSpecified;
            }
            set
            {
                this.isWheeledFieldSpecified = value;
            }
        }

        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        public bool isIndustrial
        {
            get
            {
                return this.isIndustrialField;
            }
            set
            {
                this.isIndustrialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIndustrialSpecified
        {
            get
            {
                return this.isIndustrialFieldSpecified;
            }
            set
            {
                this.isIndustrialFieldSpecified = value;
            }
        }

        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
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

        public string assemblyInstructions
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

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

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

    public enum HomeGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class Bedding
    {

        private List<fabricContentValue> fabricContentField;

        private List<string> fabricCareInstructionsField;

        private List<string> colorField;

        private string bedSizeField;

        private string threadCountField;

        public Bedding()
        {
            this.colorField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        public string bedSize
        {
            get
            {
                return this.bedSizeField;
            }
            set
            {
                this.bedSizeField = value;
            }
        }

        public string threadCount
        {
            get
            {
                return this.threadCountField;
            }
            set
            {
                this.threadCountField = value;
            }
        }
    }

    public partial class HomeDecor
    {

        private List<string> colorField;

        private string rugSizeField;

        private string clockNumberTypeField;

        private string curtainPanelStyleField;

        private List<string> fillMaterialField;

        private string scentField;

        private string threadCountField;

        private string displayTechnologyField;

        public HomeDecor()
        {
            this.fillMaterialField = new List<string>();
            this.colorField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        public string rugSize
        {
            get
            {
                return this.rugSizeField;
            }
            set
            {
                this.rugSizeField = value;
            }
        }

        public string clockNumberType
        {
            get
            {
                return this.clockNumberTypeField;
            }
            set
            {
                this.clockNumberTypeField = value;
            }
        }

        public string curtainPanelStyle
        {
            get
            {
                return this.curtainPanelStyleField;
            }
            set
            {
                this.curtainPanelStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fillMaterialValue", IsNullable = false)]
        public List<string> fillMaterial
        {
            get
            {
                return this.fillMaterialField;
            }
            set
            {
                this.fillMaterialField = value;
            }
        }

        public string scent
        {
            get
            {
                return this.scentField;
            }
            set
            {
                this.scentField = value;
            }
        }

        public string threadCount
        {
            get
            {
                return this.threadCountField;
            }
            set
            {
                this.threadCountField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }
    }

    public partial class LargeAppliances
    {

        private bool isEnergyGuideLabelRequiredField;

        private bool isEnergyGuideLabelRequiredFieldSpecified;

        private string energyGuideLabelField;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private bool hasCflField;

        private bool hasCflFieldSpecified;

        private bool isLightingFactsLabelRequiredField;

        private bool isLightingFactsLabelRequiredFieldSpecified;

        private string lightingFactsLabelField;

        private string capacityField;

        private VolumeUnit volumeCapacityField;

        private string fuelTypeField;

        private string loadPositionField;

        private ElectricalMeasurementUnit voltsField;

        private PowerUnit wattsField;

        private string btuField;

        private AreaUnit maximumRoomSizeField;

        private TimeUnit runTimeField;

        private LengthUnit cordLengthField;

        private bool isSmartField;

        private bool isSmartFieldSpecified;

        private bool hasAutomaticShutoffField;

        private bool hasAutomaticShutoffFieldSpecified;

        public LargeAppliances()
        {
            this.cordLengthField = new LengthUnit();
            this.runTimeField = new TimeUnit();
            this.maximumRoomSizeField = new AreaUnit();
            this.wattsField = new PowerUnit();
            this.voltsField = new ElectricalMeasurementUnit();
            this.volumeCapacityField = new VolumeUnit();
        }

        public bool isEnergyGuideLabelRequired
        {
            get
            {
                return this.isEnergyGuideLabelRequiredField;
            }
            set
            {
                this.isEnergyGuideLabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyGuideLabelRequiredSpecified
        {
            get
            {
                return this.isEnergyGuideLabelRequiredFieldSpecified;
            }
            set
            {
                this.isEnergyGuideLabelRequiredFieldSpecified = value;
            }
        }

        public string energyGuideLabel
        {
            get
            {
                return this.energyGuideLabelField;
            }
            set
            {
                this.energyGuideLabelField = value;
            }
        }

        public bool isEnergyStarCertified
        {
            get
            {
                return this.isEnergyStarCertifiedField;
            }
            set
            {
                this.isEnergyStarCertifiedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyStarCertifiedSpecified
        {
            get
            {
                return this.isEnergyStarCertifiedFieldSpecified;
            }
            set
            {
                this.isEnergyStarCertifiedFieldSpecified = value;
            }
        }

        public bool isRemoteControlIncluded
        {
            get
            {
                return this.isRemoteControlIncludedField;
            }
            set
            {
                this.isRemoteControlIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRemoteControlIncludedSpecified
        {
            get
            {
                return this.isRemoteControlIncludedFieldSpecified;
            }
            set
            {
                this.isRemoteControlIncludedFieldSpecified = value;
            }
        }

        public bool hasCfl
        {
            get
            {
                return this.hasCflField;
            }
            set
            {
                this.hasCflField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCflSpecified
        {
            get
            {
                return this.hasCflFieldSpecified;
            }
            set
            {
                this.hasCflFieldSpecified = value;
            }
        }

        public bool isLightingFactsLabelRequired
        {
            get
            {
                return this.isLightingFactsLabelRequiredField;
            }
            set
            {
                this.isLightingFactsLabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLightingFactsLabelRequiredSpecified
        {
            get
            {
                return this.isLightingFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isLightingFactsLabelRequiredFieldSpecified = value;
            }
        }

        public string lightingFactsLabel
        {
            get
            {
                return this.lightingFactsLabelField;
            }
            set
            {
                this.lightingFactsLabelField = value;
            }
        }

        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        public VolumeUnit volumeCapacity
        {
            get
            {
                return this.volumeCapacityField;
            }
            set
            {
                this.volumeCapacityField = value;
            }
        }

        public string fuelType
        {
            get
            {
                return this.fuelTypeField;
            }
            set
            {
                this.fuelTypeField = value;
            }
        }

        public string loadPosition
        {
            get
            {
                return this.loadPositionField;
            }
            set
            {
                this.loadPositionField = value;
            }
        }

        public ElectricalMeasurementUnit volts
        {
            get
            {
                return this.voltsField;
            }
            set
            {
                this.voltsField = value;
            }
        }

        public PowerUnit watts
        {
            get
            {
                return this.wattsField;
            }
            set
            {
                this.wattsField = value;
            }
        }

        public string btu
        {
            get
            {
                return this.btuField;
            }
            set
            {
                this.btuField = value;
            }
        }

        public AreaUnit maximumRoomSize
        {
            get
            {
                return this.maximumRoomSizeField;
            }
            set
            {
                this.maximumRoomSizeField = value;
            }
        }

        public TimeUnit runTime
        {
            get
            {
                return this.runTimeField;
            }
            set
            {
                this.runTimeField = value;
            }
        }

        public LengthUnit cordLength
        {
            get
            {
                return this.cordLengthField;
            }
            set
            {
                this.cordLengthField = value;
            }
        }

        public bool isSmart
        {
            get
            {
                return this.isSmartField;
            }
            set
            {
                this.isSmartField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSmartSpecified
        {
            get
            {
                return this.isSmartFieldSpecified;
            }
            set
            {
                this.isSmartFieldSpecified = value;
            }
        }

        public bool hasAutomaticShutoff
        {
            get
            {
                return this.hasAutomaticShutoffField;
            }
            set
            {
                this.hasAutomaticShutoffField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticShutoffSpecified
        {
            get
            {
                return this.hasAutomaticShutoffFieldSpecified;
            }
            set
            {
                this.hasAutomaticShutoffFieldSpecified = value;
            }
        }
    }

    public partial class Jewelry
    {

        private string sizeField;

        private JewelryJewelryStyle jewelryStyleField;

        private string metalField;

        private string platingField;

        private List<swatchImage> swatchImagesField;

        private string karatsField;

        private List<string> gemstoneField;

        private List<string> variantAttributeNamesField;

        private string birthstoneField;

        private string variantGroupIdField;

        private string gemstoneShapeField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private WeightUnit caratsField;

        private string diamondClarityField;

        private string gemstoneCutField;

        private LengthUnit chainLengthField;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private JewelryGender genderField;

        private List<string> colorField;

        private List<string> ageGroupField;

        private List<string> materialField;

        private List<string> patternField;

        private List<string> characterField;

        private List<string> occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private List<string> bodyPartsField;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private Rings itemField;

        public Jewelry()
        {
            this.itemField = new Rings();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.bodyPartsField = new List<string>();
            this.occasionField = new List<string>();
            this.characterField = new List<string>();
            this.patternField = new List<string>();
            this.materialField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.chainLengthField = new LengthUnit();
            this.caratsField = new WeightUnit();
            this.variantAttributeNamesField = new List<string>();
            this.gemstoneField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        public string size
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

        public JewelryJewelryStyle jewelryStyle
        {
            get
            {
                return this.jewelryStyleField;
            }
            set
            {
                this.jewelryStyleField = value;
            }
        }

        public string metal
        {
            get
            {
                return this.metalField;
            }
            set
            {
                this.metalField = value;
            }
        }

        public string plating
        {
            get
            {
                return this.platingField;
            }
            set
            {
                this.platingField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public string karats
        {
            get
            {
                return this.karatsField;
            }
            set
            {
                this.karatsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("gemstoneValue", IsNullable = false)]
        public List<string> gemstone
        {
            get
            {
                return this.gemstoneField;
            }
            set
            {
                this.gemstoneField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string birthstone
        {
            get
            {
                return this.birthstoneField;
            }
            set
            {
                this.birthstoneField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public string gemstoneShape
        {
            get
            {
                return this.gemstoneShapeField;
            }
            set
            {
                this.gemstoneShapeField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        public WeightUnit carats
        {
            get
            {
                return this.caratsField;
            }
            set
            {
                this.caratsField = value;
            }
        }

        public string diamondClarity
        {
            get
            {
                return this.diamondClarityField;
            }
            set
            {
                this.diamondClarityField = value;
            }
        }

        public string gemstoneCut
        {
            get
            {
                return this.gemstoneCutField;
            }
            set
            {
                this.gemstoneCutField = value;
            }
        }

        public LengthUnit chainLength
        {
            get
            {
                return this.chainLengthField;
            }
            set
            {
                this.chainLengthField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public JewelryGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("bodyPart", IsNullable = false)]
        public List<string> bodyParts
        {
            get
            {
                return this.bodyPartsField;
            }
            set
            {
                this.bodyPartsField = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        public Rings Item
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

    public enum JewelryJewelryStyle
    {

        /// <remarks/>
        Religious,

        /// <remarks/>
        Fashion,

        /// <remarks/>
        Fine,
    }

    public enum JewelryGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class Rings
    {

        private List<string> ringStyleField;

        public Rings()
        {
            this.ringStyleField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("ringStyleValue", IsNullable = false)]
        public List<string> ringStyle
        {
            get
            {
                return this.ringStyleField;
            }
            set
            {
                this.ringStyleField = value;
            }
        }
    }

    public partial class Media
    {

        private string titleField;

        private List<string> originalLanguagesField;

        private string variantGroupIdField;

        private List<string> variantAttributeNamesField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private bool isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private List<string> awardsWonField;

        private List<string> characterField;

        private List<string> targetAudienceField;

        private bool isDownloadableContentAvailableField;

        private bool isDownloadableContentAvailableFieldSpecified;

        private object itemField;

        public Media()
        {
            this.targetAudienceField = new List<string>();
            this.characterField = new List<string>();
            this.awardsWonField = new List<string>();
            this.variantAttributeNamesField = new List<string>();
            this.originalLanguagesField = new List<string>();
        }

        public string title
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

        [System.Xml.Serialization.XmlArrayItemAttribute("originalLanguage", IsNullable = false)]
        public List<string> originalLanguages
        {
            get
            {
                return this.originalLanguagesField;
            }
            set
            {
                this.originalLanguagesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        public bool isAdultProduct
        {
            get
            {
                return this.isAdultProductField;
            }
            set
            {
                this.isAdultProductField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdultProductSpecified
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

        [System.Xml.Serialization.XmlArrayItemAttribute("awardsWonValue", IsNullable = false)]
        public List<string> awardsWon
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

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("targetAudienceValue", IsNullable = false)]
        public List<string> targetAudience
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

        public bool isDownloadableContentAvailable
        {
            get
            {
                return this.isDownloadableContentAvailableField;
            }
            set
            {
                this.isDownloadableContentAvailableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDownloadableContentAvailableSpecified
        {
            get
            {
                return this.isDownloadableContentAvailableFieldSpecified;
            }
            set
            {
                this.isDownloadableContentAvailableFieldSpecified = value;
            }
        }

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

    public partial class BooksAndMagazines
    {

        private string conditionField;

        private BooksAndMagazinesGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private List<string> materialField;

        private List<string> patternField;

        private string editionField;

        private string subjectField;

        private string bookFormatField;

        private string genreField;

        private string subgenreField;

        private List<string> authorField;

        private string editorField;

        private string illustratorField;

        private string publisherField;

        private string translatorField;

        private string translatedFromField;

        private BooksAndMagazinesFictionNonfiction fictionNonfictionField;

        private bool fictionNonfictionFieldSpecified;

        private bool isUnabridgedField;

        private bool isUnabridgedFieldSpecified;

        private System.DateTime originalPublicationDateField;

        private bool originalPublicationDateFieldSpecified;

        private System.DateTime publicationDateField;

        private bool publicationDateFieldSpecified;

        private string readingLevelField;

        private string numberOfPagesField;

        private string issueField;

        private string seriesTitleField;

        private string numberInSeriesField;

        public BooksAndMagazines()
        {
            this.authorField = new List<string>();
            this.patternField = new List<string>();
            this.materialField = new List<string>();
            this.colorField = new List<string>();
        }

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public BooksAndMagazinesGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        public string edition
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

        public string subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        public string bookFormat
        {
            get
            {
                return this.bookFormatField;
            }
            set
            {
                this.bookFormatField = value;
            }
        }

        public string genre
        {
            get
            {
                return this.genreField;
            }
            set
            {
                this.genreField = value;
            }
        }

        public string subgenre
        {
            get
            {
                return this.subgenreField;
            }
            set
            {
                this.subgenreField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("authorValue", IsNullable = false)]
        public List<string> author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        public string editor
        {
            get
            {
                return this.editorField;
            }
            set
            {
                this.editorField = value;
            }
        }

        public string illustrator
        {
            get
            {
                return this.illustratorField;
            }
            set
            {
                this.illustratorField = value;
            }
        }

        public string publisher
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

        public string translator
        {
            get
            {
                return this.translatorField;
            }
            set
            {
                this.translatorField = value;
            }
        }

        public string translatedFrom
        {
            get
            {
                return this.translatedFromField;
            }
            set
            {
                this.translatedFromField = value;
            }
        }

        public BooksAndMagazinesFictionNonfiction fictionNonfiction
        {
            get
            {
                return this.fictionNonfictionField;
            }
            set
            {
                this.fictionNonfictionField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fictionNonfictionSpecified
        {
            get
            {
                return this.fictionNonfictionFieldSpecified;
            }
            set
            {
                this.fictionNonfictionFieldSpecified = value;
            }
        }

        public bool isUnabridged
        {
            get
            {
                return this.isUnabridgedField;
            }
            set
            {
                this.isUnabridgedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isUnabridgedSpecified
        {
            get
            {
                return this.isUnabridgedFieldSpecified;
            }
            set
            {
                this.isUnabridgedFieldSpecified = value;
            }
        }

        public System.DateTime originalPublicationDate
        {
            get
            {
                return this.originalPublicationDateField;
            }
            set
            {
                this.originalPublicationDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool originalPublicationDateSpecified
        {
            get
            {
                return this.originalPublicationDateFieldSpecified;
            }
            set
            {
                this.originalPublicationDateFieldSpecified = value;
            }
        }

        public System.DateTime publicationDate
        {
            get
            {
                return this.publicationDateField;
            }
            set
            {
                this.publicationDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool publicationDateSpecified
        {
            get
            {
                return this.publicationDateFieldSpecified;
            }
            set
            {
                this.publicationDateFieldSpecified = value;
            }
        }

        public string readingLevel
        {
            get
            {
                return this.readingLevelField;
            }
            set
            {
                this.readingLevelField = value;
            }
        }

        public string numberOfPages
        {
            get
            {
                return this.numberOfPagesField;
            }
            set
            {
                this.numberOfPagesField = value;
            }
        }

        public string issue
        {
            get
            {
                return this.issueField;
            }
            set
            {
                this.issueField = value;
            }
        }

        public string seriesTitle
        {
            get
            {
                return this.seriesTitleField;
            }
            set
            {
                this.seriesTitleField = value;
            }
        }

        public string numberInSeries
        {
            get
            {
                return this.numberInSeriesField;
            }
            set
            {
                this.numberInSeriesField = value;
            }
        }
    }

    public enum BooksAndMagazinesGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public enum BooksAndMagazinesFictionNonfiction
    {

        /// <remarks/>
        Fiction,

        /// <remarks/>
        Nonfiction,
    }

    public partial class Movies
    {

        private MoviesMpaaRating mpaaRatingField;

        private string movieGenreField;

        private string movieSubgenreField;

        private System.DateTime theatricalReleaseDateField;

        private bool theatricalReleaseDateFieldSpecified;

        private string digitalVideoFormatsField;

        private string directorField;

        private List<string> actorsField;

        private string screenwriterField;

        private string studioProductionCompanyField;

        private string videoStreamingQualityField;

        private string audioTrackCodecField;

        private TimeUnit durationField;

        private System.DateTime dvdReleaseDateField;

        private bool dvdReleaseDateFieldSpecified;

        private bool isDubbedField;

        private bool isDubbedFieldSpecified;

        private List<string> dubbedLanguagesField;

        private bool hasSubtitlesField;

        private bool hasSubtitlesFieldSpecified;

        private List<string> subtitledLanguagesField;

        private string seriesTitleField;

        private string numberInSeriesField;

        private string aspectRatioField;

        public Movies()
        {
            this.subtitledLanguagesField = new List<string>();
            this.dubbedLanguagesField = new List<string>();
            this.durationField = new TimeUnit();
            this.actorsField = new List<string>();
        }

        public MoviesMpaaRating mpaaRating
        {
            get
            {
                return this.mpaaRatingField;
            }
            set
            {
                this.mpaaRatingField = value;
            }
        }

        public string movieGenre
        {
            get
            {
                return this.movieGenreField;
            }
            set
            {
                this.movieGenreField = value;
            }
        }

        public string movieSubgenre
        {
            get
            {
                return this.movieSubgenreField;
            }
            set
            {
                this.movieSubgenreField = value;
            }
        }

        public System.DateTime theatricalReleaseDate
        {
            get
            {
                return this.theatricalReleaseDateField;
            }
            set
            {
                this.theatricalReleaseDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool theatricalReleaseDateSpecified
        {
            get
            {
                return this.theatricalReleaseDateFieldSpecified;
            }
            set
            {
                this.theatricalReleaseDateFieldSpecified = value;
            }
        }

        public string digitalVideoFormats
        {
            get
            {
                return this.digitalVideoFormatsField;
            }
            set
            {
                this.digitalVideoFormatsField = value;
            }
        }

        public string director
        {
            get
            {
                return this.directorField;
            }
            set
            {
                this.directorField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("actor", IsNullable = false)]
        public List<string> actors
        {
            get
            {
                return this.actorsField;
            }
            set
            {
                this.actorsField = value;
            }
        }

        public string screenwriter
        {
            get
            {
                return this.screenwriterField;
            }
            set
            {
                this.screenwriterField = value;
            }
        }

        public string studioProductionCompany
        {
            get
            {
                return this.studioProductionCompanyField;
            }
            set
            {
                this.studioProductionCompanyField = value;
            }
        }

        public string videoStreamingQuality
        {
            get
            {
                return this.videoStreamingQualityField;
            }
            set
            {
                this.videoStreamingQualityField = value;
            }
        }

        public string audioTrackCodec
        {
            get
            {
                return this.audioTrackCodecField;
            }
            set
            {
                this.audioTrackCodecField = value;
            }
        }

        public TimeUnit duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        public System.DateTime dvdReleaseDate
        {
            get
            {
                return this.dvdReleaseDateField;
            }
            set
            {
                this.dvdReleaseDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dvdReleaseDateSpecified
        {
            get
            {
                return this.dvdReleaseDateFieldSpecified;
            }
            set
            {
                this.dvdReleaseDateFieldSpecified = value;
            }
        }

        public bool isDubbed
        {
            get
            {
                return this.isDubbedField;
            }
            set
            {
                this.isDubbedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDubbedSpecified
        {
            get
            {
                return this.isDubbedFieldSpecified;
            }
            set
            {
                this.isDubbedFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("dubbedLanguage", IsNullable = false)]
        public List<string> dubbedLanguages
        {
            get
            {
                return this.dubbedLanguagesField;
            }
            set
            {
                this.dubbedLanguagesField = value;
            }
        }

        public bool hasSubtitles
        {
            get
            {
                return this.hasSubtitlesField;
            }
            set
            {
                this.hasSubtitlesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSubtitlesSpecified
        {
            get
            {
                return this.hasSubtitlesFieldSpecified;
            }
            set
            {
                this.hasSubtitlesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("subtitledLanguage", IsNullable = false)]
        public List<string> subtitledLanguages
        {
            get
            {
                return this.subtitledLanguagesField;
            }
            set
            {
                this.subtitledLanguagesField = value;
            }
        }

        public string seriesTitle
        {
            get
            {
                return this.seriesTitleField;
            }
            set
            {
                this.seriesTitleField = value;
            }
        }

        public string numberInSeries
        {
            get
            {
                return this.numberInSeriesField;
            }
            set
            {
                this.numberInSeriesField = value;
            }
        }

        public string aspectRatio
        {
            get
            {
                return this.aspectRatioField;
            }
            set
            {
                this.aspectRatioField = value;
            }
        }
    }

    public enum MoviesMpaaRating
    {

        /// <remarks/>
        PG,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("PG-13")]
        PG13,

        /// <remarks/>
        G,

        /// <remarks/>
        R,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("NC-17")]
        NC17,

        /// <remarks/>
        Unrated,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Not Rated")]
        NotRated,
    }

    public partial class Music
    {

        private string musicGenreField;

        private string musicSubGenreField;

        private List<string> performerField;

        private string songwriterField;

        private string musicMediaFormatField;

        private string musicProducerField;

        private string recordLabelField;

        private string numberOfDiscsField;

        private string numberOfTracksField;

        private System.DateTime releaseDateField;

        private bool releaseDateFieldSpecified;

        private string musicReleaseTypeField;

        private bool hasParentalAdvisoryLabelField;

        private bool hasParentalAdvisoryLabelFieldSpecified;

        private List<trackListing> trackListingsField;

        private string seriesTitleField;

        private string numberInSeriesField;

        public Music()
        {
            this.trackListingsField = new List<trackListing>();
            this.performerField = new List<string>();
        }

        public string musicGenre
        {
            get
            {
                return this.musicGenreField;
            }
            set
            {
                this.musicGenreField = value;
            }
        }

        public string musicSubGenre
        {
            get
            {
                return this.musicSubGenreField;
            }
            set
            {
                this.musicSubGenreField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("performerValue", IsNullable = false)]
        public List<string> performer
        {
            get
            {
                return this.performerField;
            }
            set
            {
                this.performerField = value;
            }
        }

        public string songwriter
        {
            get
            {
                return this.songwriterField;
            }
            set
            {
                this.songwriterField = value;
            }
        }

        public string musicMediaFormat
        {
            get
            {
                return this.musicMediaFormatField;
            }
            set
            {
                this.musicMediaFormatField = value;
            }
        }

        public string musicProducer
        {
            get
            {
                return this.musicProducerField;
            }
            set
            {
                this.musicProducerField = value;
            }
        }

        public string recordLabel
        {
            get
            {
                return this.recordLabelField;
            }
            set
            {
                this.recordLabelField = value;
            }
        }

        public string numberOfDiscs
        {
            get
            {
                return this.numberOfDiscsField;
            }
            set
            {
                this.numberOfDiscsField = value;
            }
        }

        public string numberOfTracks
        {
            get
            {
                return this.numberOfTracksField;
            }
            set
            {
                this.numberOfTracksField = value;
            }
        }

        public System.DateTime releaseDate
        {
            get
            {
                return this.releaseDateField;
            }
            set
            {
                this.releaseDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseDateSpecified
        {
            get
            {
                return this.releaseDateFieldSpecified;
            }
            set
            {
                this.releaseDateFieldSpecified = value;
            }
        }

        public string musicReleaseType
        {
            get
            {
                return this.musicReleaseTypeField;
            }
            set
            {
                this.musicReleaseTypeField = value;
            }
        }

        public bool hasParentalAdvisoryLabel
        {
            get
            {
                return this.hasParentalAdvisoryLabelField;
            }
            set
            {
                this.hasParentalAdvisoryLabelField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasParentalAdvisoryLabelSpecified
        {
            get
            {
                return this.hasParentalAdvisoryLabelFieldSpecified;
            }
            set
            {
                this.hasParentalAdvisoryLabelFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<trackListing> trackListings
        {
            get
            {
                return this.trackListingsField;
            }
            set
            {
                this.trackListingsField = value;
            }
        }

        public string seriesTitle
        {
            get
            {
                return this.seriesTitleField;
            }
            set
            {
                this.seriesTitleField = value;
            }
        }

        public string numberInSeries
        {
            get
            {
                return this.numberInSeriesField;
            }
            set
            {
                this.numberInSeriesField = value;
            }
        }
    }

    public partial class trackListing
    {

        private string trackNumberField;

        private string trackNameField;

        private decimal trackDurationField;

        private bool trackDurationFieldSpecified;

        public string trackNumber
        {
            get
            {
                return this.trackNumberField;
            }
            set
            {
                this.trackNumberField = value;
            }
        }

        public string trackName
        {
            get
            {
                return this.trackNameField;
            }
            set
            {
                this.trackNameField = value;
            }
        }

        public decimal trackDuration
        {
            get
            {
                return this.trackDurationField;
            }
            set
            {
                this.trackDurationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trackDurationSpecified
        {
            get
            {
                return this.trackDurationFieldSpecified;
            }
            set
            {
                this.trackDurationFieldSpecified = value;
            }
        }
    }

    public partial class TVShows
    {

        private string digitalVideoFormatsField;

        private string tvRatingField;

        private string tvShowGenreField;

        private string tvShowSubgenreField;

        private string tvNetworkField;

        private string tvShowSeasonField;

        private string numberOfEpisodesField;

        private string episodeField;

        private string directorField;

        private List<string> actorsField;

        private string screenwriterField;

        private string studioProductionCompanyField;

        private string videoStreamingQualityField;

        private string audioTrackCodecField;

        private TimeUnit durationField;

        private System.DateTime dvdReleaseDateField;

        private bool dvdReleaseDateFieldSpecified;

        private bool isDubbedField;

        private bool isDubbedFieldSpecified;

        private List<string> dubbedLanguagesField;

        private bool hasSubtitlesField;

        private bool hasSubtitlesFieldSpecified;

        private List<string> subtitledLanguagesField;

        private string seriesTitleField;

        private string numberInSeriesField;

        private string aspectRatioField;

        public TVShows()
        {
            this.subtitledLanguagesField = new List<string>();
            this.dubbedLanguagesField = new List<string>();
            this.durationField = new TimeUnit();
            this.actorsField = new List<string>();
        }

        public string digitalVideoFormats
        {
            get
            {
                return this.digitalVideoFormatsField;
            }
            set
            {
                this.digitalVideoFormatsField = value;
            }
        }

        public string tvRating
        {
            get
            {
                return this.tvRatingField;
            }
            set
            {
                this.tvRatingField = value;
            }
        }

        public string tvShowGenre
        {
            get
            {
                return this.tvShowGenreField;
            }
            set
            {
                this.tvShowGenreField = value;
            }
        }

        public string tvShowSubgenre
        {
            get
            {
                return this.tvShowSubgenreField;
            }
            set
            {
                this.tvShowSubgenreField = value;
            }
        }

        public string tvNetwork
        {
            get
            {
                return this.tvNetworkField;
            }
            set
            {
                this.tvNetworkField = value;
            }
        }

        public string tvShowSeason
        {
            get
            {
                return this.tvShowSeasonField;
            }
            set
            {
                this.tvShowSeasonField = value;
            }
        }

        public string numberOfEpisodes
        {
            get
            {
                return this.numberOfEpisodesField;
            }
            set
            {
                this.numberOfEpisodesField = value;
            }
        }

        public string episode
        {
            get
            {
                return this.episodeField;
            }
            set
            {
                this.episodeField = value;
            }
        }

        public string director
        {
            get
            {
                return this.directorField;
            }
            set
            {
                this.directorField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("actor", IsNullable = false)]
        public List<string> actors
        {
            get
            {
                return this.actorsField;
            }
            set
            {
                this.actorsField = value;
            }
        }

        public string screenwriter
        {
            get
            {
                return this.screenwriterField;
            }
            set
            {
                this.screenwriterField = value;
            }
        }

        public string studioProductionCompany
        {
            get
            {
                return this.studioProductionCompanyField;
            }
            set
            {
                this.studioProductionCompanyField = value;
            }
        }

        public string videoStreamingQuality
        {
            get
            {
                return this.videoStreamingQualityField;
            }
            set
            {
                this.videoStreamingQualityField = value;
            }
        }

        public string audioTrackCodec
        {
            get
            {
                return this.audioTrackCodecField;
            }
            set
            {
                this.audioTrackCodecField = value;
            }
        }

        public TimeUnit duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        public System.DateTime dvdReleaseDate
        {
            get
            {
                return this.dvdReleaseDateField;
            }
            set
            {
                this.dvdReleaseDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dvdReleaseDateSpecified
        {
            get
            {
                return this.dvdReleaseDateFieldSpecified;
            }
            set
            {
                this.dvdReleaseDateFieldSpecified = value;
            }
        }

        public bool isDubbed
        {
            get
            {
                return this.isDubbedField;
            }
            set
            {
                this.isDubbedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDubbedSpecified
        {
            get
            {
                return this.isDubbedFieldSpecified;
            }
            set
            {
                this.isDubbedFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("dubbedLanguage", IsNullable = false)]
        public List<string> dubbedLanguages
        {
            get
            {
                return this.dubbedLanguagesField;
            }
            set
            {
                this.dubbedLanguagesField = value;
            }
        }

        public bool hasSubtitles
        {
            get
            {
                return this.hasSubtitlesField;
            }
            set
            {
                this.hasSubtitlesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSubtitlesSpecified
        {
            get
            {
                return this.hasSubtitlesFieldSpecified;
            }
            set
            {
                this.hasSubtitlesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("subtitledLanguage", IsNullable = false)]
        public List<string> subtitledLanguages
        {
            get
            {
                return this.subtitledLanguagesField;
            }
            set
            {
                this.subtitledLanguagesField = value;
            }
        }

        public string seriesTitle
        {
            get
            {
                return this.seriesTitleField;
            }
            set
            {
                this.seriesTitleField = value;
            }
        }

        public string numberInSeries
        {
            get
            {
                return this.numberInSeriesField;
            }
            set
            {
                this.numberInSeriesField = value;
            }
        }

        public string aspectRatio
        {
            get
            {
                return this.aspectRatioField;
            }
            set
            {
                this.aspectRatioField = value;
            }
        }
    }

    public partial class MusicalInstrument
    {

        private List<swatchImage> swatchImagesField;

        private string variantGroupIdField;

        private List<string> variantAttributeNamesField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private string brandField;

        private string conditionField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private List<string> colorField;

        private List<string> materialField;

        private string numberOfPiecesField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private List<string> recommendedUsesField;

        private List<string> recommendedLocationsField;

        private object itemField;

        public MusicalInstrument()
        {
            this.recommendedLocationsField = new List<string>();
            this.recommendedUsesField = new List<string>();
            this.materialField = new List<string>();
            this.colorField = new List<string>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        public string brand
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

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        public string numberOfPieces
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

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedLocation", IsNullable = false)]
        public List<string> recommendedLocations
        {
            get
            {
                return this.recommendedLocationsField;
            }
            set
            {
                this.recommendedLocationsField = value;
            }
        }

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

    public partial class InstrumentAccessories
    {

        private bool hasSignalBoosterField;

        private bool hasSignalBoosterFieldSpecified;

        private bool hasWirelessMicrophoneField;

        private bool hasWirelessMicrophoneFieldSpecified;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private List<string> patternField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private List<string> instrumentField;

        private List<inputsAndOutput> inputsAndOutputsField;

        private string displayTechnologyField;

        private bool hasBluetoothField;

        private bool hasBluetoothFieldSpecified;

        private TimeUnit batteryLifeField;

        private List<string> wirelessTechnologiesField;

        public InstrumentAccessories()
        {
            this.wirelessTechnologiesField = new List<string>();
            this.batteryLifeField = new TimeUnit();
            this.inputsAndOutputsField = new List<inputsAndOutput>();
            this.instrumentField = new List<string>();
            this.patternField = new List<string>();
        }

        public bool hasSignalBooster
        {
            get
            {
                return this.hasSignalBoosterField;
            }
            set
            {
                this.hasSignalBoosterField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSignalBoosterSpecified
        {
            get
            {
                return this.hasSignalBoosterFieldSpecified;
            }
            set
            {
                this.hasSignalBoosterFieldSpecified = value;
            }
        }

        public bool hasWirelessMicrophone
        {
            get
            {
                return this.hasWirelessMicrophoneField;
            }
            set
            {
                this.hasWirelessMicrophoneField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWirelessMicrophoneSpecified
        {
            get
            {
                return this.hasWirelessMicrophoneFieldSpecified;
            }
            set
            {
                this.hasWirelessMicrophoneFieldSpecified = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        public bool isRemoteControlIncluded
        {
            get
            {
                return this.isRemoteControlIncludedField;
            }
            set
            {
                this.isRemoteControlIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRemoteControlIncludedSpecified
        {
            get
            {
                return this.isRemoteControlIncludedFieldSpecified;
            }
            set
            {
                this.isRemoteControlIncludedFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("instrumentValue", IsNullable = false)]
        public List<string> instrument
        {
            get
            {
                return this.instrumentField;
            }
            set
            {
                this.instrumentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<inputsAndOutput> inputsAndOutputs
        {
            get
            {
                return this.inputsAndOutputsField;
            }
            set
            {
                this.inputsAndOutputsField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        public bool hasBluetooth
        {
            get
            {
                return this.hasBluetoothField;
            }
            set
            {
                this.hasBluetoothField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasBluetoothSpecified
        {
            get
            {
                return this.hasBluetoothFieldSpecified;
            }
            set
            {
                this.hasBluetoothFieldSpecified = value;
            }
        }

        public TimeUnit batteryLife
        {
            get
            {
                return this.batteryLifeField;
            }
            set
            {
                this.batteryLifeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }

    public partial class MusicCasesAndBags
    {

        private List<fabricContentValue> fabricContentField;

        private List<string> fabricCareInstructionsField;

        private bool hardOrSoftCaseField;

        private bool hardOrSoftCaseFieldSpecified;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private List<string> instrumentField;

        private string shapeField;

        public MusicCasesAndBags()
        {
            this.instrumentField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public bool hardOrSoftCase
        {
            get
            {
                return this.hardOrSoftCaseField;
            }
            set
            {
                this.hardOrSoftCaseField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hardOrSoftCaseSpecified
        {
            get
            {
                return this.hardOrSoftCaseFieldSpecified;
            }
            set
            {
                this.hardOrSoftCaseFieldSpecified = value;
            }
        }

        public bool isWheeled
        {
            get
            {
                return this.isWheeledField;
            }
            set
            {
                this.isWheeledField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWheeledSpecified
        {
            get
            {
                return this.isWheeledFieldSpecified;
            }
            set
            {
                this.isWheeledFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("instrumentValue", IsNullable = false)]
        public List<string> instrument
        {
            get
            {
                return this.instrumentField;
            }
            set
            {
                this.instrumentField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }
    }

    public partial class MusicalInstruments
    {

        private string finishField;

        private bool hasSignalBoosterField;

        private bool hasSignalBoosterFieldSpecified;

        private bool hasWirelessMicrophoneField;

        private bool hasWirelessMicrophoneFieldSpecified;

        private List<string> ageGroupField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private string powerTypeField;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private List<string> recommendedUsesField;

        private List<string> recommendedLocationsField;

        private string audioPowerOutputField;

        private bool isCollectibleField;

        private bool isCollectibleFieldSpecified;

        private string musicalInstrumentFamilyField;

        private bool isAcousticField;

        private bool isAcousticFieldSpecified;

        private bool isElectricField;

        private bool isElectricFieldSpecified;

        private bool isFrettedField;

        private bool isFrettedFieldSpecified;

        private List<string> instrumentField;

        private string shapeField;

        private List<inputsAndOutput> inputsAndOutputsField;

        private bool hasIntegratedSpeakersField;

        private bool hasIntegratedSpeakersFieldSpecified;

        private string displayTechnologyField;

        private bool hasBluetoothField;

        private bool hasBluetoothFieldSpecified;

        private TimeUnit batteryLifeField;

        public MusicalInstruments()
        {
            this.batteryLifeField = new TimeUnit();
            this.inputsAndOutputsField = new List<inputsAndOutput>();
            this.instrumentField = new List<string>();
            this.recommendedLocationsField = new List<string>();
            this.recommendedUsesField = new List<string>();
            this.ageGroupField = new List<string>();
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public bool hasSignalBooster
        {
            get
            {
                return this.hasSignalBoosterField;
            }
            set
            {
                this.hasSignalBoosterField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSignalBoosterSpecified
        {
            get
            {
                return this.hasSignalBoosterFieldSpecified;
            }
            set
            {
                this.hasSignalBoosterFieldSpecified = value;
            }
        }

        public bool hasWirelessMicrophone
        {
            get
            {
                return this.hasWirelessMicrophoneField;
            }
            set
            {
                this.hasWirelessMicrophoneField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWirelessMicrophoneSpecified
        {
            get
            {
                return this.hasWirelessMicrophoneFieldSpecified;
            }
            set
            {
                this.hasWirelessMicrophoneFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedLocation", IsNullable = false)]
        public List<string> recommendedLocations
        {
            get
            {
                return this.recommendedLocationsField;
            }
            set
            {
                this.recommendedLocationsField = value;
            }
        }

        public string audioPowerOutput
        {
            get
            {
                return this.audioPowerOutputField;
            }
            set
            {
                this.audioPowerOutputField = value;
            }
        }

        public bool isCollectible
        {
            get
            {
                return this.isCollectibleField;
            }
            set
            {
                this.isCollectibleField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCollectibleSpecified
        {
            get
            {
                return this.isCollectibleFieldSpecified;
            }
            set
            {
                this.isCollectibleFieldSpecified = value;
            }
        }

        public string musicalInstrumentFamily
        {
            get
            {
                return this.musicalInstrumentFamilyField;
            }
            set
            {
                this.musicalInstrumentFamilyField = value;
            }
        }

        public bool isAcoustic
        {
            get
            {
                return this.isAcousticField;
            }
            set
            {
                this.isAcousticField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAcousticSpecified
        {
            get
            {
                return this.isAcousticFieldSpecified;
            }
            set
            {
                this.isAcousticFieldSpecified = value;
            }
        }

        public bool isElectric
        {
            get
            {
                return this.isElectricField;
            }
            set
            {
                this.isElectricField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isElectricSpecified
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

        public bool isFretted
        {
            get
            {
                return this.isFrettedField;
            }
            set
            {
                this.isFrettedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFrettedSpecified
        {
            get
            {
                return this.isFrettedFieldSpecified;
            }
            set
            {
                this.isFrettedFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("instrumentValue", IsNullable = false)]
        public List<string> instrument
        {
            get
            {
                return this.instrumentField;
            }
            set
            {
                this.instrumentField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<inputsAndOutput> inputsAndOutputs
        {
            get
            {
                return this.inputsAndOutputsField;
            }
            set
            {
                this.inputsAndOutputsField = value;
            }
        }

        public bool hasIntegratedSpeakers
        {
            get
            {
                return this.hasIntegratedSpeakersField;
            }
            set
            {
                this.hasIntegratedSpeakersField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasIntegratedSpeakersSpecified
        {
            get
            {
                return this.hasIntegratedSpeakersFieldSpecified;
            }
            set
            {
                this.hasIntegratedSpeakersFieldSpecified = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        public bool hasBluetooth
        {
            get
            {
                return this.hasBluetoothField;
            }
            set
            {
                this.hasBluetoothField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasBluetoothSpecified
        {
            get
            {
                return this.hasBluetoothFieldSpecified;
            }
            set
            {
                this.hasBluetoothFieldSpecified = value;
            }
        }

        public TimeUnit batteryLife
        {
            get
            {
                return this.batteryLifeField;
            }
            set
            {
                this.batteryLifeField = value;
            }
        }
    }

    public partial class SoundAndRecording
    {

        private bool hasSignalBoosterField;

        private bool hasSignalBoosterFieldSpecified;

        private bool hasWirelessMicrophoneField;

        private bool hasWirelessMicrophoneFieldSpecified;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string powerTypeField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private string audioPowerOutputField;

        private string equalizerControlField;

        private List<inputsAndOutput> inputsAndOutputsField;

        private bool hasIntegratedSpeakersField;

        private bool hasIntegratedSpeakersFieldSpecified;

        private bool hasBluetoothField;

        private bool hasBluetoothFieldSpecified;

        private TimeUnit batteryLifeField;

        private List<string> wirelessTechnologiesField;

        public SoundAndRecording()
        {
            this.wirelessTechnologiesField = new List<string>();
            this.batteryLifeField = new TimeUnit();
            this.inputsAndOutputsField = new List<inputsAndOutput>();
        }

        public bool hasSignalBooster
        {
            get
            {
                return this.hasSignalBoosterField;
            }
            set
            {
                this.hasSignalBoosterField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSignalBoosterSpecified
        {
            get
            {
                return this.hasSignalBoosterFieldSpecified;
            }
            set
            {
                this.hasSignalBoosterFieldSpecified = value;
            }
        }

        public bool hasWirelessMicrophone
        {
            get
            {
                return this.hasWirelessMicrophoneField;
            }
            set
            {
                this.hasWirelessMicrophoneField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWirelessMicrophoneSpecified
        {
            get
            {
                return this.hasWirelessMicrophoneFieldSpecified;
            }
            set
            {
                this.hasWirelessMicrophoneFieldSpecified = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public bool isRemoteControlIncluded
        {
            get
            {
                return this.isRemoteControlIncludedField;
            }
            set
            {
                this.isRemoteControlIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRemoteControlIncludedSpecified
        {
            get
            {
                return this.isRemoteControlIncludedFieldSpecified;
            }
            set
            {
                this.isRemoteControlIncludedFieldSpecified = value;
            }
        }

        public string audioPowerOutput
        {
            get
            {
                return this.audioPowerOutputField;
            }
            set
            {
                this.audioPowerOutputField = value;
            }
        }

        public string equalizerControl
        {
            get
            {
                return this.equalizerControlField;
            }
            set
            {
                this.equalizerControlField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<inputsAndOutput> inputsAndOutputs
        {
            get
            {
                return this.inputsAndOutputsField;
            }
            set
            {
                this.inputsAndOutputsField = value;
            }
        }

        public bool hasIntegratedSpeakers
        {
            get
            {
                return this.hasIntegratedSpeakersField;
            }
            set
            {
                this.hasIntegratedSpeakersField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasIntegratedSpeakersSpecified
        {
            get
            {
                return this.hasIntegratedSpeakersFieldSpecified;
            }
            set
            {
                this.hasIntegratedSpeakersFieldSpecified = value;
            }
        }

        public bool hasBluetooth
        {
            get
            {
                return this.hasBluetoothField;
            }
            set
            {
                this.hasBluetoothField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasBluetoothSpecified
        {
            get
            {
                return this.hasBluetoothFieldSpecified;
            }
            set
            {
                this.hasBluetoothFieldSpecified = value;
            }
        }

        public TimeUnit batteryLife
        {
            get
            {
                return this.batteryLifeField;
            }
            set
            {
                this.batteryLifeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }

    public partial class OccasionAndSeasonal
    {

        private List<swatchImage> swatchImagesField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<string> holidayLightingStyleField;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private List<string> colorField;

        private List<string> patternField;

        private List<string> materialField;

        private string numberOfPiecesField;

        private string powerTypeField;

        private List<string> occasionField;

        private List<string> recommendedUsesField;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private string assemblyInstructionsField;

        private PowerUnit wattsField;

        private string lightBulbTypeField;

        private object itemField;

        public OccasionAndSeasonal()
        {
            this.wattsField = new PowerUnit();
            this.recommendedUsesField = new List<string>();
            this.occasionField = new List<string>();
            this.materialField = new List<string>();
            this.patternField = new List<string>();
            this.colorField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.holidayLightingStyleField = new List<string>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("holidayLightingStyleValue", IsNullable = false)]
        public List<string> holidayLightingStyle
        {
            get
            {
                return this.holidayLightingStyleField;
            }
            set
            {
                this.holidayLightingStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        public string numberOfPieces
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

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
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

        public string assemblyInstructions
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

        public PowerUnit watts
        {
            get
            {
                return this.wattsField;
            }
            set
            {
                this.wattsField = value;
            }
        }

        public string lightBulbType
        {
            get
            {
                return this.lightBulbTypeField;
            }
            set
            {
                this.lightBulbTypeField = value;
            }
        }

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

    public partial class CeremonialClothingAndAccessories
    {

        private List<fabricContentValue> fabricContentField;

        private List<string> fabricCareInstructionsField;

        private string clothingSizeField;

        private CeremonialClothingAndAccessoriesGender genderField;

        private bool genderFieldSpecified;

        private CeremonialClothingAndAccessoriesClothingSizeType clothingSizeTypeField;

        private bool clothingSizeTypeFieldSpecified;

        private List<string> patternField;

        private CeremonialClothingAndAccessoriesApparelCategory apparelCategoryField;

        private bool apparelCategoryFieldSpecified;

        public CeremonialClothingAndAccessories()
        {
            this.patternField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string clothingSize
        {
            get
            {
                return this.clothingSizeField;
            }
            set
            {
                this.clothingSizeField = value;
            }
        }

        public CeremonialClothingAndAccessoriesGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        public CeremonialClothingAndAccessoriesClothingSizeType clothingSizeType
        {
            get
            {
                return this.clothingSizeTypeField;
            }
            set
            {
                this.clothingSizeTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool clothingSizeTypeSpecified
        {
            get
            {
                return this.clothingSizeTypeFieldSpecified;
            }
            set
            {
                this.clothingSizeTypeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        public CeremonialClothingAndAccessoriesApparelCategory apparelCategory
        {
            get
            {
                return this.apparelCategoryField;
            }
            set
            {
                this.apparelCategoryField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool apparelCategorySpecified
        {
            get
            {
                return this.apparelCategoryFieldSpecified;
            }
            set
            {
                this.apparelCategoryFieldSpecified = value;
            }
        }
    }

    public enum CeremonialClothingAndAccessoriesGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public enum CeremonialClothingAndAccessoriesClothingSizeType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Junior Plus")]
        JuniorPlus,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Petite Plus")]
        PetitePlus,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Big  Tall")]
        BigTall,

        /// <remarks/>
        Plus,

        /// <remarks/>
        Juniors,

        /// <remarks/>
        Regular,

        /// <remarks/>
        Big,

        /// <remarks/>
        Husky,

        /// <remarks/>
        Slim,

        /// <remarks/>
        Tall,

        /// <remarks/>
        Petite,
    }

    public enum CeremonialClothingAndAccessoriesApparelCategory
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Young Men\'s")]
        YoungMens,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Maternity Plus")]
        MaternityPlus,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("School Uniforms")]
        SchoolUniforms,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Men\'s Big  Tall")]
        MensBigTall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Women\'s Plus")]
        WomensPlus,

        /// <remarks/>
        Petites,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Maternity Wear")]
        MaternityWear,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Newborn Girl")]
        NewbornGirl,

        /// <remarks/>
        Boys,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Baby Boy")]
        BabyBoy,

        /// <remarks/>
        Girls,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Baby Girl")]
        BabyGirl,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Newborn Boy")]
        NewbornBoy,

        /// <remarks/>
        Juniors,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,
    }

    public partial class Costumes
    {

        private List<fabricContentValue> fabricContentField;

        private List<string> fabricCareInstructionsField;

        private List<string> themeField;

        private string clothingSizeField;

        private CostumesGender genderField;

        private bool genderFieldSpecified;

        private List<string> ageGroupField;

        private CostumesClothingSizeType clothingSizeTypeField;

        private bool clothingSizeTypeFieldSpecified;

        private string animalTypeField;

        private List<string> characterField;

        private List<string> targetAudienceField;

        public Costumes()
        {
            this.targetAudienceField = new List<string>();
            this.characterField = new List<string>();
            this.ageGroupField = new List<string>();
            this.themeField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public List<string> theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        public string clothingSize
        {
            get
            {
                return this.clothingSizeField;
            }
            set
            {
                this.clothingSizeField = value;
            }
        }

        public CostumesGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public CostumesClothingSizeType clothingSizeType
        {
            get
            {
                return this.clothingSizeTypeField;
            }
            set
            {
                this.clothingSizeTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool clothingSizeTypeSpecified
        {
            get
            {
                return this.clothingSizeTypeFieldSpecified;
            }
            set
            {
                this.clothingSizeTypeFieldSpecified = value;
            }
        }

        public string animalType
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

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("targetAudienceValue", IsNullable = false)]
        public List<string> targetAudience
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
    }

    public enum CostumesGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public enum CostumesClothingSizeType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Junior Plus")]
        JuniorPlus,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Petite Plus")]
        PetitePlus,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Big  Tall")]
        BigTall,

        /// <remarks/>
        Plus,

        /// <remarks/>
        Juniors,

        /// <remarks/>
        Regular,

        /// <remarks/>
        Big,

        /// <remarks/>
        Husky,

        /// <remarks/>
        Slim,

        /// <remarks/>
        Tall,

        /// <remarks/>
        Petite,
    }

    public partial class DecorationsAndFavors
    {

        private List<fabricContentValue> fabricContentField;

        private bool isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private string finishField;

        private bool isRecyclableField;

        private bool isRecyclableFieldSpecified;

        private List<string> themeField;

        private DecorationsAndFavorsGender genderField;

        private bool genderFieldSpecified;

        private List<string> ageGroupField;

        private string numberOfPiecesField;

        private List<string> characterField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string powerTypeField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private bool isInflatableField;

        private bool isInflatableFieldSpecified;

        private bool isAnimatedField;

        private bool isAnimatedFieldSpecified;

        private List<string> targetAudienceField;

        private bool makesNoiseField;

        private bool makesNoiseFieldSpecified;

        private string shapeField;

        public DecorationsAndFavors()
        {
            this.targetAudienceField = new List<string>();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.characterField = new List<string>();
            this.ageGroupField = new List<string>();
            this.themeField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public bool isAdultProduct
        {
            get
            {
                return this.isAdultProductField;
            }
            set
            {
                this.isAdultProductField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdultProductSpecified
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

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public bool isRecyclable
        {
            get
            {
                return this.isRecyclableField;
            }
            set
            {
                this.isRecyclableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRecyclableSpecified
        {
            get
            {
                return this.isRecyclableFieldSpecified;
            }
            set
            {
                this.isRecyclableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public List<string> theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        public DecorationsAndFavorsGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public string numberOfPieces
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

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        public bool isInflatable
        {
            get
            {
                return this.isInflatableField;
            }
            set
            {
                this.isInflatableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInflatableSpecified
        {
            get
            {
                return this.isInflatableFieldSpecified;
            }
            set
            {
                this.isInflatableFieldSpecified = value;
            }
        }

        public bool isAnimated
        {
            get
            {
                return this.isAnimatedField;
            }
            set
            {
                this.isAnimatedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAnimatedSpecified
        {
            get
            {
                return this.isAnimatedFieldSpecified;
            }
            set
            {
                this.isAnimatedFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("targetAudienceValue", IsNullable = false)]
        public List<string> targetAudience
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

        public bool makesNoise
        {
            get
            {
                return this.makesNoiseField;
            }
            set
            {
                this.makesNoiseField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool makesNoiseSpecified
        {
            get
            {
                return this.makesNoiseFieldSpecified;
            }
            set
            {
                this.makesNoiseFieldSpecified = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }
    }

    public enum DecorationsAndFavorsGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class Funeral
    {

        private string finishField;

        private List<string> fillMaterialField;

        public Funeral()
        {
            this.fillMaterialField = new List<string>();
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fillMaterialValue", IsNullable = false)]
        public List<string> fillMaterial
        {
            get
            {
                return this.fillMaterialField;
            }
            set
            {
                this.fillMaterialField = value;
            }
        }
    }

    public partial class Office
    {

        private List<string> inkColorField;

        private string numberOfSheetsField;

        private bool isRefillableField;

        private bool isRefillableFieldSpecified;

        private List<swatchImage> swatchImagesField;

        private string systemOfMeasurementField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isAntiglareField;

        private bool isAntiglareFieldSpecified;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private string finishField;

        private bool isRecyclableField;

        private bool isRecyclableFieldSpecified;

        private bool isMagneticField;

        private bool isMagneticFieldSpecified;

        private string brandField;

        private decimal envelopeSizeField;

        private bool envelopeSizeFieldSpecified;

        private string conditionField;

        private LengthUnit holeSizeField;

        private string manufacturerField;

        private List<string> themeField;

        private List<string> paperSizeField;

        private string yearField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private string calendarFormatField;

        private TimeUnit calendarTermField;

        private List<string> colorField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private List<string> ageGroupField;

        private string dexterityField;

        private string batterySizeField;

        private List<string> materialField;

        private List<string> patternField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private List<string> characterField;

        private string powerTypeField;

        private List<string> occasionField;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private List<string> recommendedUsesField;

        private bool isRetractableField;

        private bool isRetractableFieldSpecified;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private bool isTearResistantField;

        private bool isTearResistantFieldSpecified;

        private string capacityField;

        private BrightnessUnit brightnessField;

        private string shapeField;

        private List<string> compatibleDevicesField;

        public Office()
        {
            this.compatibleDevicesField = new List<string>();
            this.brightnessField = new BrightnessUnit();
            this.recommendedUsesField = new List<string>();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.occasionField = new List<string>();
            this.characterField = new List<string>();
            this.patternField = new List<string>();
            this.materialField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.calendarTermField = new TimeUnit();
            this.paperSizeField = new List<string>();
            this.themeField = new List<string>();
            this.holeSizeField = new LengthUnit();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
            this.inkColorField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("inkColorValue", IsNullable = false)]
        public List<string> inkColor
        {
            get
            {
                return this.inkColorField;
            }
            set
            {
                this.inkColorField = value;
            }
        }

        public string numberOfSheets
        {
            get
            {
                return this.numberOfSheetsField;
            }
            set
            {
                this.numberOfSheetsField = value;
            }
        }

        public bool isRefillable
        {
            get
            {
                return this.isRefillableField;
            }
            set
            {
                this.isRefillableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRefillableSpecified
        {
            get
            {
                return this.isRefillableFieldSpecified;
            }
            set
            {
                this.isRefillableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public string systemOfMeasurement
        {
            get
            {
                return this.systemOfMeasurementField;
            }
            set
            {
                this.systemOfMeasurementField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isAntiglare
        {
            get
            {
                return this.isAntiglareField;
            }
            set
            {
                this.isAntiglareField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAntiglareSpecified
        {
            get
            {
                return this.isAntiglareFieldSpecified;
            }
            set
            {
                this.isAntiglareFieldSpecified = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public bool isRecyclable
        {
            get
            {
                return this.isRecyclableField;
            }
            set
            {
                this.isRecyclableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRecyclableSpecified
        {
            get
            {
                return this.isRecyclableFieldSpecified;
            }
            set
            {
                this.isRecyclableFieldSpecified = value;
            }
        }

        public bool isMagnetic
        {
            get
            {
                return this.isMagneticField;
            }
            set
            {
                this.isMagneticField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMagneticSpecified
        {
            get
            {
                return this.isMagneticFieldSpecified;
            }
            set
            {
                this.isMagneticFieldSpecified = value;
            }
        }

        public string brand
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

        public decimal envelopeSize
        {
            get
            {
                return this.envelopeSizeField;
            }
            set
            {
                this.envelopeSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool envelopeSizeSpecified
        {
            get
            {
                return this.envelopeSizeFieldSpecified;
            }
            set
            {
                this.envelopeSizeFieldSpecified = value;
            }
        }

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public LengthUnit holeSize
        {
            get
            {
                return this.holeSizeField;
            }
            set
            {
                this.holeSizeField = value;
            }
        }

        public string manufacturer
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

        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public List<string> theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("paperSizeValue", IsNullable = false)]
        public List<string> paperSize
        {
            get
            {
                return this.paperSizeField;
            }
            set
            {
                this.paperSizeField = value;
            }
        }

        public string year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public string calendarFormat
        {
            get
            {
                return this.calendarFormatField;
            }
            set
            {
                this.calendarFormatField = value;
            }
        }

        public TimeUnit calendarTerm
        {
            get
            {
                return this.calendarTermField;
            }
            set
            {
                this.calendarTermField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public string dexterity
        {
            get
            {
                return this.dexterityField;
            }
            set
            {
                this.dexterityField = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        public bool isRetractable
        {
            get
            {
                return this.isRetractableField;
            }
            set
            {
                this.isRetractableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRetractableSpecified
        {
            get
            {
                return this.isRetractableFieldSpecified;
            }
            set
            {
                this.isRetractableFieldSpecified = value;
            }
        }

        public bool isIndustrial
        {
            get
            {
                return this.isIndustrialField;
            }
            set
            {
                this.isIndustrialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIndustrialSpecified
        {
            get
            {
                return this.isIndustrialFieldSpecified;
            }
            set
            {
                this.isIndustrialFieldSpecified = value;
            }
        }

        public bool isTearResistant
        {
            get
            {
                return this.isTearResistantField;
            }
            set
            {
                this.isTearResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTearResistantSpecified
        {
            get
            {
                return this.isTearResistantFieldSpecified;
            }
            set
            {
                this.isTearResistantFieldSpecified = value;
            }
        }

        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        public BrightnessUnit brightness
        {
            get
            {
                return this.brightnessField;
            }
            set
            {
                this.brightnessField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleDevice", IsNullable = false)]
        public List<string> compatibleDevices
        {
            get
            {
                return this.compatibleDevicesField;
            }
            set
            {
                this.compatibleDevicesField = value;
            }
        }
    }

    public partial class Other
    {

        private List<swatchImage> swatchImagesField;

        private string systemOfMeasurementField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private string finishField;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private OtherGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private List<string> recommendedRoomsField;

        private List<string> connectionsField;

        private List<string> materialField;

        private List<string> patternField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private List<string> characterField;

        private string powerTypeField;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private List<string> recommendedLocationsField;

        private bool isRetractableField;

        private bool isRetractableFieldSpecified;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private bool isCollectibleField;

        private bool isCollectibleFieldSpecified;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private string assemblyInstructionsField;

        private List<string> recommendedSurfacesField;

        private ElectricalMeasurementUnit voltsField;

        private string shapeField;

        private string displayTechnologyField;

        private object itemField;

        public Other()
        {
            this.voltsField = new ElectricalMeasurementUnit();
            this.recommendedSurfacesField = new List<string>();
            this.recommendedLocationsField = new List<string>();
            this.characterField = new List<string>();
            this.patternField = new List<string>();
            this.materialField = new List<string>();
            this.connectionsField = new List<string>();
            this.recommendedRoomsField = new List<string>();
            this.colorField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public string systemOfMeasurement
        {
            get
            {
                return this.systemOfMeasurementField;
            }
            set
            {
                this.systemOfMeasurementField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public OtherGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedRoom", IsNullable = false)]
        public List<string> recommendedRooms
        {
            get
            {
                return this.recommendedRoomsField;
            }
            set
            {
                this.recommendedRoomsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("connection", IsNullable = false)]
        public List<string> connections
        {
            get
            {
                return this.connectionsField;
            }
            set
            {
                this.connectionsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedLocation", IsNullable = false)]
        public List<string> recommendedLocations
        {
            get
            {
                return this.recommendedLocationsField;
            }
            set
            {
                this.recommendedLocationsField = value;
            }
        }

        public bool isRetractable
        {
            get
            {
                return this.isRetractableField;
            }
            set
            {
                this.isRetractableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRetractableSpecified
        {
            get
            {
                return this.isRetractableFieldSpecified;
            }
            set
            {
                this.isRetractableFieldSpecified = value;
            }
        }

        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        public bool isCollectible
        {
            get
            {
                return this.isCollectibleField;
            }
            set
            {
                this.isCollectibleField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCollectibleSpecified
        {
            get
            {
                return this.isCollectibleFieldSpecified;
            }
            set
            {
                this.isCollectibleFieldSpecified = value;
            }
        }

        public bool isIndustrial
        {
            get
            {
                return this.isIndustrialField;
            }
            set
            {
                this.isIndustrialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIndustrialSpecified
        {
            get
            {
                return this.isIndustrialFieldSpecified;
            }
            set
            {
                this.isIndustrialFieldSpecified = value;
            }
        }

        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
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

        public string assemblyInstructions
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

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedSurface", IsNullable = false)]
        public List<string> recommendedSurfaces
        {
            get
            {
                return this.recommendedSurfacesField;
            }
            set
            {
                this.recommendedSurfacesField = value;
            }
        }

        public ElectricalMeasurementUnit volts
        {
            get
            {
                return this.voltsField;
            }
            set
            {
                this.voltsField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

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

    public enum OtherGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class CleaningAndChemical
    {

        private bool isRecyclableField;

        private bool isRecyclableFieldSpecified;

        private bool isBiodegradableField;

        private bool isBiodegradableFieldSpecified;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private bool isCombustibleField;

        private bool isCombustibleFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private bool isFlammableField;

        private bool isFlammableFieldSpecified;

        private string ingredientsField;

        private LengthUnit handleLengthField;

        private VolumeUnit fluidOuncesField;

        private string scentField;

        private List<activeIngredient> activeIngredientsField;

        private List<string> inactiveIngredientsField;

        private string formField;

        private string instructionsField;

        public CleaningAndChemical()
        {
            this.inactiveIngredientsField = new List<string>();
            this.activeIngredientsField = new List<activeIngredient>();
            this.fluidOuncesField = new VolumeUnit();
            this.handleLengthField = new LengthUnit();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
        }

        public bool isRecyclable
        {
            get
            {
                return this.isRecyclableField;
            }
            set
            {
                this.isRecyclableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRecyclableSpecified
        {
            get
            {
                return this.isRecyclableFieldSpecified;
            }
            set
            {
                this.isRecyclableFieldSpecified = value;
            }
        }

        public bool isBiodegradable
        {
            get
            {
                return this.isBiodegradableField;
            }
            set
            {
                this.isBiodegradableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBiodegradableSpecified
        {
            get
            {
                return this.isBiodegradableFieldSpecified;
            }
            set
            {
                this.isBiodegradableFieldSpecified = value;
            }
        }

        public bool isEnergyStarCertified
        {
            get
            {
                return this.isEnergyStarCertifiedField;
            }
            set
            {
                this.isEnergyStarCertifiedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyStarCertifiedSpecified
        {
            get
            {
                return this.isEnergyStarCertifiedFieldSpecified;
            }
            set
            {
                this.isEnergyStarCertifiedFieldSpecified = value;
            }
        }

        public bool isCombustible
        {
            get
            {
                return this.isCombustibleField;
            }
            set
            {
                this.isCombustibleField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCombustibleSpecified
        {
            get
            {
                return this.isCombustibleFieldSpecified;
            }
            set
            {
                this.isCombustibleFieldSpecified = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        public bool isFlammable
        {
            get
            {
                return this.isFlammableField;
            }
            set
            {
                this.isFlammableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFlammableSpecified
        {
            get
            {
                return this.isFlammableFieldSpecified;
            }
            set
            {
                this.isFlammableFieldSpecified = value;
            }
        }

        public string ingredients
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

        public LengthUnit handleLength
        {
            get
            {
                return this.handleLengthField;
            }
            set
            {
                this.handleLengthField = value;
            }
        }

        public VolumeUnit fluidOunces
        {
            get
            {
                return this.fluidOuncesField;
            }
            set
            {
                this.fluidOuncesField = value;
            }
        }

        public string scent
        {
            get
            {
                return this.scentField;
            }
            set
            {
                this.scentField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<activeIngredient> activeIngredients
        {
            get
            {
                return this.activeIngredientsField;
            }
            set
            {
                this.activeIngredientsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("inactiveIngredient", IsNullable = false)]
        public List<string> inactiveIngredients
        {
            get
            {
                return this.inactiveIngredientsField;
            }
            set
            {
                this.inactiveIngredientsField = value;
            }
        }

        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        public string instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
            }
        }
    }

    public partial class Storage
    {

        private string collectionField;

        private LengthUnit shelfDepthField;

        private string shelfStyleField;

        private List<string> recommendedUsesField;

        private string drawerPositionField;

        private string drawerDimensionsField;

        private string numberOfDrawersField;

        private string numberOfShelvesField;

        private WeightUnit maximumWeightField;

        private string capacityField;

        public Storage()
        {
            this.maximumWeightField = new WeightUnit();
            this.recommendedUsesField = new List<string>();
            this.shelfDepthField = new LengthUnit();
        }

        public string collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
            }
        }

        public LengthUnit shelfDepth
        {
            get
            {
                return this.shelfDepthField;
            }
            set
            {
                this.shelfDepthField = value;
            }
        }

        public string shelfStyle
        {
            get
            {
                return this.shelfStyleField;
            }
            set
            {
                this.shelfStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        public string drawerPosition
        {
            get
            {
                return this.drawerPositionField;
            }
            set
            {
                this.drawerPositionField = value;
            }
        }

        public string drawerDimensions
        {
            get
            {
                return this.drawerDimensionsField;
            }
            set
            {
                this.drawerDimensionsField = value;
            }
        }

        public string numberOfDrawers
        {
            get
            {
                return this.numberOfDrawersField;
            }
            set
            {
                this.numberOfDrawersField = value;
            }
        }

        public string numberOfShelves
        {
            get
            {
                return this.numberOfShelvesField;
            }
            set
            {
                this.numberOfShelvesField = value;
            }
        }

        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }
    }

    public partial class Photography
    {

        private List<swatchImage> swatchImagesField;

        private List<string> accessoriesIncludedField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private bool isWeatherResistantField;

        private bool isWeatherResistantFieldSpecified;

        private bool hasSignalBoosterField;

        private bool hasSignalBoosterFieldSpecified;

        private bool hasWirelessMicrophoneField;

        private bool hasWirelessMicrophoneFieldSpecified;

        private string brandField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private List<string> colorField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private List<string> memoryCardTypeField;

        private List<string> connectionsField;

        private List<string> materialField;

        private string numberOfPiecesField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private string cleaningCareAndMaintenanceField;

        private List<string> recommendedUsesField;

        private List<string> recommendedLocationsField;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private string assemblyInstructionsField;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private bool hasTouchscreenField;

        private bool hasTouchscreenFieldSpecified;

        private List<string> recordableMediaFormatsField;

        private List<string> compatibleBrandsField;

        private List<string> compatibleDevicesField;

        private List<string> wirelessTechnologiesField;

        private object itemField;

        public Photography()
        {
            this.wirelessTechnologiesField = new List<string>();
            this.compatibleDevicesField = new List<string>();
            this.compatibleBrandsField = new List<string>();
            this.recordableMediaFormatsField = new List<string>();
            this.recommendedLocationsField = new List<string>();
            this.recommendedUsesField = new List<string>();
            this.materialField = new List<string>();
            this.connectionsField = new List<string>();
            this.memoryCardTypeField = new List<string>();
            this.colorField = new List<string>();
            this.variantAttributeNamesField = new List<string>();
            this.accessoriesIncludedField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("accessoriesIncludedValue", IsNullable = false)]
        public List<string> accessoriesIncluded
        {
            get
            {
                return this.accessoriesIncludedField;
            }
            set
            {
                this.accessoriesIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        public bool isWeatherResistant
        {
            get
            {
                return this.isWeatherResistantField;
            }
            set
            {
                this.isWeatherResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWeatherResistantSpecified
        {
            get
            {
                return this.isWeatherResistantFieldSpecified;
            }
            set
            {
                this.isWeatherResistantFieldSpecified = value;
            }
        }

        public bool hasSignalBooster
        {
            get
            {
                return this.hasSignalBoosterField;
            }
            set
            {
                this.hasSignalBoosterField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSignalBoosterSpecified
        {
            get
            {
                return this.hasSignalBoosterFieldSpecified;
            }
            set
            {
                this.hasSignalBoosterFieldSpecified = value;
            }
        }

        public bool hasWirelessMicrophone
        {
            get
            {
                return this.hasWirelessMicrophoneField;
            }
            set
            {
                this.hasWirelessMicrophoneField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWirelessMicrophoneSpecified
        {
            get
            {
                return this.hasWirelessMicrophoneFieldSpecified;
            }
            set
            {
                this.hasWirelessMicrophoneFieldSpecified = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("memoryCardTypeValue", IsNullable = false)]
        public List<string> memoryCardType
        {
            get
            {
                return this.memoryCardTypeField;
            }
            set
            {
                this.memoryCardTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("connection", IsNullable = false)]
        public List<string> connections
        {
            get
            {
                return this.connectionsField;
            }
            set
            {
                this.connectionsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        public string numberOfPieces
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

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        public string cleaningCareAndMaintenance
        {
            get
            {
                return this.cleaningCareAndMaintenanceField;
            }
            set
            {
                this.cleaningCareAndMaintenanceField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedLocation", IsNullable = false)]
        public List<string> recommendedLocations
        {
            get
            {
                return this.recommendedLocationsField;
            }
            set
            {
                this.recommendedLocationsField = value;
            }
        }

        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
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

        public string assemblyInstructions
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

        public bool isWaterproof
        {
            get
            {
                return this.isWaterproofField;
            }
            set
            {
                this.isWaterproofField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterproofSpecified
        {
            get
            {
                return this.isWaterproofFieldSpecified;
            }
            set
            {
                this.isWaterproofFieldSpecified = value;
            }
        }

        public bool hasTouchscreen
        {
            get
            {
                return this.hasTouchscreenField;
            }
            set
            {
                this.hasTouchscreenField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasTouchscreenSpecified
        {
            get
            {
                return this.hasTouchscreenFieldSpecified;
            }
            set
            {
                this.hasTouchscreenFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recordableMediaFormat", IsNullable = false)]
        public List<string> recordableMediaFormats
        {
            get
            {
                return this.recordableMediaFormatsField;
            }
            set
            {
                this.recordableMediaFormatsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleBrand", IsNullable = false)]
        public List<string> compatibleBrands
        {
            get
            {
                return this.compatibleBrandsField;
            }
            set
            {
                this.compatibleBrandsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleDevice", IsNullable = false)]
        public List<string> compatibleDevices
        {
            get
            {
                return this.compatibleDevicesField;
            }
            set
            {
                this.compatibleDevicesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }

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

    public partial class CamerasAndLenses
    {

        private List<string> ageGroupField;

        private string powerTypeField;

        private LengthUnit diameterField;

        private ResolutionUnit numberOfMegapixelsField;

        private LengthUnit focalLengthField;

        private bool hasShoulderStrapField;

        private bool hasShoulderStrapFieldSpecified;

        private bool hasHandleField;

        private bool hasHandleFieldSpecified;

        private string magnificationField;

        private string fieldOfViewField;

        private bool isFogResistantField;

        private bool isFogResistantFieldSpecified;

        private LengthUnit lensDiameterField;

        private bool isMulticoatedField;

        private bool isMulticoatedFieldSpecified;

        private string shootingProgramsField;

        private string shootingModeField;

        private string opticalZoomField;

        private TimeUnit selfTimerDelayField;

        private bool hasSelfTimerField;

        private bool hasSelfTimerFieldSpecified;

        private bool hasRemovableFlashField;

        private bool hasRemovableFlashFieldSpecified;

        private string digitalZoomField;

        private List<string> focusTypeField;

        private bool hasRedEyeReductionField;

        private bool hasRedEyeReductionFieldSpecified;

        private TimeUnit minimumShutterSpeedField;

        private string lockTypeField;

        private TimeUnit maximumShutterSpeedField;

        private ResolutionUnit sensorResolutionField;

        private string maximumShootingSpeedField;

        private string minimumApertureField;

        private bool hasDovetailBarSystemField;

        private bool hasDovetailBarSystemFieldSpecified;

        private bool hasLcdScreenField;

        private bool hasLcdScreenFieldSpecified;

        private string maximumApertureField;

        private bool hasMemoryCardSlotField;

        private bool hasMemoryCardSlotFieldSpecified;

        private bool microphoneIncludedField;

        private bool microphoneIncludedFieldSpecified;

        private bool hasNightVisionField;

        private bool hasNightVisionFieldSpecified;

        private string lensFilterTypeField;

        private bool isParfocalField;

        private bool isParfocalFieldSpecified;

        private string flashTypeField;

        private string filmCameraTypeField;

        private string attachmentStyleField;

        private List<string> exposureModesField;

        private string cameraLensTypeField;

        private ResolutionUnit displayResolutionField;

        private string focalRatioField;

        private string lensCoatingField;

        private TemperatureUnit operatingTemperatureField;

        private bool isLockableField;

        private bool isLockableFieldSpecified;

        private List<string> lensTypeField;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        private bool hasFlashField;

        private bool hasFlashFieldSpecified;

        private TimeUnit standbyTimeField;

        public CamerasAndLenses()
        {
            this.standbyTimeField = new TimeUnit();
            this.screenSizeField = new LengthUnit();
            this.lensTypeField = new List<string>();
            this.operatingTemperatureField = new TemperatureUnit();
            this.displayResolutionField = new ResolutionUnit();
            this.exposureModesField = new List<string>();
            this.sensorResolutionField = new ResolutionUnit();
            this.maximumShutterSpeedField = new TimeUnit();
            this.minimumShutterSpeedField = new TimeUnit();
            this.focusTypeField = new List<string>();
            this.selfTimerDelayField = new TimeUnit();
            this.lensDiameterField = new LengthUnit();
            this.focalLengthField = new LengthUnit();
            this.numberOfMegapixelsField = new ResolutionUnit();
            this.diameterField = new LengthUnit();
            this.ageGroupField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public LengthUnit diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
            }
        }

        public ResolutionUnit numberOfMegapixels
        {
            get
            {
                return this.numberOfMegapixelsField;
            }
            set
            {
                this.numberOfMegapixelsField = value;
            }
        }

        public LengthUnit focalLength
        {
            get
            {
                return this.focalLengthField;
            }
            set
            {
                this.focalLengthField = value;
            }
        }

        public bool hasShoulderStrap
        {
            get
            {
                return this.hasShoulderStrapField;
            }
            set
            {
                this.hasShoulderStrapField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasShoulderStrapSpecified
        {
            get
            {
                return this.hasShoulderStrapFieldSpecified;
            }
            set
            {
                this.hasShoulderStrapFieldSpecified = value;
            }
        }

        public bool hasHandle
        {
            get
            {
                return this.hasHandleField;
            }
            set
            {
                this.hasHandleField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasHandleSpecified
        {
            get
            {
                return this.hasHandleFieldSpecified;
            }
            set
            {
                this.hasHandleFieldSpecified = value;
            }
        }

        public string magnification
        {
            get
            {
                return this.magnificationField;
            }
            set
            {
                this.magnificationField = value;
            }
        }

        public string fieldOfView
        {
            get
            {
                return this.fieldOfViewField;
            }
            set
            {
                this.fieldOfViewField = value;
            }
        }

        public bool isFogResistant
        {
            get
            {
                return this.isFogResistantField;
            }
            set
            {
                this.isFogResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFogResistantSpecified
        {
            get
            {
                return this.isFogResistantFieldSpecified;
            }
            set
            {
                this.isFogResistantFieldSpecified = value;
            }
        }

        public LengthUnit lensDiameter
        {
            get
            {
                return this.lensDiameterField;
            }
            set
            {
                this.lensDiameterField = value;
            }
        }

        public bool isMulticoated
        {
            get
            {
                return this.isMulticoatedField;
            }
            set
            {
                this.isMulticoatedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMulticoatedSpecified
        {
            get
            {
                return this.isMulticoatedFieldSpecified;
            }
            set
            {
                this.isMulticoatedFieldSpecified = value;
            }
        }

        public string shootingPrograms
        {
            get
            {
                return this.shootingProgramsField;
            }
            set
            {
                this.shootingProgramsField = value;
            }
        }

        public string shootingMode
        {
            get
            {
                return this.shootingModeField;
            }
            set
            {
                this.shootingModeField = value;
            }
        }

        public string opticalZoom
        {
            get
            {
                return this.opticalZoomField;
            }
            set
            {
                this.opticalZoomField = value;
            }
        }

        public TimeUnit selfTimerDelay
        {
            get
            {
                return this.selfTimerDelayField;
            }
            set
            {
                this.selfTimerDelayField = value;
            }
        }

        public bool hasSelfTimer
        {
            get
            {
                return this.hasSelfTimerField;
            }
            set
            {
                this.hasSelfTimerField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasSelfTimerSpecified
        {
            get
            {
                return this.hasSelfTimerFieldSpecified;
            }
            set
            {
                this.hasSelfTimerFieldSpecified = value;
            }
        }

        public bool hasRemovableFlash
        {
            get
            {
                return this.hasRemovableFlashField;
            }
            set
            {
                this.hasRemovableFlashField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasRemovableFlashSpecified
        {
            get
            {
                return this.hasRemovableFlashFieldSpecified;
            }
            set
            {
                this.hasRemovableFlashFieldSpecified = value;
            }
        }

        public string digitalZoom
        {
            get
            {
                return this.digitalZoomField;
            }
            set
            {
                this.digitalZoomField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("focusTypeValue", IsNullable = false)]
        public List<string> focusType
        {
            get
            {
                return this.focusTypeField;
            }
            set
            {
                this.focusTypeField = value;
            }
        }

        public bool hasRedEyeReduction
        {
            get
            {
                return this.hasRedEyeReductionField;
            }
            set
            {
                this.hasRedEyeReductionField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasRedEyeReductionSpecified
        {
            get
            {
                return this.hasRedEyeReductionFieldSpecified;
            }
            set
            {
                this.hasRedEyeReductionFieldSpecified = value;
            }
        }

        public TimeUnit minimumShutterSpeed
        {
            get
            {
                return this.minimumShutterSpeedField;
            }
            set
            {
                this.minimumShutterSpeedField = value;
            }
        }

        public string lockType
        {
            get
            {
                return this.lockTypeField;
            }
            set
            {
                this.lockTypeField = value;
            }
        }

        public TimeUnit maximumShutterSpeed
        {
            get
            {
                return this.maximumShutterSpeedField;
            }
            set
            {
                this.maximumShutterSpeedField = value;
            }
        }

        public ResolutionUnit sensorResolution
        {
            get
            {
                return this.sensorResolutionField;
            }
            set
            {
                this.sensorResolutionField = value;
            }
        }

        public string maximumShootingSpeed
        {
            get
            {
                return this.maximumShootingSpeedField;
            }
            set
            {
                this.maximumShootingSpeedField = value;
            }
        }

        public string minimumAperture
        {
            get
            {
                return this.minimumApertureField;
            }
            set
            {
                this.minimumApertureField = value;
            }
        }

        public bool hasDovetailBarSystem
        {
            get
            {
                return this.hasDovetailBarSystemField;
            }
            set
            {
                this.hasDovetailBarSystemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasDovetailBarSystemSpecified
        {
            get
            {
                return this.hasDovetailBarSystemFieldSpecified;
            }
            set
            {
                this.hasDovetailBarSystemFieldSpecified = value;
            }
        }

        public bool hasLcdScreen
        {
            get
            {
                return this.hasLcdScreenField;
            }
            set
            {
                this.hasLcdScreenField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasLcdScreenSpecified
        {
            get
            {
                return this.hasLcdScreenFieldSpecified;
            }
            set
            {
                this.hasLcdScreenFieldSpecified = value;
            }
        }

        public string maximumAperture
        {
            get
            {
                return this.maximumApertureField;
            }
            set
            {
                this.maximumApertureField = value;
            }
        }

        public bool hasMemoryCardSlot
        {
            get
            {
                return this.hasMemoryCardSlotField;
            }
            set
            {
                this.hasMemoryCardSlotField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasMemoryCardSlotSpecified
        {
            get
            {
                return this.hasMemoryCardSlotFieldSpecified;
            }
            set
            {
                this.hasMemoryCardSlotFieldSpecified = value;
            }
        }

        public bool microphoneIncluded
        {
            get
            {
                return this.microphoneIncludedField;
            }
            set
            {
                this.microphoneIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool microphoneIncludedSpecified
        {
            get
            {
                return this.microphoneIncludedFieldSpecified;
            }
            set
            {
                this.microphoneIncludedFieldSpecified = value;
            }
        }

        public bool hasNightVision
        {
            get
            {
                return this.hasNightVisionField;
            }
            set
            {
                this.hasNightVisionField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasNightVisionSpecified
        {
            get
            {
                return this.hasNightVisionFieldSpecified;
            }
            set
            {
                this.hasNightVisionFieldSpecified = value;
            }
        }

        public string lensFilterType
        {
            get
            {
                return this.lensFilterTypeField;
            }
            set
            {
                this.lensFilterTypeField = value;
            }
        }

        public bool isParfocal
        {
            get
            {
                return this.isParfocalField;
            }
            set
            {
                this.isParfocalField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isParfocalSpecified
        {
            get
            {
                return this.isParfocalFieldSpecified;
            }
            set
            {
                this.isParfocalFieldSpecified = value;
            }
        }

        public string flashType
        {
            get
            {
                return this.flashTypeField;
            }
            set
            {
                this.flashTypeField = value;
            }
        }

        public string filmCameraType
        {
            get
            {
                return this.filmCameraTypeField;
            }
            set
            {
                this.filmCameraTypeField = value;
            }
        }

        public string attachmentStyle
        {
            get
            {
                return this.attachmentStyleField;
            }
            set
            {
                this.attachmentStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("exposureMode", IsNullable = false)]
        public List<string> exposureModes
        {
            get
            {
                return this.exposureModesField;
            }
            set
            {
                this.exposureModesField = value;
            }
        }

        public string cameraLensType
        {
            get
            {
                return this.cameraLensTypeField;
            }
            set
            {
                this.cameraLensTypeField = value;
            }
        }

        public ResolutionUnit displayResolution
        {
            get
            {
                return this.displayResolutionField;
            }
            set
            {
                this.displayResolutionField = value;
            }
        }

        public string focalRatio
        {
            get
            {
                return this.focalRatioField;
            }
            set
            {
                this.focalRatioField = value;
            }
        }

        public string lensCoating
        {
            get
            {
                return this.lensCoatingField;
            }
            set
            {
                this.lensCoatingField = value;
            }
        }

        public TemperatureUnit operatingTemperature
        {
            get
            {
                return this.operatingTemperatureField;
            }
            set
            {
                this.operatingTemperatureField = value;
            }
        }

        public bool isLockable
        {
            get
            {
                return this.isLockableField;
            }
            set
            {
                this.isLockableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLockableSpecified
        {
            get
            {
                return this.isLockableFieldSpecified;
            }
            set
            {
                this.isLockableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("lensTypeValue", IsNullable = false)]
        public List<string> lensType
        {
            get
            {
                return this.lensTypeField;
            }
            set
            {
                this.lensTypeField = value;
            }
        }

        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        public bool hasFlash
        {
            get
            {
                return this.hasFlashField;
            }
            set
            {
                this.hasFlashField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasFlashSpecified
        {
            get
            {
                return this.hasFlashFieldSpecified;
            }
            set
            {
                this.hasFlashFieldSpecified = value;
            }
        }

        public TimeUnit standbyTime
        {
            get
            {
                return this.standbyTimeField;
            }
            set
            {
                this.standbyTimeField = value;
            }
        }
    }

    public partial class PhotoAccessories
    {

        private List<fabricContentValue> fabricContentField;

        private string conditionField;

        private List<string> patternField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private List<string> occasionField;

        private bool hardOrSoftCaseField;

        private bool hardOrSoftCaseFieldSpecified;

        private bool isCordlessField;

        private bool isCordlessFieldSpecified;

        private BrightnessUnit lightOutputField;

        private WeightUnit maximumWeightField;

        private string capacityField;

        private ElectricalMeasurementUnit voltsField;

        private PowerUnit wattsField;

        private string shapeField;

        private List<inputsAndOutput> inputsAndOutputsField;

        private string displayTechnologyField;

        private bool hasBluetoothField;

        private bool hasBluetoothFieldSpecified;

        private string lightBulbTypeField;

        private List<string> wirelessTechnologiesField;

        public PhotoAccessories()
        {
            this.wirelessTechnologiesField = new List<string>();
            this.inputsAndOutputsField = new List<inputsAndOutput>();
            this.wattsField = new PowerUnit();
            this.voltsField = new ElectricalMeasurementUnit();
            this.maximumWeightField = new WeightUnit();
            this.lightOutputField = new BrightnessUnit();
            this.occasionField = new List<string>();
            this.patternField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        public bool isRemoteControlIncluded
        {
            get
            {
                return this.isRemoteControlIncludedField;
            }
            set
            {
                this.isRemoteControlIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRemoteControlIncludedSpecified
        {
            get
            {
                return this.isRemoteControlIncludedFieldSpecified;
            }
            set
            {
                this.isRemoteControlIncludedFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public bool hardOrSoftCase
        {
            get
            {
                return this.hardOrSoftCaseField;
            }
            set
            {
                this.hardOrSoftCaseField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hardOrSoftCaseSpecified
        {
            get
            {
                return this.hardOrSoftCaseFieldSpecified;
            }
            set
            {
                this.hardOrSoftCaseFieldSpecified = value;
            }
        }

        public bool isCordless
        {
            get
            {
                return this.isCordlessField;
            }
            set
            {
                this.isCordlessField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCordlessSpecified
        {
            get
            {
                return this.isCordlessFieldSpecified;
            }
            set
            {
                this.isCordlessFieldSpecified = value;
            }
        }

        public BrightnessUnit lightOutput
        {
            get
            {
                return this.lightOutputField;
            }
            set
            {
                this.lightOutputField = value;
            }
        }

        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        public ElectricalMeasurementUnit volts
        {
            get
            {
                return this.voltsField;
            }
            set
            {
                this.voltsField = value;
            }
        }

        public PowerUnit watts
        {
            get
            {
                return this.wattsField;
            }
            set
            {
                this.wattsField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<inputsAndOutput> inputsAndOutputs
        {
            get
            {
                return this.inputsAndOutputsField;
            }
            set
            {
                this.inputsAndOutputsField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        public bool hasBluetooth
        {
            get
            {
                return this.hasBluetoothField;
            }
            set
            {
                this.hasBluetoothField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasBluetoothSpecified
        {
            get
            {
                return this.hasBluetoothFieldSpecified;
            }
            set
            {
                this.hasBluetoothFieldSpecified = value;
            }
        }

        public string lightBulbType
        {
            get
            {
                return this.lightBulbTypeField;
            }
            set
            {
                this.lightBulbTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }
    }

    public partial class SportAndRecreation
    {

        private List<swatchImage> swatchImagesField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private bool isWeatherResistantField;

        private bool isWeatherResistantFieldSpecified;

        private string finishField;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string conditionField;

        private string manufacturerField;

        private TemperatureUnit minimumTemperatureField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private string clothingSizeField;

        private SportAndRecreationGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private List<string> ageGroupField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string dexterityField;

        private string batterySizeField;

        private string fishingLinePoundTestField;

        private string fishingLocationField;

        private string animalTypeField;

        private List<string> materialField;

        private List<string> patternField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string numberOfPiecesField;

        private List<string> characterField;

        private string fitnessGoalField;

        private string powerTypeField;

        private PercentageUnit maximumInclineField;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private string cleaningCareAndMaintenanceField;

        private string bladeTypeField;

        private List<string> recommendedUsesField;

        private string tentTypeField;

        private List<string> recommendedLocationsField;

        private string seatingCapacityField;

        private LengthUnit tireDiameterField;

        private List<string> seasonField;

        private bool isWheeledField;

        private bool isWheeledFieldSpecified;

        private bool isMemorabiliaField;

        private bool isMemorabiliaFieldSpecified;

        private bool isFoldableField;

        private bool isFoldableFieldSpecified;

        private bool isCollectibleField;

        private bool isCollectibleFieldSpecified;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private TimeUnit maximumRecommendedAgeField;

        private string assemblyInstructionsField;

        private TimeUnit minimumRecommendedAgeField;

        private List<string> ballCoreMaterialField;

        private string footballSizeField;

        private List<string> sportField;

        private string basketballSizeField;

        private WeightUnit maximumWeightField;

        private string soccerBallSizeField;

        private string batDropField;

        private bool isTearResistantField;

        private bool isTearResistantFieldSpecified;

        private bool isSpaceSavingField;

        private bool isSpaceSavingFieldSpecified;

        private string capacityField;

        private SpeedUnit velocityField;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private bool hasAutomaticShutoffField;

        private bool hasAutomaticShutoffFieldSpecified;

        private string shapeField;

        private List<string> wirelessTechnologiesField;

        private PowerUnit horsepowerField;

        private object itemField;

        public SportAndRecreation()
        {
            this.horsepowerField = new PowerUnit();
            this.wirelessTechnologiesField = new List<string>();
            this.velocityField = new SpeedUnit();
            this.maximumWeightField = new WeightUnit();
            this.sportField = new List<string>();
            this.ballCoreMaterialField = new List<string>();
            this.minimumRecommendedAgeField = new TimeUnit();
            this.maximumRecommendedAgeField = new TimeUnit();
            this.seasonField = new List<string>();
            this.tireDiameterField = new LengthUnit();
            this.recommendedLocationsField = new List<string>();
            this.recommendedUsesField = new List<string>();
            this.maximumInclineField = new PercentageUnit();
            this.characterField = new List<string>();
            this.patternField = new List<string>();
            this.materialField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.minimumTemperatureField = new TemperatureUnit();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public bool isWeatherResistant
        {
            get
            {
                return this.isWeatherResistantField;
            }
            set
            {
                this.isWeatherResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWeatherResistantSpecified
        {
            get
            {
                return this.isWeatherResistantFieldSpecified;
            }
            set
            {
                this.isWeatherResistantFieldSpecified = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public string manufacturer
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

        public TemperatureUnit minimumTemperature
        {
            get
            {
                return this.minimumTemperatureField;
            }
            set
            {
                this.minimumTemperatureField = value;
            }
        }

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public string clothingSize
        {
            get
            {
                return this.clothingSizeField;
            }
            set
            {
                this.clothingSizeField = value;
            }
        }

        public SportAndRecreationGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string dexterity
        {
            get
            {
                return this.dexterityField;
            }
            set
            {
                this.dexterityField = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public string fishingLinePoundTest
        {
            get
            {
                return this.fishingLinePoundTestField;
            }
            set
            {
                this.fishingLinePoundTestField = value;
            }
        }

        public string fishingLocation
        {
            get
            {
                return this.fishingLocationField;
            }
            set
            {
                this.fishingLocationField = value;
            }
        }

        public string animalType
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

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        public string numberOfPieces
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

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public string fitnessGoal
        {
            get
            {
                return this.fitnessGoalField;
            }
            set
            {
                this.fitnessGoalField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public PercentageUnit maximumIncline
        {
            get
            {
                return this.maximumInclineField;
            }
            set
            {
                this.maximumInclineField = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        public string cleaningCareAndMaintenance
        {
            get
            {
                return this.cleaningCareAndMaintenanceField;
            }
            set
            {
                this.cleaningCareAndMaintenanceField = value;
            }
        }

        public string bladeType
        {
            get
            {
                return this.bladeTypeField;
            }
            set
            {
                this.bladeTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        public string tentType
        {
            get
            {
                return this.tentTypeField;
            }
            set
            {
                this.tentTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedLocation", IsNullable = false)]
        public List<string> recommendedLocations
        {
            get
            {
                return this.recommendedLocationsField;
            }
            set
            {
                this.recommendedLocationsField = value;
            }
        }

        public string seatingCapacity
        {
            get
            {
                return this.seatingCapacityField;
            }
            set
            {
                this.seatingCapacityField = value;
            }
        }

        public LengthUnit tireDiameter
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

        [System.Xml.Serialization.XmlArrayItemAttribute("seasonValue", IsNullable = false)]
        public List<string> season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        public bool isWheeled
        {
            get
            {
                return this.isWheeledField;
            }
            set
            {
                this.isWheeledField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWheeledSpecified
        {
            get
            {
                return this.isWheeledFieldSpecified;
            }
            set
            {
                this.isWheeledFieldSpecified = value;
            }
        }

        public bool isMemorabilia
        {
            get
            {
                return this.isMemorabiliaField;
            }
            set
            {
                this.isMemorabiliaField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMemorabiliaSpecified
        {
            get
            {
                return this.isMemorabiliaFieldSpecified;
            }
            set
            {
                this.isMemorabiliaFieldSpecified = value;
            }
        }

        public bool isFoldable
        {
            get
            {
                return this.isFoldableField;
            }
            set
            {
                this.isFoldableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFoldableSpecified
        {
            get
            {
                return this.isFoldableFieldSpecified;
            }
            set
            {
                this.isFoldableFieldSpecified = value;
            }
        }

        public bool isCollectible
        {
            get
            {
                return this.isCollectibleField;
            }
            set
            {
                this.isCollectibleField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCollectibleSpecified
        {
            get
            {
                return this.isCollectibleFieldSpecified;
            }
            set
            {
                this.isCollectibleFieldSpecified = value;
            }
        }

        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
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

        public TimeUnit maximumRecommendedAge
        {
            get
            {
                return this.maximumRecommendedAgeField;
            }
            set
            {
                this.maximumRecommendedAgeField = value;
            }
        }

        public string assemblyInstructions
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

        public TimeUnit minimumRecommendedAge
        {
            get
            {
                return this.minimumRecommendedAgeField;
            }
            set
            {
                this.minimumRecommendedAgeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("ballCoreMaterialValue", IsNullable = false)]
        public List<string> ballCoreMaterial
        {
            get
            {
                return this.ballCoreMaterialField;
            }
            set
            {
                this.ballCoreMaterialField = value;
            }
        }

        public string footballSize
        {
            get
            {
                return this.footballSizeField;
            }
            set
            {
                this.footballSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("sportValue", IsNullable = false)]
        public List<string> sport
        {
            get
            {
                return this.sportField;
            }
            set
            {
                this.sportField = value;
            }
        }

        public string basketballSize
        {
            get
            {
                return this.basketballSizeField;
            }
            set
            {
                this.basketballSizeField = value;
            }
        }

        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        public string soccerBallSize
        {
            get
            {
                return this.soccerBallSizeField;
            }
            set
            {
                this.soccerBallSizeField = value;
            }
        }

        public string batDrop
        {
            get
            {
                return this.batDropField;
            }
            set
            {
                this.batDropField = value;
            }
        }

        public bool isTearResistant
        {
            get
            {
                return this.isTearResistantField;
            }
            set
            {
                this.isTearResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTearResistantSpecified
        {
            get
            {
                return this.isTearResistantFieldSpecified;
            }
            set
            {
                this.isTearResistantFieldSpecified = value;
            }
        }

        public bool isSpaceSaving
        {
            get
            {
                return this.isSpaceSavingField;
            }
            set
            {
                this.isSpaceSavingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSpaceSavingSpecified
        {
            get
            {
                return this.isSpaceSavingFieldSpecified;
            }
            set
            {
                this.isSpaceSavingFieldSpecified = value;
            }
        }

        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        public SpeedUnit velocity
        {
            get
            {
                return this.velocityField;
            }
            set
            {
                this.velocityField = value;
            }
        }

        public bool isWaterproof
        {
            get
            {
                return this.isWaterproofField;
            }
            set
            {
                this.isWaterproofField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterproofSpecified
        {
            get
            {
                return this.isWaterproofFieldSpecified;
            }
            set
            {
                this.isWaterproofFieldSpecified = value;
            }
        }

        public bool hasAutomaticShutoff
        {
            get
            {
                return this.hasAutomaticShutoffField;
            }
            set
            {
                this.hasAutomaticShutoffField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticShutoffSpecified
        {
            get
            {
                return this.hasAutomaticShutoffFieldSpecified;
            }
            set
            {
                this.hasAutomaticShutoffFieldSpecified = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }

        public PowerUnit horsepower
        {
            get
            {
                return this.horsepowerField;
            }
            set
            {
                this.horsepowerField = value;
            }
        }

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

    public enum SportAndRecreationGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class SpeedUnit
    {

        private SpeedUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private string measureField;

        public SpeedUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public string measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }
    }

    public enum SpeedUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Kilometers Per Hour")]
        KilometersPerHour,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Meters Per Second Squared")]
        MetersPerSecondSquared,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Meters Per Second")]
        MetersPerSecond,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Radian Per Second")]
        RadianPerSecond,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Revolutions Per Minute")]
        RevolutionsPerMinute,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Feet Per Minute")]
        FeetPerMinute,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Miles Per Hour")]
        MilesPerHour,
    }

    public partial class Cycling
    {

        private LengthUnit bicycleFrameSizeField;

        private LengthUnit bicycleWheelDiameterField;

        private string bicycleTireSizeField;

        private string numberOfSpeedsField;

        private string lightBulbTypeField;

        public Cycling()
        {
            this.bicycleWheelDiameterField = new LengthUnit();
            this.bicycleFrameSizeField = new LengthUnit();
        }

        public LengthUnit bicycleFrameSize
        {
            get
            {
                return this.bicycleFrameSizeField;
            }
            set
            {
                this.bicycleFrameSizeField = value;
            }
        }

        public LengthUnit bicycleWheelDiameter
        {
            get
            {
                return this.bicycleWheelDiameterField;
            }
            set
            {
                this.bicycleWheelDiameterField = value;
            }
        }

        public string bicycleTireSize
        {
            get
            {
                return this.bicycleTireSizeField;
            }
            set
            {
                this.bicycleTireSizeField = value;
            }
        }

        public string numberOfSpeeds
        {
            get
            {
                return this.numberOfSpeedsField;
            }
            set
            {
                this.numberOfSpeedsField = value;
            }
        }

        public string lightBulbType
        {
            get
            {
                return this.lightBulbTypeField;
            }
            set
            {
                this.lightBulbTypeField = value;
            }
        }
    }

    public partial class Optics
    {

        private string powerTypeField;

        private string magnificationField;

        private string fieldOfViewField;

        private bool isFogResistantField;

        private bool isFogResistantFieldSpecified;

        private LengthUnit lensDiameterField;

        private bool isMulticoatedField;

        private bool isMulticoatedFieldSpecified;

        private string opticalZoomField;

        private string digitalZoomField;

        private List<string> focusTypeField;

        private string lockTypeField;

        private ResolutionUnit sensorResolutionField;

        private bool hasDovetailBarSystemField;

        private bool hasDovetailBarSystemFieldSpecified;

        private bool hasLcdScreenField;

        private bool hasLcdScreenFieldSpecified;

        private bool hasMemoryCardSlotField;

        private bool hasMemoryCardSlotFieldSpecified;

        private bool hasNightVisionField;

        private bool hasNightVisionFieldSpecified;

        private bool isParfocalField;

        private bool isParfocalFieldSpecified;

        private string attachmentStyleField;

        private ResolutionUnit displayResolutionField;

        private string focalRatioField;

        private string lensCoatingField;

        private TemperatureUnit operatingTemperatureField;

        private bool isLockableField;

        private bool isLockableFieldSpecified;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        public Optics()
        {
            this.screenSizeField = new LengthUnit();
            this.operatingTemperatureField = new TemperatureUnit();
            this.displayResolutionField = new ResolutionUnit();
            this.sensorResolutionField = new ResolutionUnit();
            this.focusTypeField = new List<string>();
            this.lensDiameterField = new LengthUnit();
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public string magnification
        {
            get
            {
                return this.magnificationField;
            }
            set
            {
                this.magnificationField = value;
            }
        }

        public string fieldOfView
        {
            get
            {
                return this.fieldOfViewField;
            }
            set
            {
                this.fieldOfViewField = value;
            }
        }

        public bool isFogResistant
        {
            get
            {
                return this.isFogResistantField;
            }
            set
            {
                this.isFogResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFogResistantSpecified
        {
            get
            {
                return this.isFogResistantFieldSpecified;
            }
            set
            {
                this.isFogResistantFieldSpecified = value;
            }
        }

        public LengthUnit lensDiameter
        {
            get
            {
                return this.lensDiameterField;
            }
            set
            {
                this.lensDiameterField = value;
            }
        }

        public bool isMulticoated
        {
            get
            {
                return this.isMulticoatedField;
            }
            set
            {
                this.isMulticoatedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMulticoatedSpecified
        {
            get
            {
                return this.isMulticoatedFieldSpecified;
            }
            set
            {
                this.isMulticoatedFieldSpecified = value;
            }
        }

        public string opticalZoom
        {
            get
            {
                return this.opticalZoomField;
            }
            set
            {
                this.opticalZoomField = value;
            }
        }

        public string digitalZoom
        {
            get
            {
                return this.digitalZoomField;
            }
            set
            {
                this.digitalZoomField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("focusTypeValue", IsNullable = false)]
        public List<string> focusType
        {
            get
            {
                return this.focusTypeField;
            }
            set
            {
                this.focusTypeField = value;
            }
        }

        public string lockType
        {
            get
            {
                return this.lockTypeField;
            }
            set
            {
                this.lockTypeField = value;
            }
        }

        public ResolutionUnit sensorResolution
        {
            get
            {
                return this.sensorResolutionField;
            }
            set
            {
                this.sensorResolutionField = value;
            }
        }

        public bool hasDovetailBarSystem
        {
            get
            {
                return this.hasDovetailBarSystemField;
            }
            set
            {
                this.hasDovetailBarSystemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasDovetailBarSystemSpecified
        {
            get
            {
                return this.hasDovetailBarSystemFieldSpecified;
            }
            set
            {
                this.hasDovetailBarSystemFieldSpecified = value;
            }
        }

        public bool hasLcdScreen
        {
            get
            {
                return this.hasLcdScreenField;
            }
            set
            {
                this.hasLcdScreenField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasLcdScreenSpecified
        {
            get
            {
                return this.hasLcdScreenFieldSpecified;
            }
            set
            {
                this.hasLcdScreenFieldSpecified = value;
            }
        }

        public bool hasMemoryCardSlot
        {
            get
            {
                return this.hasMemoryCardSlotField;
            }
            set
            {
                this.hasMemoryCardSlotField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasMemoryCardSlotSpecified
        {
            get
            {
                return this.hasMemoryCardSlotFieldSpecified;
            }
            set
            {
                this.hasMemoryCardSlotFieldSpecified = value;
            }
        }

        public bool hasNightVision
        {
            get
            {
                return this.hasNightVisionField;
            }
            set
            {
                this.hasNightVisionField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasNightVisionSpecified
        {
            get
            {
                return this.hasNightVisionFieldSpecified;
            }
            set
            {
                this.hasNightVisionFieldSpecified = value;
            }
        }

        public bool isParfocal
        {
            get
            {
                return this.isParfocalField;
            }
            set
            {
                this.isParfocalField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isParfocalSpecified
        {
            get
            {
                return this.isParfocalFieldSpecified;
            }
            set
            {
                this.isParfocalFieldSpecified = value;
            }
        }

        public string attachmentStyle
        {
            get
            {
                return this.attachmentStyleField;
            }
            set
            {
                this.attachmentStyleField = value;
            }
        }

        public ResolutionUnit displayResolution
        {
            get
            {
                return this.displayResolutionField;
            }
            set
            {
                this.displayResolutionField = value;
            }
        }

        public string focalRatio
        {
            get
            {
                return this.focalRatioField;
            }
            set
            {
                this.focalRatioField = value;
            }
        }

        public string lensCoating
        {
            get
            {
                return this.lensCoatingField;
            }
            set
            {
                this.lensCoatingField = value;
            }
        }

        public TemperatureUnit operatingTemperature
        {
            get
            {
                return this.operatingTemperatureField;
            }
            set
            {
                this.operatingTemperatureField = value;
            }
        }

        public bool isLockable
        {
            get
            {
                return this.isLockableField;
            }
            set
            {
                this.isLockableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLockableSpecified
        {
            get
            {
                return this.isLockableFieldSpecified;
            }
            set
            {
                this.isLockableFieldSpecified = value;
            }
        }

        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }
    }

    public partial class Weapons
    {

        private decimal shotgunGaugeField;

        private bool shotgunGaugeFieldSpecified;

        private SpeedUnit velocityField;

        private string firearmActionField;

        private LengthUnit caliberField;

        private string ammunitionTypeField;

        private string firearmChamberLengthField;

        public Weapons()
        {
            this.caliberField = new LengthUnit();
            this.velocityField = new SpeedUnit();
        }

        public decimal shotgunGauge
        {
            get
            {
                return this.shotgunGaugeField;
            }
            set
            {
                this.shotgunGaugeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shotgunGaugeSpecified
        {
            get
            {
                return this.shotgunGaugeFieldSpecified;
            }
            set
            {
                this.shotgunGaugeFieldSpecified = value;
            }
        }

        public SpeedUnit velocity
        {
            get
            {
                return this.velocityField;
            }
            set
            {
                this.velocityField = value;
            }
        }

        public string firearmAction
        {
            get
            {
                return this.firearmActionField;
            }
            set
            {
                this.firearmActionField = value;
            }
        }

        public LengthUnit caliber
        {
            get
            {
                return this.caliberField;
            }
            set
            {
                this.caliberField = value;
            }
        }

        public string ammunitionType
        {
            get
            {
                return this.ammunitionTypeField;
            }
            set
            {
                this.ammunitionTypeField = value;
            }
        }

        public string firearmChamberLength
        {
            get
            {
                return this.firearmChamberLengthField;
            }
            set
            {
                this.firearmChamberLengthField = value;
            }
        }
    }

    public partial class ToolsAndHardware
    {

        private List<swatchImage> swatchImagesField;

        private List<string> accessoriesIncludedField;

        private string variantGroupIdField;

        private List<string> variantAttributeNamesField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private bool isWeatherResistantField;

        private bool isWeatherResistantFieldSpecified;

        private bool isFireResistantField;

        private bool isFireResistantFieldSpecified;

        private string brandField;

        private string manufacturerField;

        private List<string> colorField;

        private List<string> materialField;

        private string numberOfPiecesField;

        private string cleaningCareAndMaintenanceField;

        private List<string> recommendedUsesField;

        private bool isIndustrialField;

        private bool isIndustrialFieldSpecified;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private string shapeField;

        private object itemField;

        public ToolsAndHardware()
        {
            this.recommendedUsesField = new List<string>();
            this.materialField = new List<string>();
            this.colorField = new List<string>();
            this.variantAttributeNamesField = new List<string>();
            this.accessoriesIncludedField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("accessoriesIncludedValue", IsNullable = false)]
        public List<string> accessoriesIncluded
        {
            get
            {
                return this.accessoriesIncludedField;
            }
            set
            {
                this.accessoriesIncludedField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        public bool isWeatherResistant
        {
            get
            {
                return this.isWeatherResistantField;
            }
            set
            {
                this.isWeatherResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWeatherResistantSpecified
        {
            get
            {
                return this.isWeatherResistantFieldSpecified;
            }
            set
            {
                this.isWeatherResistantFieldSpecified = value;
            }
        }

        public bool isFireResistant
        {
            get
            {
                return this.isFireResistantField;
            }
            set
            {
                this.isFireResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFireResistantSpecified
        {
            get
            {
                return this.isFireResistantFieldSpecified;
            }
            set
            {
                this.isFireResistantFieldSpecified = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        public string numberOfPieces
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

        public string cleaningCareAndMaintenance
        {
            get
            {
                return this.cleaningCareAndMaintenanceField;
            }
            set
            {
                this.cleaningCareAndMaintenanceField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedUse", IsNullable = false)]
        public List<string> recommendedUses
        {
            get
            {
                return this.recommendedUsesField;
            }
            set
            {
                this.recommendedUsesField = value;
            }
        }

        public bool isIndustrial
        {
            get
            {
                return this.isIndustrialField;
            }
            set
            {
                this.isIndustrialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIndustrialSpecified
        {
            get
            {
                return this.isIndustrialFieldSpecified;
            }
            set
            {
                this.isIndustrialFieldSpecified = value;
            }
        }

        public bool isWaterproof
        {
            get
            {
                return this.isWaterproofField;
            }
            set
            {
                this.isWaterproofField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterproofSpecified
        {
            get
            {
                return this.isWaterproofFieldSpecified;
            }
            set
            {
                this.isWaterproofFieldSpecified = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

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

    public partial class BuildingSupply
    {

        private string homeDecorStyleField;

        private BuildingSupplyAcRating acRatingField;

        private bool acRatingFieldSpecified;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool isBiodegradableField;

        private bool isBiodegradableFieldSpecified;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private string carpetStyleField;

        private List<string> patternField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string powerTypeField;

        private bool isCombustibleField;

        private bool isCombustibleFieldSpecified;

        private List<string> compatibleSurfacesField;

        private AreaUnit coverageAreaField;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private TimeUnit dryTimeField;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private bool isFastSettingField;

        private bool isFastSettingFieldSpecified;

        private string finenessField;

        private bool isFlammableField;

        private bool isFlammableFieldSpecified;

        private string gradeField;

        private bool hasLowEmissivityField;

        private bool hasLowEmissivityFieldSpecified;

        private bool isMadeFromReclaimedMaterialsField;

        private bool isMadeFromReclaimedMaterialsFieldSpecified;

        private bool isMadeFromSustainableMaterialsField;

        private bool isMadeFromSustainableMaterialsFieldSpecified;

        private bool isMoldResistantField;

        private bool isMoldResistantFieldSpecified;

        private bool isOdorlessField;

        private bool isOdorlessFieldSpecified;

        private string paintFinishField;

        private string peiRatingField;

        private LengthUnit pileHeightField;

        private bool isPrefinishedField;

        private bool isPrefinishedFieldSpecified;

        private bool isReadyToUseField;

        private bool isReadyToUseFieldSpecified;

        private List<string> recommendedSurfacesField;

        private LengthUnit rollLengthField;

        private PressureUnit snowLoadRatingField;

        private PercentageUnit vocLevelField;

        private bool isWaterSolubleField;

        private bool isWaterSolubleFieldSpecified;

        private string subjectField;

        private List<activeIngredient> activeIngredientsField;

        private List<string> inactiveIngredientsField;

        private string formField;

        private bool hasCeeCertificationField;

        private bool hasCeeCertificationFieldSpecified;

        private BuildingSupplyCeeTier ceeTierField;

        private bool ceeTierFieldSpecified;

        public BuildingSupply()
        {
            this.inactiveIngredientsField = new List<string>();
            this.activeIngredientsField = new List<activeIngredient>();
            this.vocLevelField = new PercentageUnit();
            this.snowLoadRatingField = new PressureUnit();
            this.rollLengthField = new LengthUnit();
            this.recommendedSurfacesField = new List<string>();
            this.pileHeightField = new LengthUnit();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.dryTimeField = new TimeUnit();
            this.coverageAreaField = new AreaUnit();
            this.compatibleSurfacesField = new List<string>();
            this.patternField = new List<string>();
        }

        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        public BuildingSupplyAcRating acRating
        {
            get
            {
                return this.acRatingField;
            }
            set
            {
                this.acRatingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool acRatingSpecified
        {
            get
            {
                return this.acRatingFieldSpecified;
            }
            set
            {
                this.acRatingFieldSpecified = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public bool isBiodegradable
        {
            get
            {
                return this.isBiodegradableField;
            }
            set
            {
                this.isBiodegradableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBiodegradableSpecified
        {
            get
            {
                return this.isBiodegradableFieldSpecified;
            }
            set
            {
                this.isBiodegradableFieldSpecified = value;
            }
        }

        public bool isEnergyStarCertified
        {
            get
            {
                return this.isEnergyStarCertifiedField;
            }
            set
            {
                this.isEnergyStarCertifiedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyStarCertifiedSpecified
        {
            get
            {
                return this.isEnergyStarCertifiedFieldSpecified;
            }
            set
            {
                this.isEnergyStarCertifiedFieldSpecified = value;
            }
        }

        public string carpetStyle
        {
            get
            {
                return this.carpetStyleField;
            }
            set
            {
                this.carpetStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public bool isCombustible
        {
            get
            {
                return this.isCombustibleField;
            }
            set
            {
                this.isCombustibleField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCombustibleSpecified
        {
            get
            {
                return this.isCombustibleFieldSpecified;
            }
            set
            {
                this.isCombustibleFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleSurface", IsNullable = false)]
        public List<string> compatibleSurfaces
        {
            get
            {
                return this.compatibleSurfacesField;
            }
            set
            {
                this.compatibleSurfacesField = value;
            }
        }

        public AreaUnit coverageArea
        {
            get
            {
                return this.coverageAreaField;
            }
            set
            {
                this.coverageAreaField = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        public TimeUnit dryTime
        {
            get
            {
                return this.dryTimeField;
            }
            set
            {
                this.dryTimeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        public bool isFastSetting
        {
            get
            {
                return this.isFastSettingField;
            }
            set
            {
                this.isFastSettingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFastSettingSpecified
        {
            get
            {
                return this.isFastSettingFieldSpecified;
            }
            set
            {
                this.isFastSettingFieldSpecified = value;
            }
        }

        public string fineness
        {
            get
            {
                return this.finenessField;
            }
            set
            {
                this.finenessField = value;
            }
        }

        public bool isFlammable
        {
            get
            {
                return this.isFlammableField;
            }
            set
            {
                this.isFlammableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFlammableSpecified
        {
            get
            {
                return this.isFlammableFieldSpecified;
            }
            set
            {
                this.isFlammableFieldSpecified = value;
            }
        }

        public string grade
        {
            get
            {
                return this.gradeField;
            }
            set
            {
                this.gradeField = value;
            }
        }

        public bool hasLowEmissivity
        {
            get
            {
                return this.hasLowEmissivityField;
            }
            set
            {
                this.hasLowEmissivityField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasLowEmissivitySpecified
        {
            get
            {
                return this.hasLowEmissivityFieldSpecified;
            }
            set
            {
                this.hasLowEmissivityFieldSpecified = value;
            }
        }

        public bool isMadeFromReclaimedMaterials
        {
            get
            {
                return this.isMadeFromReclaimedMaterialsField;
            }
            set
            {
                this.isMadeFromReclaimedMaterialsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromReclaimedMaterialsSpecified
        {
            get
            {
                return this.isMadeFromReclaimedMaterialsFieldSpecified;
            }
            set
            {
                this.isMadeFromReclaimedMaterialsFieldSpecified = value;
            }
        }

        public bool isMadeFromSustainableMaterials
        {
            get
            {
                return this.isMadeFromSustainableMaterialsField;
            }
            set
            {
                this.isMadeFromSustainableMaterialsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromSustainableMaterialsSpecified
        {
            get
            {
                return this.isMadeFromSustainableMaterialsFieldSpecified;
            }
            set
            {
                this.isMadeFromSustainableMaterialsFieldSpecified = value;
            }
        }

        public bool isMoldResistant
        {
            get
            {
                return this.isMoldResistantField;
            }
            set
            {
                this.isMoldResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMoldResistantSpecified
        {
            get
            {
                return this.isMoldResistantFieldSpecified;
            }
            set
            {
                this.isMoldResistantFieldSpecified = value;
            }
        }

        public bool isOdorless
        {
            get
            {
                return this.isOdorlessField;
            }
            set
            {
                this.isOdorlessField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOdorlessSpecified
        {
            get
            {
                return this.isOdorlessFieldSpecified;
            }
            set
            {
                this.isOdorlessFieldSpecified = value;
            }
        }

        public string paintFinish
        {
            get
            {
                return this.paintFinishField;
            }
            set
            {
                this.paintFinishField = value;
            }
        }

        public string peiRating
        {
            get
            {
                return this.peiRatingField;
            }
            set
            {
                this.peiRatingField = value;
            }
        }

        public LengthUnit pileHeight
        {
            get
            {
                return this.pileHeightField;
            }
            set
            {
                this.pileHeightField = value;
            }
        }

        public bool isPrefinished
        {
            get
            {
                return this.isPrefinishedField;
            }
            set
            {
                this.isPrefinishedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrefinishedSpecified
        {
            get
            {
                return this.isPrefinishedFieldSpecified;
            }
            set
            {
                this.isPrefinishedFieldSpecified = value;
            }
        }

        public bool isReadyToUse
        {
            get
            {
                return this.isReadyToUseField;
            }
            set
            {
                this.isReadyToUseField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReadyToUseSpecified
        {
            get
            {
                return this.isReadyToUseFieldSpecified;
            }
            set
            {
                this.isReadyToUseFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("recommendedSurface", IsNullable = false)]
        public List<string> recommendedSurfaces
        {
            get
            {
                return this.recommendedSurfacesField;
            }
            set
            {
                this.recommendedSurfacesField = value;
            }
        }

        public LengthUnit rollLength
        {
            get
            {
                return this.rollLengthField;
            }
            set
            {
                this.rollLengthField = value;
            }
        }

        public PressureUnit snowLoadRating
        {
            get
            {
                return this.snowLoadRatingField;
            }
            set
            {
                this.snowLoadRatingField = value;
            }
        }

        public PercentageUnit vocLevel
        {
            get
            {
                return this.vocLevelField;
            }
            set
            {
                this.vocLevelField = value;
            }
        }

        public bool isWaterSoluble
        {
            get
            {
                return this.isWaterSolubleField;
            }
            set
            {
                this.isWaterSolubleField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterSolubleSpecified
        {
            get
            {
                return this.isWaterSolubleFieldSpecified;
            }
            set
            {
                this.isWaterSolubleFieldSpecified = value;
            }
        }

        public string subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<activeIngredient> activeIngredients
        {
            get
            {
                return this.activeIngredientsField;
            }
            set
            {
                this.activeIngredientsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("inactiveIngredient", IsNullable = false)]
        public List<string> inactiveIngredients
        {
            get
            {
                return this.inactiveIngredientsField;
            }
            set
            {
                this.inactiveIngredientsField = value;
            }
        }

        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        public bool hasCeeCertification
        {
            get
            {
                return this.hasCeeCertificationField;
            }
            set
            {
                this.hasCeeCertificationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCeeCertificationSpecified
        {
            get
            {
                return this.hasCeeCertificationFieldSpecified;
            }
            set
            {
                this.hasCeeCertificationFieldSpecified = value;
            }
        }

        public BuildingSupplyCeeTier ceeTier
        {
            get
            {
                return this.ceeTierField;
            }
            set
            {
                this.ceeTierField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ceeTierSpecified
        {
            get
            {
                return this.ceeTierFieldSpecified;
            }
            set
            {
                this.ceeTierFieldSpecified = value;
            }
        }
    }

    public enum BuildingSupplyAcRating
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("AC 5")]
        AC5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("AC 1")]
        AC1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("AC 4")]
        AC4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("AC 3")]
        AC3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("AC 2")]
        AC2,
    }

    public partial class PressureUnit
    {

        private PressureUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private string measureField;

        public PressureUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public string measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }
    }

    public enum PressureUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Pounds Per Square Inch")]
        PoundsPerSquareInch,

        /// <remarks/>
        Barye,

        /// <remarks/>
        Pieze,

        /// <remarks/>
        Pascal,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Psig/Bar")]
        PsigBar,

        /// <remarks/>
        Bar,

        /// <remarks/>
        Torr,
    }

    public enum BuildingSupplyCeeTier
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CEE Tier I")]
        CEETierI,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CEE Tier II")]
        CEETierII,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CEE Tier III")]
        CEETierIII,
    }

    public partial class Electrical
    {

        private string finishField;

        private string homeDecorStyleField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private List<string> mountTypeField;

        private string batterySizeField;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private List<string> patternField;

        private List<string> characterField;

        private string powerTypeField;

        private LengthUnit diameterField;

        private bool hasCflField;

        private bool hasCflFieldSpecified;

        private bool isLightingFactsLabelRequiredField;

        private bool isLightingFactsLabelRequiredFieldSpecified;

        private string lightingFactsLabelField;

        private ElectricalMeasurementUnit voltsField;

        private PowerUnit wattsField;

        private CurrencyUnit estimatedEnergyCostPerYearField;

        private TemperatureUnit colorTemperatureField;

        private string numberOfLightBulbsField;

        private string lightBulbBaseTypeField;

        private LengthUnit lightBulbDiameterField;

        private bool isLightBulbIncludedField;

        private bool isLightBulbIncludedFieldSpecified;

        private AngleUnit beamAngleField;

        private AngleUnit beamSpreadField;

        private LengthUnit compatibleConduitSizesField;

        private bool isDarkSkyCompliantField;

        private bool isDarkSkyCompliantFieldSpecified;

        private decimal electricalBallastFactorField;

        private bool electricalBallastFactorFieldSpecified;

        private bool isRatedForOutdoorUseField;

        private bool isRatedForOutdoorUseFieldSpecified;

        private decimal maximumEnergySurgeRatingField;

        private bool maximumEnergySurgeRatingFieldSpecified;

        private AreaUnit maximumRangeField;

        private TimeUnit responseTimeField;

        private string numberOfGangsField;

        private string numberOfPolesField;

        private LengthUnit americanWireGaugeField;

        private BrightnessUnit brightnessField;

        private string lifespanField;

        private bool hasCeeCertificationField;

        private bool hasCeeCertificationFieldSpecified;

        private ElectricalCeeTier ceeTierField;

        private bool ceeTierFieldSpecified;

        private ElectricalMeasurementUnit ampsField;

        private PowerUnit decibelRatingField;

        private PowerUnit horsepowerField;

        public Electrical()
        {
            this.horsepowerField = new PowerUnit();
            this.decibelRatingField = new PowerUnit();
            this.ampsField = new ElectricalMeasurementUnit();
            this.brightnessField = new BrightnessUnit();
            this.americanWireGaugeField = new LengthUnit();
            this.responseTimeField = new TimeUnit();
            this.maximumRangeField = new AreaUnit();
            this.compatibleConduitSizesField = new LengthUnit();
            this.beamSpreadField = new AngleUnit();
            this.beamAngleField = new AngleUnit();
            this.lightBulbDiameterField = new LengthUnit();
            this.colorTemperatureField = new TemperatureUnit();
            this.estimatedEnergyCostPerYearField = new CurrencyUnit();
            this.wattsField = new PowerUnit();
            this.voltsField = new ElectricalMeasurementUnit();
            this.diameterField = new LengthUnit();
            this.characterField = new List<string>();
            this.patternField = new List<string>();
            this.mountTypeField = new List<string>();
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("mountTypeValue", IsNullable = false)]
        public List<string> mountType
        {
            get
            {
                return this.mountTypeField;
            }
            set
            {
                this.mountTypeField = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public bool isEnergyStarCertified
        {
            get
            {
                return this.isEnergyStarCertifiedField;
            }
            set
            {
                this.isEnergyStarCertifiedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyStarCertifiedSpecified
        {
            get
            {
                return this.isEnergyStarCertifiedFieldSpecified;
            }
            set
            {
                this.isEnergyStarCertifiedFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public LengthUnit diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
            }
        }

        public bool hasCfl
        {
            get
            {
                return this.hasCflField;
            }
            set
            {
                this.hasCflField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCflSpecified
        {
            get
            {
                return this.hasCflFieldSpecified;
            }
            set
            {
                this.hasCflFieldSpecified = value;
            }
        }

        public bool isLightingFactsLabelRequired
        {
            get
            {
                return this.isLightingFactsLabelRequiredField;
            }
            set
            {
                this.isLightingFactsLabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLightingFactsLabelRequiredSpecified
        {
            get
            {
                return this.isLightingFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isLightingFactsLabelRequiredFieldSpecified = value;
            }
        }

        public string lightingFactsLabel
        {
            get
            {
                return this.lightingFactsLabelField;
            }
            set
            {
                this.lightingFactsLabelField = value;
            }
        }

        public ElectricalMeasurementUnit volts
        {
            get
            {
                return this.voltsField;
            }
            set
            {
                this.voltsField = value;
            }
        }

        public PowerUnit watts
        {
            get
            {
                return this.wattsField;
            }
            set
            {
                this.wattsField = value;
            }
        }

        public CurrencyUnit estimatedEnergyCostPerYear
        {
            get
            {
                return this.estimatedEnergyCostPerYearField;
            }
            set
            {
                this.estimatedEnergyCostPerYearField = value;
            }
        }

        public TemperatureUnit colorTemperature
        {
            get
            {
                return this.colorTemperatureField;
            }
            set
            {
                this.colorTemperatureField = value;
            }
        }

        public string numberOfLightBulbs
        {
            get
            {
                return this.numberOfLightBulbsField;
            }
            set
            {
                this.numberOfLightBulbsField = value;
            }
        }

        public string lightBulbBaseType
        {
            get
            {
                return this.lightBulbBaseTypeField;
            }
            set
            {
                this.lightBulbBaseTypeField = value;
            }
        }

        public LengthUnit lightBulbDiameter
        {
            get
            {
                return this.lightBulbDiameterField;
            }
            set
            {
                this.lightBulbDiameterField = value;
            }
        }

        public bool isLightBulbIncluded
        {
            get
            {
                return this.isLightBulbIncludedField;
            }
            set
            {
                this.isLightBulbIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLightBulbIncludedSpecified
        {
            get
            {
                return this.isLightBulbIncludedFieldSpecified;
            }
            set
            {
                this.isLightBulbIncludedFieldSpecified = value;
            }
        }

        public AngleUnit beamAngle
        {
            get
            {
                return this.beamAngleField;
            }
            set
            {
                this.beamAngleField = value;
            }
        }

        public AngleUnit beamSpread
        {
            get
            {
                return this.beamSpreadField;
            }
            set
            {
                this.beamSpreadField = value;
            }
        }

        public LengthUnit compatibleConduitSizes
        {
            get
            {
                return this.compatibleConduitSizesField;
            }
            set
            {
                this.compatibleConduitSizesField = value;
            }
        }

        public bool isDarkSkyCompliant
        {
            get
            {
                return this.isDarkSkyCompliantField;
            }
            set
            {
                this.isDarkSkyCompliantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDarkSkyCompliantSpecified
        {
            get
            {
                return this.isDarkSkyCompliantFieldSpecified;
            }
            set
            {
                this.isDarkSkyCompliantFieldSpecified = value;
            }
        }

        public decimal electricalBallastFactor
        {
            get
            {
                return this.electricalBallastFactorField;
            }
            set
            {
                this.electricalBallastFactorField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool electricalBallastFactorSpecified
        {
            get
            {
                return this.electricalBallastFactorFieldSpecified;
            }
            set
            {
                this.electricalBallastFactorFieldSpecified = value;
            }
        }

        public bool isRatedForOutdoorUse
        {
            get
            {
                return this.isRatedForOutdoorUseField;
            }
            set
            {
                this.isRatedForOutdoorUseField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRatedForOutdoorUseSpecified
        {
            get
            {
                return this.isRatedForOutdoorUseFieldSpecified;
            }
            set
            {
                this.isRatedForOutdoorUseFieldSpecified = value;
            }
        }

        public decimal maximumEnergySurgeRating
        {
            get
            {
                return this.maximumEnergySurgeRatingField;
            }
            set
            {
                this.maximumEnergySurgeRatingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumEnergySurgeRatingSpecified
        {
            get
            {
                return this.maximumEnergySurgeRatingFieldSpecified;
            }
            set
            {
                this.maximumEnergySurgeRatingFieldSpecified = value;
            }
        }

        public AreaUnit maximumRange
        {
            get
            {
                return this.maximumRangeField;
            }
            set
            {
                this.maximumRangeField = value;
            }
        }

        public TimeUnit responseTime
        {
            get
            {
                return this.responseTimeField;
            }
            set
            {
                this.responseTimeField = value;
            }
        }

        public string numberOfGangs
        {
            get
            {
                return this.numberOfGangsField;
            }
            set
            {
                this.numberOfGangsField = value;
            }
        }

        public string numberOfPoles
        {
            get
            {
                return this.numberOfPolesField;
            }
            set
            {
                this.numberOfPolesField = value;
            }
        }

        public LengthUnit americanWireGauge
        {
            get
            {
                return this.americanWireGaugeField;
            }
            set
            {
                this.americanWireGaugeField = value;
            }
        }

        public BrightnessUnit brightness
        {
            get
            {
                return this.brightnessField;
            }
            set
            {
                this.brightnessField = value;
            }
        }

        public string lifespan
        {
            get
            {
                return this.lifespanField;
            }
            set
            {
                this.lifespanField = value;
            }
        }

        public bool hasCeeCertification
        {
            get
            {
                return this.hasCeeCertificationField;
            }
            set
            {
                this.hasCeeCertificationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCeeCertificationSpecified
        {
            get
            {
                return this.hasCeeCertificationFieldSpecified;
            }
            set
            {
                this.hasCeeCertificationFieldSpecified = value;
            }
        }

        public ElectricalCeeTier ceeTier
        {
            get
            {
                return this.ceeTierField;
            }
            set
            {
                this.ceeTierField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ceeTierSpecified
        {
            get
            {
                return this.ceeTierFieldSpecified;
            }
            set
            {
                this.ceeTierFieldSpecified = value;
            }
        }

        public ElectricalMeasurementUnit amps
        {
            get
            {
                return this.ampsField;
            }
            set
            {
                this.ampsField = value;
            }
        }

        public PowerUnit decibelRating
        {
            get
            {
                return this.decibelRatingField;
            }
            set
            {
                this.decibelRatingField = value;
            }
        }

        public PowerUnit horsepower
        {
            get
            {
                return this.horsepowerField;
            }
            set
            {
                this.horsepowerField = value;
            }
        }
    }

    public partial class AngleUnit
    {

        private AngleUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private string measureField;

        public AngleUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public string measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }
    }

    public enum AngleUnitOfMeasure
    {

        /// <remarks/>
        Degree,

        /// <remarks/>
        Radian,

        /// <remarks/>
        Steradian,
    }

    public enum ElectricalCeeTier
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CEE Tier I")]
        CEETierI,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CEE Tier II")]
        CEETierII,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CEE Tier III")]
        CEETierIII,
    }

    public partial class Hardware
    {

        private string finishField;

        private string homeDecorStyleField;

        private List<string> mountTypeField;

        private WeightUnit maximumWeightField;

        private LengthUnit backsetSizeField;

        private LengthUnit liftHeightField;

        private bool isLockableField;

        private bool isLockableFieldSpecified;

        private WeightUnit maximumForceResistedField;

        private string petSizeField;

        private string threadStandardField;

        public Hardware()
        {
            this.maximumForceResistedField = new WeightUnit();
            this.liftHeightField = new LengthUnit();
            this.backsetSizeField = new LengthUnit();
            this.maximumWeightField = new WeightUnit();
            this.mountTypeField = new List<string>();
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("mountTypeValue", IsNullable = false)]
        public List<string> mountType
        {
            get
            {
                return this.mountTypeField;
            }
            set
            {
                this.mountTypeField = value;
            }
        }

        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        public LengthUnit backsetSize
        {
            get
            {
                return this.backsetSizeField;
            }
            set
            {
                this.backsetSizeField = value;
            }
        }

        public LengthUnit liftHeight
        {
            get
            {
                return this.liftHeightField;
            }
            set
            {
                this.liftHeightField = value;
            }
        }

        public bool isLockable
        {
            get
            {
                return this.isLockableField;
            }
            set
            {
                this.isLockableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLockableSpecified
        {
            get
            {
                return this.isLockableFieldSpecified;
            }
            set
            {
                this.isLockableFieldSpecified = value;
            }
        }

        public WeightUnit maximumForceResisted
        {
            get
            {
                return this.maximumForceResistedField;
            }
            set
            {
                this.maximumForceResistedField = value;
            }
        }

        public string petSize
        {
            get
            {
                return this.petSizeField;
            }
            set
            {
                this.petSizeField = value;
            }
        }

        public string threadStandard
        {
            get
            {
                return this.threadStandardField;
            }
            set
            {
                this.threadStandardField = value;
            }
        }
    }

    public partial class PlumbingAndHVAC
    {

        private bool isEnergyGuideLabelRequiredField;

        private bool isEnergyGuideLabelRequiredFieldSpecified;

        private string energyGuideLabelField;

        private string finishField;

        private string homeDecorStyleField;

        private List<string> mountTypeField;

        private string powerTypeField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private string seatingCapacityField;

        private VolumeUnit volumeCapacityField;

        private string fuelTypeField;

        private ElectricalMeasurementUnit voltsField;

        private PowerUnit wattsField;

        private string btuField;

        private AreaUnit maximumRoomSizeField;

        private bool hasAutomaticShutoffField;

        private bool hasAutomaticShutoffFieldSpecified;

        private bool hasCeeCertificationField;

        private bool hasCeeCertificationFieldSpecified;

        private PlumbingAndHVACCeeTier ceeTierField;

        private bool ceeTierFieldSpecified;

        private string drainConfigurationField;

        private string faucetDrillingsField;

        private VolumeUnit gallonsPerFlushField;

        private VolumeUnit gallonsPerMinuteField;

        private string humidificationOutputPerDayField;

        private LengthUnit inletDiameterField;

        private string mervRatingField;

        private LengthUnit outletDiameterField;

        private string pintsOfMoistureRemovedPerDayField;

        private LengthUnit spoutHeightField;

        private LengthUnit spoutReachField;

        private LengthUnit spudInletSizeField;

        private string threadStandardField;

        private string toiletBowlSizeField;

        private string tripLeverPlacementField;

        private bool isVentedField;

        private bool isVentedFieldSpecified;

        private bool ventingRequiredField;

        private bool ventingRequiredFieldSpecified;

        private string humidificationMethodField;

        private PowerUnit horsepowerField;

        public PlumbingAndHVAC()
        {
            this.horsepowerField = new PowerUnit();
            this.spudInletSizeField = new LengthUnit();
            this.spoutReachField = new LengthUnit();
            this.spoutHeightField = new LengthUnit();
            this.outletDiameterField = new LengthUnit();
            this.inletDiameterField = new LengthUnit();
            this.gallonsPerMinuteField = new VolumeUnit();
            this.gallonsPerFlushField = new VolumeUnit();
            this.maximumRoomSizeField = new AreaUnit();
            this.wattsField = new PowerUnit();
            this.voltsField = new ElectricalMeasurementUnit();
            this.volumeCapacityField = new VolumeUnit();
            this.mountTypeField = new List<string>();
        }

        public bool isEnergyGuideLabelRequired
        {
            get
            {
                return this.isEnergyGuideLabelRequiredField;
            }
            set
            {
                this.isEnergyGuideLabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyGuideLabelRequiredSpecified
        {
            get
            {
                return this.isEnergyGuideLabelRequiredFieldSpecified;
            }
            set
            {
                this.isEnergyGuideLabelRequiredFieldSpecified = value;
            }
        }

        public string energyGuideLabel
        {
            get
            {
                return this.energyGuideLabelField;
            }
            set
            {
                this.energyGuideLabelField = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public string homeDecorStyle
        {
            get
            {
                return this.homeDecorStyleField;
            }
            set
            {
                this.homeDecorStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("mountTypeValue", IsNullable = false)]
        public List<string> mountType
        {
            get
            {
                return this.mountTypeField;
            }
            set
            {
                this.mountTypeField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public bool isRemoteControlIncluded
        {
            get
            {
                return this.isRemoteControlIncludedField;
            }
            set
            {
                this.isRemoteControlIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRemoteControlIncludedSpecified
        {
            get
            {
                return this.isRemoteControlIncludedFieldSpecified;
            }
            set
            {
                this.isRemoteControlIncludedFieldSpecified = value;
            }
        }

        public string seatingCapacity
        {
            get
            {
                return this.seatingCapacityField;
            }
            set
            {
                this.seatingCapacityField = value;
            }
        }

        public VolumeUnit volumeCapacity
        {
            get
            {
                return this.volumeCapacityField;
            }
            set
            {
                this.volumeCapacityField = value;
            }
        }

        public string fuelType
        {
            get
            {
                return this.fuelTypeField;
            }
            set
            {
                this.fuelTypeField = value;
            }
        }

        public ElectricalMeasurementUnit volts
        {
            get
            {
                return this.voltsField;
            }
            set
            {
                this.voltsField = value;
            }
        }

        public PowerUnit watts
        {
            get
            {
                return this.wattsField;
            }
            set
            {
                this.wattsField = value;
            }
        }

        public string btu
        {
            get
            {
                return this.btuField;
            }
            set
            {
                this.btuField = value;
            }
        }

        public AreaUnit maximumRoomSize
        {
            get
            {
                return this.maximumRoomSizeField;
            }
            set
            {
                this.maximumRoomSizeField = value;
            }
        }

        public bool hasAutomaticShutoff
        {
            get
            {
                return this.hasAutomaticShutoffField;
            }
            set
            {
                this.hasAutomaticShutoffField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticShutoffSpecified
        {
            get
            {
                return this.hasAutomaticShutoffFieldSpecified;
            }
            set
            {
                this.hasAutomaticShutoffFieldSpecified = value;
            }
        }

        public bool hasCeeCertification
        {
            get
            {
                return this.hasCeeCertificationField;
            }
            set
            {
                this.hasCeeCertificationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCeeCertificationSpecified
        {
            get
            {
                return this.hasCeeCertificationFieldSpecified;
            }
            set
            {
                this.hasCeeCertificationFieldSpecified = value;
            }
        }

        public PlumbingAndHVACCeeTier ceeTier
        {
            get
            {
                return this.ceeTierField;
            }
            set
            {
                this.ceeTierField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ceeTierSpecified
        {
            get
            {
                return this.ceeTierFieldSpecified;
            }
            set
            {
                this.ceeTierFieldSpecified = value;
            }
        }

        public string drainConfiguration
        {
            get
            {
                return this.drainConfigurationField;
            }
            set
            {
                this.drainConfigurationField = value;
            }
        }

        public string faucetDrillings
        {
            get
            {
                return this.faucetDrillingsField;
            }
            set
            {
                this.faucetDrillingsField = value;
            }
        }

        public VolumeUnit gallonsPerFlush
        {
            get
            {
                return this.gallonsPerFlushField;
            }
            set
            {
                this.gallonsPerFlushField = value;
            }
        }

        public VolumeUnit gallonsPerMinute
        {
            get
            {
                return this.gallonsPerMinuteField;
            }
            set
            {
                this.gallonsPerMinuteField = value;
            }
        }

        public string humidificationOutputPerDay
        {
            get
            {
                return this.humidificationOutputPerDayField;
            }
            set
            {
                this.humidificationOutputPerDayField = value;
            }
        }

        public LengthUnit inletDiameter
        {
            get
            {
                return this.inletDiameterField;
            }
            set
            {
                this.inletDiameterField = value;
            }
        }

        public string mervRating
        {
            get
            {
                return this.mervRatingField;
            }
            set
            {
                this.mervRatingField = value;
            }
        }

        public LengthUnit outletDiameter
        {
            get
            {
                return this.outletDiameterField;
            }
            set
            {
                this.outletDiameterField = value;
            }
        }

        public string pintsOfMoistureRemovedPerDay
        {
            get
            {
                return this.pintsOfMoistureRemovedPerDayField;
            }
            set
            {
                this.pintsOfMoistureRemovedPerDayField = value;
            }
        }

        public LengthUnit spoutHeight
        {
            get
            {
                return this.spoutHeightField;
            }
            set
            {
                this.spoutHeightField = value;
            }
        }

        public LengthUnit spoutReach
        {
            get
            {
                return this.spoutReachField;
            }
            set
            {
                this.spoutReachField = value;
            }
        }

        public LengthUnit spudInletSize
        {
            get
            {
                return this.spudInletSizeField;
            }
            set
            {
                this.spudInletSizeField = value;
            }
        }

        public string threadStandard
        {
            get
            {
                return this.threadStandardField;
            }
            set
            {
                this.threadStandardField = value;
            }
        }

        public string toiletBowlSize
        {
            get
            {
                return this.toiletBowlSizeField;
            }
            set
            {
                this.toiletBowlSizeField = value;
            }
        }

        public string tripLeverPlacement
        {
            get
            {
                return this.tripLeverPlacementField;
            }
            set
            {
                this.tripLeverPlacementField = value;
            }
        }

        public bool isVented
        {
            get
            {
                return this.isVentedField;
            }
            set
            {
                this.isVentedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isVentedSpecified
        {
            get
            {
                return this.isVentedFieldSpecified;
            }
            set
            {
                this.isVentedFieldSpecified = value;
            }
        }

        public bool ventingRequired
        {
            get
            {
                return this.ventingRequiredField;
            }
            set
            {
                this.ventingRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ventingRequiredSpecified
        {
            get
            {
                return this.ventingRequiredFieldSpecified;
            }
            set
            {
                this.ventingRequiredFieldSpecified = value;
            }
        }

        public string humidificationMethod
        {
            get
            {
                return this.humidificationMethodField;
            }
            set
            {
                this.humidificationMethodField = value;
            }
        }

        public PowerUnit horsepower
        {
            get
            {
                return this.horsepowerField;
            }
            set
            {
                this.horsepowerField = value;
            }
        }
    }

    public enum PlumbingAndHVACCeeTier
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CEE Tier I")]
        CEETierI,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CEE Tier II")]
        CEETierII,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CEE Tier III")]
        CEETierIII,
    }

    public partial class Tools
    {

        private string finishField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private string powerTypeField;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private bool hasCflField;

        private bool hasCflFieldSpecified;

        private bool isLightingFactsLabelRequiredField;

        private bool isLightingFactsLabelRequiredFieldSpecified;

        private string lightingFactsLabelField;

        private VolumeUnit volumeCapacityField;

        private string fuelTypeField;

        private ElectricalMeasurementUnit voltsField;

        private LengthUnit cordLengthField;

        private string lightBulbTypeField;

        private string handingField;

        private bool caseIncludedField;

        private bool caseIncludedFieldSpecified;

        private ElectricalMeasurementUnit ampsField;

        private bool isBareToolField;

        private bool isBareToolFieldSpecified;

        private ElectricalMeasurementUnit batteryCapacityField;

        private bool chargerIncludedField;

        private bool chargerIncludedFieldSpecified;

        private TimeUnit chargingTimeField;

        private bool hasElectricBrakeField;

        private bool hasElectricBrakeFieldSpecified;

        private bool isVariableSpeedField;

        private bool isVariableSpeedFieldSpecified;

        private bool toolFreeBladeChangingField;

        private bool toolFreeBladeChangingFieldSpecified;

        private LengthUnit bladeDiameterField;

        private LengthUnit bladeLengthField;

        private string bladeShankField;

        private string teethPerInchField;

        private LengthUnit discSizeField;

        private LengthUnit chuckSizeField;

        private string chuckTypeField;

        private LengthUnit colletSizeField;

        private string sandingBeltSizeField;

        private LengthUnit arborDiameterField;

        private string spindleThreadField;

        private LengthUnit shankSizeField;

        private string shankShapeField;

        private LengthUnit maximumJawOpeningField;

        private PowerUnit decibelRatingField;

        private PowerUnit impactEnergyField;

        private string blowsPerMinuteField;

        private LengthUnit strokeLengthField;

        private string strokesPerMinuteField;

        private PowerUnit maximumWattsOutField;

        private SpeedUnit noLoadSpeedField;

        private decimal torqueField;

        private bool torqueFieldSpecified;

        private SpeedUnit sandingSpeedField;

        private LengthUnit airInletField;

        private VolumeUnit averageAirConsumptionAt90PSIField;

        private VolumeUnit cfmAt40PsiField;

        private VolumeUnit cfmAt90PsiField;

        private PressureUnit workingPressureField;

        private PressureUnit maximumAirPressureField;

        private string tankConfigurationField;

        private VolumeUnit tankSizeField;

        private bool isCarbCompliantField;

        private bool isCarbCompliantFieldSpecified;

        private VolumeUnit engineDisplacementField;

        private PowerUnit horsepowerField;

        private string engineStarterField;

        private bool hasAutomaticTransferSwitchField;

        private bool hasAutomaticTransferSwitchFieldSpecified;

        private LengthUnit clearingWidthField;

        private PressureUnit loadCapacityField;

        public Tools()
        {
            this.loadCapacityField = new PressureUnit();
            this.clearingWidthField = new LengthUnit();
            this.horsepowerField = new PowerUnit();
            this.engineDisplacementField = new VolumeUnit();
            this.tankSizeField = new VolumeUnit();
            this.maximumAirPressureField = new PressureUnit();
            this.workingPressureField = new PressureUnit();
            this.cfmAt90PsiField = new VolumeUnit();
            this.cfmAt40PsiField = new VolumeUnit();
            this.averageAirConsumptionAt90PSIField = new VolumeUnit();
            this.airInletField = new LengthUnit();
            this.sandingSpeedField = new SpeedUnit();
            this.noLoadSpeedField = new SpeedUnit();
            this.maximumWattsOutField = new PowerUnit();
            this.strokeLengthField = new LengthUnit();
            this.impactEnergyField = new PowerUnit();
            this.decibelRatingField = new PowerUnit();
            this.maximumJawOpeningField = new LengthUnit();
            this.shankSizeField = new LengthUnit();
            this.arborDiameterField = new LengthUnit();
            this.colletSizeField = new LengthUnit();
            this.chuckSizeField = new LengthUnit();
            this.discSizeField = new LengthUnit();
            this.bladeLengthField = new LengthUnit();
            this.bladeDiameterField = new LengthUnit();
            this.chargingTimeField = new TimeUnit();
            this.batteryCapacityField = new ElectricalMeasurementUnit();
            this.ampsField = new ElectricalMeasurementUnit();
            this.cordLengthField = new LengthUnit();
            this.voltsField = new ElectricalMeasurementUnit();
            this.volumeCapacityField = new VolumeUnit();
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public bool isPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        public bool hasCfl
        {
            get
            {
                return this.hasCflField;
            }
            set
            {
                this.hasCflField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasCflSpecified
        {
            get
            {
                return this.hasCflFieldSpecified;
            }
            set
            {
                this.hasCflFieldSpecified = value;
            }
        }

        public bool isLightingFactsLabelRequired
        {
            get
            {
                return this.isLightingFactsLabelRequiredField;
            }
            set
            {
                this.isLightingFactsLabelRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLightingFactsLabelRequiredSpecified
        {
            get
            {
                return this.isLightingFactsLabelRequiredFieldSpecified;
            }
            set
            {
                this.isLightingFactsLabelRequiredFieldSpecified = value;
            }
        }

        public string lightingFactsLabel
        {
            get
            {
                return this.lightingFactsLabelField;
            }
            set
            {
                this.lightingFactsLabelField = value;
            }
        }

        public VolumeUnit volumeCapacity
        {
            get
            {
                return this.volumeCapacityField;
            }
            set
            {
                this.volumeCapacityField = value;
            }
        }

        public string fuelType
        {
            get
            {
                return this.fuelTypeField;
            }
            set
            {
                this.fuelTypeField = value;
            }
        }

        public ElectricalMeasurementUnit volts
        {
            get
            {
                return this.voltsField;
            }
            set
            {
                this.voltsField = value;
            }
        }

        public LengthUnit cordLength
        {
            get
            {
                return this.cordLengthField;
            }
            set
            {
                this.cordLengthField = value;
            }
        }

        public string lightBulbType
        {
            get
            {
                return this.lightBulbTypeField;
            }
            set
            {
                this.lightBulbTypeField = value;
            }
        }

        public string handing
        {
            get
            {
                return this.handingField;
            }
            set
            {
                this.handingField = value;
            }
        }

        public bool caseIncluded
        {
            get
            {
                return this.caseIncludedField;
            }
            set
            {
                this.caseIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool caseIncludedSpecified
        {
            get
            {
                return this.caseIncludedFieldSpecified;
            }
            set
            {
                this.caseIncludedFieldSpecified = value;
            }
        }

        public ElectricalMeasurementUnit amps
        {
            get
            {
                return this.ampsField;
            }
            set
            {
                this.ampsField = value;
            }
        }

        public bool isBareTool
        {
            get
            {
                return this.isBareToolField;
            }
            set
            {
                this.isBareToolField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBareToolSpecified
        {
            get
            {
                return this.isBareToolFieldSpecified;
            }
            set
            {
                this.isBareToolFieldSpecified = value;
            }
        }

        public ElectricalMeasurementUnit batteryCapacity
        {
            get
            {
                return this.batteryCapacityField;
            }
            set
            {
                this.batteryCapacityField = value;
            }
        }

        public bool chargerIncluded
        {
            get
            {
                return this.chargerIncludedField;
            }
            set
            {
                this.chargerIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool chargerIncludedSpecified
        {
            get
            {
                return this.chargerIncludedFieldSpecified;
            }
            set
            {
                this.chargerIncludedFieldSpecified = value;
            }
        }

        public TimeUnit chargingTime
        {
            get
            {
                return this.chargingTimeField;
            }
            set
            {
                this.chargingTimeField = value;
            }
        }

        public bool hasElectricBrake
        {
            get
            {
                return this.hasElectricBrakeField;
            }
            set
            {
                this.hasElectricBrakeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasElectricBrakeSpecified
        {
            get
            {
                return this.hasElectricBrakeFieldSpecified;
            }
            set
            {
                this.hasElectricBrakeFieldSpecified = value;
            }
        }

        public bool isVariableSpeed
        {
            get
            {
                return this.isVariableSpeedField;
            }
            set
            {
                this.isVariableSpeedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isVariableSpeedSpecified
        {
            get
            {
                return this.isVariableSpeedFieldSpecified;
            }
            set
            {
                this.isVariableSpeedFieldSpecified = value;
            }
        }

        public bool toolFreeBladeChanging
        {
            get
            {
                return this.toolFreeBladeChangingField;
            }
            set
            {
                this.toolFreeBladeChangingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toolFreeBladeChangingSpecified
        {
            get
            {
                return this.toolFreeBladeChangingFieldSpecified;
            }
            set
            {
                this.toolFreeBladeChangingFieldSpecified = value;
            }
        }

        public LengthUnit bladeDiameter
        {
            get
            {
                return this.bladeDiameterField;
            }
            set
            {
                this.bladeDiameterField = value;
            }
        }

        public LengthUnit bladeLength
        {
            get
            {
                return this.bladeLengthField;
            }
            set
            {
                this.bladeLengthField = value;
            }
        }

        public string bladeShank
        {
            get
            {
                return this.bladeShankField;
            }
            set
            {
                this.bladeShankField = value;
            }
        }

        public string teethPerInch
        {
            get
            {
                return this.teethPerInchField;
            }
            set
            {
                this.teethPerInchField = value;
            }
        }

        public LengthUnit discSize
        {
            get
            {
                return this.discSizeField;
            }
            set
            {
                this.discSizeField = value;
            }
        }

        public LengthUnit chuckSize
        {
            get
            {
                return this.chuckSizeField;
            }
            set
            {
                this.chuckSizeField = value;
            }
        }

        public string chuckType
        {
            get
            {
                return this.chuckTypeField;
            }
            set
            {
                this.chuckTypeField = value;
            }
        }

        public LengthUnit colletSize
        {
            get
            {
                return this.colletSizeField;
            }
            set
            {
                this.colletSizeField = value;
            }
        }

        public string sandingBeltSize
        {
            get
            {
                return this.sandingBeltSizeField;
            }
            set
            {
                this.sandingBeltSizeField = value;
            }
        }

        public LengthUnit arborDiameter
        {
            get
            {
                return this.arborDiameterField;
            }
            set
            {
                this.arborDiameterField = value;
            }
        }

        public string spindleThread
        {
            get
            {
                return this.spindleThreadField;
            }
            set
            {
                this.spindleThreadField = value;
            }
        }

        public LengthUnit shankSize
        {
            get
            {
                return this.shankSizeField;
            }
            set
            {
                this.shankSizeField = value;
            }
        }

        public string shankShape
        {
            get
            {
                return this.shankShapeField;
            }
            set
            {
                this.shankShapeField = value;
            }
        }

        public LengthUnit maximumJawOpening
        {
            get
            {
                return this.maximumJawOpeningField;
            }
            set
            {
                this.maximumJawOpeningField = value;
            }
        }

        public PowerUnit decibelRating
        {
            get
            {
                return this.decibelRatingField;
            }
            set
            {
                this.decibelRatingField = value;
            }
        }

        public PowerUnit impactEnergy
        {
            get
            {
                return this.impactEnergyField;
            }
            set
            {
                this.impactEnergyField = value;
            }
        }

        public string blowsPerMinute
        {
            get
            {
                return this.blowsPerMinuteField;
            }
            set
            {
                this.blowsPerMinuteField = value;
            }
        }

        public LengthUnit strokeLength
        {
            get
            {
                return this.strokeLengthField;
            }
            set
            {
                this.strokeLengthField = value;
            }
        }

        public string strokesPerMinute
        {
            get
            {
                return this.strokesPerMinuteField;
            }
            set
            {
                this.strokesPerMinuteField = value;
            }
        }

        public PowerUnit maximumWattsOut
        {
            get
            {
                return this.maximumWattsOutField;
            }
            set
            {
                this.maximumWattsOutField = value;
            }
        }

        public SpeedUnit noLoadSpeed
        {
            get
            {
                return this.noLoadSpeedField;
            }
            set
            {
                this.noLoadSpeedField = value;
            }
        }

        public decimal torque
        {
            get
            {
                return this.torqueField;
            }
            set
            {
                this.torqueField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool torqueSpecified
        {
            get
            {
                return this.torqueFieldSpecified;
            }
            set
            {
                this.torqueFieldSpecified = value;
            }
        }

        public SpeedUnit sandingSpeed
        {
            get
            {
                return this.sandingSpeedField;
            }
            set
            {
                this.sandingSpeedField = value;
            }
        }

        public LengthUnit airInlet
        {
            get
            {
                return this.airInletField;
            }
            set
            {
                this.airInletField = value;
            }
        }

        public VolumeUnit averageAirConsumptionAt90PSI
        {
            get
            {
                return this.averageAirConsumptionAt90PSIField;
            }
            set
            {
                this.averageAirConsumptionAt90PSIField = value;
            }
        }

        public VolumeUnit cfmAt40Psi
        {
            get
            {
                return this.cfmAt40PsiField;
            }
            set
            {
                this.cfmAt40PsiField = value;
            }
        }

        public VolumeUnit cfmAt90Psi
        {
            get
            {
                return this.cfmAt90PsiField;
            }
            set
            {
                this.cfmAt90PsiField = value;
            }
        }

        public PressureUnit workingPressure
        {
            get
            {
                return this.workingPressureField;
            }
            set
            {
                this.workingPressureField = value;
            }
        }

        public PressureUnit maximumAirPressure
        {
            get
            {
                return this.maximumAirPressureField;
            }
            set
            {
                this.maximumAirPressureField = value;
            }
        }

        public string tankConfiguration
        {
            get
            {
                return this.tankConfigurationField;
            }
            set
            {
                this.tankConfigurationField = value;
            }
        }

        public VolumeUnit tankSize
        {
            get
            {
                return this.tankSizeField;
            }
            set
            {
                this.tankSizeField = value;
            }
        }

        public bool isCarbCompliant
        {
            get
            {
                return this.isCarbCompliantField;
            }
            set
            {
                this.isCarbCompliantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isCarbCompliantSpecified
        {
            get
            {
                return this.isCarbCompliantFieldSpecified;
            }
            set
            {
                this.isCarbCompliantFieldSpecified = value;
            }
        }

        public VolumeUnit engineDisplacement
        {
            get
            {
                return this.engineDisplacementField;
            }
            set
            {
                this.engineDisplacementField = value;
            }
        }

        public PowerUnit horsepower
        {
            get
            {
                return this.horsepowerField;
            }
            set
            {
                this.horsepowerField = value;
            }
        }

        public string engineStarter
        {
            get
            {
                return this.engineStarterField;
            }
            set
            {
                this.engineStarterField = value;
            }
        }

        public bool hasAutomaticTransferSwitch
        {
            get
            {
                return this.hasAutomaticTransferSwitchField;
            }
            set
            {
                this.hasAutomaticTransferSwitchField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasAutomaticTransferSwitchSpecified
        {
            get
            {
                return this.hasAutomaticTransferSwitchFieldSpecified;
            }
            set
            {
                this.hasAutomaticTransferSwitchFieldSpecified = value;
            }
        }

        public LengthUnit clearingWidth
        {
            get
            {
                return this.clearingWidthField;
            }
            set
            {
                this.clearingWidthField = value;
            }
        }

        public PressureUnit loadCapacity
        {
            get
            {
                return this.loadCapacityField;
            }
            set
            {
                this.loadCapacityField = value;
            }
        }
    }

    public partial class Toy
    {

        private string animalBreedField;

        private List<swatchImage> swatchImagesField;

        private ToyAgeRange ageRangeField;

        private WeightUnit minimumWeightField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private List<fabricContentValue> fabricContentField;

        private bool isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private string finishField;

        private bool isRecyclableField;

        private bool isRecyclableFieldSpecified;

        private List<string> fabricCareInstructionsField;

        private string brandField;

        private string manufacturerField;

        private List<string> themeField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private ToyGender genderField;

        private bool genderFieldSpecified;

        private List<string> colorField;

        private List<string> ageGroupField;

        private List<string> awardsWonField;

        private bool isEnergyStarCertifiedField;

        private bool isEnergyStarCertifiedFieldSpecified;

        private string animalTypeField;

        private List<string> materialField;

        private bool isPoweredField;

        private bool isPoweredFieldSpecified;

        private string numberOfPiecesField;

        private List<string> characterField;

        private string powerTypeField;

        private bool isRemoteControlIncludedField;

        private bool isRemoteControlIncludedFieldSpecified;

        private List<string> occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isMadeFromRecycledMaterialField;

        private bool isMadeFromRecycledMaterialFieldSpecified;

        private bool isTravelSizeField;

        private bool isTravelSizeFieldSpecified;

        private List<recycledMaterialContentValue> recycledMaterialContentField;

        private string seatingCapacityField;

        private bool isInflatableField;

        private bool isInflatableFieldSpecified;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private TimeUnit maximumRecommendedAgeField;

        private string assemblyInstructionsField;

        private TimeUnit minimumRecommendedAgeField;

        private List<string> sportField;

        private string skillLevelField;

        private WeightUnit maximumWeightField;

        private List<string> targetAudienceField;

        private SpeedUnit maximumSpeedField;

        private List<string> educationalFocusField;

        private string capacityField;

        private string skinToneField;

        private ElectricalMeasurementUnit voltsField;

        private string vehicleTypeField;

        private string shapeField;

        private LengthUnit screenSizeField;

        private string displayTechnologyField;

        private object itemField;

        public Toy()
        {
            this.screenSizeField = new LengthUnit();
            this.voltsField = new ElectricalMeasurementUnit();
            this.educationalFocusField = new List<string>();
            this.maximumSpeedField = new SpeedUnit();
            this.targetAudienceField = new List<string>();
            this.maximumWeightField = new WeightUnit();
            this.sportField = new List<string>();
            this.minimumRecommendedAgeField = new TimeUnit();
            this.maximumRecommendedAgeField = new TimeUnit();
            this.recycledMaterialContentField = new List<recycledMaterialContentValue>();
            this.occasionField = new List<string>();
            this.characterField = new List<string>();
            this.materialField = new List<string>();
            this.awardsWonField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.themeField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.variantAttributeNamesField = new List<string>();
            this.minimumWeightField = new WeightUnit();
            this.swatchImagesField = new List<swatchImage>();
        }

        public string animalBreed
        {
            get
            {
                return this.animalBreedField;
            }
            set
            {
                this.animalBreedField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public ToyAgeRange ageRange
        {
            get
            {
                return this.ageRangeField;
            }
            set
            {
                this.ageRangeField = value;
            }
        }

        public WeightUnit minimumWeight
        {
            get
            {
                return this.minimumWeightField;
            }
            set
            {
                this.minimumWeightField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public bool isAdultProduct
        {
            get
            {
                return this.isAdultProductField;
            }
            set
            {
                this.isAdultProductField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdultProductSpecified
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

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public bool isRecyclable
        {
            get
            {
                return this.isRecyclableField;
            }
            set
            {
                this.isRecyclableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRecyclableSpecified
        {
            get
            {
                return this.isRecyclableFieldSpecified;
            }
            set
            {
                this.isRecyclableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public List<string> theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public ToyGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("awardsWonValue", IsNullable = false)]
        public List<string> awardsWon
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

        public bool isEnergyStarCertified
        {
            get
            {
                return this.isEnergyStarCertifiedField;
            }
            set
            {
                this.isEnergyStarCertifiedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEnergyStarCertifiedSpecified
        {
            get
            {
                return this.isEnergyStarCertifiedFieldSpecified;
            }
            set
            {
                this.isEnergyStarCertifiedFieldSpecified = value;
            }
        }

        public string animalType
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

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        public bool isPowered
        {
            get
            {
                return this.isPoweredField;
            }
            set
            {
                this.isPoweredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPoweredSpecified
        {
            get
            {
                return this.isPoweredFieldSpecified;
            }
            set
            {
                this.isPoweredFieldSpecified = value;
            }
        }

        public string numberOfPieces
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

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public bool isRemoteControlIncluded
        {
            get
            {
                return this.isRemoteControlIncludedField;
            }
            set
            {
                this.isRemoteControlIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRemoteControlIncludedSpecified
        {
            get
            {
                return this.isRemoteControlIncludedFieldSpecified;
            }
            set
            {
                this.isRemoteControlIncludedFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public bool isMadeFromRecycledMaterial
        {
            get
            {
                return this.isMadeFromRecycledMaterialField;
            }
            set
            {
                this.isMadeFromRecycledMaterialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMadeFromRecycledMaterialSpecified
        {
            get
            {
                return this.isMadeFromRecycledMaterialFieldSpecified;
            }
            set
            {
                this.isMadeFromRecycledMaterialFieldSpecified = value;
            }
        }

        public bool isTravelSize
        {
            get
            {
                return this.isTravelSizeField;
            }
            set
            {
                this.isTravelSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTravelSizeSpecified
        {
            get
            {
                return this.isTravelSizeFieldSpecified;
            }
            set
            {
                this.isTravelSizeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<recycledMaterialContentValue> recycledMaterialContent
        {
            get
            {
                return this.recycledMaterialContentField;
            }
            set
            {
                this.recycledMaterialContentField = value;
            }
        }

        public string seatingCapacity
        {
            get
            {
                return this.seatingCapacityField;
            }
            set
            {
                this.seatingCapacityField = value;
            }
        }

        public bool isInflatable
        {
            get
            {
                return this.isInflatableField;
            }
            set
            {
                this.isInflatableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInflatableSpecified
        {
            get
            {
                return this.isInflatableFieldSpecified;
            }
            set
            {
                this.isInflatableFieldSpecified = value;
            }
        }

        public bool isAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAssemblyRequiredSpecified
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

        public TimeUnit maximumRecommendedAge
        {
            get
            {
                return this.maximumRecommendedAgeField;
            }
            set
            {
                this.maximumRecommendedAgeField = value;
            }
        }

        public string assemblyInstructions
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

        public TimeUnit minimumRecommendedAge
        {
            get
            {
                return this.minimumRecommendedAgeField;
            }
            set
            {
                this.minimumRecommendedAgeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("sportValue", IsNullable = false)]
        public List<string> sport
        {
            get
            {
                return this.sportField;
            }
            set
            {
                this.sportField = value;
            }
        }

        public string skillLevel
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

        public WeightUnit maximumWeight
        {
            get
            {
                return this.maximumWeightField;
            }
            set
            {
                this.maximumWeightField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("targetAudienceValue", IsNullable = false)]
        public List<string> targetAudience
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

        public SpeedUnit maximumSpeed
        {
            get
            {
                return this.maximumSpeedField;
            }
            set
            {
                this.maximumSpeedField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("educationalFocu", IsNullable = false)]
        public List<string> educationalFocus
        {
            get
            {
                return this.educationalFocusField;
            }
            set
            {
                this.educationalFocusField = value;
            }
        }

        public string capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        public string skinTone
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

        public ElectricalMeasurementUnit volts
        {
            get
            {
                return this.voltsField;
            }
            set
            {
                this.voltsField = value;
            }
        }

        public string vehicleType
        {
            get
            {
                return this.vehicleTypeField;
            }
            set
            {
                this.vehicleTypeField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        public LengthUnit screenSize
        {
            get
            {
                return this.screenSizeField;
            }
            set
            {
                this.screenSizeField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

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

    public enum ToyAgeRange
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0-12 Months")]
        Item012Months,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12-24 Months")]
        Item1224Months,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2-4 Years")]
        Item24Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5-7 Years")]
        Item57Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8-11 Years")]
        Item811Years,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12  Up")]
        Item12Up,
    }

    public enum ToyGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class Games
    {

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool makesNoiseField;

        private bool makesNoiseFieldSpecified;

        private NumberOfPlayer numberOfPlayersField;

        public Games()
        {
            this.numberOfPlayersField = new NumberOfPlayer();
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public bool makesNoise
        {
            get
            {
                return this.makesNoiseField;
            }
            set
            {
                this.makesNoiseField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool makesNoiseSpecified
        {
            get
            {
                return this.makesNoiseFieldSpecified;
            }
            set
            {
                this.makesNoiseFieldSpecified = value;
            }
        }

        public NumberOfPlayer numberOfPlayers
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
    }

    public partial class NumberOfPlayer
    {

        private string minimumNumberOfPlayersField;

        private string maximumNumberOfPlayersField;

        public string minimumNumberOfPlayers
        {
            get
            {
                return this.minimumNumberOfPlayersField;
            }
            set
            {
                this.minimumNumberOfPlayersField = value;
            }
        }

        public string maximumNumberOfPlayers
        {
            get
            {
                return this.maximumNumberOfPlayersField;
            }
            set
            {
                this.maximumNumberOfPlayersField = value;
            }
        }
    }

    public partial class Puzzles
    {

        private string numberOfPiecesField;

        public string numberOfPieces
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
    }

    public partial class Toys
    {

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool makesNoiseField;

        private bool makesNoiseFieldSpecified;

        private List<string> fillMaterialField;

        public Toys()
        {
            this.fillMaterialField = new List<string>();
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public bool makesNoise
        {
            get
            {
                return this.makesNoiseField;
            }
            set
            {
                this.makesNoiseField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool makesNoiseSpecified
        {
            get
            {
                return this.makesNoiseFieldSpecified;
            }
            set
            {
                this.makesNoiseFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fillMaterialValue", IsNullable = false)]
        public List<string> fillMaterial
        {
            get
            {
                return this.fillMaterialField;
            }
            set
            {
                this.fillMaterialField = value;
            }
        }
    }

    public partial class Vehicle
    {

        private List<swatchImage> swatchImagesField;

        private string variantGroupIdField;

        private List<string> variantAttributeNamesField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private string brandField;

        private string conditionField;

        private string manufacturerField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private List<string> colorField;

        private List<string> materialField;

        private object itemField;

        public Vehicle()
        {
            this.materialField = new List<string>();
            this.colorField = new List<string>();
            this.variantAttributeNamesField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        public string brand
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

        public string condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public string manufacturer
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

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

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

    public partial class LandVehicles
    {

        private string landVehicleCategoryField;

        private string powertrainField;

        private string drivetrainField;

        private string transmissionDesignationField;

        private string accelerationField;

        private string frontSuspensionField;

        private string rearSuspensionField;

        private string frontBrakesField;

        private string rearBrakesField;

        private string seatingCapacityField;

        private string frontWheelsField;

        private string rearWheelsField;

        private string frontTiresField;

        private string rearTiresField;

        private LengthUnit wheelbaseField;

        private WeightUnit curbWeightField;

        private WeightUnit towingCapacityField;

        private string submodelField;

        private LengthUnit seatHeightField;

        private string engineModelField;

        private string compressionRatioField;

        private string boreStrokeField;

        private string inductionSystemField;

        private string coolingSystemField;

        private string maximumEnginePowerField;

        private string topSpeedField;

        private string fuelRequirementField;

        private string fuelSystemField;

        private VolumeUnit fuelCapacityField;

        private FuelEconomyUnit averageFuelConsumptionField;

        private string vehicleMakeField;

        private string vehicleModelField;

        private string vehicleTypeField;

        private string vehicleYearField;

        private decimal torqueField;

        private bool torqueFieldSpecified;

        private VolumeUnit engineDisplacementField;

        public LandVehicles()
        {
            this.engineDisplacementField = new VolumeUnit();
            this.averageFuelConsumptionField = new FuelEconomyUnit();
            this.fuelCapacityField = new VolumeUnit();
            this.seatHeightField = new LengthUnit();
            this.towingCapacityField = new WeightUnit();
            this.curbWeightField = new WeightUnit();
            this.wheelbaseField = new LengthUnit();
        }

        public string landVehicleCategory
        {
            get
            {
                return this.landVehicleCategoryField;
            }
            set
            {
                this.landVehicleCategoryField = value;
            }
        }

        public string powertrain
        {
            get
            {
                return this.powertrainField;
            }
            set
            {
                this.powertrainField = value;
            }
        }

        public string drivetrain
        {
            get
            {
                return this.drivetrainField;
            }
            set
            {
                this.drivetrainField = value;
            }
        }

        public string transmissionDesignation
        {
            get
            {
                return this.transmissionDesignationField;
            }
            set
            {
                this.transmissionDesignationField = value;
            }
        }

        public string acceleration
        {
            get
            {
                return this.accelerationField;
            }
            set
            {
                this.accelerationField = value;
            }
        }

        public string frontSuspension
        {
            get
            {
                return this.frontSuspensionField;
            }
            set
            {
                this.frontSuspensionField = value;
            }
        }

        public string rearSuspension
        {
            get
            {
                return this.rearSuspensionField;
            }
            set
            {
                this.rearSuspensionField = value;
            }
        }

        public string frontBrakes
        {
            get
            {
                return this.frontBrakesField;
            }
            set
            {
                this.frontBrakesField = value;
            }
        }

        public string rearBrakes
        {
            get
            {
                return this.rearBrakesField;
            }
            set
            {
                this.rearBrakesField = value;
            }
        }

        public string seatingCapacity
        {
            get
            {
                return this.seatingCapacityField;
            }
            set
            {
                this.seatingCapacityField = value;
            }
        }

        public string frontWheels
        {
            get
            {
                return this.frontWheelsField;
            }
            set
            {
                this.frontWheelsField = value;
            }
        }

        public string rearWheels
        {
            get
            {
                return this.rearWheelsField;
            }
            set
            {
                this.rearWheelsField = value;
            }
        }

        public string frontTires
        {
            get
            {
                return this.frontTiresField;
            }
            set
            {
                this.frontTiresField = value;
            }
        }

        public string rearTires
        {
            get
            {
                return this.rearTiresField;
            }
            set
            {
                this.rearTiresField = value;
            }
        }

        public LengthUnit wheelbase
        {
            get
            {
                return this.wheelbaseField;
            }
            set
            {
                this.wheelbaseField = value;
            }
        }

        public WeightUnit curbWeight
        {
            get
            {
                return this.curbWeightField;
            }
            set
            {
                this.curbWeightField = value;
            }
        }

        public WeightUnit towingCapacity
        {
            get
            {
                return this.towingCapacityField;
            }
            set
            {
                this.towingCapacityField = value;
            }
        }

        public string submodel
        {
            get
            {
                return this.submodelField;
            }
            set
            {
                this.submodelField = value;
            }
        }

        public LengthUnit seatHeight
        {
            get
            {
                return this.seatHeightField;
            }
            set
            {
                this.seatHeightField = value;
            }
        }

        public string engineModel
        {
            get
            {
                return this.engineModelField;
            }
            set
            {
                this.engineModelField = value;
            }
        }

        public string compressionRatio
        {
            get
            {
                return this.compressionRatioField;
            }
            set
            {
                this.compressionRatioField = value;
            }
        }

        public string boreStroke
        {
            get
            {
                return this.boreStrokeField;
            }
            set
            {
                this.boreStrokeField = value;
            }
        }

        public string inductionSystem
        {
            get
            {
                return this.inductionSystemField;
            }
            set
            {
                this.inductionSystemField = value;
            }
        }

        public string coolingSystem
        {
            get
            {
                return this.coolingSystemField;
            }
            set
            {
                this.coolingSystemField = value;
            }
        }

        public string maximumEnginePower
        {
            get
            {
                return this.maximumEnginePowerField;
            }
            set
            {
                this.maximumEnginePowerField = value;
            }
        }

        public string topSpeed
        {
            get
            {
                return this.topSpeedField;
            }
            set
            {
                this.topSpeedField = value;
            }
        }

        public string fuelRequirement
        {
            get
            {
                return this.fuelRequirementField;
            }
            set
            {
                this.fuelRequirementField = value;
            }
        }

        public string fuelSystem
        {
            get
            {
                return this.fuelSystemField;
            }
            set
            {
                this.fuelSystemField = value;
            }
        }

        public VolumeUnit fuelCapacity
        {
            get
            {
                return this.fuelCapacityField;
            }
            set
            {
                this.fuelCapacityField = value;
            }
        }

        public FuelEconomyUnit averageFuelConsumption
        {
            get
            {
                return this.averageFuelConsumptionField;
            }
            set
            {
                this.averageFuelConsumptionField = value;
            }
        }

        public string vehicleMake
        {
            get
            {
                return this.vehicleMakeField;
            }
            set
            {
                this.vehicleMakeField = value;
            }
        }

        public string vehicleModel
        {
            get
            {
                return this.vehicleModelField;
            }
            set
            {
                this.vehicleModelField = value;
            }
        }

        public string vehicleType
        {
            get
            {
                return this.vehicleTypeField;
            }
            set
            {
                this.vehicleTypeField = value;
            }
        }

        public string vehicleYear
        {
            get
            {
                return this.vehicleYearField;
            }
            set
            {
                this.vehicleYearField = value;
            }
        }

        public decimal torque
        {
            get
            {
                return this.torqueField;
            }
            set
            {
                this.torqueField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool torqueSpecified
        {
            get
            {
                return this.torqueFieldSpecified;
            }
            set
            {
                this.torqueFieldSpecified = value;
            }
        }

        public VolumeUnit engineDisplacement
        {
            get
            {
                return this.engineDisplacementField;
            }
            set
            {
                this.engineDisplacementField = value;
            }
        }
    }

    public partial class FuelEconomyUnit
    {

        private FuelEconomyUnitOfMeasure unitField;

        private bool unitFieldSpecified;

        private decimal measureField;

        private bool measureFieldSpecified;

        public FuelEconomyUnitOfMeasure unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified
        {
            get
            {
                return this.unitFieldSpecified;
            }
            set
            {
                this.unitFieldSpecified = value;
            }
        }

        public decimal measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measureSpecified
        {
            get
            {
                return this.measureFieldSpecified;
            }
            set
            {
                this.measureFieldSpecified = value;
            }
        }
    }

    public enum FuelEconomyUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Miles Per Gallon")]
        MilesPerGallon,
    }

    public partial class Tires
    {

        private LengthUnit tireDiameterField;

        private decimal tireSizeField;

        private bool tireSizeFieldSpecified;

        private string tireWidthField;

        private string tireSeasonField;

        private string tireLoadIndexField;

        private string tireSpeedRatingField;

        private string tireTreadwearRatingField;

        private bool isRunFlatField;

        private bool isRunFlatFieldSpecified;

        private TiresTireTractionRating tireTractionRatingField;

        private bool tireTractionRatingFieldSpecified;

        private TiresTireTemperatureRating tireTemperatureRatingField;

        private bool tireTemperatureRatingFieldSpecified;

        private string constructionTypeField;

        private string tireSidewallStyleField;

        private string tireTypeField;

        private PressureUnit maximumInflationPressureField;

        private string treadDepthField;

        private string treadWidthField;

        private string uniformTireQualityGradeField;

        private LengthUnit overallDiameterField;

        public Tires()
        {
            this.overallDiameterField = new LengthUnit();
            this.maximumInflationPressureField = new PressureUnit();
            this.tireDiameterField = new LengthUnit();
        }

        public LengthUnit tireDiameter
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

        public decimal tireSize
        {
            get
            {
                return this.tireSizeField;
            }
            set
            {
                this.tireSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tireSizeSpecified
        {
            get
            {
                return this.tireSizeFieldSpecified;
            }
            set
            {
                this.tireSizeFieldSpecified = value;
            }
        }

        public string tireWidth
        {
            get
            {
                return this.tireWidthField;
            }
            set
            {
                this.tireWidthField = value;
            }
        }

        public string tireSeason
        {
            get
            {
                return this.tireSeasonField;
            }
            set
            {
                this.tireSeasonField = value;
            }
        }

        public string tireLoadIndex
        {
            get
            {
                return this.tireLoadIndexField;
            }
            set
            {
                this.tireLoadIndexField = value;
            }
        }

        public string tireSpeedRating
        {
            get
            {
                return this.tireSpeedRatingField;
            }
            set
            {
                this.tireSpeedRatingField = value;
            }
        }

        public string tireTreadwearRating
        {
            get
            {
                return this.tireTreadwearRatingField;
            }
            set
            {
                this.tireTreadwearRatingField = value;
            }
        }

        public bool isRunFlat
        {
            get
            {
                return this.isRunFlatField;
            }
            set
            {
                this.isRunFlatField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRunFlatSpecified
        {
            get
            {
                return this.isRunFlatFieldSpecified;
            }
            set
            {
                this.isRunFlatFieldSpecified = value;
            }
        }

        public TiresTireTractionRating tireTractionRating
        {
            get
            {
                return this.tireTractionRatingField;
            }
            set
            {
                this.tireTractionRatingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tireTractionRatingSpecified
        {
            get
            {
                return this.tireTractionRatingFieldSpecified;
            }
            set
            {
                this.tireTractionRatingFieldSpecified = value;
            }
        }

        public TiresTireTemperatureRating tireTemperatureRating
        {
            get
            {
                return this.tireTemperatureRatingField;
            }
            set
            {
                this.tireTemperatureRatingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tireTemperatureRatingSpecified
        {
            get
            {
                return this.tireTemperatureRatingFieldSpecified;
            }
            set
            {
                this.tireTemperatureRatingFieldSpecified = value;
            }
        }

        public string constructionType
        {
            get
            {
                return this.constructionTypeField;
            }
            set
            {
                this.constructionTypeField = value;
            }
        }

        public string tireSidewallStyle
        {
            get
            {
                return this.tireSidewallStyleField;
            }
            set
            {
                this.tireSidewallStyleField = value;
            }
        }

        public string tireType
        {
            get
            {
                return this.tireTypeField;
            }
            set
            {
                this.tireTypeField = value;
            }
        }

        public PressureUnit maximumInflationPressure
        {
            get
            {
                return this.maximumInflationPressureField;
            }
            set
            {
                this.maximumInflationPressureField = value;
            }
        }

        public string treadDepth
        {
            get
            {
                return this.treadDepthField;
            }
            set
            {
                this.treadDepthField = value;
            }
        }

        public string treadWidth
        {
            get
            {
                return this.treadWidthField;
            }
            set
            {
                this.treadWidthField = value;
            }
        }

        public string uniformTireQualityGrade
        {
            get
            {
                return this.uniformTireQualityGradeField;
            }
            set
            {
                this.uniformTireQualityGradeField = value;
            }
        }

        public LengthUnit overallDiameter
        {
            get
            {
                return this.overallDiameterField;
            }
            set
            {
                this.overallDiameterField = value;
            }
        }
    }

    public enum TiresTireTractionRating
    {

        /// <remarks/>
        B,

        /// <remarks/>
        A,

        /// <remarks/>
        AA,

        /// <remarks/>
        C,
    }

    public enum TiresTireTemperatureRating
    {

        /// <remarks/>
        C,

        /// <remarks/>
        B,

        /// <remarks/>
        A,
    }

    public partial class VehiclePartsAndAccessories
    {

        private List<fabricContentValue> fabricContentField;

        private bool isWeatherResistantField;

        private bool isWeatherResistantFieldSpecified;

        private string finishField;

        private LengthUnit chainLengthField;

        private List<string> fabricCareInstructionsField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private bool isReusableField;

        private bool isReusableFieldSpecified;

        private List<string> connectionsField;

        private List<string> characterField;

        private string powerTypeField;

        private LengthUnit tireDiameterField;

        private List<string> fillMaterialField;

        private VolumeUnit fluidOuncesField;

        private TemperatureUnit maximumTemperatureField;

        private VolumeUnit volumeCapacityField;

        private string fuelTypeField;

        private ElectricalMeasurementUnit voltsField;

        private PowerUnit wattsField;

        private bool isLightBulbIncludedField;

        private bool isLightBulbIncludedFieldSpecified;

        private string vehicleMakeField;

        private AngleUnit beamAngleField;

        private AngleUnit beamSpreadField;

        private string vehicleModelField;

        private string vehicleTypeField;

        private string vehicleYearField;

        private string automotiveWindowShadeFitField;

        private WeightUnit breakingStrengthField;

        private string candlePowerField;

        private ResolutionUnit displayResolutionField;

        private string formField;

        private string coldCrankAmpField;

        private string compatibleCarsField;

        private LengthUnit dropDistanceField;

        private string shapeField;

        private string fastenerHeadTypeField;

        private bool isLockableField;

        private bool isLockableFieldSpecified;

        private TimeUnit filterLifeField;

        private string flashPointField;

        private bool fullyIncinerableField;

        private bool fullyIncinerableFieldSpecified;

        private string hitchClassField;

        private bool inDashSystemField;

        private bool inDashSystemFieldSpecified;

        private List<string> interfaceTypeField;

        private string displayTechnologyField;

        private decimal maximumMotorSpeedField;

        private bool maximumMotorSpeedFieldSpecified;

        private string numberOfOutletsField;

        private string numberOfPhasesField;

        private LengthUnit receiverCompatibilityField;

        private TimeUnit reserveCapacityField;

        private bool saeDotCompliantField;

        private bool saeDotCompliantFieldSpecified;

        private LengthUnit shackleClearanceField;

        private LengthUnit shackleDiameterField;

        private LengthUnit shackleLengthField;

        private LengthUnit shankLengthField;

        private WeightUnit shearStrengthField;

        private bool hasShortCircuitProtectionField;

        private bool hasShortCircuitProtectionFieldSpecified;

        private LengthUnit thicknessField;

        private LengthUnit threadSizeField;

        private string towingMirrorSideField;

        private string lightBulbTypeField;

        private LengthUnit cableLengthField;

        private List<string> compatibleBrandsField;

        private List<string> compatibleDevicesField;

        private List<string> wirelessTechnologiesField;

        private ElectricalMeasurementUnit ampsField;

        private WeightUnit maximumLoadWeightField;

        private PowerUnit horsepowerField;

        private PressureUnit loadCapacityField;

        public VehiclePartsAndAccessories()
        {
            this.loadCapacityField = new PressureUnit();
            this.horsepowerField = new PowerUnit();
            this.maximumLoadWeightField = new WeightUnit();
            this.ampsField = new ElectricalMeasurementUnit();
            this.wirelessTechnologiesField = new List<string>();
            this.compatibleDevicesField = new List<string>();
            this.compatibleBrandsField = new List<string>();
            this.cableLengthField = new LengthUnit();
            this.threadSizeField = new LengthUnit();
            this.thicknessField = new LengthUnit();
            this.shearStrengthField = new WeightUnit();
            this.shankLengthField = new LengthUnit();
            this.shackleLengthField = new LengthUnit();
            this.shackleDiameterField = new LengthUnit();
            this.shackleClearanceField = new LengthUnit();
            this.reserveCapacityField = new TimeUnit();
            this.receiverCompatibilityField = new LengthUnit();
            this.interfaceTypeField = new List<string>();
            this.filterLifeField = new TimeUnit();
            this.dropDistanceField = new LengthUnit();
            this.displayResolutionField = new ResolutionUnit();
            this.breakingStrengthField = new WeightUnit();
            this.beamSpreadField = new AngleUnit();
            this.beamAngleField = new AngleUnit();
            this.wattsField = new PowerUnit();
            this.voltsField = new ElectricalMeasurementUnit();
            this.volumeCapacityField = new VolumeUnit();
            this.maximumTemperatureField = new TemperatureUnit();
            this.fluidOuncesField = new VolumeUnit();
            this.fillMaterialField = new List<string>();
            this.tireDiameterField = new LengthUnit();
            this.characterField = new List<string>();
            this.connectionsField = new List<string>();
            this.fabricCareInstructionsField = new List<string>();
            this.chainLengthField = new LengthUnit();
            this.fabricContentField = new List<fabricContentValue>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public bool isWeatherResistant
        {
            get
            {
                return this.isWeatherResistantField;
            }
            set
            {
                this.isWeatherResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWeatherResistantSpecified
        {
            get
            {
                return this.isWeatherResistantFieldSpecified;
            }
            set
            {
                this.isWeatherResistantFieldSpecified = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public LengthUnit chainLength
        {
            get
            {
                return this.chainLengthField;
            }
            set
            {
                this.chainLengthField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("fabricCareInstruction", IsNullable = false)]
        public List<string> fabricCareInstructions
        {
            get
            {
                return this.fabricCareInstructionsField;
            }
            set
            {
                this.fabricCareInstructionsField = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        public bool isReusable
        {
            get
            {
                return this.isReusableField;
            }
            set
            {
                this.isReusableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReusableSpecified
        {
            get
            {
                return this.isReusableFieldSpecified;
            }
            set
            {
                this.isReusableFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("connection", IsNullable = false)]
        public List<string> connections
        {
            get
            {
                return this.connectionsField;
            }
            set
            {
                this.connectionsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        public LengthUnit tireDiameter
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

        [System.Xml.Serialization.XmlArrayItemAttribute("fillMaterialValue", IsNullable = false)]
        public List<string> fillMaterial
        {
            get
            {
                return this.fillMaterialField;
            }
            set
            {
                this.fillMaterialField = value;
            }
        }

        public VolumeUnit fluidOunces
        {
            get
            {
                return this.fluidOuncesField;
            }
            set
            {
                this.fluidOuncesField = value;
            }
        }

        public TemperatureUnit maximumTemperature
        {
            get
            {
                return this.maximumTemperatureField;
            }
            set
            {
                this.maximumTemperatureField = value;
            }
        }

        public VolumeUnit volumeCapacity
        {
            get
            {
                return this.volumeCapacityField;
            }
            set
            {
                this.volumeCapacityField = value;
            }
        }

        public string fuelType
        {
            get
            {
                return this.fuelTypeField;
            }
            set
            {
                this.fuelTypeField = value;
            }
        }

        public ElectricalMeasurementUnit volts
        {
            get
            {
                return this.voltsField;
            }
            set
            {
                this.voltsField = value;
            }
        }

        public PowerUnit watts
        {
            get
            {
                return this.wattsField;
            }
            set
            {
                this.wattsField = value;
            }
        }

        public bool isLightBulbIncluded
        {
            get
            {
                return this.isLightBulbIncludedField;
            }
            set
            {
                this.isLightBulbIncludedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLightBulbIncludedSpecified
        {
            get
            {
                return this.isLightBulbIncludedFieldSpecified;
            }
            set
            {
                this.isLightBulbIncludedFieldSpecified = value;
            }
        }

        public string vehicleMake
        {
            get
            {
                return this.vehicleMakeField;
            }
            set
            {
                this.vehicleMakeField = value;
            }
        }

        public AngleUnit beamAngle
        {
            get
            {
                return this.beamAngleField;
            }
            set
            {
                this.beamAngleField = value;
            }
        }

        public AngleUnit beamSpread
        {
            get
            {
                return this.beamSpreadField;
            }
            set
            {
                this.beamSpreadField = value;
            }
        }

        public string vehicleModel
        {
            get
            {
                return this.vehicleModelField;
            }
            set
            {
                this.vehicleModelField = value;
            }
        }

        public string vehicleType
        {
            get
            {
                return this.vehicleTypeField;
            }
            set
            {
                this.vehicleTypeField = value;
            }
        }

        public string vehicleYear
        {
            get
            {
                return this.vehicleYearField;
            }
            set
            {
                this.vehicleYearField = value;
            }
        }

        public string automotiveWindowShadeFit
        {
            get
            {
                return this.automotiveWindowShadeFitField;
            }
            set
            {
                this.automotiveWindowShadeFitField = value;
            }
        }

        public WeightUnit breakingStrength
        {
            get
            {
                return this.breakingStrengthField;
            }
            set
            {
                this.breakingStrengthField = value;
            }
        }

        public string candlePower
        {
            get
            {
                return this.candlePowerField;
            }
            set
            {
                this.candlePowerField = value;
            }
        }

        public ResolutionUnit displayResolution
        {
            get
            {
                return this.displayResolutionField;
            }
            set
            {
                this.displayResolutionField = value;
            }
        }

        public string form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        public string coldCrankAmp
        {
            get
            {
                return this.coldCrankAmpField;
            }
            set
            {
                this.coldCrankAmpField = value;
            }
        }

        public string compatibleCars
        {
            get
            {
                return this.compatibleCarsField;
            }
            set
            {
                this.compatibleCarsField = value;
            }
        }

        public LengthUnit dropDistance
        {
            get
            {
                return this.dropDistanceField;
            }
            set
            {
                this.dropDistanceField = value;
            }
        }

        public string shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
            }
        }

        public string fastenerHeadType
        {
            get
            {
                return this.fastenerHeadTypeField;
            }
            set
            {
                this.fastenerHeadTypeField = value;
            }
        }

        public bool isLockable
        {
            get
            {
                return this.isLockableField;
            }
            set
            {
                this.isLockableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLockableSpecified
        {
            get
            {
                return this.isLockableFieldSpecified;
            }
            set
            {
                this.isLockableFieldSpecified = value;
            }
        }

        public TimeUnit filterLife
        {
            get
            {
                return this.filterLifeField;
            }
            set
            {
                this.filterLifeField = value;
            }
        }

        public string flashPoint
        {
            get
            {
                return this.flashPointField;
            }
            set
            {
                this.flashPointField = value;
            }
        }

        public bool fullyIncinerable
        {
            get
            {
                return this.fullyIncinerableField;
            }
            set
            {
                this.fullyIncinerableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fullyIncinerableSpecified
        {
            get
            {
                return this.fullyIncinerableFieldSpecified;
            }
            set
            {
                this.fullyIncinerableFieldSpecified = value;
            }
        }

        public string hitchClass
        {
            get
            {
                return this.hitchClassField;
            }
            set
            {
                this.hitchClassField = value;
            }
        }

        public bool inDashSystem
        {
            get
            {
                return this.inDashSystemField;
            }
            set
            {
                this.inDashSystemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inDashSystemSpecified
        {
            get
            {
                return this.inDashSystemFieldSpecified;
            }
            set
            {
                this.inDashSystemFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("interfaceTypeValue", IsNullable = false)]
        public List<string> interfaceType
        {
            get
            {
                return this.interfaceTypeField;
            }
            set
            {
                this.interfaceTypeField = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }

        public decimal maximumMotorSpeed
        {
            get
            {
                return this.maximumMotorSpeedField;
            }
            set
            {
                this.maximumMotorSpeedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumMotorSpeedSpecified
        {
            get
            {
                return this.maximumMotorSpeedFieldSpecified;
            }
            set
            {
                this.maximumMotorSpeedFieldSpecified = value;
            }
        }

        public string numberOfOutlets
        {
            get
            {
                return this.numberOfOutletsField;
            }
            set
            {
                this.numberOfOutletsField = value;
            }
        }

        public string numberOfPhases
        {
            get
            {
                return this.numberOfPhasesField;
            }
            set
            {
                this.numberOfPhasesField = value;
            }
        }

        public LengthUnit receiverCompatibility
        {
            get
            {
                return this.receiverCompatibilityField;
            }
            set
            {
                this.receiverCompatibilityField = value;
            }
        }

        public TimeUnit reserveCapacity
        {
            get
            {
                return this.reserveCapacityField;
            }
            set
            {
                this.reserveCapacityField = value;
            }
        }

        public bool saeDotCompliant
        {
            get
            {
                return this.saeDotCompliantField;
            }
            set
            {
                this.saeDotCompliantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool saeDotCompliantSpecified
        {
            get
            {
                return this.saeDotCompliantFieldSpecified;
            }
            set
            {
                this.saeDotCompliantFieldSpecified = value;
            }
        }

        public LengthUnit shackleClearance
        {
            get
            {
                return this.shackleClearanceField;
            }
            set
            {
                this.shackleClearanceField = value;
            }
        }

        public LengthUnit shackleDiameter
        {
            get
            {
                return this.shackleDiameterField;
            }
            set
            {
                this.shackleDiameterField = value;
            }
        }

        public LengthUnit shackleLength
        {
            get
            {
                return this.shackleLengthField;
            }
            set
            {
                this.shackleLengthField = value;
            }
        }

        public LengthUnit shankLength
        {
            get
            {
                return this.shankLengthField;
            }
            set
            {
                this.shankLengthField = value;
            }
        }

        public WeightUnit shearStrength
        {
            get
            {
                return this.shearStrengthField;
            }
            set
            {
                this.shearStrengthField = value;
            }
        }

        public bool hasShortCircuitProtection
        {
            get
            {
                return this.hasShortCircuitProtectionField;
            }
            set
            {
                this.hasShortCircuitProtectionField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasShortCircuitProtectionSpecified
        {
            get
            {
                return this.hasShortCircuitProtectionFieldSpecified;
            }
            set
            {
                this.hasShortCircuitProtectionFieldSpecified = value;
            }
        }

        public LengthUnit thickness
        {
            get
            {
                return this.thicknessField;
            }
            set
            {
                this.thicknessField = value;
            }
        }

        public LengthUnit threadSize
        {
            get
            {
                return this.threadSizeField;
            }
            set
            {
                this.threadSizeField = value;
            }
        }

        public string towingMirrorSide
        {
            get
            {
                return this.towingMirrorSideField;
            }
            set
            {
                this.towingMirrorSideField = value;
            }
        }

        public string lightBulbType
        {
            get
            {
                return this.lightBulbTypeField;
            }
            set
            {
                this.lightBulbTypeField = value;
            }
        }

        public LengthUnit cableLength
        {
            get
            {
                return this.cableLengthField;
            }
            set
            {
                this.cableLengthField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleBrand", IsNullable = false)]
        public List<string> compatibleBrands
        {
            get
            {
                return this.compatibleBrandsField;
            }
            set
            {
                this.compatibleBrandsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("compatibleDevice", IsNullable = false)]
        public List<string> compatibleDevices
        {
            get
            {
                return this.compatibleDevicesField;
            }
            set
            {
                this.compatibleDevicesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("wirelessTechnology", IsNullable = false)]
        public List<string> wirelessTechnologies
        {
            get
            {
                return this.wirelessTechnologiesField;
            }
            set
            {
                this.wirelessTechnologiesField = value;
            }
        }

        public ElectricalMeasurementUnit amps
        {
            get
            {
                return this.ampsField;
            }
            set
            {
                this.ampsField = value;
            }
        }

        public WeightUnit maximumLoadWeight
        {
            get
            {
                return this.maximumLoadWeightField;
            }
            set
            {
                this.maximumLoadWeightField = value;
            }
        }

        public PowerUnit horsepower
        {
            get
            {
                return this.horsepowerField;
            }
            set
            {
                this.horsepowerField = value;
            }
        }

        public PressureUnit loadCapacity
        {
            get
            {
                return this.loadCapacityField;
            }
            set
            {
                this.loadCapacityField = value;
            }
        }
    }

    public partial class Watercraft
    {

        private string seatingCapacityField;

        private string watercraftCategoryField;

        private string submodelField;

        private string engineLocationField;

        private string propulsionSystemField;

        private string engineModelField;

        private string compressionRatioField;

        private string boreStrokeField;

        private string inductionSystemField;

        private string coolingSystemField;

        private string maximumEnginePowerField;

        private WeightUnit thrustField;

        private string impellerPropellerField;

        private string topSpeedField;

        private string fuelRequirementField;

        private string fuelSystemField;

        private VolumeUnit fuelCapacityField;

        private FuelEconomyUnit averageFuelConsumptionField;

        private LengthUnit hullLengthField;

        private LengthUnit beamField;

        private LengthUnit airDraftField;

        private LengthUnit draftField;

        private VolumeUnit waterCapacityField;

        private WeightUnit dryWeightField;

        private string vehicleMakeField;

        private string vehicleModelField;

        private string vehicleTypeField;

        private string vehicleYearField;

        private VolumeUnit engineDisplacementField;

        public Watercraft()
        {
            this.engineDisplacementField = new VolumeUnit();
            this.dryWeightField = new WeightUnit();
            this.waterCapacityField = new VolumeUnit();
            this.draftField = new LengthUnit();
            this.airDraftField = new LengthUnit();
            this.beamField = new LengthUnit();
            this.hullLengthField = new LengthUnit();
            this.averageFuelConsumptionField = new FuelEconomyUnit();
            this.fuelCapacityField = new VolumeUnit();
            this.thrustField = new WeightUnit();
        }

        public string seatingCapacity
        {
            get
            {
                return this.seatingCapacityField;
            }
            set
            {
                this.seatingCapacityField = value;
            }
        }

        public string watercraftCategory
        {
            get
            {
                return this.watercraftCategoryField;
            }
            set
            {
                this.watercraftCategoryField = value;
            }
        }

        public string submodel
        {
            get
            {
                return this.submodelField;
            }
            set
            {
                this.submodelField = value;
            }
        }

        public string engineLocation
        {
            get
            {
                return this.engineLocationField;
            }
            set
            {
                this.engineLocationField = value;
            }
        }

        public string propulsionSystem
        {
            get
            {
                return this.propulsionSystemField;
            }
            set
            {
                this.propulsionSystemField = value;
            }
        }

        public string engineModel
        {
            get
            {
                return this.engineModelField;
            }
            set
            {
                this.engineModelField = value;
            }
        }

        public string compressionRatio
        {
            get
            {
                return this.compressionRatioField;
            }
            set
            {
                this.compressionRatioField = value;
            }
        }

        public string boreStroke
        {
            get
            {
                return this.boreStrokeField;
            }
            set
            {
                this.boreStrokeField = value;
            }
        }

        public string inductionSystem
        {
            get
            {
                return this.inductionSystemField;
            }
            set
            {
                this.inductionSystemField = value;
            }
        }

        public string coolingSystem
        {
            get
            {
                return this.coolingSystemField;
            }
            set
            {
                this.coolingSystemField = value;
            }
        }

        public string maximumEnginePower
        {
            get
            {
                return this.maximumEnginePowerField;
            }
            set
            {
                this.maximumEnginePowerField = value;
            }
        }

        public WeightUnit thrust
        {
            get
            {
                return this.thrustField;
            }
            set
            {
                this.thrustField = value;
            }
        }

        public string impellerPropeller
        {
            get
            {
                return this.impellerPropellerField;
            }
            set
            {
                this.impellerPropellerField = value;
            }
        }

        public string topSpeed
        {
            get
            {
                return this.topSpeedField;
            }
            set
            {
                this.topSpeedField = value;
            }
        }

        public string fuelRequirement
        {
            get
            {
                return this.fuelRequirementField;
            }
            set
            {
                this.fuelRequirementField = value;
            }
        }

        public string fuelSystem
        {
            get
            {
                return this.fuelSystemField;
            }
            set
            {
                this.fuelSystemField = value;
            }
        }

        public VolumeUnit fuelCapacity
        {
            get
            {
                return this.fuelCapacityField;
            }
            set
            {
                this.fuelCapacityField = value;
            }
        }

        public FuelEconomyUnit averageFuelConsumption
        {
            get
            {
                return this.averageFuelConsumptionField;
            }
            set
            {
                this.averageFuelConsumptionField = value;
            }
        }

        public LengthUnit hullLength
        {
            get
            {
                return this.hullLengthField;
            }
            set
            {
                this.hullLengthField = value;
            }
        }

        public LengthUnit beam
        {
            get
            {
                return this.beamField;
            }
            set
            {
                this.beamField = value;
            }
        }

        public LengthUnit airDraft
        {
            get
            {
                return this.airDraftField;
            }
            set
            {
                this.airDraftField = value;
            }
        }

        public LengthUnit draft
        {
            get
            {
                return this.draftField;
            }
            set
            {
                this.draftField = value;
            }
        }

        public VolumeUnit waterCapacity
        {
            get
            {
                return this.waterCapacityField;
            }
            set
            {
                this.waterCapacityField = value;
            }
        }

        public WeightUnit dryWeight
        {
            get
            {
                return this.dryWeightField;
            }
            set
            {
                this.dryWeightField = value;
            }
        }

        public string vehicleMake
        {
            get
            {
                return this.vehicleMakeField;
            }
            set
            {
                this.vehicleMakeField = value;
            }
        }

        public string vehicleModel
        {
            get
            {
                return this.vehicleModelField;
            }
            set
            {
                this.vehicleModelField = value;
            }
        }

        public string vehicleType
        {
            get
            {
                return this.vehicleTypeField;
            }
            set
            {
                this.vehicleTypeField = value;
            }
        }

        public string vehicleYear
        {
            get
            {
                return this.vehicleYearField;
            }
            set
            {
                this.vehicleYearField = value;
            }
        }

        public VolumeUnit engineDisplacement
        {
            get
            {
                return this.engineDisplacementField;
            }
            set
            {
                this.engineDisplacementField = value;
            }
        }
    }

    public partial class WheelsAndWheelComponents
    {

        private string finishField;

        private LengthUnit diameterField;

        private decimal vehicleRimSizeField;

        private bool vehicleRimSizeFieldSpecified;

        private decimal compatibleTireSizeField;

        private bool compatibleTireSizeFieldSpecified;

        private string numberOfSpokesField;

        private bool hasWearSensorField;

        private bool hasWearSensorFieldSpecified;

        public WheelsAndWheelComponents()
        {
            this.diameterField = new LengthUnit();
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public LengthUnit diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
            }
        }

        public decimal vehicleRimSize
        {
            get
            {
                return this.vehicleRimSizeField;
            }
            set
            {
                this.vehicleRimSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vehicleRimSizeSpecified
        {
            get
            {
                return this.vehicleRimSizeFieldSpecified;
            }
            set
            {
                this.vehicleRimSizeFieldSpecified = value;
            }
        }

        public decimal compatibleTireSize
        {
            get
            {
                return this.compatibleTireSizeField;
            }
            set
            {
                this.compatibleTireSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compatibleTireSizeSpecified
        {
            get
            {
                return this.compatibleTireSizeFieldSpecified;
            }
            set
            {
                this.compatibleTireSizeFieldSpecified = value;
            }
        }

        public string numberOfSpokes
        {
            get
            {
                return this.numberOfSpokesField;
            }
            set
            {
                this.numberOfSpokesField = value;
            }
        }

        public bool hasWearSensor
        {
            get
            {
                return this.hasWearSensorField;
            }
            set
            {
                this.hasWearSensorField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasWearSensorSpecified
        {
            get
            {
                return this.hasWearSensorFieldSpecified;
            }
            set
            {
                this.hasWearSensorFieldSpecified = value;
            }
        }
    }

    public partial class Watches
    {

        private List<string> watchBandMaterialField;

        private string metalField;

        private string watchCaseShapeField;

        private string platingField;

        private List<swatchImage> swatchImagesField;

        private List<string> watchStyleField;

        private List<string> gemstoneField;

        private List<string> variantAttributeNamesField;

        private string variantGroupIdField;

        private string gemstoneShapeField;

        private bool isPrimaryVariantField;

        private bool isPrimaryVariantFieldSpecified;

        private WeightUnit caratsField;

        private List<fabricContentValue> fabricContentField;

        private bool isWeatherResistantField;

        private bool isWeatherResistantFieldSpecified;

        private string finishField;

        private string brandField;

        private string manufacturerField;

        private List<string> themeField;

        private string modelNumberField;

        private string manufacturerPartNumberField;

        private WatchesGender genderField;

        private List<string> colorField;

        private List<string> ageGroupField;

        private bool batteriesRequiredField;

        private bool batteriesRequiredFieldSpecified;

        private string batterySizeField;

        private List<string> materialField;

        private List<string> patternField;

        private List<string> characterField;

        private string powerTypeField;

        private List<string> occasionField;

        private bool isPersonalizableField;

        private bool isPersonalizableFieldSpecified;

        private bool isWaterproofField;

        private bool isWaterproofFieldSpecified;

        private string displayTechnologyField;

        public Watches()
        {
            this.occasionField = new List<string>();
            this.characterField = new List<string>();
            this.patternField = new List<string>();
            this.materialField = new List<string>();
            this.ageGroupField = new List<string>();
            this.colorField = new List<string>();
            this.themeField = new List<string>();
            this.fabricContentField = new List<fabricContentValue>();
            this.caratsField = new WeightUnit();
            this.variantAttributeNamesField = new List<string>();
            this.gemstoneField = new List<string>();
            this.watchStyleField = new List<string>();
            this.swatchImagesField = new List<swatchImage>();
            this.watchBandMaterialField = new List<string>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("watchBandMaterialValue", IsNullable = false)]
        public List<string> watchBandMaterial
        {
            get
            {
                return this.watchBandMaterialField;
            }
            set
            {
                this.watchBandMaterialField = value;
            }
        }

        public string metal
        {
            get
            {
                return this.metalField;
            }
            set
            {
                this.metalField = value;
            }
        }

        public string watchCaseShape
        {
            get
            {
                return this.watchCaseShapeField;
            }
            set
            {
                this.watchCaseShapeField = value;
            }
        }

        public string plating
        {
            get
            {
                return this.platingField;
            }
            set
            {
                this.platingField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<swatchImage> swatchImages
        {
            get
            {
                return this.swatchImagesField;
            }
            set
            {
                this.swatchImagesField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("watchStyleValue", IsNullable = false)]
        public List<string> watchStyle
        {
            get
            {
                return this.watchStyleField;
            }
            set
            {
                this.watchStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("gemstoneValue", IsNullable = false)]
        public List<string> gemstone
        {
            get
            {
                return this.gemstoneField;
            }
            set
            {
                this.gemstoneField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("variantAttributeName", IsNullable = false)]
        public List<string> variantAttributeNames
        {
            get
            {
                return this.variantAttributeNamesField;
            }
            set
            {
                this.variantAttributeNamesField = value;
            }
        }

        public string variantGroupId
        {
            get
            {
                return this.variantGroupIdField;
            }
            set
            {
                this.variantGroupIdField = value;
            }
        }

        public string gemstoneShape
        {
            get
            {
                return this.gemstoneShapeField;
            }
            set
            {
                this.gemstoneShapeField = value;
            }
        }

        public bool isPrimaryVariant
        {
            get
            {
                return this.isPrimaryVariantField;
            }
            set
            {
                this.isPrimaryVariantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrimaryVariantSpecified
        {
            get
            {
                return this.isPrimaryVariantFieldSpecified;
            }
            set
            {
                this.isPrimaryVariantFieldSpecified = value;
            }
        }

        public WeightUnit carats
        {
            get
            {
                return this.caratsField;
            }
            set
            {
                this.caratsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public List<fabricContentValue> fabricContent
        {
            get
            {
                return this.fabricContentField;
            }
            set
            {
                this.fabricContentField = value;
            }
        }

        public bool isWeatherResistant
        {
            get
            {
                return this.isWeatherResistantField;
            }
            set
            {
                this.isWeatherResistantField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWeatherResistantSpecified
        {
            get
            {
                return this.isWeatherResistantFieldSpecified;
            }
            set
            {
                this.isWeatherResistantFieldSpecified = value;
            }
        }

        public string finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }

        public string brand
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

        public string manufacturer
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

        [System.Xml.Serialization.XmlArrayItemAttribute("themeValue", IsNullable = false)]
        public List<string> theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        public string modelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        public string manufacturerPartNumber
        {
            get
            {
                return this.manufacturerPartNumberField;
            }
            set
            {
                this.manufacturerPartNumberField = value;
            }
        }

        public WatchesGender gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("colorValue", IsNullable = false)]
        public List<string> color
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

        [System.Xml.Serialization.XmlArrayItemAttribute("ageGroupValue", IsNullable = false)]
        public List<string> ageGroup
        {
            get
            {
                return this.ageGroupField;
            }
            set
            {
                this.ageGroupField = value;
            }
        }

        public bool batteriesRequired
        {
            get
            {
                return this.batteriesRequiredField;
            }
            set
            {
                this.batteriesRequiredField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool batteriesRequiredSpecified
        {
            get
            {
                return this.batteriesRequiredFieldSpecified;
            }
            set
            {
                this.batteriesRequiredFieldSpecified = value;
            }
        }

        public string batterySize
        {
            get
            {
                return this.batterySizeField;
            }
            set
            {
                this.batterySizeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("materialValue", IsNullable = false)]
        public List<string> material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("patternValue", IsNullable = false)]
        public List<string> pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("characterValue", IsNullable = false)]
        public List<string> character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        public string powerType
        {
            get
            {
                return this.powerTypeField;
            }
            set
            {
                this.powerTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("occasionValue", IsNullable = false)]
        public List<string> occasion
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

        public bool isPersonalizable
        {
            get
            {
                return this.isPersonalizableField;
            }
            set
            {
                this.isPersonalizableField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonalizableSpecified
        {
            get
            {
                return this.isPersonalizableFieldSpecified;
            }
            set
            {
                this.isPersonalizableFieldSpecified = value;
            }
        }

        public bool isWaterproof
        {
            get
            {
                return this.isWaterproofField;
            }
            set
            {
                this.isWaterproofField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWaterproofSpecified
        {
            get
            {
                return this.isWaterproofFieldSpecified;
            }
            set
            {
                this.isWaterproofFieldSpecified = value;
            }
        }

        public string displayTechnology
        {
            get
            {
                return this.displayTechnologyField;
            }
            set
            {
                this.displayTechnologyField = value;
            }
        }
    }

    public enum WatchesGender
    {

        /// <remarks/>
        Unisex,

        /// <remarks/>
        Women,

        /// <remarks/>
        Men,

        /// <remarks/>
        Boys,

        /// <remarks/>
        Girls,
    }

    public partial class Money
    {

        private CurrencyCode currencyField;

        private decimal amountField;

        public CurrencyCode currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    public enum CurrencyCode
    {

        /// <remarks/>
        AED,

        /// <remarks/>
        AFN,

        /// <remarks/>
        ALL,

        /// <remarks/>
        AMD,

        /// <remarks/>
        ANG,

        /// <remarks/>
        AOA,

        /// <remarks/>
        ARS,

        /// <remarks/>
        AUD,

        /// <remarks/>
        AWG,

        /// <remarks/>
        AZN,

        /// <remarks/>
        BAM,

        /// <remarks/>
        BBD,

        /// <remarks/>
        BDT,

        /// <remarks/>
        BGN,

        /// <remarks/>
        BHD,

        /// <remarks/>
        BIF,

        /// <remarks/>
        BMD,

        /// <remarks/>
        BND,

        /// <remarks/>
        BOB,

        /// <remarks/>
        BRL,

        /// <remarks/>
        BSD,

        /// <remarks/>
        BTN,

        /// <remarks/>
        BWP,

        /// <remarks/>
        BYR,

        /// <remarks/>
        BZD,

        /// <remarks/>
        CAD,

        /// <remarks/>
        CDF,

        /// <remarks/>
        CHF,

        /// <remarks/>
        CLP,

        /// <remarks/>
        CNY,

        /// <remarks/>
        COP,

        /// <remarks/>
        CRC,

        /// <remarks/>
        CUP,

        /// <remarks/>
        CVE,

        /// <remarks/>
        CZK,

        /// <remarks/>
        DJF,

        /// <remarks/>
        DKK,

        /// <remarks/>
        DOP,

        /// <remarks/>
        DZD,

        /// <remarks/>
        EGP,

        /// <remarks/>
        ERN,

        /// <remarks/>
        ETB,

        /// <remarks/>
        EUR,

        /// <remarks/>
        FJD,

        /// <remarks/>
        FKP,

        /// <remarks/>
        GBP,

        /// <remarks/>
        GEL,

        /// <remarks/>
        GHS,

        /// <remarks/>
        GIP,

        /// <remarks/>
        GMD,

        /// <remarks/>
        GNF,

        /// <remarks/>
        GTQ,

        /// <remarks/>
        GYD,

        /// <remarks/>
        HKD,

        /// <remarks/>
        HNL,

        /// <remarks/>
        HRK,

        /// <remarks/>
        HTG,

        /// <remarks/>
        HUF,

        /// <remarks/>
        IDR,

        /// <remarks/>
        ILS,

        /// <remarks/>
        INR,

        /// <remarks/>
        IQD,

        /// <remarks/>
        IRR,

        /// <remarks/>
        ISK,

        /// <remarks/>
        JMD,

        /// <remarks/>
        JOD,

        /// <remarks/>
        JPY,

        /// <remarks/>
        KES,

        /// <remarks/>
        KGS,

        /// <remarks/>
        KHR,

        /// <remarks/>
        KMF,

        /// <remarks/>
        KPW,

        /// <remarks/>
        KRW,

        /// <remarks/>
        KWD,

        /// <remarks/>
        KYD,

        /// <remarks/>
        KZT,

        /// <remarks/>
        LAK,

        /// <remarks/>
        LBP,

        /// <remarks/>
        LKR,

        /// <remarks/>
        LRD,

        /// <remarks/>
        LSL,

        /// <remarks/>
        LTL,

        /// <remarks/>
        LVL,

        /// <remarks/>
        LYD,

        /// <remarks/>
        MAD,

        /// <remarks/>
        MDL,

        /// <remarks/>
        MGA,

        /// <remarks/>
        MKD,

        /// <remarks/>
        MMK,

        /// <remarks/>
        MNT,

        /// <remarks/>
        MOP,

        /// <remarks/>
        MRO,

        /// <remarks/>
        MUR,

        /// <remarks/>
        MVR,

        /// <remarks/>
        MWK,

        /// <remarks/>
        MXN,

        /// <remarks/>
        MYR,

        /// <remarks/>
        MZN,

        /// <remarks/>
        NAD,

        /// <remarks/>
        NGN,

        /// <remarks/>
        NIO,

        /// <remarks/>
        NOK,

        /// <remarks/>
        NPR,

        /// <remarks/>
        NZD,

        /// <remarks/>
        OMR,

        /// <remarks/>
        PAB,

        /// <remarks/>
        PEN,

        /// <remarks/>
        PGK,

        /// <remarks/>
        PHP,

        /// <remarks/>
        PKR,

        /// <remarks/>
        PLN,

        /// <remarks/>
        PYG,

        /// <remarks/>
        QAR,

        /// <remarks/>
        RON,

        /// <remarks/>
        RSD,

        /// <remarks/>
        RUB,

        /// <remarks/>
        RUR,

        /// <remarks/>
        RWF,

        /// <remarks/>
        SAR,

        /// <remarks/>
        SBD,

        /// <remarks/>
        SCR,

        /// <remarks/>
        SDG,

        /// <remarks/>
        SEK,

        /// <remarks/>
        SGD,

        /// <remarks/>
        SHP,

        /// <remarks/>
        SLL,

        /// <remarks/>
        SOS,

        /// <remarks/>
        SRD,

        /// <remarks/>
        STD,

        /// <remarks/>
        SYP,

        /// <remarks/>
        SZL,

        /// <remarks/>
        THB,

        /// <remarks/>
        TJS,

        /// <remarks/>
        TMT,

        /// <remarks/>
        TND,

        /// <remarks/>
        TOP,

        /// <remarks/>
        TRY,

        /// <remarks/>
        TTD,

        /// <remarks/>
        TWD,

        /// <remarks/>
        TZS,

        /// <remarks/>
        UAH,

        /// <remarks/>
        UGX,

        /// <remarks/>
        USD,

        /// <remarks/>
        UYU,

        /// <remarks/>
        UZS,

        /// <remarks/>
        VEF,

        /// <remarks/>
        VND,

        /// <remarks/>
        VUV,

        /// <remarks/>
        WST,

        /// <remarks/>
        XAF,

        /// <remarks/>
        XAG,

        /// <remarks/>
        XAU,

        /// <remarks/>
        XBA,

        /// <remarks/>
        XBB,

        /// <remarks/>
        XBC,

        /// <remarks/>
        XBD,

        /// <remarks/>
        XCD,

        /// <remarks/>
        XDR,

        /// <remarks/>
        XFU,

        /// <remarks/>
        XOF,

        /// <remarks/>
        XPD,

        /// <remarks/>
        XPF,

        /// <remarks/>
        XPT,

        /// <remarks/>
        XTS,

        /// <remarks/>
        XXX,

        /// <remarks/>
        YER,

        /// <remarks/>
        ZAR,

        /// <remarks/>
        ZMK,

        /// <remarks/>
        ZWL,
    }

    public partial class WeightMeasure
    {

        private double valueField;

        private UnitOfWeight unitField;

        public double value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        public UnitOfWeight unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
    }

    public enum UnitOfWeight
    {

        /// <remarks/>
        KG,

        /// <remarks/>
        G,

        /// <remarks/>
        MG,

        /// <remarks/>
        LB,

        /// <remarks/>
        OZ,
    }

    public partial class MPItemShippingOverride
    {

        private bool isShippingAllowedField;

        private bool isShippingAllowedFieldSpecified;

        private ShipRegion shipRegionField;

        private ShipMethod shipMethodField;

        private double shipPriceField;

        private bool shipPriceFieldSpecified;

        public bool isShippingAllowed
        {
            get
            {
                return this.isShippingAllowedField;
            }
            set
            {
                this.isShippingAllowedField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isShippingAllowedSpecified
        {
            get
            {
                return this.isShippingAllowedFieldSpecified;
            }
            set
            {
                this.isShippingAllowedFieldSpecified = value;
            }
        }

        public ShipRegion shipRegion
        {
            get
            {
                return this.shipRegionField;
            }
            set
            {
                this.shipRegionField = value;
            }
        }

        public ShipMethod shipMethod
        {
            get
            {
                return this.shipMethodField;
            }
            set
            {
                this.shipMethodField = value;
            }
        }

        public double shipPrice
        {
            get
            {
                return this.shipPriceField;
            }
            set
            {
                this.shipPriceField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipPriceSpecified
        {
            get
            {
                return this.shipPriceFieldSpecified;
            }
            set
            {
                this.shipPriceFieldSpecified = value;
            }
        }
    }

    public enum ShipRegion
    {

        /// <remarks/>
        STREET_48_STATES,

        /// <remarks/>
        PO_BOX_48_STATES,

        /// <remarks/>
        STREET_AK_AND_HI,

        /// <remarks/>
        PO_BOX_AK_AND_HI,

        /// <remarks/>
        PO_BOX_US_PROTECTORATES,

        /// <remarks/>
        STREET_US_PROTECTORATES,

        /// <remarks/>
        APO_FPO,
    }

    public enum ShipMethod
    {

        /// <remarks/>
        STANDARD,

        /// <remarks/>
        EXPEDITED,

        /// <remarks/>
        FREIGHT,

        /// <remarks/>
        ONE_DAY,

        /// <remarks/>
        FREIGHT_WITH_WHITE_GLOVE,
    }

    public partial class MPItemUpdate
    {

        private Mart martField;

        private bool martFieldSpecified;

        private string skuField;

        private string wpidField;

        private MPProduct productField;

        private System.DateTime launchDateField;

        private bool launchDateFieldSpecified;

        private System.DateTime discontinueDateField;

        private bool discontinueDateFieldSpecified;

        private Money priceField;

        private Money minAdvertisedPriceField;

        private bool isMustShipAloneField;

        private WeightMeasure shippingWeightField;

        private List<MPItemShippingOverride> shippingOverridesField;

        private MPItemUpdateProcessMode processModeField;

        public MPItemUpdate()
        {
            this.shippingOverridesField = new List<MPItemShippingOverride>();
            this.shippingWeightField = new WeightMeasure();
            this.minAdvertisedPriceField = new Money();
            this.priceField = new Money();
            this.productField = new MPProduct();
            this.isMustShipAloneField = false;
            this.processModeField = MPItemUpdateProcessMode.REPLACE;
        }

        public Mart mart
        {
            get
            {
                return this.martField;
            }
            set
            {
                this.martField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool martSpecified
        {
            get
            {
                return this.martFieldSpecified;
            }
            set
            {
                this.martFieldSpecified = value;
            }
        }

        public string sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        public string wpid
        {
            get
            {
                return this.wpidField;
            }
            set
            {
                this.wpidField = value;
            }
        }

        public MPProduct Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        public System.DateTime launchDate
        {
            get
            {
                return this.launchDateField;
            }
            set
            {
                this.launchDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool launchDateSpecified
        {
            get
            {
                return this.launchDateFieldSpecified;
            }
            set
            {
                this.launchDateFieldSpecified = value;
            }
        }

        public System.DateTime discontinueDate
        {
            get
            {
                return this.discontinueDateField;
            }
            set
            {
                this.discontinueDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discontinueDateSpecified
        {
            get
            {
                return this.discontinueDateFieldSpecified;
            }
            set
            {
                this.discontinueDateFieldSpecified = value;
            }
        }

        public Money price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        public Money minAdvertisedPrice
        {
            get
            {
                return this.minAdvertisedPriceField;
            }
            set
            {
                this.minAdvertisedPriceField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isMustShipAlone
        {
            get
            {
                return this.isMustShipAloneField;
            }
            set
            {
                this.isMustShipAloneField = value;
            }
        }

        public WeightMeasure shippingWeight
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

        [System.Xml.Serialization.XmlArrayItemAttribute("shippingOverride", IsNullable = false)]
        public List<MPItemShippingOverride> shippingOverrides
        {
            get
            {
                return this.shippingOverridesField;
            }
            set
            {
                this.shippingOverridesField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(MPItemUpdateProcessMode.REPLACE)]
        public MPItemUpdateProcessMode processMode
        {
            get
            {
                return this.processModeField;
            }
            set
            {
                this.processModeField = value;
            }
        }
    }

    public enum MPItemUpdateProcessMode
    {

        /// <remarks/>
        REPLACE,
    }

    public partial class ProductEnvelope
    {

        private Mart martField;

        private bool martFieldSpecified;

        private string skuField;

        private string wpidField;

        private MPProduct productField;

        public ProductEnvelope()
        {
            this.productField = new MPProduct();
        }

        public Mart mart
        {
            get
            {
                return this.martField;
            }
            set
            {
                this.martField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool martSpecified
        {
            get
            {
                return this.martFieldSpecified;
            }
            set
            {
                this.martFieldSpecified = value;
            }
        }

        public string sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        public string wpid
        {
            get
            {
                return this.wpidField;
            }
            set
            {
                this.wpidField = value;
            }
        }

        public MPProduct Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }
    }

    public partial class OfferEnvelope
    {

        private Mart martField;

        private bool martFieldSpecified;

        private string skuField;

        private string wpidField;

        private System.DateTime launchDateField;

        private bool launchDateFieldSpecified;

        private System.DateTime discontinueDateField;

        private bool discontinueDateFieldSpecified;

        private Money priceField;

        private Money minAdvertisedPriceField;

        private bool isMustShipAloneField;

        private WeightMeasure shippingWeightField;

        private List<MPItemShippingOverride> shippingOverridesField;

        public OfferEnvelope()
        {
            this.shippingOverridesField = new List<MPItemShippingOverride>();
            this.shippingWeightField = new WeightMeasure();
            this.minAdvertisedPriceField = new Money();
            this.priceField = new Money();
            this.isMustShipAloneField = false;
        }

        public Mart mart
        {
            get
            {
                return this.martField;
            }
            set
            {
                this.martField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool martSpecified
        {
            get
            {
                return this.martFieldSpecified;
            }
            set
            {
                this.martFieldSpecified = value;
            }
        }

        public string sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        public string wpid
        {
            get
            {
                return this.wpidField;
            }
            set
            {
                this.wpidField = value;
            }
        }

        public System.DateTime launchDate
        {
            get
            {
                return this.launchDateField;
            }
            set
            {
                this.launchDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool launchDateSpecified
        {
            get
            {
                return this.launchDateFieldSpecified;
            }
            set
            {
                this.launchDateFieldSpecified = value;
            }
        }

        public System.DateTime discontinueDate
        {
            get
            {
                return this.discontinueDateField;
            }
            set
            {
                this.discontinueDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discontinueDateSpecified
        {
            get
            {
                return this.discontinueDateFieldSpecified;
            }
            set
            {
                this.discontinueDateFieldSpecified = value;
            }
        }

        public Money price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        public Money minAdvertisedPrice
        {
            get
            {
                return this.minAdvertisedPriceField;
            }
            set
            {
                this.minAdvertisedPriceField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool isMustShipAlone
        {
            get
            {
                return this.isMustShipAloneField;
            }
            set
            {
                this.isMustShipAloneField = value;
            }
        }

        public WeightMeasure shippingWeight
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

        [System.Xml.Serialization.XmlArrayItemAttribute("shippingOverride", IsNullable = false)]
        public List<MPItemShippingOverride> shippingOverrides
        {
            get
            {
                return this.shippingOverridesField;
            }
            set
            {
                this.shippingOverridesField = value;
            }
        }
    }
    [XmlRoot("MPItemFeed", Namespace = "http://walmart.com/")]

    public partial class MPItemFeed
    {

        private MPItemFeedHeader mPItemFeedHeaderField;

        private List<MPItem> itemsField;

        public MPItemFeed()
        {

        }

        public MPItemFeedHeader MPItemFeedHeader
        {
            get
            {
                return this.mPItemFeedHeaderField;
            }
            set
            {
                this.mPItemFeedHeaderField = value;
            }
        }

        [XmlArrayItem("MPItem")]
        public List<MPItem> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}

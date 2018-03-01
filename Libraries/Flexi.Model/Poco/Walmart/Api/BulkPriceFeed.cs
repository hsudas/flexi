

namespace Flexi.Model.Poco.Walmart.Api
{
    using System.Collections.Generic;
    using System.Xml.Serialization;


    public partial class feedHeaderType
    {

        private feedHeaderTypeVersion versionField;

        private System.DateTime feedDateField;

        private bool feedDateFieldSpecified;

        public feedHeaderTypeVersion version
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

    public enum feedHeaderTypeVersion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.5.1")]
        Item151,
        [System.Xml.Serialization.XmlEnumAttribute("1.5")]
        Item15
    }

    public partial class itemPriceType
    {

        private itemIdentifierType itemIdentifierField;

        private List<pricingType> pricingListField;

        public itemPriceType()
        {
            this.pricingListField = new List<pricingType>();
            this.itemIdentifierField = new itemIdentifierType();
        }

        public itemIdentifierType itemIdentifier
        {
            get
            {
                return this.itemIdentifierField;
            }
            set
            {
                this.itemIdentifierField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("pricing", IsNullable = false)]
        public List<pricingType> pricingList
        {
            get
            {
                return this.pricingListField;
            }
            set
            {
                this.pricingListField = value;
            }
        }
    }

    public partial class itemIdentifierType
    {

        private string itemField;

        private ItemChoiceType itemElementNameField;

        //  [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [XmlElement("sku")]
        public string Item
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    public enum ItemChoiceType
    {

        /// <remarks/>
        offerId,

        /// <remarks/>
        sku,
    }

    public partial class pricingType
    {

        private price currentPriceField;

        private priceType currentPriceTypeField;

        private bool currentPriceTypeFieldSpecified;

        private price comparisonPriceField;

        private priceDisplayCodes priceDisplayCodesField;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expirationDateField;

        private bool expirationDateFieldSpecified;

        private string promoIdField;

        private processModeType processModeField;

        private bool processModeFieldSpecified;

        public pricingType()
        {

        }

        public price currentPrice
        {
            get
            {
                return this.currentPriceField;
            }
            set
            {
                this.currentPriceField = value;
            }
        }

        public priceType currentPriceType
        {
            get
            {
                return this.currentPriceTypeField;
            }
            set
            {
                this.currentPriceTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentPriceTypeSpecified
        {
            get
            {
                return this.currentPriceTypeFieldSpecified;
            }
            set
            {
                this.currentPriceTypeFieldSpecified = value;
            }
        }

        public price comparisonPrice
        {
            get
            {
                return this.comparisonPriceField;
            }
            set
            {
                this.comparisonPriceField = value;
            }
        }

        public priceDisplayCodes priceDisplayCodes
        {
            get
            {
                return this.priceDisplayCodesField;
            }
            set
            {
                this.priceDisplayCodesField = value;
            }
        }

        public System.DateTime effectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveDateSpecified
        {
            get
            {
                return this.effectiveDateFieldSpecified;
            }
            set
            {
                this.effectiveDateFieldSpecified = value;
            }
        }

        public System.DateTime expirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateSpecified
        {
            get
            {
                return this.expirationDateFieldSpecified;
            }
            set
            {
                this.expirationDateFieldSpecified = value;
            }
        }

        public string promoId
        {
            get
            {
                return this.promoIdField;
            }
            set
            {
                this.promoIdField = value;
            }
        }

        public processModeType processMode
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool processModeSpecified
        {
            get
            {
                return this.processModeFieldSpecified;
            }
            set
            {
                this.processModeFieldSpecified = value;
            }
        }
    }

    public partial class price
    {

        private moneyType valueField;

        public price()
        {
            this.valueField = new moneyType();
        }

        public moneyType value
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
    }

    public partial class moneyType
    {

        private string currencyField;

        private decimal amountField;

        private string valueField;

        public moneyType()
        {

        }
        [XmlAttribute]
        public string currency
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
        [XmlAttribute]
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

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    }

    public enum priceType
    {

        /// <remarks/>
        BASE,

        /// <remarks/>
        REDUCED,

        /// <remarks/>
        CLEARANCE,
    }

    public partial class priceDisplayCodes
    {

        private submapType submapTypeField;

        private bool submapTypeFieldSpecified;

        public submapType submapType
        {
            get
            {
                return this.submapTypeField;
            }
            set
            {
                this.submapTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool submapTypeSpecified
        {
            get
            {
                return this.submapTypeFieldSpecified;
            }
            set
            {
                this.submapTypeFieldSpecified = value;
            }
        }
    }

    public enum submapType
    {

        /// <remarks/>
        CART,

        /// <remarks/>
        CHECKOUT,
    }

    public enum processModeType
    {

        /// <remarks/>
        UPSERT,

        /// <remarks/>
        DELETE,
    }
    [XmlRoot("PriceFeed", Namespace = "http://walmart.com/")]
    public partial class PriceFeed
    {

        private feedHeaderType priceHeaderField;

        private List<itemPriceType> priceField;

        public PriceFeed()
        {
            this.priceField = new List<itemPriceType>();
            this.priceHeaderField = new feedHeaderType();
        }

        public feedHeaderType PriceHeader
        {
            get
            {
                return this.priceHeaderField;
            }
            set
            {
                this.priceHeaderField = value;
            }
        }
        [XmlArrayItem("Price")]
        public List<itemPriceType> PriceList
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
    }

    public partial class pricingListType
    {

        private List<pricingType> pricingField;

        public pricingListType()
        {
            this.pricingField = new List<pricingType>();
        }

        public List<pricingType> pricing
        {
            get
            {
                return this.pricingField;
            }
            set
            {
                this.pricingField = value;
            }
        }
    }
}

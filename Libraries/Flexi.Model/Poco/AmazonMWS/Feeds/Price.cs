namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Price
    {
        
        private string sKUField;
        
        private OverrideCurrencyAmount standardPriceField;
        
        private string standardPricePointsField;
        
        private decimal businessPriceField;
        
        private bool businessPriceFieldSpecified;
        
        private QuantityPriceTypes quantityPriceTypeField;
        
        private bool quantityPriceTypeFieldSpecified;
        
        private PriceQuantityPrice quantityPriceField;
        
        private StringOverrideCurrencyAmount minimumSellerAllowedPriceField;
        
        private StringOverrideCurrencyAmount maximumSellerAllowedPriceField;
        
        private OverrideCurrencyAmount mAPField;
        
        private CurrencyAmountWithDefault depositAmountField;
        
        private PriceSale saleField;
        
        private DatedCompareAtPrice compareAtField;
        
        private DatedPrice previousField;
        
        private PriceRental_0 rental_0Field;
        
        private PriceRental_1 rental_1Field;
        
        private PriceRental_2 rental_2Field;
        
        private PriceRental_3 rental_3Field;
        
        private PriceRental_4 rental_4Field;
        
        private PriceRental_5 rental_5Field;
        
        private PriceRental_6 rental_6Field;
        
        private PriceRental_7 rental_7Field;
        
        private PriceRental_8 rental_8Field;
        
        private PriceRental_9 rental_9Field;
        
        private OverrideCurrencyAmount costPerClickBidPriceField;
        
        private bool makeAnOfferEligibilityField;
        
        private bool makeAnOfferEligibilityFieldSpecified;
        
        private decimal minimumAcceptPercentageField;
        
        private bool minimumAcceptPercentageFieldSpecified;
        
        private decimal maximumRejectPercentageField;
        
        private bool maximumRejectPercentageFieldSpecified;
        
        private PricingActionValues pricingActionField;
        
        private bool pricingActionFieldSpecified;
        
        private string metalStandardPriceField;
        
        private string diamondStandardPriceField;
        
        private string gemstoneStandardPriceField;
        
        private string makingChargesStandardPriceField;
        
        private string taxStandardPriceField;
        
        private string metalSalePriceField;
        
        private string diamondSalePriceField;
        
        private string gemstoneSalePriceField;
        
        private string makingChargesSalePriceField;
        
        private string taxSalePriceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
            }
        }
        
        /// <remarks/>
        public OverrideCurrencyAmount StandardPrice
        {
            get
            {
                return this.standardPriceField;
            }
            set
            {
                this.standardPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string StandardPricePoints
        {
            get
            {
                return this.standardPricePointsField;
            }
            set
            {
                this.standardPricePointsField = value;
            }
        }
        
        /// <remarks/>
        public decimal BusinessPrice
        {
            get
            {
                return this.businessPriceField;
            }
            set
            {
                this.businessPriceField = value;
                this.BusinessPriceSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BusinessPriceSpecified
        {
            get
            {
                return this.businessPriceFieldSpecified;
            }
            set
            {
                this.businessPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public QuantityPriceTypes QuantityPriceType
        {
            get
            {
                return this.quantityPriceTypeField;
            }
            set
            {
                this.quantityPriceTypeField = value;
                this.QuantityPriceTypeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityPriceTypeSpecified
        {
            get
            {
                return this.quantityPriceTypeFieldSpecified;
            }
            set
            {
                this.quantityPriceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PriceQuantityPrice QuantityPrice
        {
            get
            {
                return this.quantityPriceField;
            }
            set
            {
                this.quantityPriceField = value;
            }
        }
        
        /// <remarks/>
        public StringOverrideCurrencyAmount MinimumSellerAllowedPrice
        {
            get
            {
                return this.minimumSellerAllowedPriceField;
            }
            set
            {
                this.minimumSellerAllowedPriceField = value;
            }
        }
        
        /// <remarks/>
        public StringOverrideCurrencyAmount MaximumSellerAllowedPrice
        {
            get
            {
                return this.maximumSellerAllowedPriceField;
            }
            set
            {
                this.maximumSellerAllowedPriceField = value;
            }
        }
        
        /// <remarks/>
        public OverrideCurrencyAmount MAP
        {
            get
            {
                return this.mAPField;
            }
            set
            {
                this.mAPField = value;
            }
        }
        
        /// <remarks/>
        public CurrencyAmountWithDefault DepositAmount
        {
            get
            {
                return this.depositAmountField;
            }
            set
            {
                this.depositAmountField = value;
            }
        }
        
        /// <remarks/>
        public PriceSale Sale
        {
            get
            {
                return this.saleField;
            }
            set
            {
                this.saleField = value;
            }
        }
        
        /// <remarks/>
        public DatedCompareAtPrice CompareAt
        {
            get
            {
                return this.compareAtField;
            }
            set
            {
                this.compareAtField = value;
            }
        }
        
        /// <remarks/>
        public DatedPrice Previous
        {
            get
            {
                return this.previousField;
            }
            set
            {
                this.previousField = value;
            }
        }
        
        /// <remarks/>
        public PriceRental_0 Rental_0
        {
            get
            {
                return this.rental_0Field;
            }
            set
            {
                this.rental_0Field = value;
            }
        }
        
        /// <remarks/>
        public PriceRental_1 Rental_1
        {
            get
            {
                return this.rental_1Field;
            }
            set
            {
                this.rental_1Field = value;
            }
        }
        
        /// <remarks/>
        public PriceRental_2 Rental_2
        {
            get
            {
                return this.rental_2Field;
            }
            set
            {
                this.rental_2Field = value;
            }
        }
        
        /// <remarks/>
        public PriceRental_3 Rental_3
        {
            get
            {
                return this.rental_3Field;
            }
            set
            {
                this.rental_3Field = value;
            }
        }
        
        /// <remarks/>
        public PriceRental_4 Rental_4
        {
            get
            {
                return this.rental_4Field;
            }
            set
            {
                this.rental_4Field = value;
            }
        }
        
        /// <remarks/>
        public PriceRental_5 Rental_5
        {
            get
            {
                return this.rental_5Field;
            }
            set
            {
                this.rental_5Field = value;
            }
        }
        
        /// <remarks/>
        public PriceRental_6 Rental_6
        {
            get
            {
                return this.rental_6Field;
            }
            set
            {
                this.rental_6Field = value;
            }
        }
        
        /// <remarks/>
        public PriceRental_7 Rental_7
        {
            get
            {
                return this.rental_7Field;
            }
            set
            {
                this.rental_7Field = value;
            }
        }
        
        /// <remarks/>
        public PriceRental_8 Rental_8
        {
            get
            {
                return this.rental_8Field;
            }
            set
            {
                this.rental_8Field = value;
            }
        }
        
        /// <remarks/>
        public PriceRental_9 Rental_9
        {
            get
            {
                return this.rental_9Field;
            }
            set
            {
                this.rental_9Field = value;
            }
        }
        
        /// <remarks/>
        public OverrideCurrencyAmount CostPerClickBidPrice
        {
            get
            {
                return this.costPerClickBidPriceField;
            }
            set
            {
                this.costPerClickBidPriceField = value;
            }
        }
        
        /// <remarks/>
        public bool MakeAnOfferEligibility
        {
            get
            {
                return this.makeAnOfferEligibilityField;
            }
            set
            {
                this.makeAnOfferEligibilityField = value;
                this.MakeAnOfferEligibilitySpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MakeAnOfferEligibilitySpecified
        {
            get
            {
                return this.makeAnOfferEligibilityFieldSpecified;
            }
            set
            {
                this.makeAnOfferEligibilityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal MinimumAcceptPercentage
        {
            get
            {
                return this.minimumAcceptPercentageField;
            }
            set
            {
                this.minimumAcceptPercentageField = value;
                this.MinimumAcceptPercentageSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumAcceptPercentageSpecified
        {
            get
            {
                return this.minimumAcceptPercentageFieldSpecified;
            }
            set
            {
                this.minimumAcceptPercentageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal MaximumRejectPercentage
        {
            get
            {
                return this.maximumRejectPercentageField;
            }
            set
            {
                this.maximumRejectPercentageField = value;
                this.MaximumRejectPercentageSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaximumRejectPercentageSpecified
        {
            get
            {
                return this.maximumRejectPercentageFieldSpecified;
            }
            set
            {
                this.maximumRejectPercentageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PricingActionValues PricingAction
        {
            get
            {
                return this.pricingActionField;
            }
            set
            {
                this.pricingActionField = value;
                this.PricingActionSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PricingActionSpecified
        {
            get
            {
                return this.pricingActionFieldSpecified;
            }
            set
            {
                this.pricingActionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MetalStandardPrice
        {
            get
            {
                return this.metalStandardPriceField;
            }
            set
            {
                this.metalStandardPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string DiamondStandardPrice
        {
            get
            {
                return this.diamondStandardPriceField;
            }
            set
            {
                this.diamondStandardPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string GemstoneStandardPrice
        {
            get
            {
                return this.gemstoneStandardPriceField;
            }
            set
            {
                this.gemstoneStandardPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MakingChargesStandardPrice
        {
            get
            {
                return this.makingChargesStandardPriceField;
            }
            set
            {
                this.makingChargesStandardPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string TaxStandardPrice
        {
            get
            {
                return this.taxStandardPriceField;
            }
            set
            {
                this.taxStandardPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MetalSalePrice
        {
            get
            {
                return this.metalSalePriceField;
            }
            set
            {
                this.metalSalePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string DiamondSalePrice
        {
            get
            {
                return this.diamondSalePriceField;
            }
            set
            {
                this.diamondSalePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string GemstoneSalePrice
        {
            get
            {
                return this.gemstoneSalePriceField;
            }
            set
            {
                this.gemstoneSalePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MakingChargesSalePrice
        {
            get
            {
                return this.makingChargesSalePriceField;
            }
            set
            {
                this.makingChargesSalePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string TaxSalePrice
        {
            get
            {
                return this.taxSalePriceField;
            }
            set
            {
                this.taxSalePriceField = value;
            }
        }
    }
}

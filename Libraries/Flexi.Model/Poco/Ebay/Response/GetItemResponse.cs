using System.Xml.Serialization;

namespace Royal.Model.Poco.Ebay.Response
{
    [XmlRoot(ElementName = "ApplyBuyerProtection", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ApplyBuyerProtection
    {
        [XmlElement(ElementName = "BuyerProtectionSource", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BuyerProtectionSource { get; set; }
        [XmlElement(ElementName = "BuyerProtectionStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BuyerProtectionStatus { get; set; }
    }

    [XmlRoot(ElementName = "BestOfferDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class BestOfferDetails
    {
        [XmlElement(ElementName = "BestOfferCount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BestOfferCount { get; set; }
        [XmlElement(ElementName = "BestOfferEnabled", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BestOfferEnabled { get; set; }
    }

    [XmlRoot(ElementName = "Address", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Address
    {
        [XmlElement(ElementName = "FirstName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "LastName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LastName { get; set; }
    }

    [XmlRoot(ElementName = "VATDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class VATDetails
    {
        [XmlElement(ElementName = "BusinessSeller", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BusinessSeller { get; set; }
        [XmlElement(ElementName = "RestrictedToBusiness", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string RestrictedToBusiness { get; set; }
        [XmlElement(ElementName = "VATID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string VATID { get; set; }
        [XmlElement(ElementName = "VATPercent", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string VATPercent { get; set; }
        [XmlElement(ElementName = "VATSite", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string VATSite { get; set; }
    }

    [XmlRoot(ElementName = "BusinessSellerDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class BusinessSellerDetails
    {
        [XmlElement(ElementName = "AdditionalContactInformation", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string AdditionalContactInformation { get; set; }
        [XmlElement(ElementName = "Address", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Address Address { get; set; }
        [XmlElement(ElementName = "Email", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Email { get; set; }
        [XmlElement(ElementName = "Fax", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "LegalInvoice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LegalInvoice { get; set; }
        [XmlElement(ElementName = "TermsAndConditions", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string TermsAndConditions { get; set; }
        [XmlElement(ElementName = "TradeRegistrationNumber", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string TradeRegistrationNumber { get; set; }
        [XmlElement(ElementName = "VATDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public VATDetails VATDetails { get; set; }
    }

    [XmlRoot(ElementName = "BuyerGuaranteePrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class BuyerGuaranteePrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MaximumBuyerPolicyViolations", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class MaximumBuyerPolicyViolations
    {
        [XmlElement(ElementName = "Count", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Count { get; set; }
        [XmlElement(ElementName = "Period", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Period { get; set; }
    }

    [XmlRoot(ElementName = "MaximumItemRequirements", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class MaximumItemRequirements
    {
        [XmlElement(ElementName = "MaximumItemCount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string MaximumItemCount { get; set; }
        [XmlElement(ElementName = "MinimumFeedbackScore", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string MinimumFeedbackScore { get; set; }
    }

    [XmlRoot(ElementName = "MaximumUnpaidItemStrikesInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class MaximumUnpaidItemStrikesInfo
    {
        [XmlElement(ElementName = "Count", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Count { get; set; }
        [XmlElement(ElementName = "Period", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Period { get; set; }
    }

    [XmlRoot(ElementName = "VerifiedUserRequirements", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class VerifiedUserRequirements
    {
        [XmlElement(ElementName = "MinimumFeedbackScore", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string MinimumFeedbackScore { get; set; }
        [XmlElement(ElementName = "VerifiedUser", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string VerifiedUser { get; set; }
    }

    [XmlRoot(ElementName = "BuyerRequirementDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class BuyerRequirementDetails
    {
        [XmlElement(ElementName = "LinkedPayPalAccount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LinkedPayPalAccount { get; set; }
        [XmlElement(ElementName = "MaximumBuyerPolicyViolations", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public MaximumBuyerPolicyViolations MaximumBuyerPolicyViolations { get; set; }
        [XmlElement(ElementName = "MaximumItemRequirements", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public MaximumItemRequirements MaximumItemRequirements { get; set; }
        [XmlElement(ElementName = "MaximumUnpaidItemStrikesInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public MaximumUnpaidItemStrikesInfo MaximumUnpaidItemStrikesInfo { get; set; }
        [XmlElement(ElementName = "MinimumFeedbackScore", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string MinimumFeedbackScore { get; set; }
        [XmlElement(ElementName = "ShipToRegistrationCountry", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShipToRegistrationCountry { get; set; }
        [XmlElement(ElementName = "VerifiedUserRequirements", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public VerifiedUserRequirements VerifiedUserRequirements { get; set; }
        [XmlElement(ElementName = "ZeroFeedbackScore", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ZeroFeedbackScore { get; set; }
    }

    [XmlRoot(ElementName = "BuyItNowPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class BuyItNowPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Charity", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Charity
    {
        [XmlElement(ElementName = "CharityID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CharityID { get; set; }
        [XmlElement(ElementName = "CharityName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CharityName { get; set; }
        [XmlElement(ElementName = "CharityNumber", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CharityNumber { get; set; }
        [XmlElement(ElementName = "DonationPercent", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DonationPercent { get; set; }
        [XmlElement(ElementName = "LogoURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LogoURL { get; set; }
        [XmlElement(ElementName = "Mission", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Mission { get; set; }
        [XmlElement(ElementName = "Status", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Status { get; set; }
    }

    [XmlRoot(ElementName = "DigitalGoodInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class DigitalGoodInfo
    {
        [XmlElement(ElementName = "DigitalDelivery", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DigitalDelivery { get; set; }
    }

    [XmlRoot(ElementName = "MadeForOutletComparisonPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class MadeForOutletComparisonPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MinimumAdvertisedPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class MinimumAdvertisedPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OriginalRetailPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class OriginalRetailPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DiscountPriceInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class DiscountPriceInfo
    {
        [XmlElement(ElementName = "MadeForOutletComparisonPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public MadeForOutletComparisonPrice MadeForOutletComparisonPrice { get; set; }
        [XmlElement(ElementName = "MinimumAdvertisedPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public MinimumAdvertisedPrice MinimumAdvertisedPrice { get; set; }
        [XmlElement(ElementName = "MinimumAdvertisedPriceExposure", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string MinimumAdvertisedPriceExposure { get; set; }
        [XmlElement(ElementName = "OriginalRetailPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public OriginalRetailPrice OriginalRetailPrice { get; set; }
        [XmlElement(ElementName = "PricingTreatment", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PricingTreatment { get; set; }
        [XmlElement(ElementName = "SoldOffeBay", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SoldOffeBay { get; set; }
        [XmlElement(ElementName = "SoldOneBay", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SoldOneBay { get; set; }
    }

    [XmlRoot(ElementName = "ContactHoursDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ContactHoursDetails
    {
        [XmlElement(ElementName = "Hours1AnyTime", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Hours1AnyTime { get; set; }
        [XmlElement(ElementName = "Hours1Days", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Hours1Days { get; set; }
        [XmlElement(ElementName = "Hours1From", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Hours1From { get; set; }
        [XmlElement(ElementName = "Hours1To", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Hours1To { get; set; }
        [XmlElement(ElementName = "Hours2AnyTime", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Hours2AnyTime { get; set; }
        [XmlElement(ElementName = "Hours2Days", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Hours2Days { get; set; }
        [XmlElement(ElementName = "Hours2From", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Hours2From { get; set; }
        [XmlElement(ElementName = "Hours2To", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Hours2To { get; set; }
        [XmlElement(ElementName = "TimeZoneID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string TimeZoneID { get; set; }
    }

    [XmlRoot(ElementName = "ExtendedSellerContactDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ExtendedSellerContactDetails
    {
        [XmlElement(ElementName = "ClassifiedAdContactByEmailEnabled", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ClassifiedAdContactByEmailEnabled { get; set; }
        [XmlElement(ElementName = "ContactHoursDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ContactHoursDetails ContactHoursDetails { get; set; }
    }

    [XmlRoot(ElementName = "FreeAddedCategory", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class FreeAddedCategory
    {
        [XmlElement(ElementName = "CategoryID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CategoryID { get; set; }
        [XmlElement(ElementName = "CategoryName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CategoryName { get; set; }
    }

    [XmlRoot(ElementName = "NameValueList", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class NameValueList
    {
        [XmlElement(ElementName = "Name", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Source", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Source { get; set; }
        [XmlElement(ElementName = "Value", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "Compatibility", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Compatibility
    {
        [XmlElement(ElementName = "CompatibilityNotes", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CompatibilityNotes { get; set; }
        [XmlElement(ElementName = "NameValueList", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public NameValueList NameValueList { get; set; }
    }

    [XmlRoot(ElementName = "ItemCompatibilityList", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ItemCompatibilityList
    {
        [XmlElement(ElementName = "Compatibility", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Compatibility Compatibility { get; set; }
    }

    [XmlRoot(ElementName = "ItemPolicyViolation", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ItemPolicyViolation
    {
        [XmlElement(ElementName = "PolicyID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PolicyID { get; set; }
        [XmlElement(ElementName = "PolicyText", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PolicyText { get; set; }
    }

    [XmlRoot(ElementName = "ItemSpecifics", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ItemSpecifics
    {
        [XmlElement(ElementName = "NameValueList", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public NameValueList NameValueList { get; set; }
    }

    [XmlRoot(ElementName = "ListingDesigner", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ListingDesigner
    {
        [XmlElement(ElementName = "LayoutID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LayoutID { get; set; }
        [XmlElement(ElementName = "OptimalPictureSize", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string OptimalPictureSize { get; set; }
        [XmlElement(ElementName = "ThemeID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ThemeID { get; set; }
    }

    [XmlRoot(ElementName = "BestOfferAutoAcceptPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class BestOfferAutoAcceptPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ConvertedBuyItNowPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ConvertedBuyItNowPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ConvertedReservePrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ConvertedReservePrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ConvertedStartPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ConvertedStartPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MinimumBestOfferPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class MinimumBestOfferPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ListingDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ListingDetails
    {
        [XmlElement(ElementName = "Adult", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Adult { get; set; }
        [XmlElement(ElementName = "BestOfferAutoAcceptPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public BestOfferAutoAcceptPrice BestOfferAutoAcceptPrice { get; set; }
        [XmlElement(ElementName = "BindingAuction", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BindingAuction { get; set; }
        [XmlElement(ElementName = "BuyItNowAvailable", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BuyItNowAvailable { get; set; }
        [XmlElement(ElementName = "CheckoutEnabled", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CheckoutEnabled { get; set; }
        [XmlElement(ElementName = "ConvertedBuyItNowPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ConvertedBuyItNowPrice ConvertedBuyItNowPrice { get; set; }
        [XmlElement(ElementName = "ConvertedReservePrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ConvertedReservePrice ConvertedReservePrice { get; set; }
        [XmlElement(ElementName = "ConvertedStartPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ConvertedStartPrice ConvertedStartPrice { get; set; }
        [XmlElement(ElementName = "EndingReason", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EndingReason { get; set; }
        [XmlElement(ElementName = "EndTime", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EndTime { get; set; }
        [XmlElement(ElementName = "HasPublicMessages", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string HasPublicMessages { get; set; }
        [XmlElement(ElementName = "HasReservePrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string HasReservePrice { get; set; }
        [XmlElement(ElementName = "HasUnansweredQuestions", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string HasUnansweredQuestions { get; set; }
        [XmlElement(ElementName = "MinimumBestOfferPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public MinimumBestOfferPrice MinimumBestOfferPrice { get; set; }
        [XmlElement(ElementName = "RelistedItemID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string RelistedItemID { get; set; }
        [XmlElement(ElementName = "SecondChanceOriginalItemID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SecondChanceOriginalItemID { get; set; }
        [XmlElement(ElementName = "StartTime", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string StartTime { get; set; }
        [XmlElement(ElementName = "TCROriginalItemID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string TCROriginalItemID { get; set; }
        [XmlElement(ElementName = "ViewItemURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ViewItemURL { get; set; }
        [XmlElement(ElementName = "ViewItemURLForNaturalSearch", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ViewItemURLForNaturalSearch { get; set; }
    }

    [XmlRoot(ElementName = "DepositAmount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class DepositAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PaymentDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class PaymentDetails
    {
        [XmlElement(ElementName = "DaysToFullPayment", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DaysToFullPayment { get; set; }
        [XmlElement(ElementName = "DepositAmount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public DepositAmount DepositAmount { get; set; }
        [XmlElement(ElementName = "DepositType", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DepositType { get; set; }
        [XmlElement(ElementName = "HoursToDeposit", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string HoursToDeposit { get; set; }
    }

    [XmlRoot(ElementName = "PickupInStoreDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class PickupInStoreDetails
    {
        [XmlElement(ElementName = "EligibleForPickupDropOff", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EligibleForPickupDropOff { get; set; }
        [XmlElement(ElementName = "EligibleForPickupInStore", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EligibleForPickupInStore { get; set; }
    }

    [XmlRoot(ElementName = "PictureURLs", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class PictureURLs
    {
        [XmlElement(ElementName = "eBayPictureURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EBayPictureURL { get; set; }
        [XmlElement(ElementName = "ExternalPictureURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ExternalPictureURL { get; set; }
    }

    [XmlRoot(ElementName = "ExtendedPictureDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ExtendedPictureDetails
    {
        [XmlElement(ElementName = "PictureURLs", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public PictureURLs PictureURLs { get; set; }
    }

    [XmlRoot(ElementName = "PictureDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class PictureDetails
    {
        [XmlElement(ElementName = "ExtendedPictureDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ExtendedPictureDetails ExtendedPictureDetails { get; set; }
        [XmlElement(ElementName = "ExternalPictureURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ExternalPictureURL { get; set; }
        [XmlElement(ElementName = "GalleryDuration", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string GalleryDuration { get; set; }
        [XmlElement(ElementName = "GalleryErrorInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string GalleryErrorInfo { get; set; }
        [XmlElement(ElementName = "GalleryStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string GalleryStatus { get; set; }
        [XmlElement(ElementName = "GalleryType", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string GalleryType { get; set; }
        [XmlElement(ElementName = "PhotoDisplay", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PhotoDisplay { get; set; }
        [XmlElement(ElementName = "PictureSource", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PictureSource { get; set; }
        [XmlElement(ElementName = "PictureURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PictureURL { get; set; }
    }

    [XmlRoot(ElementName = "PrimaryCategory", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class PrimaryCategory
    {
        [XmlElement(ElementName = "CategoryID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CategoryID { get; set; }
        [XmlElement(ElementName = "CategoryName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CategoryName { get; set; }
    }

    [XmlRoot(ElementName = "BrandMPN", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class BrandMPN
    {
        [XmlElement(ElementName = "Brand", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Brand { get; set; }
        [XmlElement(ElementName = "MPN", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string MPN { get; set; }
    }

    [XmlRoot(ElementName = "TicketListingDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class TicketListingDetails
    {
        [XmlElement(ElementName = "EventTitle", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EventTitle { get; set; }
        [XmlElement(ElementName = "PrintedDate", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PrintedDate { get; set; }
        [XmlElement(ElementName = "PrintedTime", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PrintedTime { get; set; }
        [XmlElement(ElementName = "Venue", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Venue { get; set; }
    }

    [XmlRoot(ElementName = "ProductListingDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ProductListingDetails
    {
        [XmlElement(ElementName = "BrandMPN", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public BrandMPN BrandMPN { get; set; }
        [XmlElement(ElementName = "Copyright", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Copyright { get; set; }
        [XmlElement(ElementName = "EAN", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EAN { get; set; }
        [XmlElement(ElementName = "IncludeeBayProductDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string IncludeeBayProductDetails { get; set; }
        [XmlElement(ElementName = "IncludeStockPhotoURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string IncludeStockPhotoURL { get; set; }
        [XmlElement(ElementName = "ISBN", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ISBN { get; set; }
        [XmlElement(ElementName = "StockPhotoURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string StockPhotoURL { get; set; }
        [XmlElement(ElementName = "TicketListingDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public TicketListingDetails TicketListingDetails { get; set; }
        [XmlElement(ElementName = "UPC", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string UPC { get; set; }
        [XmlElement(ElementName = "UseStockPhotoURLAsGallery", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string UseStockPhotoURLAsGallery { get; set; }
    }

    [XmlRoot(ElementName = "QuantityInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class QuantityInfo
    {
        [XmlElement(ElementName = "MinimumRemnantSet", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string MinimumRemnantSet { get; set; }
    }

    [XmlRoot(ElementName = "ReservePrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ReservePrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ReturnPolicy", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ReturnPolicy
    {
        [XmlElement(ElementName = "Description", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Description { get; set; }
        [XmlElement(ElementName = "ExtendedHolidayReturns", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ExtendedHolidayReturns { get; set; }
        [XmlElement(ElementName = "Refund", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Refund { get; set; }
        [XmlElement(ElementName = "RefundOption", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string RefundOption { get; set; }
        [XmlElement(ElementName = "RestockingFeeValue", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string RestockingFeeValue { get; set; }
        [XmlElement(ElementName = "RestockingFeeValueOption", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string RestockingFeeValueOption { get; set; }
        [XmlElement(ElementName = "ReturnsAccepted", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ReturnsAccepted { get; set; }
        [XmlElement(ElementName = "ReturnsAcceptedOption", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ReturnsAcceptedOption { get; set; }
        [XmlElement(ElementName = "ReturnsWithin", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ReturnsWithin { get; set; }
        [XmlElement(ElementName = "ReturnsWithinOption", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ReturnsWithinOption { get; set; }
        [XmlElement(ElementName = "ShippingCostPaidBy", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingCostPaidBy { get; set; }
        [XmlElement(ElementName = "ShippingCostPaidByOption", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingCostPaidByOption { get; set; }
        [XmlElement(ElementName = "WarrantyDuration", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string WarrantyDuration { get; set; }
        [XmlElement(ElementName = "WarrantyDurationOption", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string WarrantyDurationOption { get; set; }
        [XmlElement(ElementName = "WarrantyOffered", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string WarrantyOffered { get; set; }
        [XmlElement(ElementName = "WarrantyOfferedOption", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string WarrantyOfferedOption { get; set; }
        [XmlElement(ElementName = "WarrantyType", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string WarrantyType { get; set; }
        [XmlElement(ElementName = "WarrantyTypeOption", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string WarrantyTypeOption { get; set; }
    }

    [XmlRoot(ElementName = "ReviseStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ReviseStatus
    {
        [XmlElement(ElementName = "BuyItNowAdded", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BuyItNowAdded { get; set; }
        [XmlElement(ElementName = "BuyItNowLowered", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BuyItNowLowered { get; set; }
        [XmlElement(ElementName = "ItemRevised", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ItemRevised { get; set; }
        [XmlElement(ElementName = "ReserveLowered", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ReserveLowered { get; set; }
        [XmlElement(ElementName = "ReserveRemoved", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ReserveRemoved { get; set; }
    }

    [XmlRoot(ElementName = "SecondaryCategory", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class SecondaryCategory
    {
        [XmlElement(ElementName = "CategoryID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CategoryID { get; set; }
        [XmlElement(ElementName = "CategoryName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CategoryName { get; set; }
    }

    [XmlRoot(ElementName = "RegistrationAddress", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class RegistrationAddress
    {
        [XmlElement(ElementName = "CityName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "Country", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Country { get; set; }
        [XmlElement(ElementName = "CountryName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CountryName { get; set; }
        [XmlElement(ElementName = "FirstName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "LastName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Phone", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Phone { get; set; }
        [XmlElement(ElementName = "PostalCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Street", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Street { get; set; }
        [XmlElement(ElementName = "Street1", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Street1 { get; set; }
        [XmlElement(ElementName = "Street2", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Street2 { get; set; }
    }

    [XmlRoot(ElementName = "SellerInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class SellerInfo
    {
        [XmlElement(ElementName = "AllowPaymentEdit", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string AllowPaymentEdit { get; set; }
        [XmlElement(ElementName = "CheckoutEnabled", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CheckoutEnabled { get; set; }
        [XmlElement(ElementName = "CIPBankAccountStored", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CIPBankAccountStored { get; set; }
        [XmlElement(ElementName = "GoodStanding", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string GoodStanding { get; set; }
        [XmlElement(ElementName = "QualifiesForB2BVAT", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string QualifiesForB2BVAT { get; set; }
        [XmlElement(ElementName = "SafePaymentExempt", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SafePaymentExempt { get; set; }
        [XmlElement(ElementName = "SellerBusinessType", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SellerBusinessType { get; set; }
        [XmlElement(ElementName = "SellerLevel", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SellerLevel { get; set; }
        [XmlElement(ElementName = "StoreOwner", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string StoreOwner { get; set; }
        [XmlElement(ElementName = "StoreURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string StoreURL { get; set; }
        [XmlElement(ElementName = "TopRatedSeller", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string TopRatedSeller { get; set; }
    }

    [XmlRoot(ElementName = "Seller", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Seller
    {
        [XmlElement(ElementName = "AboutMePage", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string AboutMePage { get; set; }
        [XmlElement(ElementName = "eBayGoodStanding", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EBayGoodStanding { get; set; }
        [XmlElement(ElementName = "Email", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Email { get; set; }
        [XmlElement(ElementName = "FeedbackPrivate", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string FeedbackPrivate { get; set; }
        [XmlElement(ElementName = "FeedbackRatingStar", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string FeedbackRatingStar { get; set; }
        [XmlElement(ElementName = "FeedbackScore", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string FeedbackScore { get; set; }
        [XmlElement(ElementName = "IDVerified", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string IDVerified { get; set; }
        [XmlElement(ElementName = "MotorsDealer", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string MotorsDealer { get; set; }
        [XmlElement(ElementName = "NewUser", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string NewUser { get; set; }
        [XmlElement(ElementName = "PositiveFeedbackPercent", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PositiveFeedbackPercent { get; set; }
        [XmlElement(ElementName = "RegistrationAddress", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public RegistrationAddress RegistrationAddress { get; set; }
        [XmlElement(ElementName = "RegistrationDate", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string RegistrationDate { get; set; }
        [XmlElement(ElementName = "SellerInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public SellerInfo SellerInfo { get; set; }
        [XmlElement(ElementName = "Site", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Site { get; set; }
        [XmlElement(ElementName = "Status", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Status { get; set; }
        [XmlElement(ElementName = "UserID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string UserID { get; set; }
        [XmlElement(ElementName = "UserIDChanged", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string UserIDChanged { get; set; }
        [XmlElement(ElementName = "UserIDLastChanged", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string UserIDLastChanged { get; set; }
        [XmlElement(ElementName = "VATStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string VATStatus { get; set; }
    }

    [XmlRoot(ElementName = "SellerContactDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class SellerContactDetails
    {
        [XmlElement(ElementName = "CompanyName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CompanyName { get; set; }
        [XmlElement(ElementName = "County", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string County { get; set; }
        [XmlElement(ElementName = "FirstName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "LastName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "Phone2AreaOrCityCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Phone2AreaOrCityCode { get; set; }
        [XmlElement(ElementName = "Phone2CountryCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Phone2CountryCode { get; set; }
        [XmlElement(ElementName = "Phone2CountryPrefix", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Phone2CountryPrefix { get; set; }
        [XmlElement(ElementName = "Phone2LocalNumber", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Phone2LocalNumber { get; set; }
        [XmlElement(ElementName = "PhoneAreaOrCityCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PhoneAreaOrCityCode { get; set; }
        [XmlElement(ElementName = "PhoneCountryCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PhoneCountryCode { get; set; }
        [XmlElement(ElementName = "PhoneCountryPrefix", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PhoneCountryPrefix { get; set; }
        [XmlElement(ElementName = "PhoneLocalNumber", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PhoneLocalNumber { get; set; }
        [XmlElement(ElementName = "Street1", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Street1 { get; set; }
        [XmlElement(ElementName = "Street2", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Street2 { get; set; }
    }

    [XmlRoot(ElementName = "SellerPaymentProfile", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class SellerPaymentProfile
    {
        [XmlElement(ElementName = "PaymentProfileID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PaymentProfileID { get; set; }
        [XmlElement(ElementName = "PaymentProfileName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PaymentProfileName { get; set; }
    }

    [XmlRoot(ElementName = "SellerReturnProfile", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class SellerReturnProfile
    {
        [XmlElement(ElementName = "ReturnProfileID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ReturnProfileID { get; set; }
        [XmlElement(ElementName = "ReturnProfileName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ReturnProfileName { get; set; }
    }

    [XmlRoot(ElementName = "SellerShippingProfile", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class SellerShippingProfile
    {
        [XmlElement(ElementName = "ShippingProfileID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingProfileID { get; set; }
        [XmlElement(ElementName = "ShippingProfileName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingProfileName { get; set; }
    }

    [XmlRoot(ElementName = "SellerProfiles", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class SellerProfiles
    {
        [XmlElement(ElementName = "SellerPaymentProfile", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public SellerPaymentProfile SellerPaymentProfile { get; set; }
        [XmlElement(ElementName = "SellerReturnProfile", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public SellerReturnProfile SellerReturnProfile { get; set; }
        [XmlElement(ElementName = "SellerShippingProfile", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public SellerShippingProfile SellerShippingProfile { get; set; }
    }

    [XmlRoot(ElementName = "BidIncrement", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class BidIncrement
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ConvertedCurrentPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ConvertedCurrentPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CurrentPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class CurrentPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ShippingAddress", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ShippingAddress
    {
        [XmlElement(ElementName = "Country", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Country { get; set; }
        [XmlElement(ElementName = "FirstName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "LastName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "PostalCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PostalCode { get; set; }
    }

    [XmlRoot(ElementName = "BuyerInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class BuyerInfo
    {
        [XmlElement(ElementName = "ShippingAddress", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ShippingAddress ShippingAddress { get; set; }
    }

    [XmlRoot(ElementName = "HighBidder", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class HighBidder
    {
        [XmlElement(ElementName = "AboutMePage", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string AboutMePage { get; set; }
        [XmlElement(ElementName = "BuyerInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public BuyerInfo BuyerInfo { get; set; }
        [XmlElement(ElementName = "eBayGoodStanding", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EBayGoodStanding { get; set; }
        [XmlElement(ElementName = "Email", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Email { get; set; }
        [XmlElement(ElementName = "FeedbackPrivate", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string FeedbackPrivate { get; set; }
        [XmlElement(ElementName = "FeedbackRatingStar", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string FeedbackRatingStar { get; set; }
        [XmlElement(ElementName = "FeedbackScore", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string FeedbackScore { get; set; }
        [XmlElement(ElementName = "IDVerified", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string IDVerified { get; set; }
        [XmlElement(ElementName = "NewUser", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string NewUser { get; set; }
        [XmlElement(ElementName = "PositiveFeedbackPercent", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PositiveFeedbackPercent { get; set; }
        [XmlElement(ElementName = "RegistrationAddress", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public RegistrationAddress RegistrationAddress { get; set; }
        [XmlElement(ElementName = "RegistrationDate", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string RegistrationDate { get; set; }
        [XmlElement(ElementName = "Site", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Site { get; set; }
        [XmlElement(ElementName = "Status", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Status { get; set; }
        [XmlElement(ElementName = "UserAnonymized", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string UserAnonymized { get; set; }
        [XmlElement(ElementName = "UserID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string UserID { get; set; }
        [XmlElement(ElementName = "UserIDChanged", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string UserIDChanged { get; set; }
        [XmlElement(ElementName = "UserIDLastChanged", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string UserIDLastChanged { get; set; }
        [XmlElement(ElementName = "VATStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string VATStatus { get; set; }
    }

    [XmlRoot(ElementName = "MinimumToBid", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class MinimumToBid
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OriginalPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class OriginalPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PromotionalSaleDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class PromotionalSaleDetails
    {
        [XmlElement(ElementName = "EndTime", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EndTime { get; set; }
        [XmlElement(ElementName = "OriginalPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public OriginalPrice OriginalPrice { get; set; }
        [XmlElement(ElementName = "StartTime", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string StartTime { get; set; }
    }

    [XmlRoot(ElementName = "SellingStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class SellingStatus
    {
        [XmlElement(ElementName = "AdminEnded", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string AdminEnded { get; set; }
        [XmlElement(ElementName = "BidCount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BidCount { get; set; }
        [XmlElement(ElementName = "BidIncrement", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public BidIncrement BidIncrement { get; set; }
        [XmlElement(ElementName = "ConvertedCurrentPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ConvertedCurrentPrice ConvertedCurrentPrice { get; set; }
        [XmlElement(ElementName = "CurrentPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public CurrentPrice CurrentPrice { get; set; }
        [XmlElement(ElementName = "HighBidder", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public HighBidder HighBidder { get; set; }
        [XmlElement(ElementName = "LeadCount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LeadCount { get; set; }
        [XmlElement(ElementName = "ListingStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ListingStatus { get; set; }
        [XmlElement(ElementName = "MinimumToBid", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public MinimumToBid MinimumToBid { get; set; }
        [XmlElement(ElementName = "PromotionalSaleDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public PromotionalSaleDetails PromotionalSaleDetails { get; set; }
        [XmlElement(ElementName = "QuantitySold", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public int QuantitySold { get; set; }
        [XmlElement(ElementName = "QuantitySoldByPickupInStore", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public int QuantitySoldByPickupInStore { get; set; }
        [XmlElement(ElementName = "ReserveMet", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ReserveMet { get; set; }
        [XmlElement(ElementName = "SecondChanceEligible", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SecondChanceEligible { get; set; }
        [XmlElement(ElementName = "SoldAsBin", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SoldAsBin { get; set; }
    }

    [XmlRoot(ElementName = "WeightOff", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class WeightOff
    {
        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }
        [XmlAttribute(AttributeName = "measurementSystem")]
        public string MeasurementSystem { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DiscountProfile", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class DiscountProfile
    {
        [XmlElement(ElementName = "DiscountProfileID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DiscountProfileID { get; set; }
        [XmlElement(ElementName = "DiscountProfileName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DiscountProfileName { get; set; }
        [XmlElement(ElementName = "MappedDiscountProfileID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string MappedDiscountProfileID { get; set; }
        [XmlElement(ElementName = "WeightOff", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public WeightOff WeightOff { get; set; }
        [XmlElement(ElementName = "EachAdditionalAmount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public EachAdditionalAmount EachAdditionalAmount { get; set; }
        [XmlElement(ElementName = "EachAdditionalAmountOff", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public EachAdditionalAmountOff EachAdditionalAmountOff { get; set; }
        [XmlElement(ElementName = "EachAdditionalPercentOff", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EachAdditionalPercentOff { get; set; }
    }

    [XmlRoot(ElementName = "CalculatedShippingDiscount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class CalculatedShippingDiscount
    {
        [XmlElement(ElementName = "DiscountName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DiscountName { get; set; }
        [XmlElement(ElementName = "DiscountProfile", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public DiscountProfile DiscountProfile { get; set; }
    }

    [XmlRoot(ElementName = "InternationalPackagingHandlingCosts", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class InternationalPackagingHandlingCosts
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PackagingHandlingCosts", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class PackagingHandlingCosts
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CalculatedShippingRate", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class CalculatedShippingRate
    {
        [XmlElement(ElementName = "InternationalPackagingHandlingCosts", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public InternationalPackagingHandlingCosts InternationalPackagingHandlingCosts { get; set; }
        [XmlElement(ElementName = "OriginatingPostalCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string OriginatingPostalCode { get; set; }
        [XmlElement(ElementName = "PackagingHandlingCosts", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public PackagingHandlingCosts PackagingHandlingCosts { get; set; }
        [XmlElement(ElementName = "ShippingIrregular", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingIrregular { get; set; }
    }

    [XmlRoot(ElementName = "CODCost", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class CODCost
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EachAdditionalAmount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class EachAdditionalAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EachAdditionalAmountOff", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class EachAdditionalAmountOff
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "FlatShippingDiscount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class FlatShippingDiscount
    {
        [XmlElement(ElementName = "DiscountName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DiscountName { get; set; }
        [XmlElement(ElementName = "DiscountProfile", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public DiscountProfile DiscountProfile { get; set; }
    }

    [XmlRoot(ElementName = "InternationalCalculatedShippingDiscount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class InternationalCalculatedShippingDiscount
    {
        [XmlElement(ElementName = "DiscountName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DiscountName { get; set; }
        [XmlElement(ElementName = "DiscountProfile", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public DiscountProfile DiscountProfile { get; set; }
    }

    [XmlRoot(ElementName = "InternationalFlatShippingDiscount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class InternationalFlatShippingDiscount
    {
        [XmlElement(ElementName = "DiscountName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DiscountName { get; set; }
        [XmlElement(ElementName = "DiscountProfile", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public DiscountProfile DiscountProfile { get; set; }
    }

    [XmlRoot(ElementName = "ShippingServiceAdditionalCost", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ShippingServiceAdditionalCost
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ShippingServiceCost", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ShippingServiceCost
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InternationalShippingServiceOption", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class InternationalShippingServiceOption
    {
        [XmlElement(ElementName = "ShippingService", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingService { get; set; }
        [XmlElement(ElementName = "ShippingServiceAdditionalCost", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ShippingServiceAdditionalCost ShippingServiceAdditionalCost { get; set; }
        [XmlElement(ElementName = "ShippingServiceCost", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ShippingServiceCost ShippingServiceCost { get; set; }
        [XmlElement(ElementName = "ShippingServicePriority", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingServicePriority { get; set; }
        [XmlElement(ElementName = "ShipToLocation", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShipToLocation { get; set; }
    }

    [XmlRoot(ElementName = "OrderAmount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class OrderAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ShippingCost", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ShippingCost
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PromotionalShippingDiscountDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class PromotionalShippingDiscountDetails
    {
        [XmlElement(ElementName = "DiscountName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DiscountName { get; set; }
        [XmlElement(ElementName = "ItemCount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ItemCount { get; set; }
        [XmlElement(ElementName = "OrderAmount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public OrderAmount OrderAmount { get; set; }
        [XmlElement(ElementName = "ShippingCost", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ShippingCost ShippingCost { get; set; }
    }

    [XmlRoot(ElementName = "RateTableDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class RateTableDetails
    {
        [XmlElement(ElementName = "DomesticRateTable", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DomesticRateTable { get; set; }
        [XmlElement(ElementName = "DomesticRateTableId", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DomesticRateTableId { get; set; }
        [XmlElement(ElementName = "InternationalRateTable", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string InternationalRateTable { get; set; }
        [XmlElement(ElementName = "InternationalRateTableId", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string InternationalRateTableId { get; set; }
    }

    [XmlRoot(ElementName = "SalesTax", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class SalesTax
    {
        [XmlElement(ElementName = "SalesTaxPercent", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SalesTaxPercent { get; set; }
        [XmlElement(ElementName = "SalesTaxState", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SalesTaxState { get; set; }
        [XmlElement(ElementName = "ShippingIncludedInTax", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingIncludedInTax { get; set; }
    }

    [XmlRoot(ElementName = "ShippingSurcharge", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ShippingSurcharge
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ShippingServiceOptions", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ShippingServiceOptions
    {
        [XmlElement(ElementName = "ExpeditedService", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ExpeditedService { get; set; }
        [XmlElement(ElementName = "FreeShipping", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string FreeShipping { get; set; }
        [XmlElement(ElementName = "LogisticPlanType", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LogisticPlanType { get; set; }
        [XmlElement(ElementName = "ShippingService", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingService { get; set; }
        [XmlElement(ElementName = "ShippingServiceAdditionalCost", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ShippingServiceAdditionalCost ShippingServiceAdditionalCost { get; set; }
        [XmlElement(ElementName = "ShippingServiceCost", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ShippingServiceCost ShippingServiceCost { get; set; }
        [XmlElement(ElementName = "ShippingServicePriority", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingServicePriority { get; set; }
        [XmlElement(ElementName = "ShippingSurcharge", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ShippingSurcharge ShippingSurcharge { get; set; }
        [XmlElement(ElementName = "ShippingTimeMax", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingTimeMax { get; set; }
        [XmlElement(ElementName = "ShippingTimeMin", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingTimeMin { get; set; }
    }

    [XmlRoot(ElementName = "TaxJurisdiction", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class TaxJurisdiction
    {
        [XmlElement(ElementName = "JurisdictionID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string JurisdictionID { get; set; }
        [XmlElement(ElementName = "SalesTaxPercent", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SalesTaxPercent { get; set; }
        [XmlElement(ElementName = "ShippingIncludedInTax", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingIncludedInTax { get; set; }
    }

    [XmlRoot(ElementName = "TaxTable", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class TaxTable
    {
        [XmlElement(ElementName = "TaxJurisdiction", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public TaxJurisdiction TaxJurisdiction { get; set; }
    }

    [XmlRoot(ElementName = "ShippingDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ShippingDetails
    {
        [XmlElement(ElementName = "CalculatedShippingDiscount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public CalculatedShippingDiscount CalculatedShippingDiscount { get; set; }
        [XmlElement(ElementName = "CalculatedShippingRate", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public CalculatedShippingRate CalculatedShippingRate { get; set; }
        [XmlElement(ElementName = "CODCost", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public CODCost CODCost { get; set; }
        [XmlElement(ElementName = "ExcludeShipToLocation", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ExcludeShipToLocation { get; set; }
        [XmlElement(ElementName = "FlatShippingDiscount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public FlatShippingDiscount FlatShippingDiscount { get; set; }
        [XmlElement(ElementName = "GlobalShipping", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string GlobalShipping { get; set; }
        [XmlElement(ElementName = "InternationalCalculatedShippingDiscount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public InternationalCalculatedShippingDiscount InternationalCalculatedShippingDiscount { get; set; }
        [XmlElement(ElementName = "InternationalFlatShippingDiscount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public InternationalFlatShippingDiscount InternationalFlatShippingDiscount { get; set; }
        [XmlElement(ElementName = "InternationalPromotionalShippingDiscount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string InternationalPromotionalShippingDiscount { get; set; }
        [XmlElement(ElementName = "InternationalShippingDiscountProfileID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string InternationalShippingDiscountProfileID { get; set; }
        [XmlElement(ElementName = "InternationalShippingServiceOption", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public InternationalShippingServiceOption InternationalShippingServiceOption { get; set; }
        [XmlElement(ElementName = "PaymentInstructions", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PaymentInstructions { get; set; }
        [XmlElement(ElementName = "PromotionalShippingDiscount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PromotionalShippingDiscount { get; set; }
        [XmlElement(ElementName = "PromotionalShippingDiscountDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public PromotionalShippingDiscountDetails PromotionalShippingDiscountDetails { get; set; }
        [XmlElement(ElementName = "RateTableDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public RateTableDetails RateTableDetails { get; set; }
        [XmlElement(ElementName = "SalesTax", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public SalesTax SalesTax { get; set; }
        [XmlElement(ElementName = "SellerExcludeShipToLocationsPreference", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SellerExcludeShipToLocationsPreference { get; set; }
        [XmlElement(ElementName = "ShippingDiscountProfileID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingDiscountProfileID { get; set; }
        [XmlElement(ElementName = "ShippingServiceOptions", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ShippingServiceOptions ShippingServiceOptions { get; set; }
        [XmlElement(ElementName = "ShippingType", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingType { get; set; }
        [XmlElement(ElementName = "TaxTable", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public TaxTable TaxTable { get; set; }
    }

    [XmlRoot(ElementName = "PackageDepth", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class PackageDepth
    {
        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }
        [XmlAttribute(AttributeName = "measurementSystem")]
        public string MeasurementSystem { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PackageLength", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class PackageLength
    {
        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }
        [XmlAttribute(AttributeName = "measurementSystem")]
        public string MeasurementSystem { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PackageWidth", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class PackageWidth
    {
        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }
        [XmlAttribute(AttributeName = "measurementSystem")]
        public string MeasurementSystem { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "WeightMajor", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class WeightMajor
    {
        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }
        [XmlAttribute(AttributeName = "measurementSystem")]
        public string MeasurementSystem { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "WeightMinor", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class WeightMinor
    {
        [XmlAttribute(AttributeName = "unit")]
        public string Unit { get; set; }
        [XmlAttribute(AttributeName = "measurementSystem")]
        public string MeasurementSystem { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ShippingPackageDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class ShippingPackageDetails
    {
        [XmlElement(ElementName = "PackageDepth", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public PackageDepth PackageDepth { get; set; }
        [XmlElement(ElementName = "PackageLength", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public PackageLength PackageLength { get; set; }
        [XmlElement(ElementName = "PackageWidth", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public PackageWidth PackageWidth { get; set; }
        [XmlElement(ElementName = "ShippingIrregular", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingIrregular { get; set; }
        [XmlElement(ElementName = "ShippingPackage", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingPackage { get; set; }
        [XmlElement(ElementName = "WeightMajor", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public WeightMajor WeightMajor { get; set; }
        [XmlElement(ElementName = "WeightMinor", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public WeightMinor WeightMinor { get; set; }
    }

    [XmlRoot(ElementName = "StartPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class StartPrice
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public decimal Text { get; set; }
    }

    [XmlRoot(ElementName = "Storefront", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Storefront
    {
        [XmlElement(ElementName = "StoreCategory2ID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string StoreCategory2ID { get; set; }
        [XmlElement(ElementName = "StoreCategoryID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string StoreCategoryID { get; set; }
        [XmlElement(ElementName = "StoreURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string StoreURL { get; set; }
    }

    [XmlRoot(ElementName = "VariationSpecificPictureSet", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class VariationSpecificPictureSet
    {
        [XmlElement(ElementName = "ExtendedPictureDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ExtendedPictureDetails ExtendedPictureDetails { get; set; }
        [XmlElement(ElementName = "ExternalPictureURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ExternalPictureURL { get; set; }
        [XmlElement(ElementName = "PictureURL", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PictureURL { get; set; }
        [XmlElement(ElementName = "VariationSpecificValue", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string VariationSpecificValue { get; set; }
    }

    [XmlRoot(ElementName = "Pictures", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Pictures
    {
        [XmlElement(ElementName = "VariationSpecificName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string VariationSpecificName { get; set; }
        [XmlElement(ElementName = "VariationSpecificPictureSet", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public VariationSpecificPictureSet VariationSpecificPictureSet { get; set; }
    }

    [XmlRoot(ElementName = "VariationProductListingDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class VariationProductListingDetails
    {
        [XmlElement(ElementName = "EAN", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EAN { get; set; }
        [XmlElement(ElementName = "ISBN", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ISBN { get; set; }
        [XmlElement(ElementName = "UPC", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string UPC { get; set; }
    }

    [XmlRoot(ElementName = "VariationSpecifics", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class VariationSpecifics
    {
        [XmlElement(ElementName = "NameValueList", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public NameValueList NameValueList { get; set; }
    }

    [XmlRoot(ElementName = "Variation", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Variation
    {
        [XmlElement(ElementName = "DiscountPriceInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public DiscountPriceInfo DiscountPriceInfo { get; set; }
        [XmlElement(ElementName = "Quantity", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Quantity { get; set; }
        [XmlElement(ElementName = "SellingStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public SellingStatus SellingStatus { get; set; }
        [XmlElement(ElementName = "SKU", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SKU { get; set; }
        [XmlElement(ElementName = "StartPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public StartPrice StartPrice { get; set; }
        [XmlElement(ElementName = "VariationProductListingDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public VariationProductListingDetails VariationProductListingDetails { get; set; }
        [XmlElement(ElementName = "VariationSpecifics", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public VariationSpecifics VariationSpecifics { get; set; }
    }

    [XmlRoot(ElementName = "VariationSpecificsSet", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class VariationSpecificsSet
    {
        [XmlElement(ElementName = "NameValueList", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public NameValueList NameValueList { get; set; }
    }

    [XmlRoot(ElementName = "Variations", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Variations
    {
        [XmlElement(ElementName = "Pictures", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Pictures Pictures { get; set; }
        [XmlElement(ElementName = "Variation", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Variation Variation { get; set; }
        [XmlElement(ElementName = "VariationSpecificsSet", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public VariationSpecificsSet VariationSpecificsSet { get; set; }
    }

    [XmlRoot(ElementName = "Item", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class Item
    {
        [XmlElement(ElementName = "ApplicationData", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ApplicationData { get; set; }
        [XmlElement(ElementName = "ApplyBuyerProtection", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ApplyBuyerProtection ApplyBuyerProtection { get; set; }
        [XmlElement(ElementName = "AutoPay", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string AutoPay { get; set; }
        [XmlElement(ElementName = "AvailableForPickupDropOff", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string AvailableForPickupDropOff { get; set; }
        [XmlElement(ElementName = "BestOfferDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public BestOfferDetails BestOfferDetails { get; set; }
        [XmlElement(ElementName = "BusinessSellerDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public BusinessSellerDetails BusinessSellerDetails { get; set; }
        [XmlElement(ElementName = "BuyerGuaranteePrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public BuyerGuaranteePrice BuyerGuaranteePrice { get; set; }
        [XmlElement(ElementName = "BuyerProtection", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BuyerProtection { get; set; }
        [XmlElement(ElementName = "BuyerRequirementDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public BuyerRequirementDetails BuyerRequirementDetails { get; set; }
        [XmlElement(ElementName = "BuyerResponsibleForShipping", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string BuyerResponsibleForShipping { get; set; }
        [XmlElement(ElementName = "BuyItNowPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public BuyItNowPrice BuyItNowPrice { get; set; }
        [XmlElement(ElementName = "Charity", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Charity Charity { get; set; }
        [XmlElement(ElementName = "ConditionDefinition", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ConditionDefinition { get; set; }
        [XmlElement(ElementName = "ConditionDisplayName", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ConditionDisplayName { get; set; }
        [XmlElement(ElementName = "ConditionID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ConditionID { get; set; }
        [XmlElement(ElementName = "Country", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Country { get; set; }
        [XmlElement(ElementName = "CrossBorderTrade", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CrossBorderTrade { get; set; }
        [XmlElement(ElementName = "Currency", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Currency { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Description { get; set; }
        [XmlElement(ElementName = "DigitalGoodInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public DigitalGoodInfo DigitalGoodInfo { get; set; }
        [XmlElement(ElementName = "DisableBuyerRequirements", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DisableBuyerRequirements { get; set; }
        [XmlElement(ElementName = "DiscountPriceInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public DiscountPriceInfo DiscountPriceInfo { get; set; }
        [XmlElement(ElementName = "DispatchTimeMax", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string DispatchTimeMax { get; set; }
        [XmlElement(ElementName = "eBayNowAvailable", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EBayNowAvailable { get; set; }
        [XmlElement(ElementName = "eBayPlus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EBayPlus { get; set; }
        [XmlElement(ElementName = "eBayPlusEligible", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EBayPlusEligible { get; set; }
        [XmlElement(ElementName = "EligibleForPickupDropOff", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EligibleForPickupDropOff { get; set; }
        [XmlElement(ElementName = "eMailDeliveryAvailable", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string EMailDeliveryAvailable { get; set; }
        [XmlElement(ElementName = "ExtendedSellerContactDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ExtendedSellerContactDetails ExtendedSellerContactDetails { get; set; }
        [XmlElement(ElementName = "FreeAddedCategory", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public FreeAddedCategory FreeAddedCategory { get; set; }
        [XmlElement(ElementName = "HideFromSearch", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public bool HideFromSearch { get; set; }
        [XmlElement(ElementName = "HitCount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string HitCount { get; set; }
        [XmlElement(ElementName = "HitCounter", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string HitCounter { get; set; }
        [XmlElement(ElementName = "IgnoreQuantity", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string IgnoreQuantity { get; set; }
        [XmlElement(ElementName = "IntegratedMerchantCreditCardEnabled", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string IntegratedMerchantCreditCardEnabled { get; set; }
        [XmlElement(ElementName = "InventoryTrackingMethod", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string InventoryTrackingMethod { get; set; }
        [XmlElement(ElementName = "IsIntermediatedShippingEligible", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string IsIntermediatedShippingEligible { get; set; }
        [XmlElement(ElementName = "ItemCompatibilityCount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ItemCompatibilityCount { get; set; }
        [XmlElement(ElementName = "ItemCompatibilityList", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ItemCompatibilityList ItemCompatibilityList { get; set; }
        [XmlElement(ElementName = "ItemID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ItemID { get; set; }
        [XmlElement(ElementName = "ItemPolicyViolation", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ItemPolicyViolation ItemPolicyViolation { get; set; }
        [XmlElement(ElementName = "ItemSpecifics", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ItemSpecifics ItemSpecifics { get; set; }
        [XmlElement(ElementName = "ListingDesigner", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ListingDesigner ListingDesigner { get; set; }
        [XmlElement(ElementName = "ListingDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ListingDetails ListingDetails { get; set; }
        [XmlElement(ElementName = "ListingDuration", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ListingDuration { get; set; }
        [XmlElement(ElementName = "ListingEnhancement", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ListingEnhancement { get; set; }
        [XmlElement(ElementName = "ListingSubtype2", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ListingSubtype2 { get; set; }
        [XmlElement(ElementName = "ListingType", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ListingType { get; set; }
        [XmlElement(ElementName = "LiveAuction", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LiveAuction { get; set; }
        [XmlElement(ElementName = "Location", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Location { get; set; }
        [XmlElement(ElementName = "LocationDefaulted", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LocationDefaulted { get; set; }
        [XmlElement(ElementName = "LotSize", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string LotSize { get; set; }
        [XmlElement(ElementName = "MechanicalCheckAccepted", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string MechanicalCheckAccepted { get; set; }
        [XmlElement(ElementName = "MotorsGermanySearchable", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string MotorsGermanySearchable { get; set; }
        [XmlElement(ElementName = "PaymentAllowedSite", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PaymentAllowedSite { get; set; }
        [XmlElement(ElementName = "PaymentDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public PaymentDetails PaymentDetails { get; set; }
        [XmlElement(ElementName = "PaymentMethods", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PaymentMethods { get; set; }
        [XmlElement(ElementName = "PayPalEmailAddress", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PayPalEmailAddress { get; set; }
        [XmlElement(ElementName = "PickupInStoreDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public PickupInStoreDetails PickupInStoreDetails { get; set; }
        [XmlElement(ElementName = "PictureDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public PictureDetails PictureDetails { get; set; }
        [XmlElement(ElementName = "PostalCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "PrimaryCategory", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public PrimaryCategory PrimaryCategory { get; set; }
        [XmlElement(ElementName = "PrivateListing", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string PrivateListing { get; set; }
        [XmlElement(ElementName = "ProductListingDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ProductListingDetails ProductListingDetails { get; set; }
        [XmlElement(ElementName = "ProxyItem", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ProxyItem { get; set; }
        [XmlElement(ElementName = "Quantity", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public int Quantity { get; set; }
        [XmlElement(ElementName = "QuantityAvailableHint", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string QuantityAvailableHint { get; set; }
        [XmlElement(ElementName = "QuantityInfo", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public QuantityInfo QuantityInfo { get; set; }
        [XmlElement(ElementName = "QuantityThreshold", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string QuantityThreshold { get; set; }
        [XmlElement(ElementName = "ReasonHideFromSearch", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ReasonHideFromSearch { get; set; }
        [XmlElement(ElementName = "RelistParentID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string RelistParentID { get; set; }
        [XmlElement(ElementName = "ReservePrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ReservePrice ReservePrice { get; set; }
        [XmlElement(ElementName = "ReturnPolicy", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ReturnPolicy ReturnPolicy { get; set; }
        [XmlElement(ElementName = "ReviseStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ReviseStatus ReviseStatus { get; set; }
        [XmlElement(ElementName = "SecondaryCategory", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public SecondaryCategory SecondaryCategory { get; set; }
        [XmlElement(ElementName = "Seller", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Seller Seller { get; set; }
        [XmlElement(ElementName = "SellerContactDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public SellerContactDetails SellerContactDetails { get; set; }
        [XmlElement(ElementName = "SellerProfiles", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public SellerProfiles SellerProfiles { get; set; }
        [XmlElement(ElementName = "SellerVacationNote", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SellerVacationNote { get; set; }
        [XmlElement(ElementName = "SellingStatus", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public SellingStatus SellingStatus { get; set; }
        [XmlElement(ElementName = "ShippingDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ShippingDetails ShippingDetails { get; set; }
        [XmlElement(ElementName = "ShippingPackageDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public ShippingPackageDetails ShippingPackageDetails { get; set; }
        [XmlElement(ElementName = "ShippingServiceCostOverrideList", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingServiceCostOverrideList { get; set; }
        [XmlElement(ElementName = "ShippingTermsInDescription", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShippingTermsInDescription { get; set; }
        [XmlElement(ElementName = "ShipToLocations", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string ShipToLocations { get; set; }
        [XmlElement(ElementName = "Site", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Site { get; set; }
        [XmlElement(ElementName = "SKU", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SKU { get; set; }
        [XmlElement(ElementName = "StartPrice", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public StartPrice StartPrice { get; set; }
        [XmlElement(ElementName = "Storefront", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Storefront Storefront { get; set; }
        [XmlElement(ElementName = "SubTitle", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string SubTitle { get; set; }
        [XmlElement(ElementName = "TaxCategory", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string TaxCategory { get; set; }
        [XmlElement(ElementName = "TimeLeft", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string TimeLeft { get; set; }
        [XmlElement(ElementName = "Title", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Title { get; set; }
        [XmlElement(ElementName = "TopRatedListing", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string TopRatedListing { get; set; }
        [XmlElement(ElementName = "UUID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string UUID { get; set; }
        [XmlElement(ElementName = "Variations", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Variations Variations { get; set; }
        [XmlElement(ElementName = "VATDetails", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public VATDetails VATDetails { get; set; }
        [XmlElement(ElementName = "WatchCount", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string WatchCount { get; set; }
    }
    //[XmlRoot(ElementName = "ErrorParameters", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //public class ErrorParameters
    //{
    //    [XmlElement(ElementName = "Value", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //    public string Value { get; set; }
    //    [XmlAttribute(AttributeName = "ParamID")]
    //    public string ParamID { get; set; }
    //}

    //[XmlRoot(ElementName = "Errors", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //public class Errors
    //{
    //    [XmlElement(ElementName = "ErrorClassification", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //    public string ErrorClassification { get; set; }
    //    [XmlElement(ElementName = "ErrorCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //    public string ErrorCode { get; set; }
    //    [XmlElement(ElementName = "ErrorParameters", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //    public ErrorParameters ErrorParameters { get; set; }
    //    [XmlElement(ElementName = "LongMessage", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //    public string LongMessage { get; set; }
    //    [XmlElement(ElementName = "SeverityCode", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //    public string SeverityCode { get; set; }
    //    [XmlElement(ElementName = "ShortMessage", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    //    public string ShortMessage { get; set; }
    //}

    [XmlRoot(ElementName = "GetItemResponse", Namespace = "urn:ebay:apis:eBLBaseComponents")]
    public class GetItemResponse
    {
        [XmlElement(ElementName = "Item", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Item Item { get; set; }
        [XmlElement(ElementName = "Ack", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Ack { get; set; }
        [XmlElement(ElementName = "Build", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Build { get; set; }
        [XmlElement(ElementName = "CorrelationID", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string CorrelationID { get; set; }
        [XmlElement(ElementName = "Errors", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public Errors Errors { get; set; }
        [XmlElement(ElementName = "HardExpirationWarning", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string HardExpirationWarning { get; set; }
        [XmlElement(ElementName = "Timestamp", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Timestamp { get; set; }
        [XmlElement(ElementName = "Version", Namespace = "urn:ebay:apis:eBLBaseComponents")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}

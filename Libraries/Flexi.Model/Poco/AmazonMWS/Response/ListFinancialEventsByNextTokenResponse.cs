using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Report.Response
{
    [XmlRoot(ElementName = "ListFinancialEventsByNextTokenResponse", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    public class ListFinancialEventsByNextTokenResponse
    {
        [XmlElement(ElementName = "ListFinancialEventsByNextTokenResult", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
        public ListFinancialEventsByNextTokenResult ListFinancialEventsByNextTokenResult { get; set; }
        [XmlElement(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
        public ResponseMetadata ResponseMetadata { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "ListFinancialEventsByNextTokenResult", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    public class ListFinancialEventsByNextTokenResult
    {
        [XmlElement(ElementName = "NextToken", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
        public string NextToken { get; set; }
        [XmlElement(ElementName = "FinancialEvents", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
        public FinancialEvents FinancialEvents { get; set; }
    }

    //[XmlRoot(ElementName = "ChargeAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class ChargeAmount
    //{
    //    [XmlElement(ElementName = "CurrencyAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyAmount { get; set; }
    //    [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyCode { get; set; }
    //}

    //[XmlRoot(ElementName = "ChargeComponent", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class ChargeComponent
    //{
    //    [XmlElement(ElementName = "ChargeType", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string ChargeType { get; set; }
    //    [XmlElement(ElementName = "ChargeAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public ChargeAmount ChargeAmount { get; set; }
    //}

    //[XmlRoot(ElementName = "ItemChargeList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class ItemChargeList
    //{
    //    [XmlElement(ElementName = "ChargeComponent", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public List<ChargeComponent> ChargeComponent { get; set; }
    //}

    //[XmlRoot(ElementName = "FeeAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class FeeAmount
    //{
    //    [XmlElement(ElementName = "CurrencyAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyAmount { get; set; }
    //    [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyCode { get; set; }
    //}

    //[XmlRoot(ElementName = "FeeComponent", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class FeeComponent
    //{
    //    [XmlElement(ElementName = "FeeType", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string FeeType { get; set; }
    //    [XmlElement(ElementName = "FeeAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public FeeAmount FeeAmount { get; set; }
    //}

    //[XmlRoot(ElementName = "ItemFeeList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class ItemFeeList
    //{
    //    [XmlElement(ElementName = "FeeComponent", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public List<FeeComponent> FeeComponent { get; set; }
    //}

    //[XmlRoot(ElementName = "ShipmentItem", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class ShipmentItem
    //{
    //    [XmlElement(ElementName = "ItemChargeList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public ItemChargeList ItemChargeList { get; set; }
    //    [XmlElement(ElementName = "ItemFeeList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public ItemFeeList ItemFeeList { get; set; }
    //    [XmlElement(ElementName = "OrderItemId", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string OrderItemId { get; set; }
    //    [XmlElement(ElementName = "QuantityShipped", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string QuantityShipped { get; set; }
    //    [XmlElement(ElementName = "SellerSKU", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string SellerSKU { get; set; }
    //    [XmlElement(ElementName = "PromotionList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public PromotionList PromotionList { get; set; }
    //}

    //[XmlRoot(ElementName = "ShipmentItemList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class ShipmentItemList
    //{
    //    [XmlElement(ElementName = "ShipmentItem", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public List<ShipmentItem> ShipmentItem { get; set; }
    //}

    //[XmlRoot(ElementName = "ShipmentEvent", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class ShipmentEvent
    //{
    //    [XmlElement(ElementName = "ShipmentItemList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public ShipmentItemList ShipmentItemList { get; set; }
    //    [XmlElement(ElementName = "AmazonOrderId", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string AmazonOrderId { get; set; }
    //    [XmlElement(ElementName = "PostedDate", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string PostedDate { get; set; }
    //    [XmlElement(ElementName = "MarketplaceName", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string MarketplaceName { get; set; }
    //    [XmlElement(ElementName = "SellerOrderId", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string SellerOrderId { get; set; }
    //}

    //[XmlRoot(ElementName = "PromotionAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class PromotionAmount
    //{
    //    [XmlElement(ElementName = "CurrencyAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyAmount { get; set; }
    //    [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyCode { get; set; }
    //}

    //[XmlRoot(ElementName = "Promotion", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class Promotion
    //{
    //    [XmlElement(ElementName = "PromotionType", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string PromotionType { get; set; }
    //    [XmlElement(ElementName = "PromotionAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public PromotionAmount PromotionAmount { get; set; }
    //    [XmlElement(ElementName = "PromotionId", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string PromotionId { get; set; }
    //}

    //[XmlRoot(ElementName = "PromotionList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class PromotionList
    //{
    //    [XmlElement(ElementName = "Promotion", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public List<Promotion> Promotion { get; set; }
    //}

    //[XmlRoot(ElementName = "ShipmentEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class ShipmentEventList
    //{
    //    [XmlElement(ElementName = "ShipmentEvent", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public List<ShipmentEvent> ShipmentEvent { get; set; }
    //}

    //[XmlRoot(ElementName = "PerUnitAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class PerUnitAmount
    //{
    //    [XmlElement(ElementName = "CurrencyAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyAmount { get; set; }
    //    [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyCode { get; set; }
    //}

    //[XmlRoot(ElementName = "TotalAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class TotalAmount
    //{
    //    [XmlElement(ElementName = "CurrencyAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyAmount { get; set; }
    //    [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyCode { get; set; }
    //}

    //[XmlRoot(ElementName = "AdjustmentItem", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class AdjustmentItem
    //{
    //    [XmlElement(ElementName = "PerUnitAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public PerUnitAmount PerUnitAmount { get; set; }
    //    [XmlElement(ElementName = "TotalAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public TotalAmount TotalAmount { get; set; }
    //    [XmlElement(ElementName = "Quantity", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string Quantity { get; set; }
    //    [XmlElement(ElementName = "SellerSKU", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string SellerSKU { get; set; }
    //    [XmlElement(ElementName = "ProductDescription", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string ProductDescription { get; set; }
    //}

    //[XmlRoot(ElementName = "AdjustmentItemList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class AdjustmentItemList
    //{
    //    [XmlElement(ElementName = "AdjustmentItem", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public AdjustmentItem AdjustmentItem { get; set; }
    //}

    //[XmlRoot(ElementName = "AdjustmentAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class AdjustmentAmount
    //{
    //    [XmlElement(ElementName = "CurrencyAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyAmount { get; set; }
    //    [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CurrencyCode { get; set; }
    //}

    //[XmlRoot(ElementName = "AdjustmentEvent", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class AdjustmentEvent
    //{
    //    [XmlElement(ElementName = "AdjustmentItemList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public AdjustmentItemList AdjustmentItemList { get; set; }
    //    [XmlElement(ElementName = "AdjustmentAmount", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public AdjustmentAmount AdjustmentAmount { get; set; }
    //    [XmlElement(ElementName = "AdjustmentType", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string AdjustmentType { get; set; }
    //    [XmlElement(ElementName = "PostedDate", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string PostedDate { get; set; }
    //}

    //[XmlRoot(ElementName = "AdjustmentEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class AdjustmentEventList
    //{
    //    [XmlElement(ElementName = "AdjustmentEvent", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public AdjustmentEvent AdjustmentEvent { get; set; }
    //}

    //[XmlRoot(ElementName = "FinancialEvents", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class FinancialEvents
    //{
    //    [XmlElement(ElementName = "ProductAdsPaymentEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string ProductAdsPaymentEventList { get; set; }
    //    [XmlElement(ElementName = "RentalTransactionEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string RentalTransactionEventList { get; set; }
    //    [XmlElement(ElementName = "PayWithAmazonEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string PayWithAmazonEventList { get; set; }
    //    [XmlElement(ElementName = "ServiceFeeEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string ServiceFeeEventList { get; set; }
    //    [XmlElement(ElementName = "CouponPaymentEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string CouponPaymentEventList { get; set; }
    //    [XmlElement(ElementName = "ServiceProviderCreditEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string ServiceProviderCreditEventList { get; set; }
    //    [XmlElement(ElementName = "SellerDealPaymentEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string SellerDealPaymentEventList { get; set; }
    //    [XmlElement(ElementName = "SellerReviewEnrollmentPaymentEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string SellerReviewEnrollmentPaymentEventList { get; set; }
    //    [XmlElement(ElementName = "DebtRecoveryEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string DebtRecoveryEventList { get; set; }
    //    [XmlElement(ElementName = "ShipmentEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public ShipmentEventList ShipmentEventList { get; set; }
    //    [XmlElement(ElementName = "RetrochargeEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string RetrochargeEventList { get; set; }
    //    [XmlElement(ElementName = "SAFETReimbursementEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string SAFETReimbursementEventList { get; set; }
    //    [XmlElement(ElementName = "GuaranteeClaimEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string GuaranteeClaimEventList { get; set; }
    //    [XmlElement(ElementName = "ChargebackEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string ChargebackEventList { get; set; }
    //    [XmlElement(ElementName = "FBALiquidationEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string FBALiquidationEventList { get; set; }
    //    [XmlElement(ElementName = "LoanServicingEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string LoanServicingEventList { get; set; }
    //    [XmlElement(ElementName = "RefundEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string RefundEventList { get; set; }
    //    [XmlElement(ElementName = "AdjustmentEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public AdjustmentEventList AdjustmentEventList { get; set; }
    //    [XmlElement(ElementName = "PerformanceBondRefundEventList", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string PerformanceBondRefundEventList { get; set; }
    //}



    //[XmlRoot(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //public class ResponseMetadata
    //{
    //    [XmlElement(ElementName = "RequestId", Namespace = "http://mws.amazonservices.com/Finances/2015-05-01")]
    //    public string RequestId { get; set; }
    //}

}

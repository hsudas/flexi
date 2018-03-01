using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{

    [XmlRoot(ElementName = "TotalFeesEstimate", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class TotalFeesEstimate
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string Amount { get; set; }
    }

    [XmlRoot(ElementName = "FinalFee", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class FinalFee
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public decimal Amount { get; set; }
    }

    [XmlRoot(ElementName = "FeePromotion", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class FeePromotion
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public decimal Amount { get; set; }
    }

    [XmlRoot(ElementName = "FeeDetail", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class FeeDetail
    {
        [XmlElement(ElementName = "FeeAmount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Flexi.Model.Poco.AmazonMWS.Response2.FeeAmount FeeAmount { get; set; }
        [XmlElement(ElementName = "FinalFee", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public FinalFee FinalFee { get; set; }
        [XmlElement(ElementName = "FeePromotion", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public FeePromotion FeePromotion { get; set; }
        [XmlElement(ElementName = "FeeType", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string FeeType { get; set; }
        [XmlElement(ElementName = "IncludedFeeDetailList", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public FeeDetailList IncludedFeeDetailList { get; set; }
    }

    [XmlRoot(ElementName = "IncludedFeeDetailList", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class IncludedFeeDetailList
    {
        [XmlElement(ElementName = "FeeDetail", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public List<FeeDetail> FeeDetail { get; set; }
    }

    [XmlRoot(ElementName = "FeeDetailList", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class FeeDetailList
    {
        [XmlElement(ElementName = "FeeDetail", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public List<FeeDetail> FeeDetail { get; set; }
    }

    [XmlRoot(ElementName = "FeesEstimate", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class FeesEstimate
    {
        [XmlElement(ElementName = "TotalFeesEstimate", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public TotalFeesEstimate TotalFeesEstimate { get; set; }
        [XmlElement(ElementName = "TimeOfFeesEstimation", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string TimeOfFeesEstimation { get; set; }
        [XmlElement(ElementName = "FeeDetailList", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public FeeDetailList FeeDetailList { get; set; }
    }

    [XmlRoot(ElementName = "ListingPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class ListingPrice
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public decimal Amount { get; set; }
    }

    [XmlRoot(ElementName = "Points", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class Points
    {
        [XmlElement(ElementName = "PointsNumber", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string PointsNumber { get; set; }
    }

    [XmlRoot(ElementName = "PriceToEstimateFees", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class PriceToEstimateFees
    {
        [XmlElement(ElementName = "ListingPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public ListingPrice ListingPrice { get; set; }
        [XmlElement(ElementName = "Points", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Points Points { get; set; }
    }

    [XmlRoot(ElementName = "FeesEstimateIdentifier", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class FeesEstimateIdentifier
    {
        [XmlElement(ElementName = "MarketplaceId", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string MarketplaceId { get; set; }
        [XmlElement(ElementName = "IdType", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string IdType { get; set; }
        [XmlElement(ElementName = "SellerId", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string SellerId { get; set; }
        [XmlElement(ElementName = "IsAmazonFulfilled", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string IsAmazonFulfilled { get; set; }
        [XmlElement(ElementName = "SellerInputIdentifier", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string SellerInputIdentifier { get; set; }
        [XmlElement(ElementName = "IdValue", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string IdValue { get; set; }
        [XmlElement(ElementName = "PriceToEstimateFees", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public PriceToEstimateFees PriceToEstimateFees { get; set; }
    }

    [XmlRoot(ElementName = "FeesEstimateResult", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class FeesEstimateResult
    {
        [XmlElement(ElementName = "FeesEstimate", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public FeesEstimate FeesEstimate { get; set; }
        [XmlElement(ElementName = "FeesEstimateIdentifier", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public FeesEstimateIdentifier FeesEstimateIdentifier { get; set; }
        [XmlElement(ElementName = "Status", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string Status { get; set; }
        [XmlElement(ElementName = "Error", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Error Error { get; set; }
    }

    [XmlRoot(ElementName = "Error", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class Error
    {
        [XmlElement(ElementName = "Code", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string Code { get; set; }
        [XmlElement(ElementName = "Message", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string Message { get; set; }
        [XmlElement(ElementName = "Type", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "FeesEstimateResultList", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class FeesEstimateResultList
    {
        [XmlElement(ElementName = "FeesEstimateResult", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public List<FeesEstimateResult> FeesEstimateResult { get; set; }
    }

    [XmlRoot(ElementName = "GetMyFeesEstimateResult", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class GetMyFeesEstimateResult
    {
        [XmlElement(ElementName = "FeesEstimateResultList", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public FeesEstimateResultList FeesEstimateResultList { get; set; }
    }

    //[XmlRoot(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //public class ResponseMetadata
    //{
    //    [XmlElement(ElementName = "RequestId", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //    public string RequestId { get; set; }
    //}

    [XmlRoot(ElementName = "GetMyFeesEstimateResponse", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class GetMyFeesEstimateResponse
    {
        [XmlElement(ElementName = "GetMyFeesEstimateResult", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public GetMyFeesEstimateResult GetMyFeesEstimateResult { get; set; }
        [XmlElement(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public ResponseMetadata ResponseMetadata { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    //[XmlRoot(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //public class ResponseMetadata
    //{
    //    [XmlElement(ElementName = "RequestId", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //    public string RequestId { get; set; }
    //}

}

namespace Flexi.Model.Poco.AmazonMWS.Response2
{
    [XmlRoot(ElementName = "FeeAmount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class FeeAmount
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string Amount { get; set; }
    }
}

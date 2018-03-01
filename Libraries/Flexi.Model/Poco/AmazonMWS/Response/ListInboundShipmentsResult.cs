using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{

    [XmlRoot(ElementName = "ListInboundShipmentsResponse", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class ListInboundShipmentsResponse
    {
        [XmlElement(ElementName = "ListInboundShipmentsResult", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public ListInboundShipmentsResult ListInboundShipmentsResult { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "ShipFromAddress", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class ShipFromAddress
    {
        [XmlElement(ElementName = "PostalCode", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string Name { get; set; }
        [XmlElement(ElementName = "CountryCode", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string CountryCode { get; set; }
        [XmlElement(ElementName = "StateOrProvinceCode", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string StateOrProvinceCode { get; set; }
        [XmlElement(ElementName = "AddressLine1", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string AddressLine1 { get; set; }
        [XmlElement(ElementName = "City", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string City { get; set; }
    }

    [XmlRoot(ElementName = "member", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class Member2
    {
        [XmlElement(ElementName = "ShipFromAddress", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public ShipFromAddress ShipFromAddress { get; set; }
        [XmlElement(ElementName = "ShipmentId", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string ShipmentId { get; set; }
        [XmlElement(ElementName = "ShipmentName", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string ShipmentName { get; set; }
        [XmlElement(ElementName = "ShipmentStatus", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string ShipmentStatus { get; set; }
        [XmlElement(ElementName = "LabelPrepType", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string LabelPrepType { get; set; }
        [XmlElement(ElementName = "DestinationFulfillmentCenterId", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string DestinationFulfillmentCenterId { get; set; }
        [XmlElement(ElementName = "BoxContentsSource", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string BoxContentsSource { get; set; }
        [XmlElement(ElementName = "EstimatedBoxContentsFee", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public EstimatedBoxContentsFee EstimatedBoxContentsFee { get; set; }
    }

    [XmlRoot(ElementName = "FeePerUnit", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class FeePerUnit
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "Value", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "TotalFee", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class TotalFee
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "Value", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public decimal? Value { get; set; }
    }

    [XmlRoot(ElementName = "EstimatedBoxContentsFee", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class EstimatedBoxContentsFee
    {
        [XmlElement(ElementName = "TotalUnits", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public int? TotalUnits { get; set; }
        [XmlElement(ElementName = "FeePerUnit", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public FeePerUnit FeePerUnit { get; set; }
        [XmlElement(ElementName = "TotalFee", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public TotalFee TotalFee { get; set; }
    }

    [XmlRoot(ElementName = "ShipmentData", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class ShipmentData
    {
        [XmlElement(ElementName = "member", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public List<Member2> Member { get; set; }
    }

    [XmlRoot(ElementName = "ListInboundShipmentsResult", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class ListInboundShipmentsResult
    {
        [XmlElement(ElementName = "ShipmentData", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public ShipmentData ShipmentData { get; set; }
    }

    //[XmlRoot(ElementName = "ShipFromAddress", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //public class ShipFromAddress
    //{
    //    [XmlElement(ElementName = "City", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string City { get; set; }
    //    [XmlElement(ElementName = "CountryCode", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string CountryCode { get; set; }
    //    [XmlElement(ElementName = "PostalCode", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string PostalCode { get; set; }
    //    [XmlElement(ElementName = "Name", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string Name { get; set; }
    //    [XmlElement(ElementName = "AddressLine1", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string AddressLine1 { get; set; }
    //    [XmlElement(ElementName = "StateOrProvinceCode", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string StateOrProvinceCode { get; set; }
    //}

    //[XmlRoot(ElementName = "member", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //public class Member2
    //{
    //    [XmlElement(ElementName = "DestinationFulfillmentCenterId", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string DestinationFulfillmentCenterId { get; set; }
    //    [XmlElement(ElementName = "LabelPrepType", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string LabelPrepType { get; set; }
    //    [XmlElement(ElementName = "ShipFromAddress", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public ShipFromAddress ShipFromAddress { get; set; }
    //    [XmlElement(ElementName = "ShipmentId", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string ShipmentId { get; set; }
    //    [XmlElement(ElementName = "AreCasesRequired", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string AreCasesRequired { get; set; }
    //    [XmlElement(ElementName = "ShipmentName", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string ShipmentName { get; set; }
    //    [XmlElement(ElementName = "BoxContentsSource", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string BoxContentsSource { get; set; }
    //    [XmlElement(ElementName = "ShipmentStatus", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string ShipmentStatus { get; set; }
    //}

    //[XmlRoot(ElementName = "ShipmentData", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //public class ShipmentData
    //{
    //    [XmlElement(ElementName = "member", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public Member2 Member { get; set; }
    //}

    //[XmlRoot(ElementName = "ListInboundShipmentsResult", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //public class ListInboundShipmentsResult
    //{
    //    [XmlElement(ElementName = "ShipmentData", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public ShipmentData ShipmentData { get; set; }
    //}

    ////[XmlRoot(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    ////public class ResponseMetadata
    ////{
    ////    [XmlElement(ElementName = "RequestId", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    ////    public string RequestId { get; set; }
    ////}

    //[XmlRoot(ElementName = "ListInboundShipmentsResponse", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //public class ListInboundShipmentsResponse
    //{
    //    [XmlElement(ElementName = "ListInboundShipmentsResult", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public ListInboundShipmentsResult ListInboundShipmentsResult { get; set; }
    //    [XmlElement(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public ResponseMetadata ResponseMetadata { get; set; }
    //    [XmlAttribute(AttributeName = "xmlns")]
    //    public string Xmlns { get; set; }
    //}
}

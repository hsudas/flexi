using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{
    [XmlRoot(ElementName = "PrepDetails", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class PrepDetails
    {
        [XmlElement(ElementName = "PrepOwner", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string PrepOwner { get; set; }
        [XmlElement(ElementName = "PrepInstruction", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string PrepInstruction { get; set; }
    }

    [XmlRoot(ElementName = "PrepDetailsList", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class PrepDetailsList
    {
        [XmlElement(ElementName = "PrepDetails", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public List<PrepDetails> PrepDetails { get; set; }
    }

    [XmlRoot(ElementName = "member", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class Member3
    {
        [XmlElement(ElementName = "QuantityShipped", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public int? QuantityShipped { get; set; }
        [XmlElement(ElementName = "ShipmentId", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string ShipmentId { get; set; }
        [XmlElement(ElementName = "PrepDetailsList", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public PrepDetailsList PrepDetailsList { get; set; }
        [XmlElement(ElementName = "FulfillmentNetworkSKU", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string FulfillmentNetworkSKU { get; set; }
        [XmlElement(ElementName = "SellerSKU", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string SellerSKU { get; set; }
        [XmlElement(ElementName = "QuantityReceived", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public int? QuantityReceived { get; set; }
        [XmlElement(ElementName = "QuantityInCase", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public int? QuantityInCase { get; set; }
        [XmlElement(ElementName = "ReleaseDate", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string ReleaseDate { get; set; }
    }

    [XmlRoot(ElementName = "ItemData", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class ItemData
    {
        [XmlElement(ElementName = "member", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public List<Member3> Member { get; set; }
    }

    [XmlRoot(ElementName = "ListInboundShipmentItemsResult", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class ListInboundShipmentItemsResult
    {
        [XmlElement(ElementName = "ItemData", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public ItemData ItemData { get; set; }
        [XmlElement(ElementName = "NextToken", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string NextToken { get; set; }
    }

    //[XmlRoot(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //public class ResponseMetadata
    //{
    //    [XmlElement(ElementName = "RequestId", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    //    public string RequestId { get; set; }
    //}

    [XmlRoot(ElementName = "ListInboundShipmentItemsResponse", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class ListInboundShipmentItemsResponse
    {
        [XmlElement(ElementName = "ListInboundShipmentItemsResult", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public ListInboundShipmentItemsResult ListInboundShipmentItemsResult { get; set; }
        [XmlElement(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public ResponseMetadata ResponseMetadata { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}

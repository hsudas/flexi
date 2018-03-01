using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{
    [XmlRoot(ElementName = "TransportHeader", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class TransportHeader
    {
        [XmlElement(ElementName = "SellerId", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string SellerId { get; set; }
        [XmlElement(ElementName = "IsPartnered", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string IsPartnered { get; set; }
        [XmlElement(ElementName = "ShipmentId", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string ShipmentId { get; set; }
        [XmlElement(ElementName = "ShipmentType", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string ShipmentType { get; set; }
    }

    [XmlRoot(ElementName = "TransportResult", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class TransportResult
    {
        [XmlElement(ElementName = "TransportStatus", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string TransportStatus { get; set; }
    }

    [XmlRoot(ElementName = "Amount", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class Amount
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "Value", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public decimal Value { get; set; }
    }

    [XmlRoot(ElementName = "PartneredEstimate", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class PartneredEstimate
    {
        [XmlElement(ElementName = "Amount", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public Amount Amount { get; set; }
    }

    [XmlRoot(ElementName = "Weight", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class Weight2
    {
        [XmlElement(ElementName = "Value", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public decimal Value { get; set; }
        [XmlElement(ElementName = "Unit", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string Unit { get; set; }
    }

    [XmlRoot(ElementName = "Dimensions", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class Dimensions
    {
        [XmlElement(ElementName = "Width", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public decimal Width { get; set; }
        [XmlElement(ElementName = "Length", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public decimal Length { get; set; }
        [XmlElement(ElementName = "Unit", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string Unit { get; set; }
        [XmlElement(ElementName = "Height", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public decimal Height { get; set; }
    }

    [XmlRoot(ElementName = "member", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class Member4
    {
        [XmlElement(ElementName = "IsStacked", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string IsStacked { get; set; }
        [XmlElement(ElementName = "Weight", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public Weight Weight { get; set; }
        [XmlElement(ElementName = "Dimensions", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public Dimensions Dimensions { get; set; }
    }

    [XmlRoot(ElementName = "PalletList", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class PalletList
    {
        [XmlElement(ElementName = "member", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public List<Member4> Member { get; set; }
    }

    [XmlRoot(ElementName = "Contact", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class Contact
    {
        [XmlElement(ElementName = "Name", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Phone", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string Phone { get; set; }
        [XmlElement(ElementName = "Email", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string Email { get; set; }
    }

    [XmlRoot(ElementName = "TotalWeight", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class TotalWeight
    {
        [XmlElement(ElementName = "Value", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public decimal Value { get; set; }
        [XmlElement(ElementName = "Unit", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string Unit { get; set; }
    }

    [XmlRoot(ElementName = "AmazonCalculatedValue", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class AmazonCalculatedValue
    {
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string CurrencyCode { get; set; }
        [XmlElement(ElementName = "Value", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public decimal Value { get; set; }
    }

    [XmlRoot(ElementName = "PartneredLtlData", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class PartneredLtlData
    {
        [XmlElement(ElementName = "IsBillOfLadingAvailable", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string IsBillOfLadingAvailable { get; set; }
        [XmlElement(ElementName = "FreightReadyDate", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string FreightReadyDate { get; set; }
        [XmlElement(ElementName = "AmazonReferenceId", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string AmazonReferenceId { get; set; }
        [XmlElement(ElementName = "PreviewFreightClass", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string PreviewFreightClass { get; set; }
        [XmlElement(ElementName = "PreviewPickupDate", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string PreviewPickupDate { get; set; }
        [XmlElement(ElementName = "PartneredEstimate", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public PartneredEstimate PartneredEstimate { get; set; }
        [XmlElement(ElementName = "PalletList", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public PalletList PalletList { get; set; }
        [XmlElement(ElementName = "BoxCount", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string BoxCount { get; set; }
        [XmlElement(ElementName = "Contact", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public Contact Contact { get; set; }
        [XmlElement(ElementName = "TotalWeight", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public TotalWeight TotalWeight { get; set; }
        [XmlElement(ElementName = "PreviewDeliveryDate", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public string PreviewDeliveryDate { get; set; }
        [XmlElement(ElementName = "AmazonCalculatedValue", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public AmazonCalculatedValue AmazonCalculatedValue { get; set; }
    }

    [XmlRoot(ElementName = "TransportDetails", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class TransportDetails
    {
        [XmlElement(ElementName = "PartneredLtlData", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public PartneredLtlData PartneredLtlData { get; set; }
    }

    [XmlRoot(ElementName = "TransportContent", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class TransportContent
    {
        [XmlElement(ElementName = "TransportHeader", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public TransportHeader TransportHeader { get; set; }
        [XmlElement(ElementName = "TransportResult", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public TransportResult TransportResult { get; set; }
        [XmlElement(ElementName = "TransportDetails", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public TransportDetails TransportDetails { get; set; }
    }

    [XmlRoot(ElementName = "GetTransportContentResult", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class GetTransportContentResult
    {
        [XmlElement(ElementName = "TransportContent", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public TransportContent TransportContent { get; set; }
    }

    [XmlRoot(ElementName = "GetTransportContentResponse", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
    public class GetTransportContentResponse
    {
        [XmlElement(ElementName = "GetTransportContentResult", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public GetTransportContentResult GetTransportContentResult { get; set; }
        [XmlElement(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonaws.com/FulfillmentInboundShipment/2010-10-01/")]
        public ResponseMetadata ResponseMetadata { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{
    [XmlRoot(ElementName = "ListInventorySupplyResponse", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    public class ListInventorySupplyResponse
    {
        [XmlElement(ElementName = "ListInventorySupplyResult", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public ListInventorySupplyResult ListInventorySupplyResult { get; set; }
        [XmlElement(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public ResponseMetadata ResponseMetadata { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "member", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    public class Member
    {
        [XmlElement(ElementName = "TotalSupplyQuantity", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public int TotalSupplyQuantity { get; set; }
        [XmlElement(ElementName = "InStockSupplyQuantity", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public int InStockSupplyQuantity { get; set; }
        [XmlElement(ElementName = "SellerSKU", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public string SellerSKU { get; set; }
        [XmlElement(ElementName = "Condition", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public string Condition { get; set; }
        [XmlElement(ElementName = "SupplyDetail", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public string SupplyDetail { get; set; }
        [XmlElement(ElementName = "EarliestAvailability", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public EarliestAvailability EarliestAvailability { get; set; }
        [XmlElement(ElementName = "FNSKU", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public string FNSKU { get; set; }
        [XmlElement(ElementName = "ASIN", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public string ASIN { get; set; }
    }

    [XmlRoot(ElementName = "EarliestAvailability", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    public class EarliestAvailability
    {
        [XmlElement(ElementName = "TimepointType", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public string TimepointType { get; set; }
    }

    [XmlRoot(ElementName = "InventorySupplyList", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    public class InventorySupplyList
    {
        [XmlElement(ElementName = "member", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public List<Member> Member { get; set; }
    }

    [XmlRoot(ElementName = "ListInventorySupplyResult", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    public class ListInventorySupplyResult
    {
        [XmlElement(ElementName = "MarketplaceId", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public string MarketplaceId { get; set; }
        [XmlElement(ElementName = "InventorySupplyList", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
        public InventorySupplyList InventorySupplyList { get; set; }
    }

    //[XmlRoot(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    //public class ResponseMetadata
    //{
    //    [XmlElement(ElementName = "RequestId", Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    //    public string RequestId { get; set; }
    //}
}

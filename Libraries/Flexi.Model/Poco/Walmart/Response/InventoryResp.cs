using System.Xml.Serialization;

namespace Flexi.Model.Poco.Walmart.Response
{
    [XmlRoot(ElementName = "inventory", Namespace = "http://walmart.com/")]
    public class Inventory
    {
        [XmlElement(ElementName = "sku", Namespace = "http://walmart.com/")]
        public string Sku { get; set; }
        [XmlElement(ElementName = "quantity", Namespace = "http://walmart.com/")]
        public Quantity Quantity { get; set; }
        [XmlElement(ElementName = "fulfillmentLagTime", Namespace = "http://walmart.com/")]
        public string FulfillmentLagTime { get; set; }
        [XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns2 { get; set; }
    }


    [XmlRoot(ElementName = "quantity", Namespace = "http://walmart.com/")]
    public class Quantity
    {
        [XmlElement(ElementName = "unit", Namespace = "http://walmart.com/")]
        public string Unit { get; set; }
        [XmlElement(ElementName = "amount", Namespace = "http://walmart.com/")]
        public string Amount { get; set; }
    }
}

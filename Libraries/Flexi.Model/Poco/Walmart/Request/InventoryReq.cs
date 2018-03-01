using System.Xml.Serialization;

namespace Flexi.Model.Poco.Walmart.Request
{

    [XmlRoot(ElementName = "inventory", Namespace = "http://walmart.com/")]
    public class Inventory
    {
        [XmlElement(ElementName = "sku", Namespace = "http://walmart.com/")]
        public string Sku { get; set; }
        [XmlElement(ElementName = "quantity", Namespace = "http://walmart.com/")]
        public Quantity Quantity { get; set; }
        [XmlElement(ElementName = "fulfillmentLagTime", Namespace = "http://walmart.com/")]
        public int FulfillmentLagTime { get; set; }
        [XmlAttribute(AttributeName = "wm", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Wm { get; set; }
    }

    [XmlRoot(ElementName = "quantity", Namespace = "http://walmart.com/")]
    public class Quantity
    {
        [XmlElement(ElementName = "unit", Namespace = "http://walmart.com/")]
        public string Unit { get; set; }
        [XmlElement(ElementName = "amount", Namespace = "http://walmart.com/")]
        public int Amount { get; set; }
    }

}

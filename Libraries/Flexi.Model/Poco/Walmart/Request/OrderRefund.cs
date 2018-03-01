using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.Walmart.Request
{
    [XmlRoot(ElementName = "orderRefund", Namespace = "http://walmart.com/mp/v3/orders")]
    public class OrderRefund
    {
        [XmlElement(ElementName = "purchaseOrderId", Namespace = "http://walmart.com/mp/v3/orders")]
        public string PurchaseOrderId { get; set; }
        [XmlElement(ElementName = "orderLines", Namespace = "http://walmart.com/mp/v3/orders")]
        public OrderLines OrderLines { get; set; }
        [XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns2 { get; set; }
        [XmlAttribute(AttributeName = "ns3", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns3 { get; set; }
    }

    [XmlRoot(ElementName = "chargeAmount", Namespace = "http://walmart.com/mp/v3/orders")]
    public class ChargeAmount
    {
        [XmlElement(ElementName = "currency", Namespace = "http://walmart.com/mp/v3/orders")]
        public string Currency { get; set; }
        [XmlElement(ElementName = "amount", Namespace = "http://walmart.com/mp/v3/orders")]
        public string Amount { get; set; }
    }

    [XmlRoot(ElementName = "taxAmount", Namespace = "http://walmart.com/mp/v3/orders")]
    public class TaxAmount
    {
        [XmlElement(ElementName = "currency", Namespace = "http://walmart.com/mp/v3/orders")]
        public string Currency { get; set; }
        [XmlElement(ElementName = "amount", Namespace = "http://walmart.com/mp/v3/orders")]
        public string Amount { get; set; }
    }

    [XmlRoot(ElementName = "tax", Namespace = "http://walmart.com/mp/v3/orders")]
    public class Tax
    {
        [XmlElement(ElementName = "taxName", Namespace = "http://walmart.com/mp/v3/orders")]
        public string TaxName { get; set; }
        [XmlElement(ElementName = "taxAmount", Namespace = "http://walmart.com/mp/v3/orders")]
        public TaxAmount TaxAmount { get; set; }
    }

    [XmlRoot(ElementName = "charge", Namespace = "http://walmart.com/mp/v3/orders")]
    public class Charge
    {
        [XmlElement(ElementName = "chargeType", Namespace = "http://walmart.com/mp/v3/orders")]
        public string ChargeType { get; set; }
        [XmlElement(ElementName = "chargeName", Namespace = "http://walmart.com/mp/v3/orders")]
        public string ChargeName { get; set; }
        [XmlElement(ElementName = "chargeAmount", Namespace = "http://walmart.com/mp/v3/orders")]
        public ChargeAmount ChargeAmount { get; set; }
        [XmlElement(ElementName = "tax", Namespace = "http://walmart.com/mp/v3/orders")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "refundCharge", Namespace = "http://walmart.com/mp/v3/orders")]
    public class RefundCharge
    {
        [XmlElement(ElementName = "refundReason", Namespace = "http://walmart.com/mp/v3/orders")]
        public string RefundReason { get; set; }
        [XmlElement(ElementName = "charge", Namespace = "http://walmart.com/mp/v3/orders")]
        public Charge Charge { get; set; }
    }

    [XmlRoot(ElementName = "refundCharges", Namespace = "http://walmart.com/mp/v3/orders")]
    public class RefundCharges
    {
        [XmlElement(ElementName = "refundCharge", Namespace = "http://walmart.com/mp/v3/orders")]
        public List<RefundCharge> RefundCharge { get; set; }
    }

    [XmlRoot(ElementName = "refund", Namespace = "http://walmart.com/mp/v3/orders")]
    public class Refund
    {
        [XmlElement(ElementName = "refundComments", Namespace = "http://walmart.com/mp/v3/orders")]
        public string RefundComments { get; set; }
        [XmlElement(ElementName = "refundCharges", Namespace = "http://walmart.com/mp/v3/orders")]
        public RefundCharges RefundCharges { get; set; }
    }

    [XmlRoot(ElementName = "refunds", Namespace = "http://walmart.com/mp/v3/orders")]
    public class Refunds
    {
        [XmlElement(ElementName = "refund", Namespace = "http://walmart.com/mp/v3/orders")]
        public Refund Refund { get; set; }
    }

    [XmlRoot(ElementName = "orderLine", Namespace = "http://walmart.com/mp/v3/orders")]
    public class OrderLine
    {
        [XmlElement(ElementName = "lineNumber", Namespace = "http://walmart.com/mp/v3/orders")]
        public string LineNumber { get; set; }
        [XmlElement(ElementName = "refunds", Namespace = "http://walmart.com/mp/v3/orders")]
        public Refunds Refunds { get; set; }
    }

    [XmlRoot(ElementName = "orderLines", Namespace = "http://walmart.com/mp/v3/orders")]
    public class OrderLines
    {
        [XmlElement(ElementName = "orderLine", Namespace = "http://walmart.com/mp/v3/orders")]
        public OrderLine OrderLine { get; set; }
    }


}

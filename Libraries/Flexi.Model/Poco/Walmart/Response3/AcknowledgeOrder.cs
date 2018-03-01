using System.Collections.Generic;

namespace Flexi.Model.Poco.Walmart.Response3
{

    public class AcknowledgeOrder
    {
        public Order Order { get; set; }
    }
    public class ChargeAmount2
    {
        public string Currency { get; set; }
        public double Amount { get; set; }
    }

    public class Charge2
    {
        public string ChargeType { get; set; }
        public string ChargeName { get; set; }
        public ChargeAmount2 chargeAmount { get; set; }
        public object tax { get; set; }
    }

    public class RefundCharge
    {
        public string RefundReason { get; set; }
        public Charge2 Charge { get; set; }
    }

    public class RefundCharges
    {
        public List<RefundCharge> RefundCharge { get; set; }
    }

    public class Refund
    {
        public string RefundId { get; set; }
        public string RefundComments { get; set; }
        public RefundCharges RefundCharges { get; set; }
    }
}

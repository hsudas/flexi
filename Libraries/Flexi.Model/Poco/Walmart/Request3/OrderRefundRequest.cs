using System.Collections.Generic;

namespace Flexi.Model.Poco.Walmart.Request3
{
    public class OrderRefundRequest
    {
        public OrderRefund orderRefund { get; set; }
    }

    public class OrderRefund
    {
        public string purchaseOrderId { get; set; }
        public OrderLines orderLines { get; set; }
    }

    public class ChargeAmount
    {
        public string currency { get; set; }
        public double amount { get; set; }
    }

    public class TaxAmount
    {
        public string currency { get; set; }
        public double amount { get; set; }
    }

    public class Tax
    {
        public string taxName { get; set; }
        public TaxAmount taxAmount { get; set; }
    }

    //public class Charge
    //{
    //    public string chargeType { get; set; }
    //    public string chargeName { get; set; }
    //    public ChargeAmount chargeAmount { get; set; }
    //    public Tax tax { get; set; }
    //}

    public class RefundCharge
    {
        public string refundReason { get; set; }
        public Flexi.Model.Poco.Walmart.Response3.Charge charge { get; set; }
    }

    public class RefundCharges
    {
        public List<RefundCharge> refundCharge { get; set; }
    }

    public class Refund
    {
        public string refundComments { get; set; }
        public RefundCharges refundCharges { get; set; }
    }

    public class Refunds
    {
        public List<Refund> refund { get; set; }
    }


}

using System;
using System.Collections.Generic;

namespace Flexi.Model.Poco.Amazon
{
    public class FulfillmentPreviewPoco
    {
        public string ShippingSpeedCategory { get; set; }
        public DateTime LatestShipDate { get; set; }
        public DateTime LatestArrivalDate { get; set; }
        public List<FulfillmentPreviewItemPoco> FulfillmentPreviewItemList { get; set; }
        public int EstimatedFee { get; set; }
        public bool IsFulfillable { get; set; }
        public bool IsCODCapable { get; set; }
        public List<EstimatedFeePoco> EstimatedFeeList { get; set; }
        public List<UnfulfillablePreviewItemPoco> UnfulfillablePreviewItemList { get; set; }
    }

    public class FulfillmentPreviewItemPoco
    {
        public string EstimatedShippingWeightUnit { get; set; }
        public string EstimatedShippingWeightValue { get; set; }

        public string SellerSKU { get; set; }
        public string SellerFulfillmentOrderItemId { get; set; }
        public string ShippingWeightCalculationMethod { get; set; }
        public int Quantity { get; set; }
        public DateTime EarliestShipDate { get; set; }
        public DateTime EarliestArrivalDate { get; set; }
    }

    public class UnfulfillablePreviewItemPoco
    {
        public string ItemUnfulfillableReasons { get; set; }
        public string SellerSKU { get; set; }
        public string SellerFulfillmentOrderItemId { get; set; }
        public string ShippingWeightCalculationMethod { get; set; }
        public int Quantity { get; set; }
        public DateTime EarliestShipDate { get; set; }
        public DateTime EarliestArrivalDate { get; set; }
    }

    public class EstimatedFeePoco
    {
        public decimal EstimatedFeeValue { get; set; }
        public string EstimatedFeeName { get; set; }
    }
}

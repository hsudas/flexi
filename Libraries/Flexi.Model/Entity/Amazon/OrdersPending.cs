using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("orderspending")]
    public class OrdersPending
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("amazonorderid")]
        public string AmazonOrderId { get; set; }
        [Column("buyeremail")]
        public string BuyerEmail { get; set; }
        [Column("buyername")]
        public string BuyerName { get; set; }
        [Column("earliestdeliverydate")]
        public DateTime? EarliestDeliveryDate { get; set; }
        [Column("earliestshipdate")]
        public DateTime? EarliestShipDate { get; set; }
        [Column("fulfillmentchannel")]
        public string FulfillmentChannel { get; set; }
        [Column("isbusinessorder")]
        public bool? IsBusinessOrder { get; set; }
        [Column("ispremiumorder")]
        public bool? IsPremiumOrder { get; set; }
        [Column("isprime")]
        public bool? IsPrime { get; set; }
        [Column("lastupdatedate")]
        public DateTime? LastUpdateDate { get; set; }
        [Column("latestdeliverydate")]
        public DateTime? LatestDeliveryDate { get; set; }
        [Column("latestshipdate")]
        public DateTime? LatestShipDate { get; set; }
        [Column("marketplaceid")]
        public string MarketplaceId { get; set; }
        [Column("numberofitemsshipped")]
        public int? NumberOfItemsShipped { get; set; }
        [Column("numberofitemsunshipped")]
        public int? NumberOfItemsUnshipped { get; set; }
        [Column("orderchannel")]
        public string OrderChannel { get; set; }
        [Column("orderstatus")]
        public string OrderStatus { get; set; }
        [Column("ordertotal")]
        public decimal? OrderTotal { get; set; }
        [Column("ordertype")]
        public string OrderType { get; set; }
        [Column("paymentmethod")]
        public string PaymentMethod { get; set; }
        [Column("purchasedate")]
        public DateTime? PurchaseDate { get; set; }
        [Column("purchaseordernumber")]
        public string PurchaseOrderNumber { get; set; }
        [Column("saleschannel")]
        public string SalesChannel { get; set; }
        [Column("sellerorderid")]
        public string SellerOrderId { get; set; }
        [Column("shipmentservicelevelcategory")]
        public string ShipmentServiceLevelCategory { get; set; }
        [Column("shippedbyamazontfm")]
        public bool? ShippedByAmazonTFM { get; set; }
        [Column("shippingaddress")]
        public string ShippingAddress { get; set; }
        [Column("shipservicelevel")]
        public string ShipServiceLevel { get; set; }
        [Column("tfmshipmentstatus")]
        public string TFMShipmentStatus { get; set; }
        [Column("saveitems")]
        public int? SaveItems { get; set; }
        [Column("ordercategoryid")]
        public int? OrderCategoryId { get; set; }
        [Column("addressname")]
        public string AddressName { get; set; }
        [Column("addressline1")]
        public string AddressLine1 { get; set; }
        [Column("addressline2")]
        public string AddressLine2 { get; set; }
        [Column("addressline3")]
        public string AddressLine3 { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("county")]
        public string County { get; set; }
        [Column("district")]
        public string District { get; set; }
        [Column("stateorregion")]
        public string StateOrRegion { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("postalcode")]
        public string PostalCode { get; set; }
        [Column("countrycode")]
        public string CountryCode { get; set; }
        [Column("source")]
        public string Source { get; set; }

    }
}

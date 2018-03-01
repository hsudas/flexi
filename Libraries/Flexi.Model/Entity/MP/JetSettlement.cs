using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.MP
{
    [Table("jetsettlement", Schema = "mp")]
    public class JetSettlement
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("transactiontype")]
        public string TransactionType { get; set; }
        [Column("shipdate")]
        public DateTime? ShipDate { get; set; }
        [Column("shipmentid")]
        public string ShipmentId { get; set; }
        [Column("orderdate")]
        public DateTime? OrderDate { get; set; }
        [Column("merchantorderid")]
        public string MerchantorderId { get; set; }
        [Column("orderitemid")]
        public string OrderItemId { get; set; }
        [Column("referenceorderid")]
        public string ReferenceorderId { get; set; }
        [Column("altorderid")]
        public string AltOrderId { get; set; }
        [Column("altorderitemid")]
        public string AltOrderItemId { get; set; }
        [Column("merchantsku")]
        public string Merchantsku { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("jetcategory")]
        public int? JetCategory { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("totalitemprice")]
        public decimal? TotalItemPrice { get; set; }
        [Column("shippingcost")]
        public decimal? ShippingCost { get; set; }
        [Column("itemtaxcollected")]
        public string ItemTaxCollected { get; set; }
        [Column("shippingtaxcollected")]
        public string ShippingTaxCollected { get; set; }
        [Column("merchantreturncharge")]
        public decimal? MerchantReturnCharge { get; set; }
        [Column("basecommission")]
        public decimal? BaseCommission { get; set; }
        [Column("shippingdistancecommission")]
        public decimal? ShippingDistanceCommission { get; set; }
        [Column("waivereturnscommission")]
        public decimal? WaiveReturnsCommission { get; set; }
        [Column("basketbuildingcommission")]
        public decimal? BasketBuildingcommission { get; set; }
        [Column("emailoptincommission")]
        public decimal? EmailoptIncommission { get; set; }
        [Column("totalvariablecommission")]
        public decimal? TotalVariableCommission { get; set; }
        [Column("jetadjustments")]
        public string JetAdjustments { get; set; }
        [Column("totalpayable")]
        public decimal? TotalPayable { get; set; }
        [Column("settlementid")]
        public int? SettlementId { get; set; }
        [Column("periodstart")]
        public DateTime? PeriodStart { get; set; }
        [Column("periodend")]
        public DateTime? PeriodEnd { get; set; }
        [Column("depositdate")]
        public DateTime? DepositDate { get; set; }
        [Column("fulfillmentnodeid")]
        public string FulfillmentNodeId { get; set; }
        [Column("customerzip")]
        public string CustomerZip { get; set; }
        [Column("returnauthorizationid")]
        public string ReturnAuthorizationId { get; set; }
        [Column("retailerfulfillmentcost")]
        public decimal? RetailerFulfillmentCost { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
    }
}

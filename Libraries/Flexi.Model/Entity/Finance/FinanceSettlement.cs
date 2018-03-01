using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Flexi.Model.Entity.FinanceSettlement
{
    [Table("financesettlement", Schema = "mp")]
    public class FinanceSettlement
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("settlementid")]
        public long? SettlementId { get; set; }
        [Column("settlementstartdate")]
        public DateTime? SettlementStartDate { get; set; }
        [Column("settlementenddate")]
        public DateTime? SettlementendDate { get; set; }
        [Column("settlementdepositdate")]
        public DateTime? SettlementDepositDate { get; set; }
        [Column("totalamount")]
        public decimal? TotalAmount { get; set; }
        [Column("currency")]
        public string Currency { get; set; }
        [Column("transactiontype")]
        public string TransactionType { get; set; }
        [Column("orderid")]
        public string OrderId { get; set; }
        [Column("merchantorderid")]
        public string MerchantorderId { get; set; }
        [Column("adjustmentid")]
        public string AdjustmentId { get; set; }
        [Column("shipmentid")]
        public string Shipmentid { get; set; }
        [Column("marketplacename")]
        public string MarketplaceName { get; set; }
        [Column("amounttype")]
        public string AmountType { get; set; }
        [Column("amountdescription")]
        public string AmountDescription { get; set; }
        [Column("amount")]
        public decimal? Amount { get; set; }
        [Column("fulfillmentid")]
        public string FulfillmentId { get; set; }
        [Column("posteddate")]
        public DateTime? PostedDate { get; set; }
        [Column("posteddatetime")]
        public DateTime? PostedDatetime { get; set; }
        [Column("orderitemcode")]
        public string OrderiItemCode { get; set; }
        [Column("merchantorderitemid")]
        public string MerchantOrderItemId { get; set; }
        [Column("merchantadjustmentitemid")]
        public string MerchantAdjustmentItemId { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("quantitypurchased")]
        public int? QuantityPurchased { get; set; }
        [Column("promotionid")]
        public string PromotionId { get; set; }

        [Column("filename")]
        public string FileName { get; set; }

    }
}
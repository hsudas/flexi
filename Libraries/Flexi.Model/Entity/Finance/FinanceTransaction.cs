using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Flexi.Model.Entity.FinanceSettlement
{
    [Table("financetransaction", Schema = "fin")]
    public class FinanceTransaction
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("querydate")]
        public int QueryDate { get; set; }
        [Column("transactiontype")]
        public string TransactionType { get; set; }
        [Column("orderid")]
        public string OrderId { get; set; }
        [Column("merchantorderid")]
        public string MerchantorderId { get; set; }
        [Column("amounttype")]
        public string AmountType { get; set; }
        [Column("amount")]
        public decimal? Amount { get; set; }
        [Column("fulfillmentid")]
        public string FulfillmentId { get; set; }
        [Column("marketplacename")]
        public string MarketplaceName { get; set; }
        [Column("orderitemcode")]
        public string OrderiItemCode { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("currency")]
        public string Currency { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("posteddatetime")]
        public DateTime? PostedDatetime { get; set; }
        [Column("adjustmentid")]
        public string AdjustmentId { get; set; }
        [Column("amountdescription")]
        public string AmountDescription { get; set; }
        [Column("promotionid")]
        public string PromotionId { get; set; }
        [Column("customdata")]
        public string CustomData { get; set; }
        [Column("orderandskuunique")]
        public Boolean? Orderandskuunique { get; set; }
        [Column("groupid")]
        public string GroupId { get; set; }

    }

    [Table("financialeventgroup", Schema = "fin")]
    public class FinancialEventGroups
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("groupid")]
        public string GroupId { get; set; }
        [Column("nexttoken")]
        public string NextToken { get; set; }
        [Column("processed")]
        public int? Processed { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }

    }
}



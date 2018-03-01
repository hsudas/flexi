using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("sku2")]
    public class Sku2
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("sku")]
        public string SKU { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("cost")]
        public decimal? Cost { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("vendor")]
        public string Vendor { get; set; }
        [Column("shipping")]
        public decimal? Shipping { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("fulfillmentby")]
        public string FulfillmentBy { get; set; }
        [Column("autostockcheck")]
        public int? AutoStockCheck { get; set; }
        [Column("autopricecheck")]
        public int? AutoPriceCheck { get; set; }
        [Column("priceprofile")]
        public string PriceProfile { get; set; }
        [Column("expdate")]
        public string ExpDate { get; set; }
        [Column("createuser")]
        public string CreateUser { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
        [Column("status"), DefaultValue(true)]
        public bool? Status { get; set; }
        [Column("fnsku")]
        public string FnSku { get; set; }
        [Column("perunitvolume")]
        public string PerUnitVolume { get; set; }
        [Column("yourprice")]
        public decimal? YourPrice { get; set; }
        [Column("mfnlistingexists")]
        public string MfnListingExists { get; set; }
        [Column("mfnfulfillablequantity")]
        public int? MfnFulfillableQuantity { get; set; }
        [Column("afnlistingexists")]
        public string AfnListingExists { get; set; }
        [Column("afnwarehousequantity")]
        public int? AfnWarehouseQuantity { get; set; }
        [Column("afnfulfillablequantity")]
        public int? AfnFulfillableQuantity { get; set; }
        [Column("afnunsellablequantity")]
        public int? AfnUnsellableQuantity { get; set; }
        [Column("afnreservedquantity")]
        public int? AfnReservedQuantity { get; set; }
        [Column("afntotalquantity")]
        public int? AfnTotalQuantity { get; set; }
        [Column("afninboundworkingquantity")]
        public int? AfnInboundWorkingQuantity { get; set; }
        [Column("afninboundshippedquantity")]
        public int? AfnInboundShippedQuantity { get; set; }
        [Column("afninboundreceivingquantity")]
        public int? AfnInboundReceivingQuantity { get; set; }
        [Column("updatedate")]
        public DateTime? UpdateDate { get; set; }
        [Column("updateuser")]
        public string UpdateUser { get; set; }
        [Column("myprice")]
        [DefaultValue(9999.99)]
        public decimal? MyPrice { get; set; }
        [Column("pricecheckdate")]
        public DateTime? PriceCheckDate { get; set; }
        [Column("expirationdate")]
        public DateTime? ExpirationDate { get; set; }
        [Column("isactive")]
        public int IsActive { get; set; }
        [Column("minprice")]
        public decimal MinPrice { get; set; }
        [Column("maxprice")]
        public decimal MaxPrice { get; set; }
        [Column("ismainsku"), DefaultValue(true)]
        public bool IsMainSku { get; set; }
        [Column("constantprice")]
        public decimal ConstantPrice { get; set; }
        [Column("minpricetolerancerate"), DefaultValue(1)]
        public decimal MinPriceTolerancerate { get; set; }
        [Column("note")]
        public string Note { get; set; }
        [Column("shippingtemplate")]
        public string ShippingTemplate { get; set; }

        //minpricetolerancerate
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.AmazonReport
{
    [Table("report_get_flat_file_all_orders_data_by_last_update_log",Schema ="rpr")]
    public class ReportGetFlatFileAllOrdersDataByLastUpdateLog
    {
        [Key]
        [Column("id")]
        public int? Id { get; set; }
        [Column("generated_report_id")]
        public long Generated_Report_Id { get; set; }
        [Column("amazon_order_id")]
        public string Amazon_Order_Id { get; set; }
        [Column("merchant_order_id")]
        public string Merchant_Order_Id { get; set; }
        [Column("purchase_date")]
        public DateTime? Purchase_Date { get; set; }
        [Column("last_updated_date")]
        public DateTime? Last_Updated_Date { get; set; }
        [Column("order_status")]
        public string Order_Status { get; set; }
        [Column("fulfillment_channel")]
        public string Fulfillment_Channel { get; set; }
        [Column("sales_channel")]
        public string Sales_Channel { get; set; }
        [Column("order_channel")]
        public string Order_Channel { get; set; }
        [Column("url")]
        public string Url { get; set; }
        [Column("ship_service_level")]
        public string Ship_Service_Level { get; set; }
        [Column("product_name")]
        public string Product_Name { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("item_status")]
        public string Item_Status { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("currency")]
        public string Currency { get; set; }
        [Column("item_price")]
        public decimal? Item_Price { get; set; }
        [Column("item_tax")]
        public decimal? Item_Tax { get; set; }
        [Column("shipping_price")]
        public decimal? Shipping_Price { get; set; }
        [Column("shipping_tax")]
        public decimal? Shipping_Tax { get; set; }
        [Column("gift_wrap_price")]
        public decimal? Gift_Wrap_Price { get; set; }
        [Column("gift_wrap_tax")]
        public decimal? Gift_Wrap_Tax { get; set; }
        [Column("item_promotion_discount")]
        public decimal? Item_Promotion_Discount { get; set; }
        [Column("ship_promotion_discount")]
        public decimal? Ship_Promotion_Discount { get; set; }
        [Column("ship_city")]
        public string Ship_City { get; set; }
        [Column("ship_state")]
        public string Ship_State { get; set; }
        [Column("ship_postal_code")]
        public string Ship_Postal_Code { get; set; }
        [Column("ship_country")]
        public string Ship_Country { get; set; }
        [Column("promotion_ids")]
        public string Promotion_Ids { get; set; }
        [Column("is_business_order")]
        public string Is_Business_Order { get; set; }
        [Column("purchase_order_number")]
        public string Purchase_Order_Number { get; set; }
        [Column("price_designation")]
        public string Price_Designation { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
    }
}
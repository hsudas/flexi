using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.AmazonReport
{
    [Table("report_get_merchant_listings_data_log", Schema = "rpr")]
    public class ReportGetMerchantListingsDataLog
    {
        [Key]
        [Column("id")]
        public int? Id { get; set; }
        [Column("generated_report_id")]
        public long Generated_Report_Id { get; set; }
        [Column("item_name")]
        public string Item_Name { get; set; }
        [Column("item_description")]
        public string Item_Description { get; set; }
        [Column("listing_id")]
        public string Listing_Id { get; set; }
        [Column("seller_sku")]
        public string Seller_Sku { get; set; }
        [Column("price")]
        public decimal? Price { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
        [Column("open_date")]
        public DateTime? Open_Date { get; set; }
        [Column("image_url")]
        public string Image_Url { get; set; }
        [Column("item_is_marketplace")]
        public string Item_Is_Marketplace { get; set; }
        [Column("product_id_type")]
        public string ProductIdType { get; set; }
        [Column("zshop_shipping_fee")]
        public decimal? ZShop_Shipping_Fee { get; set; }
        [Column("item_note")]
        public string Item_Note { get; set; }
        [Column("item_condition")]
        public string Item_Condition { get; set; }
        [Column("zshop_category1")]
        public string ZShop_Category1 { get; set; }
        [Column("zshop_browse_path")]
        public string ZShop_Browse_Path { get; set; }
        [Column("zshop_storefront_feature")]
        public string ZShop_StoreFront_Feature { get; set; }
        [Column("asin1")]
        public string Asin1 { get; set; }
        [Column("asin2")]
        public string Asin2 { get; set; }
        [Column("asin3")]
        public string Asin3 { get; set; }
        [Column("will_ship_internationally")]
        public string Will_Ship_Internationally { get; set; }
        [Column("expedited_shipping")]
        public string Expedited_Shipping { get; set; }
        [Column("zshop_boldface")]
        public string ZShop_BoldFace { get; set; }
        [Column("product_id")]
        public string Product_Id { get; set; }
        [Column("bid_for_featured_placement")]
        public string Bid_For_Featured_Placement { get; set; }
        [Column("add_delete")]
        public string Add_Delete { get; set; }
        [Column("pending_quantity")]
        public int? Pending_Quantity { get; set; }
        [Column("fulfillment_channel")]
        public string Fulfillment_Channel { get; set; }
        [Column("business_price")]
        public decimal? Business_Price { get; set; }
        [Column("merchant_shipping_group")]
        public string Merchant_Shipping_Group { get; set; }
        [Column("quantity_price_type")]
        public string Quantity_Price_Type { get; set; }
        [Column("quantity_lower_bound_1")]
        public string Quantity_Lower_Bound_1 { get; set; }
        [Column("quantity_price_1")]
        public decimal? Quantity_Price_1 { get; set; }
        [Column("quantity_lower_bound_2")]
        public string Quantity_Lower_Bound_2 { get; set; }
        [Column("quantity_price_2")]
        public decimal? Quantity_Price_2 { get; set; }
        [Column("quantity_lower_bound_3")]
        public string Quantity_Lower_Bound_3 { get; set; }
        [Column("quantity_price_3")]
        public decimal? Quantity_Price_3 { get; set; }
        [Column("quantity_lower_bound_4")]
        public string Quantity_Lower_Bound_4 { get; set; }
        [Column("quantity_price_4")]
        public decimal? Quantity_Price_4 { get; set; }
        [Column("quantity_lower_bound_5")]
        public string Quantity_Lower_Bound_5 { get; set; }
        [Column("quantity_price_5")]
        public decimal? Quantity_Price_5 { get; set; }
        [Column("createdate")]
        public DateTime? CreateDate { get; set; }
    }
}

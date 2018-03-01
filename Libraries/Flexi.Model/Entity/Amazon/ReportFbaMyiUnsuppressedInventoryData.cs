using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    public class ReportFbaMyiUnsuppressedInventoryData
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("report_id")]
        public string ReportId { get; set; }
        [Column("date")]
        public DateTime? Date { get; set; }
        [Column("afn_total_quantity")]
        public string AfnTotalQuantity { get; set; }
        [Column("per_unit_volume")]
        public decimal? PerUnitVolume { get; set; }
        [Column("afn_inbound_working_quantity")]
        public decimal? AfnInboundWorkingQuantity { get; set; }
        [Column("afn_inbound_shipped_quantity")]
        public decimal? AfnInboundShippedQuantity { get; set; }
        [Column("afn_inbound_receiving_quantity")]
        public decimal? AfnInboundReceivingQuantity { get; set; }
        [Column("your_price")]
        public decimal YourPrice { get; set; }
        [Column("fnsku")]
        public string Fnsku { get; set; }
        [Column("condition")]
        public string Condition { get; set; }
        [Column("mfn_listing_exists")]
        public string MfnListingExists { get; set; }
        [Column("mfn_fulfillable_quantity")]
        public decimal? MfnFulfillableQuantity { get; set; }
        [Column("afn_listing_exists")]
        public string AfnListingExists { get; set; }
        [Column("afn_warehouse_quantity")]
        public decimal? AfnWarehouseQuantity { get; set; }
        [Column("afn_fulfillable_quantity")]
        public decimal? AfnFulfillableQuantity { get; set; }
        [Column("afn_unsellable_quantity")]
        public decimal? AfnUnsellableQuantity { get; set; }
        [Column("afn_reserved_quantity")]
        public decimal? AfnReservedQuantity { get; set; }
    }
}

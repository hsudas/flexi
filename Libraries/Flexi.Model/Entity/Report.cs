using Dapper.Contrib.Extensions;
using System;

namespace Flexi.Model
{
    [Table("rpr.reportrequest")]
    public class Report_Request
    {
        [Key]
        public int ID { get; set; }

        public DateTime? START_DATE { get; set; }

        public DateTime? END_DATE { get; set; }

        public string REPORT_TYPE { get; set; }

        public DateTime? SUBMIT_DATE { get; set; }

        public string STATUS { get; set; }

        public string REPORT_REQUEST_ID { get; set; }

        public string GENERATED_REPORT_ID { get; set; }

        public string DOWNLOADED_DB { get; set; }

        public string DOWNLOAD_TYPE { get; set; }

        public int SCHEDULE_ID { get; set; }

        public string UUID { get; set; }

        public string DOWNLOADED_PC { get; set; }

        public string SCRIPT { get; set; }
        public bool? NOPARAMETER { get; set; }
        public int? LINECOUNT { get; set; }
        public int? ISEXTERNAL { get; set; }
        public string SELLERID { get; set; }

    }
    [Table("REPORT_FBA_MYI_UNSUPPRESSED_INVENTORY_DATA")]
    public class REPORT_FBA_MYI_UNSUPPRESSED_INVENTORY_DATA
    {
        [Key]
        public int ID { get; set; }

        public DateTime? DATE { get; set; }

        public string REPORT_ID { get; set; }

        public string SKU { get; set; }

        public string FNSKU { get; set; }

        public string ASIN { get; set; }

        public string CONDITION { get; set; }

        public decimal? YOUR_PRICE { get; set; }

        public string MFN_LISTING_EXISTS { get; set; }

        public decimal? MFN_FULFILLABLE_QUANTITY { get; set; }

        public string AFN_LISTING_EXISTS { get; set; }

        public decimal? AFN_WAREHOUSE_QUANTITY { get; set; }

        public decimal? AFN_FULFILLABLE_QUANTITY { get; set; }

        public decimal? AFN_UNSELLABLE_QUANTITY { get; set; }

        public decimal? AFN_RESERVED_QUANTITY { get; set; }

        public decimal? AFN_TOTAL_QUANTITY { get; set; }

        public decimal? PER_UNIT_VOLUME { get; set; }

        public decimal? AFN_INBOUND_WORKING_QUANTITY { get; set; }

        public decimal? AFN_INBOUND_SHIPPED_QUANTITY { get; set; }

        public decimal? AFN_INBOUND_RECEIVING_QUANTITY { get; set; }

    }

    [Table("REPORT_GET_FBA_FULFILLMENT_INVENTORY_HEALTH_DATA")]
    public class REPORT_GET_FBA_FULFILLMENT_INVENTORY_HEALTH_DATA
    {
        [Key]
        public int ID { get; set; }

        public string REPORT_ID { get; set; }

        public DateTime? DATE { get; set; }

        public string Snapshot_Date { get; set; }

        public string SKU { get; set; }

        public string fnSKU { get; set; }

        public string ASIN { get; set; }

        public string Product_Name { get; set; }

        public string Condition { get; set; }

        public decimal? Sales_Rank { get; set; }

        public string Product_Group { get; set; }

        public decimal? Total_Quantity { get; set; }

        public decimal? Sellable_Quantity { get; set; }

        public decimal? Unsellable_Quantity { get; set; }

        public decimal? Inv_Avg_0_to_90_Days { get; set; }

        public decimal? Inv_Avg_91_to_180_Days { get; set; }

        public decimal? Inv_Avg_181_to_270_Days { get; set; }

        public decimal? Inv_Avg_271_to_365_Days { get; set; }

        public decimal? Inv_Avg_365_Days { get; set; }

        public decimal? Units_Shipped_Last_24_Hours { get; set; }

        public decimal? Units_Shipped_Last_7_Days { get; set; }

        public decimal? Units_Shipped_Last_30_Days { get; set; }

        public decimal? Units_Shipped_Last_90_Days { get; set; }

        public decimal? Units_Shipped_Last_180_Days { get; set; }

        public decimal? Units_Shipped_Last_365_Days { get; set; }

        public string Weeks_of_Cover_t7 { get; set; }

        public string Weeks_of_Cover_t30 { get; set; }

        public string Weeks_of_Cover_t90 { get; set; }

        public string Weeks_of_Cover_t180 { get; set; }

        public string Weeks_of_Cover_t365 { get; set; }

        public decimal? Num_Afn_New_Sellers { get; set; }

        public decimal? Num_Afn_Used_Sellers { get; set; }

        public string Currency { get; set; }

        public decimal? Your_Price { get; set; }

        public decimal? Sales_Price { get; set; }

        public decimal? Lowest_Afn_New_Price { get; set; }

        public decimal? Lowest_Afn_Used_Price { get; set; }

        public decimal? Lowest_Mfn_New_Price { get; set; }

        public decimal? Lowest_Mfn_Used_Price { get; set; }

        public decimal? Qty_to_be_Charged_ltsf_12_Mo { get; set; }

        public decimal? Qty_in_Long_Term_Storage_Program { get; set; }

        public decimal? Qty_with_Removals_in_Progress { get; set; }

        public decimal? Projected_Itsf_12_Mo { get; set; }

        public decimal? Per_Unit_Volume { get; set; }

        public string Is_Hazmat { get; set; }

        public decimal? Inbound_Quantity { get; set; }

        public decimal? ASIN_Limit { get; set; }

        public decimal? Inbound_Recommend_Quantity { get; set; }

        public decimal? Qty_to_be_Charged_Itsf_6_Mo { get; set; }

    }

    [Table("Report_Contents")]
    public class Report_Contents
    {
        [Key]
        public int ID { get; set; }

        public string REPORT_ID { get; set; }

        public string ROW_ID { get; set; }

        public string Column1 { get; set; }

        public string Column2 { get; set; }

        public string Column3 { get; set; }

        public string Column4 { get; set; }

        public string Column5 { get; set; }

        public string Column6 { get; set; }

        public string Column7 { get; set; }

        public string Column8 { get; set; }

        public string Column9 { get; set; }

        public string Column10 { get; set; }

        public string Column11 { get; set; }

        public string Column12 { get; set; }

        public string Column13 { get; set; }

        public string Column14 { get; set; }

        public string Column15 { get; set; }

        public string Column16 { get; set; }

        public string Column17 { get; set; }

        public string Column18 { get; set; }

        public string Column19 { get; set; }

        public string Column20 { get; set; }

        public string Column21 { get; set; }

        public string Column22 { get; set; }

        public string Column23 { get; set; }

        public string Column24 { get; set; }

        public string Column25 { get; set; }

        public string Column26 { get; set; }

        public string Column27 { get; set; }

        public string Column28 { get; set; }

        public string Column29 { get; set; }

        public string Column30 { get; set; }

        public string Column31 { get; set; }

        public string Column32 { get; set; }

        public string Column33 { get; set; }

        public string Column34 { get; set; }

        public string Column35 { get; set; }

        public string Column36 { get; set; }

        public string Column37 { get; set; }

        public string Column38 { get; set; }

        public string Column39 { get; set; }

        public string Column40 { get; set; }

        public string Column41 { get; set; }

        public string Column42 { get; set; }

        public string Column43 { get; set; }

        public string Column44 { get; set; }

        public string Column45 { get; set; }

        public string Column46 { get; set; }

        public string Column47 { get; set; }

        public string Column48 { get; set; }

        public string Column49 { get; set; }

        public string Column50 { get; set; }

        public string UUID { get; set; }

    }


    [Table("rpr.reportschedule")]
    public class Report_Schedule
    {
        [Key]
        public int ID { get; set; }

        public string PERIOD_TYPE { get; set; }

        public string PERIOD { get; set; }

        public string REPORT_TYPE { get; set; }

        public string START_DATE_PERIOD_TYPE { get; set; }

        public string START_DATE_PERIOD { get; set; }

        public string END_DATE_PERIOD_TYPE { get; set; }

        public string END_DATE_PERIOD { get; set; }

        public DateTime? LAST_REPORT_DATE { get; set; }

        public string REQUEST { get; set; }

        public string UUID { get; set; }

        public string SCRIPT { get; set; }

        public bool? CHECK_REQUEST { get; set; }

        public bool? NOPARAMETER { get; set; }
        public int? Status { get; set; }

        public DateTime? LastCancelDate { get; set; }

    }

    public class ReportServiceResponse
    {
        public DateTime SubmitDate { get; set; }
        public string ReportProcessingStatus { get; set; }
        public string ReportRequestId { get; set; }
        public string Uuid { get; set; }
        /// <summary>
        /// From REPORT_REQUEST table
        /// </summary>
        public int ReportId { get; set; }

        public string GeneratedReportId { get; set; }

        public Report_Request RecordRequestObject { get; set; }

    }
}

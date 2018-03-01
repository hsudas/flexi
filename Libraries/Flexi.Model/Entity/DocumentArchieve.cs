using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity
{
    [Table("documentarchieve")]
    public class DocumentArchieve
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("document_type")]
        public string DOCUMENT_TYPE { get; set; }
        [Column("total_amount")]
        public double TOTAL_AMOUNT { get; set; }
        [Column("vendor_name")]
        public string VENDOR_NAME { get; set; }
        [Column("invoice_number")]
        public string INVOICE_NUMBER { get; set; }
        [Column("file_path")]
        public string FILE_PATH { get; set; }
        [Column("purchase_order_no")]
        public string PURCHASE_ORDER_NO { get; set; }
        [Column("save_date")]
        public DateTime? SAVE_DATE { get; set; }
        [Column("invoice_date")]
        public DateTime? INVOICE_DATE { get; set; }
        [Column("user_name")]
        public string USER_NAME { get; set; }
        [Column("received_date")]
        public DateTime? RECEIVED_DATE { get; set; }
        [Column("description")]
        public string DESCRIPTION { get; set; }
        [Column("org_file_path")]
        public string ORG_FILE_PATH { get; set; }
        [Column("status")]
        public int status { get; set; }
        [Column("departmentcode")]
        public string DepartmentCode { get; set; }
        [Column("paymentsource")]
        public string PaymentSource { get; set; }
    }


    [Table("documentpaymentsource")]
    public class DocumentPaymentSource
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("documentid")]
        public int DocumentId { get; set; }
        [Column("paymentsource")]
        public string PaymentSource { get; set; }
        [Column("amount")]
        public decimal Amount { get; set; }
    

    }

    [Table("documentdepartmentcode")]
    public class DocumentDepartmentCode
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("documentid")]
        public int DocumentId { get; set; }
        [Column("departmentcode")]
        public string DepartmentCode { get; set; }
        [Column("amount")]
        public decimal Amount { get; set; }

    }
}

using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Royal.Flexi.WebUILite.Models.Inventory
{
    [Table("inventory")]
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        public string SKU { get; set; }
     
        public string ShipmentId { get; set; }
    
        public string Quantity { get; set; }
 
        public string Status { get; set; }

        public int? OrderId { get; set; }
        
        public int? InvStatusId { get; set; }
     
        public string CreateUser { get; set; }
     
        public DateTime? CreateDate { get; set; }

        public string ShipmentName { get; set; }
 
        public string mac { get; set; }
       
        public string ExpDate { get; set; }
     
        public string ScanUser { get; set; }
      
        public DateTime? ScanDate { get; set; }
    
        public DateTime? PackedDate { get; set; }
   
        public string InvoiceNo { get; set; }
   
        public string SellerId { get; set; }

    }
}
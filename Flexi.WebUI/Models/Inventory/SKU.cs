using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Royal.Flexi.WebUILite.Models.Inventory
{
    [Table("sku")]
    public class Sku
    {
        [Key]
     
        public long Id { get; set; }
      
        public string SKU { get; set; }
 
        public string Asin { get; set; }

        public decimal? Cost { get; set; }
    
        public int? Quantity { get; set; }
       
        public string Vendor { get; set; }
       
        public decimal? Shipping { get; set; }
        
        public string Title { get; set; }
       
        public string FulfillmentBy { get; set; }
      
        public int? AutoStockCheck { get; set; }
  
        public int? AutoPriceCheck { get; set; }
 
        public string PriceProfile { get; set; }

        public string ExpDate { get; set; }

        public string CreateUser { get; set; }
       
        public DateTime? CreateDate { get; set; }
  
      
        public string FnSku { get; set; }
  
        public string PerUnitVolume { get; set; }
 
        public decimal? YourPrice { get; set; }
        
        public string MfnListingExists { get; set; }
  
        public int? MfnFulfillableQuantity { get; set; }
      
        public string AfnListingExists { get; set; }
    
        public int? AfnWarehouseQuantity { get; set; }
      
        public int? AfnFulfillableQuantity { get; set; }
      
        public int? AfnUnsellableQuantity { get; set; }
      
        public int? AfnReservedQuantity { get; set; }
      
        public int? AfnTotalQuantity { get; set; }

        public int? AfnInboundWorkingQuantity { get; set; }
      
        public int? AfnInboundShippedQuantity { get; set; }
       
        public int? AfnInboundReceivingQuantity { get; set; }
       
        public DateTime? UpdateDate { get; set; }
       
        public string UpdateUser { get; set; }
   
        public decimal? MyPrice { get; set; }
     
        public DateTime? PriceCheckDate { get; set; }
      
        public DateTime? ExpirationDate { get; set; }
       
        public int IsActive { get; set; }
      
        public decimal MinPrice { get; set; }
     
        public decimal MaxPrice { get; set; }

        public bool IsMainSku { get; set; }
  
        public decimal ConstantPrice { get; set; }
      
        public decimal MinPriceTolerancerate { get; set; }
 
        public string Note { get; set; }

        //minpricetolerancerate
    }
}
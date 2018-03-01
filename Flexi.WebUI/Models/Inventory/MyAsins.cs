using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Royal.Flexi.WebUILite.Models.Inventory
{
   
        [Table("myasins")]
        public class MyAsins
        {
            [Key]          
            public long Id { get; set; }

            public string ASIN { get; set; }
           
            public int AmazonInventory { get; set; }
       
            public decimal PerUnitVolume { get; set; }
           
            public decimal YourPrice { get; set; }
        
            public string AsinName { get; set; }
          
            public int Pack { get; set; }
        
            public int AsinReq1 { get; set; }
         
            public int AsinReq2 { get; set; }
         
            public int AsinReq3 { get; set; }
         
            public int AsinReq4 { get; set; }
     
            public int AsinReq5 { get; set; }
        
            public int AsinReq6 { get; set; }
    
            public int AsinReq7 { get; set; }
         
            public int AsinReq8 { get; set; }
       
            public int AsinReq9 { get; set; }
           
            public int AsinReq10 { get; set; }
 
            public int AsinReq11 { get; set; }
           
            public int AsinReq12 { get; set; }
    
            public int AsinReq13 { get; set; }
         
            public string Memo { get; set; }
         
            public string Upc { get; set; }
         
            public bool IsExpDateLabel { get; set; }
  
            public bool IsPolyBagging { get; set; }
          
            public bool IsBubbleWrapping { get; set; }
        
            public bool IsBarcodeCovering { get; set; }
         
            public bool IsBulk { get; set; }
         
            public bool IsNutritionFact { get; set; }

            public bool IsRestrictedFba { get; set; }
   
            public bool IsHazmat { get; set; }
        
            public bool IsRestrictedAll { get; set; }
    
            public bool IsBundling { get; set; }

            public string CreateUser { get; set; }
       
            public DateTime? CreateDate { get; set; }
       
            public DateTime? LastUpdatedDate { get; set; }
           
            public string SellerId { get; set; }
        }
    
}
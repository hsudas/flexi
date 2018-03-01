using System;
using System.Collections.Generic;
using System.Data;

namespace Flexi.Model.Poco.Amazon
{
    public class AmazonItem
    {
        public string ASIN { get; set; }
        public string SKU { get; set; }
        public string UPC { get; set; }
        public string EAN { get; set; }
        public string LargeImageUrl { get; set; }
        public string SmallImageUrl { get; set; }
        public string MediumImageUrl { get; set; }
        public List<string> LargeImageURLList { get; set; }
        public List<string> SmallImageURLList { get; set; }
        public List<string> MediumImageURLList { get; set; }
        public string Title { get; set; }
        public string EditorialReview { get; set; }
        public string ProductGroup { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int? NumberOfItems { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public int? PackQuantity { get; set; }
        public string Manufacturer { get; set; }
        public decimal LowestNewPrice { get; set; }
        public string SalesRank { get; set; }
        public long ListingId { get; set; }

    }

}

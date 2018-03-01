using Flexi.Model.Entity.MP;
using System;

namespace Flexi.Model.Poco.MP
{

    public class StockPoco
    {
        public long StockId { get; set; }
        public int Status { get; set; }
        public long ProductId { get; set; }
        public string Upc { get; set; }
        public string Title { get; set; }
        public string ItemCondition { get; set; }
        public string ItemSourceChannel { get; set; }
        public string ItemDestination { get; set; }
        public string StockStatus { get; set; }
        public int Quantity { get; set; }
        public int? ParentId { get; set; }
        public string LocationColumn { get; set; }
        public string LocationRow { get; set; }
        public string LocationAisle { get; set; }
        //public int? SourceRefId { get; set; }
        //public string Warehouse { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string Note { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }


    }
}

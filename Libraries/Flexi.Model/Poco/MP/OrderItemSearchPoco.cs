using Flexi.Model.Entity.MP;
using Flexi.Model.Enum.Amazon;
using System;
using System.Collections.Generic;

namespace Royal.WebStudio.Models.Poco
{
    public class OrderItemSearchPoco
    {
        public string Sku { get; set; }
        public string Title { get; set; }
        public Flexi.Model.Enum.MP.MP? MP { get; set; }
        public FulfillmentBy? FulfillmentBy { get; set; }
        public OrderItemStatus? OrderItemStatus { get; set; }
        public string OrderId { get; set; }
        public string TrackingNo { get; set; }
        public DateTime? CreateDateStart { get; set; }
        public DateTime? CreateDateEnd { get; set; }
        public List<OrderItem> OrderItemList { get; set; }
    }
}
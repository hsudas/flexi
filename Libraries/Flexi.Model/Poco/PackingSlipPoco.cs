using System.Collections.Generic;

namespace Flexi.Model.Poco
{
    public class PackingSlipPoco
    {
        public string FromAddress;
        public string FromPhone;
        public string ToName;
        public string ToAddress1;
        public string ToAddress2;
        public string ToAddress3;
        public string MarketPlace;
        public string OrderId;
        public List<PackingSlipItemPoco> PackingSlipItem = new List<PackingSlipItemPoco>();
        public string PurchaseDate;
    }

    public class PackingSlipItemPoco
    {
        public string QtyOrdered;
        public string QtyShipped;
        public string ProductName;
        public string Loc;
        public string ASIN;
        public string stock;


        public PackingSlipItemPoco(string ProductName, string QtyShipped, string QtyOrdered, string Loc, string Asin)
        {
            this.QtyOrdered = QtyOrdered;
            this.QtyShipped = QtyShipped;
            this.ProductName = ProductName;
            this.Loc = Loc;
            this.ASIN = Asin;


        }
    }
}

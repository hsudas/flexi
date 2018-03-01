using System;
using System.ComponentModel.DataAnnotations;

namespace Flexi.Model.Entity.Dashboard
{
    public class PrintRequest
    {
        [Key]
        public long Id { get; set; }
        public string OrderId { get; set; }
        public string OrderItemId { get; set; }
        public string MarketPlace { get; set; }
        public string TrackingId { get; set; }
        public string ClientId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string LabelData { get; set; }
        public string DataType { get; set; }
    }

    public class PrintRequestArchive
    {
        [Key]
        public long Id { get; set; }
        public long PrintRequestId { get; set; }
        public string OrderId { get; set; }
        public string OrderItemId { get; set; }
        public string MarketPlace { get; set; }
        public string TrackingId { get; set; }
        public string ClientId { get; set; }
        public string RequestCreateUser { get; set; }
        public DateTime RequestCreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }

        public string LabelData { get; set; }

        public string LabelDataType { get; set; }
    }
    /*
     id bigserial,
orderid varchar(100),
orderitemid varchar(100),
marketplace  varchar(50),
trakingid varchar(100),
clientid varchar(100),
createuser varchar(100),
createdate timestamp default now()
     */
}

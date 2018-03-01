using System.Collections.Generic;

namespace Flexi.Model.Poco.Amazon
{
    public class GetShippingOffersRequest
    {
        public MWSMerchantFulfillmentService.Model.Address FromAddress { get; set; }
        public MWSMerchantFulfillmentService.Model.PackageDimensions PackageDimensions { get; set; }
        public MWSMerchantFulfillmentService.Model.Weight Weight { get; set; }
        public List<MWSMerchantFulfillmentService.Model.Item> ShipmentOrderItemList { get; set; }
        public string SellerOrderId { get; set; }
        public string AmazonOrderId { get; set; }
    }
}




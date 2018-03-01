using System.Collections.Generic;

namespace Flexi.Model.Poco.Walmart
{
    public class WalmartProductRoot
    {
        public int itemId { get; set; }
        public int parentItemId { get; set; }
        public string name { get; set; }
        public double salePrice { get; set; }
        public string upc { get; set; }
        public string categoryPath { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public string thumbnailImage { get; set; }
        public string mediumImage { get; set; }
        public string largeImage { get; set; }
        public string productTrackingUrl { get; set; }
        public double standardShipRate { get; set; }
        public bool marketplace { get; set; }
        public string sellerInfo { get; set; }
        public string productUrl { get; set; }
        public bool bundle { get; set; }
        public bool clearance { get; set; }
        public bool preOrder { get; set; }
        public string stock { get; set; }
        public string addToCartUrl { get; set; }
        public string affiliateAddToCartUrl { get; set; }
        public bool freeShippingOver50Dollars { get; set; }
        public List<ImageEntity> imageEntities { get; set; }
        public string offerType { get; set; }
        public bool shippingPassEligible { get; set; }
        public bool availableOnline { get; set; }
    }

    public class ImageEntity
    {
        public string thumbnailImage { get; set; }
        public string mediumImage { get; set; }
        public string largeImage { get; set; }
        public string entityType { get; set; }
    }
}

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{
    [XmlRoot(ElementName = "MarketplaceASIN", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class MarketplaceASIN
    {
        [XmlElement(ElementName = "MarketplaceId", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string MarketplaceId { get; set; }
        [XmlElement(ElementName = "ASIN", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string ASIN { get; set; }
    }

    [XmlRoot(ElementName = "Identifiers", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class Identifiers
    {
        [XmlElement(ElementName = "MarketplaceASIN", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public MarketplaceASIN MarketplaceASIN { get; set; }
    }

    [XmlRoot(ElementName = "Height", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
    public class Height
    {
        [XmlAttribute(AttributeName = "Units")]
        public string Units { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Length", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
    public class Length
    {
        [XmlAttribute(AttributeName = "Units")]
        public string Units { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Width", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
    public class Width
    {
        [XmlAttribute(AttributeName = "Units")]
        public string Units { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Weight", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
    public class Weight
    {
        [XmlAttribute(AttributeName = "Units")]
        public string Units { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ItemDimensions", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
    public class ItemDimensions
    {
        [XmlElement(ElementName = "Height", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public Height Height { get; set; }
        [XmlElement(ElementName = "Length", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public Length Length { get; set; }
        [XmlElement(ElementName = "Width", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public Width Width { get; set; }
        [XmlElement(ElementName = "Weight", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public Weight Weight { get; set; }
    }

    [XmlRoot(ElementName = "ListPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
    public class ListPrice
    {
        [XmlElement(ElementName = "Amount", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string Amount { get; set; }
        [XmlElement(ElementName = "CurrencyCode", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string CurrencyCode { get; set; }
    }

    [XmlRoot(ElementName = "PackageDimensions", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
    public class PackageDimensions
    {
        [XmlElement(ElementName = "Height", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public Height Height { get; set; }
        [XmlElement(ElementName = "Length", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public Length Length { get; set; }
        [XmlElement(ElementName = "Width", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public Width Width { get; set; }
        [XmlElement(ElementName = "Weight", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public Weight Weight { get; set; }
    }

    [XmlRoot(ElementName = "SmallImage", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
    public class SmallImage
    {
        [XmlElement(ElementName = "URL", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string URL { get; set; }
        [XmlElement(ElementName = "Height", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public Height Height { get; set; }
        [XmlElement(ElementName = "Width", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public Width Width { get; set; }
    }

    [XmlRoot(ElementName = "ItemAttributes", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
    public class ItemAttributes
    {
        [XmlElement(ElementName = "Binding", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string Binding { get; set; }
        [XmlElement(ElementName = "Brand", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string Brand { get; set; }
        [XmlElement(ElementName = "Flavor", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string Flavor { get; set; }
        [XmlElement(ElementName = "ItemDimensions", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public ItemDimensions ItemDimensions { get; set; }
        [XmlElement(ElementName = "IsAdultProduct", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string IsAdultProduct { get; set; }
        [XmlElement(ElementName = "Label", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string Label { get; set; }
        [XmlElement(ElementName = "ListPrice", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public ListPrice ListPrice { get; set; }
        [XmlElement(ElementName = "Manufacturer", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string Manufacturer { get; set; }
        [XmlElement(ElementName = "Model", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string Model { get; set; }
        [XmlElement(ElementName = "NumberOfItems", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string NumberOfItems { get; set; }
        [XmlElement(ElementName = "PackageDimensions", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public PackageDimensions PackageDimensions { get; set; }
        [XmlElement(ElementName = "PackageQuantity", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public int? PackageQuantity { get; set; }
        [XmlElement(ElementName = "PartNumber", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string PartNumber { get; set; }
        [XmlElement(ElementName = "ProductGroup", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string ProductGroup { get; set; }
        [XmlElement(ElementName = "ProductTypeName", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string ProductTypeName { get; set; }
        [XmlElement(ElementName = "Publisher", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string Publisher { get; set; }
        [XmlElement(ElementName = "Size", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string Size { get; set; }
        [XmlElement(ElementName = "SmallImage", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public SmallImage SmallImage { get; set; }
        [XmlElement(ElementName = "Studio", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string Studio { get; set; }
        [XmlElement(ElementName = "Title", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public string Title { get; set; }
        [XmlAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Lang { get; set; }
    }

    [XmlRoot(ElementName = "AttributeSets", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class AttributeSets
    {
        [XmlElement(ElementName = "ItemAttributes", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd")]
        public ItemAttributes ItemAttributes { get; set; }
    }

    [XmlRoot(ElementName = "VariationParent", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class VariationParent
    {
        [XmlElement(ElementName = "Identifiers", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Identifiers Identifiers { get; set; }
    }

    [XmlRoot(ElementName = "Relationships", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class Relationships
    {
        [XmlElement(ElementName = "VariationParent", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public VariationParent VariationParent { get; set; }
    }

    [XmlRoot(ElementName = "SalesRank", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class SalesRank
    {
        [XmlElement(ElementName = "ProductCategoryId", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string ProductCategoryId { get; set; }
        [XmlElement(ElementName = "Rank", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public string Rank { get; set; }
    }

    [XmlRoot(ElementName = "SalesRankings", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class SalesRankings
    {
        [XmlElement(ElementName = "SalesRank", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public List<SalesRank> SalesRank { get; set; }
    }

    [XmlRoot(ElementName = "Product", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class Product
    {
        [XmlElement(ElementName = "Identifiers", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Identifiers Identifiers { get; set; }
        [XmlElement(ElementName = "AttributeSets", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public AttributeSets AttributeSets { get; set; }
        [XmlElement(ElementName = "Relationships", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Relationships Relationships { get; set; }
        [XmlElement(ElementName = "SalesRankings", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public SalesRankings SalesRankings { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns2 { get; set; }
    }

    [XmlRoot(ElementName = "GetMatchingProductResult", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class GetMatchingProductResult
    {
        [XmlElement(ElementName = "Product", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Product Product { get; set; }
        [XmlAttribute(AttributeName = "ASIN")]
        public string ASIN { get; set; }
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "Error", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public Error Error { get; set; }
    }

    [XmlRoot(ElementName = "GetMatchingProductResponse", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    public class GetMatchingProductResponse
    {
        [XmlElement(ElementName = "GetMatchingProductResult", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public GetMatchingProductResult GetMatchingProductResult { get; set; }
        [XmlElement(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
        public ResponseMetadata ResponseMetadata { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    //[XmlRoot(ElementName = "Error", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //public class Error
    //{
    //    [XmlElement(ElementName = "Type", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //    public string Type { get; set; }
    //    [XmlElement(ElementName = "Code", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //    public string Code { get; set; }
    //    [XmlElement(ElementName = "Message", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //    public string Message { get; set; }
    //}

    //[XmlRoot(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //public class ResponseMetadata
    //{
    //    [XmlElement(ElementName = "RequestId", Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    //    public string RequestId { get; set; }
    //}    
}

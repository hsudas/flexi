using System.Collections.Generic;

namespace Flexi.Model.Poco.Walmart.Response3
{
    public class FeedStatusResponse
    {
        public string FeedId { get; set; }
        public string FeedStatus { get; set; }
        public object ShipNode { get; set; }
        public IngestionErrors IngestionErrors { get; set; }
        public int ItemsReceived { get; set; }
        public int ItemsSucceeded { get; set; }
        public int ItemsFailed { get; set; }
        public int ItemsProcessing { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
        public ItemDetails ItemDetails { get; set; }
    }

    public class IngestionErrors
    {
        public object IngestionError { get; set; }
    }

    public class IngestionError
    {
        public string Type { get; set; }
        public string Code { get; set; }
        public string Field { get; set; }
        public string Description { get; set; }
    }

    public class IngestionErrors2
    {
        public List<IngestionError> IngestionError { get; set; }
    }

    public class ItemIngestionStatu
    {
        public int MartId { get; set; }
        public string Sku { get; set; }
        public string WpId { get; set; }
        public int Index { get; set; }
        public string IngestionStatus { get; set; }
        public IngestionErrors2 IngestionErrors { get; set; }
    }

    public class ItemDetails
    {
        public List<ItemIngestionStatu> ItemIngestionStatus { get; set; }
    }


}

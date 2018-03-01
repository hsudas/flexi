namespace Flexi.Model.Poco.ThirdParty
{
    public class BenasseInventoryResponse
    {
        public string Upc { get; set; }
        public string Sku { get; set; }
        public string Asin { get; set; }
        public int Quantity { get; set; }
        public int WarehouseId { get; set; }
        public double Cost { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
}

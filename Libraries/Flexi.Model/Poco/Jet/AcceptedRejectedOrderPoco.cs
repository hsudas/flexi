namespace Flexi.Model.Poco.Jet
{
    public class AcceptedRejectedOrderPoco
    {
        public string Sku { get; set; }
        public bool HasValidInventory { get; set; }
        public string OrderItemId { get; set; }
    }
}

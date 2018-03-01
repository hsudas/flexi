namespace Flexi.Model.Enum.Amazon
{
    //http://docs.developer.amazonservices.com/en_ES/fba_outbound/FBAOutbound_Datatypes.html    FulfillmentShipmentStatus
    public enum FulfillmentShipmentStatus
    {
        PENDING,
        SHIPPED,
        CANCELLED_BY_FULFILLER,
        CANCELLED_BY_SELLER
    }
}

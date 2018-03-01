using System.ComponentModel;

namespace Flexi.Model.Enum.Amazon
{
    //http://docs.developer.amazonservices.com/en_ES/fba_outbound/FBAOutbound_Datatypes.html   FulfillmentOrderStatus
    public enum FulfillmentOrderStatus
    {
        [Description("Received")]
        RECEIVED,
        [Description("Invalid")]
        INVALID,
        [Description("Planning")]
        PLANNING,
        [Description("Processing")]
        PROCESSING,
        [Description("Cancelled")]
        CANCELLED,
        [Description("Complete")]
        COMPLETE,
        [Description("Complete_partialled")]
        COMPLETE_PARTIALLED,
        [Description("Unfulfillable")]
        UNFULFILLABLE

    }
}

using System.ComponentModel;

namespace Flexi.Model.Enum.MP
{
    public enum ItemSourceChannel
    {
        [Description("PURCHASE ORDER")]
        PURCHASEORDER,
        [Description("RETURN-FBA")]
        RETURNFBA,
        [Description("RETURN-CUSTOMER")]
        RETURNCUSTOMER,
        [Description("SUPPLY")]
        SUPPLY,

    }
}

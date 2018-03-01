using System.ComponentModel;

namespace Flexi.Model.Enum.Amazon
{
    public enum ShippingTemplate
    {
        [Description("CA/NJ Prime template")]
        PRIMEALL,
        [Description("NJ Prime template")]
        PRIMENJ,
        [Description("CA-Prime template")]
        PRIMECA,
        NONPRIME
    }
}

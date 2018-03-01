using System.ComponentModel;

namespace Flexi.Model.Enum.Jet
{
    public enum RefundReason
    {
        [Description("No longer want this item")]
        NoLongerWantThisItem,
        [Description("Received the wrong item")]
        ReceivedTheWrongItem,
        [Description("Website description is inaccurate")]
        WebsiteDescriptionIsInaccurate,
        [Description("Product is defective / does not work")]
        ProductIsDefectiveDoesNotWork,
        [Description("Item arrived damaged - box intact")]
        ItemArrivedDamagedBoxIntact,
        [Description("Item arrived damaged - box damaged")]
        ItemArrivedDamagedBoxDamaged,
        [Description("Package never arrived")]
        PackageNeverArrived,
        [Description("Wrong quantity received")]
        WrongQuantityReceived,
        [Description("Better price found elsewhere")]
        BetterPriceFoundElseWhere,
        [Description("Unauthorized purchase")]
        UnauthorizedPurchase,
        [Description("Item is missing parts / accessories")]
        ItemIsMissingPartsAccessories,
        [Description("Item is refurbished")]
        ItemIsRefurbished,
        [Description("Item is expired")]
        ItemIsExpired,
        //[Description("Item does not fit")]
        //ItemDoesNotFit
    }
}

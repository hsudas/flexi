using System.ComponentModel;

namespace Flexi.Model.Enum.Walmart
{

    public enum ReasonCodeType
    {

        [Description("Billing Error")]
        BillingError,
        [Description("Tax Exempt Customer")]
        TaxExemptCustomer,
        [Description("Item Not As Advertised")]
        ItemNotAsAdvertised,
        [Description("Incorrect Item Received")]
        IncorrectItemReceived,
        [Description("Cancelled Yet Shipped")]
        CancelledYetShipped,
        [Description("Item Not Received By Customer")]
        ItemNotReceivedByCustomer,
        [Description("Incorrect Shipping Price")]
        IncorrectShippingPrice,
        [Description("Damaged Item")]
        DamagedItem,
        [Description("Defective Item")]
        DefectiveItem,
        [Description("Customer Changed Mind")]
        CustomerChangedMind,
        [Description("Customer Received Item Late")]
        CustomerReceivedItemLate,
        [Description("Missing Parts Instructions")]
        MissingPartsInstructions,
        [Description("Finance Good will")]
        FinanceGoodwill,
        [Description("Finance Rollback")]
        FinanceRollback,
        [Description("Others")]
        Others
    }
}

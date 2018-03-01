namespace Flexi.Model.Enum.Amazon
{
    public enum OrderItemStatus
    {
        PENDING = 1,
        AMAZONHOLD = 2,
        INSUFFICIENTPRODUCT = 3,
        ACKNOWLEDGED = 4,
        UNSHIPPED = 5, // for fulfillment by royal, after acknowledged
        AMAZONSHIPPING = 6,
        AMAZONSHIPPED = 7,
        //AMAZONPROCESS,        
        //TRACKINGREADY,
        COMPLETED = 8,
        CANCEL = 9,
        //COMPLETEDCANCEL,
        ERROR = 10,
        MONITORING = 11,
        REFUND = 12

    }
}

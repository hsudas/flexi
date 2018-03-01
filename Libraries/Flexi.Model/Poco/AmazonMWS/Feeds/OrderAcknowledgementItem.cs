namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class OrderAcknowledgementItem
    {
        
        private string amazonOrderItemCodeField;
        
        private string merchantOrderItemIDField;
        
        private OrderAcknowledgementItemCancelReason cancelReasonField;
        
        private bool cancelReasonFieldSpecified;
        
        /// <remarks/>
        public string AmazonOrderItemCode
        {
            get
            {
                return this.amazonOrderItemCodeField;
            }
            set
            {
                this.amazonOrderItemCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantOrderItemID
        {
            get
            {
                return this.merchantOrderItemIDField;
            }
            set
            {
                this.merchantOrderItemIDField = value;
            }
        }
        
        /// <remarks/>
        public OrderAcknowledgementItemCancelReason CancelReason
        {
            get
            {
                return this.cancelReasonField;
            }
            set
            {
                this.cancelReasonField = value;
                this.CancelReasonSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancelReasonSpecified
        {
            get
            {
                return this.cancelReasonFieldSpecified;
            }
            set
            {
                this.cancelReasonFieldSpecified = value;
            }
        }
    }
}

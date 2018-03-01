namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SettlementReportAdjustmentFulfillment
    {
        
        private string merchantFulfillmentIDField;
        
        private System.DateTime postedDateField;
        
        private SettlementReportAdjustmentFulfillmentAdjustedItem[] adjustedItemField;
        
        private DirectPaymentTypeComponent[] directPaymentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantFulfillmentID
        {
            get
            {
                return this.merchantFulfillmentIDField;
            }
            set
            {
                this.merchantFulfillmentIDField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime PostedDate
        {
            get
            {
                return this.postedDateField;
            }
            set
            {
                this.postedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdjustedItem")]
        public SettlementReportAdjustmentFulfillmentAdjustedItem[] AdjustedItem
        {
            get
            {
                return this.adjustedItemField;
            }
            set
            {
                this.adjustedItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable=false)]
        public DirectPaymentTypeComponent[] DirectPayment
        {
            get
            {
                return this.directPaymentField;
            }
            set
            {
                this.directPaymentField = value;
            }
        }
    }
}

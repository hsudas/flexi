namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SettlementReportOrderFulfillment
    {
        
        private string merchantFulfillmentIDField;
        
        private System.DateTime postedDateField;
        
        private SettlementReportOrderFulfillmentItem[] itemField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public SettlementReportOrderFulfillmentItem[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
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

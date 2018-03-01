namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SettlementReportSettlementData
    {
        
        private string amazonSettlementIDField;
        
        private CurrencyAmount totalAmountField;
        
        private System.DateTime startDateField;
        
        private System.DateTime endDateField;
        
        private System.DateTime depositDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string AmazonSettlementID
        {
            get
            {
                return this.amazonSettlementIDField;
            }
            set
            {
                this.amazonSettlementIDField = value;
            }
        }
        
        /// <remarks/>
        public CurrencyAmount TotalAmount
        {
            get
            {
                return this.totalAmountField;
            }
            set
            {
                this.totalAmountField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DepositDate
        {
            get
            {
                return this.depositDateField;
            }
            set
            {
                this.depositDateField = value;
            }
        }
    }
}

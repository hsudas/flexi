namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SettlementReport
    {
        
        private SettlementReportSettlementData settlementDataField;
        
        private SettlementReportOrder[] orderField;
        
        private SettlementReportAdjustment[] adjustmentField;
        
        private SettlementReportOtherFee[] otherFeeField;
        
        private SettlementReportOtherTransaction[] otherTransactionField;
        
        private SettlementReportMiscEvent[] miscEventField;
        
        /// <remarks/>
        public SettlementReportSettlementData SettlementData
        {
            get
            {
                return this.settlementDataField;
            }
            set
            {
                this.settlementDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Order")]
        public SettlementReportOrder[] Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Adjustment")]
        public SettlementReportAdjustment[] Adjustment
        {
            get
            {
                return this.adjustmentField;
            }
            set
            {
                this.adjustmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherFee")]
        public SettlementReportOtherFee[] OtherFee
        {
            get
            {
                return this.otherFeeField;
            }
            set
            {
                this.otherFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherTransaction")]
        public SettlementReportOtherTransaction[] OtherTransaction
        {
            get
            {
                return this.otherTransactionField;
            }
            set
            {
                this.otherTransactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MiscEvent")]
        public SettlementReportMiscEvent[] MiscEvent
        {
            get
            {
                return this.miscEventField;
            }
            set
            {
                this.miscEventField = value;
            }
        }
    }
}

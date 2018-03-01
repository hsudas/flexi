namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SettlementReportOrder
    {
        
        private string amazonOrderIDField;
        
        private string merchantOrderIDField;
        
        private System.DateTime postedDateField;
        
        private bool postedDateFieldSpecified;
        
        private SettlementReportOrderItem[] itemField;
        
        private DirectPaymentTypeComponent[] directPaymentField;
        
        private object shipmentIDField;
        
        private AmazonFeesFee[] shipmentFeesField;
        
        private string marketplaceNameField;
        
        private SettlementReportOrderFulfillment fulfillmentField;
        
        private AmazonFeesFee[] orderFeeField;
        
        /// <remarks/>
        public string AmazonOrderID
        {
            get
            {
                return this.amazonOrderIDField;
            }
            set
            {
                this.amazonOrderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MerchantOrderID
        {
            get
            {
                return this.merchantOrderIDField;
            }
            set
            {
                this.merchantOrderIDField = value;
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
                this.PostedDateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PostedDateSpecified
        {
            get
            {
                return this.postedDateFieldSpecified;
            }
            set
            {
                this.postedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public SettlementReportOrderItem[] Item
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
        
        /// <remarks/>
        public object ShipmentID
        {
            get
            {
                return this.shipmentIDField;
            }
            set
            {
                this.shipmentIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", typeof(AmazonFeesFee), IsNullable=false)]
        public AmazonFeesFee[] ShipmentFees
        {
            get
            {
                return this.shipmentFeesField;
            }
            set
            {
                this.shipmentFeesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MarketplaceName
        {
            get
            {
                return this.marketplaceNameField;
            }
            set
            {
                this.marketplaceNameField = value;
            }
        }
        
        /// <remarks/>
        public SettlementReportOrderFulfillment Fulfillment
        {
            get
            {
                return this.fulfillmentField;
            }
            set
            {
                this.fulfillmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", typeof(AmazonFeesFee), IsNullable=false)]
        public AmazonFeesFee[] OrderFee
        {
            get
            {
                return this.orderFeeField;
            }
            set
            {
                this.orderFeeField = value;
            }
        }
    }
}

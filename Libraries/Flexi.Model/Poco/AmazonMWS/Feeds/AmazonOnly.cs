namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute("Amazon-Only", Namespace="", IsNullable=false)]
    public partial class AmazonOnly
    {
        
        private string tierField;
        
        private string purchasingCategoryField;
        
        private string purchasingSubCategoryField;
        
        private string packagingTypeField;
        
        private AmazonOnlyUnderlyingAvailability underlyingAvailabilityField;
        
        private AmazonOnlyReplenishmentCategory replenishmentCategoryField;
        
        private AmazonOnlyDropShipStatus dropShipStatusField;
        
        private AmazonOnlyOutOfStockWebsiteMessage outOfStockWebsiteMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string Tier
        {
            get
            {
                return this.tierField;
            }
            set
            {
                this.tierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string PurchasingCategory
        {
            get
            {
                return this.purchasingCategoryField;
            }
            set
            {
                this.purchasingCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string PurchasingSubCategory
        {
            get
            {
                return this.purchasingSubCategoryField;
            }
            set
            {
                this.purchasingSubCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string PackagingType
        {
            get
            {
                return this.packagingTypeField;
            }
            set
            {
                this.packagingTypeField = value;
            }
        }
        
        /// <remarks/>
        public AmazonOnlyUnderlyingAvailability UnderlyingAvailability
        {
            get
            {
                return this.underlyingAvailabilityField;
            }
            set
            {
                this.underlyingAvailabilityField = value;
            }
        }
        
        /// <remarks/>
        public AmazonOnlyReplenishmentCategory ReplenishmentCategory
        {
            get
            {
                return this.replenishmentCategoryField;
            }
            set
            {
                this.replenishmentCategoryField = value;
            }
        }
        
        /// <remarks/>
        public AmazonOnlyDropShipStatus DropShipStatus
        {
            get
            {
                return this.dropShipStatusField;
            }
            set
            {
                this.dropShipStatusField = value;
            }
        }
        
        /// <remarks/>
        public AmazonOnlyOutOfStockWebsiteMessage OutOfStockWebsiteMessage
        {
            get
            {
                return this.outOfStockWebsiteMessageField;
            }
            set
            {
                this.outOfStockWebsiteMessageField = value;
            }
        }
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class OrderAdjustment
    {
        
        private string itemField;
        
        private ItemChoiceType1 itemElementNameField;
        
        private OrderAdjustmentActionType actionTypeField;
        
        private bool actionTypeFieldSpecified;
        
        private OrderAdjustmentCODCollectionMethod cODCollectionMethodField;
        
        private bool cODCollectionMethodFieldSpecified;
        
        private OrderAdjustmentAdjustedItem[] adjustedItemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AmazonOrderID", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MerchantOrderID", typeof(string), DataType="normalizedString")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
        
        /// <remarks/>
        public OrderAdjustmentActionType ActionType
        {
            get
            {
                return this.actionTypeField;
            }
            set
            {
                this.actionTypeField = value;
                this.ActionTypeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionTypeSpecified
        {
            get
            {
                return this.actionTypeFieldSpecified;
            }
            set
            {
                this.actionTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public OrderAdjustmentCODCollectionMethod CODCollectionMethod
        {
            get
            {
                return this.cODCollectionMethodField;
            }
            set
            {
                this.cODCollectionMethodField = value;
                this.CODCollectionMethodSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CODCollectionMethodSpecified
        {
            get
            {
                return this.cODCollectionMethodFieldSpecified;
            }
            set
            {
                this.cODCollectionMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdjustedItem")]
        public OrderAdjustmentAdjustedItem[] AdjustedItem
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
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class RebateType
    {
        
        private System.DateTime rebateStartDateField;
        
        private System.DateTime rebateEndDateField;
        
        private string rebateMessageField;
        
        private string rebateNameField;
        
        /// <remarks/>
        public System.DateTime RebateStartDate
        {
            get
            {
                return this.rebateStartDateField;
            }
            set
            {
                this.rebateStartDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime RebateEndDate
        {
            get
            {
                return this.rebateEndDateField;
            }
            set
            {
                this.rebateEndDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string RebateMessage
        {
            get
            {
                return this.rebateMessageField;
            }
            set
            {
                this.rebateMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string RebateName
        {
            get
            {
                return this.rebateNameField;
            }
            set
            {
                this.rebateNameField = value;
            }
        }
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("CharacterData", Namespace="", IsNullable=false)]
    public partial class CharacterDataType
    {
        
        private string sKUField;
        
        private System.DateTime effectiveTimestampField;
        
        private bool effectiveTimestampFieldSpecified;
        
        private string[] pluginField;
        
        private string additionalMessageDiscriminatorField;
        
        private string payloadField;
        
        private string schemaVersionField;
        
        private bool isOfferOnlyUpdateField;
        
        private bool isOfferOnlyUpdateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime EffectiveTimestamp
        {
            get
            {
                return this.effectiveTimestampField;
            }
            set
            {
                this.effectiveTimestampField = value;
                this.EffectiveTimestampSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveTimestampSpecified
        {
            get
            {
                return this.effectiveTimestampFieldSpecified;
            }
            set
            {
                this.effectiveTimestampFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Plugin")]
        public string[] Plugin
        {
            get
            {
                return this.pluginField;
            }
            set
            {
                this.pluginField = value;
            }
        }
        
        /// <remarks/>
        public string AdditionalMessageDiscriminator
        {
            get
            {
                return this.additionalMessageDiscriminatorField;
            }
            set
            {
                this.additionalMessageDiscriminatorField = value;
            }
        }
        
        /// <remarks/>
        public string Payload
        {
            get
            {
                return this.payloadField;
            }
            set
            {
                this.payloadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schemaVersion
        {
            get
            {
                return this.schemaVersionField;
            }
            set
            {
                this.schemaVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isOfferOnlyUpdate
        {
            get
            {
                return this.isOfferOnlyUpdateField;
            }
            set
            {
                this.isOfferOnlyUpdateField = value;
                this.isOfferOnlyUpdateSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOfferOnlyUpdateSpecified
        {
            get
            {
                return this.isOfferOnlyUpdateFieldSpecified;
            }
            set
            {
                this.isOfferOnlyUpdateFieldSpecified = value;
            }
        }
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{


    /// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class AmazonEnvelope
    {

        private Header headerField;

        private AmazonEnvelopeMessageType messageTypeField;

        private string marketplaceNameField;

        private bool purgeAndReplaceField;

        private bool purgeAndReplaceFieldSpecified;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private AmazonEnvelopeMessage[] messageField;

        /// <remarks/>
        public Header Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public AmazonEnvelopeMessageType MessageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
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
        public bool PurgeAndReplace
        {
            get
            {
                return this.purgeAndReplaceField;
            }
            set
            {
                this.purgeAndReplaceField = value;
                this.PurgeAndReplaceSpecified = true;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurgeAndReplaceSpecified
        {
            get
            {
                return this.purgeAndReplaceFieldSpecified;
            }
            set
            {
                this.purgeAndReplaceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
                this.EffectiveDateSpecified = true;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveDateSpecified
        {
            get
            {
                return this.effectiveDateFieldSpecified;
            }
            set
            {
                this.effectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Message")]
        public AmazonEnvelopeMessage[] Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
}

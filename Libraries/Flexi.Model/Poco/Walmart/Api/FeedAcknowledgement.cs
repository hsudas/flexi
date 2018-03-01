namespace Flexi.Model.Poco.Walmart.Api.Ack
{
    using System.Xml.Serialization;

    [XmlRoot("FeedAcknowledgement", Namespace = "http://walmart.com/")]
    public partial class FeedAcknowledgement
    {

        private string feedIdField;

        private IngestionError errorField;

        public FeedAcknowledgement()
        {

        }

        public string feedId
        {
            get
            {
                return this.feedIdField;
            }
            set
            {
                this.feedIdField = value;
            }
        }

        public IngestionError error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }

    public partial class IngestionError
    {

        private ErrorType typeField;

        private string codeField;

        private string descriptionField;

        public ErrorType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    public enum ErrorType
    {

        /// <remarks/>
        DATA_ERROR,

        /// <remarks/>
        SYSTEM_ERROR,

        /// <remarks/>
        TIMEOUT_ERROR,
    }
}

using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{
    [XmlRoot(ElementName = "RequestReportResponse", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    public class RequestReportResponse
    {
        [XmlElement(ElementName = "RequestReportResult", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public RequestReportResult RequestReportResult { get; set; }
        [XmlElement(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public ResponseMetadata ResponseMetadata { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    //[XmlRoot(ElementName = "ReportRequestInfo", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //public class ReportRequestInfo
    //{
    //    [XmlElement(ElementName = "ReportRequestId", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //    public string ReportRequestId { get; set; }
    //    [XmlElement(ElementName = "ReportType", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //    public string ReportType { get; set; }
    //    [XmlElement(ElementName = "StartDate", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //    public DateTime StartDate { get; set; }
    //    [XmlElement(ElementName = "EndDate", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //    public DateTime EndDate { get; set; }
    //    [XmlElement(ElementName = "Scheduled", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //    public string Scheduled { get; set; }
    //    [XmlElement(ElementName = "SubmittedDate", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //    public DateTime SubmittedDate { get; set; }
    //    [XmlElement(ElementName = "ReportProcessingStatus", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //    public string ReportProcessingStatus { get; set; }
    //}

    [XmlRoot(ElementName = "RequestReportResult", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    public class RequestReportResult
    {
        [XmlElement(ElementName = "ReportRequestInfo", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public ReportRequestInfo ReportRequestInfo { get; set; }
    }

    //[XmlRoot(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //public class ResponseMetadata
    //{
    //    [XmlElement(ElementName = "RequestId", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //    public string RequestId { get; set; }
    //}
}

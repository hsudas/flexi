using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.AmazonMWS.Response
{
    [XmlRoot(ElementName = "GetReportRequestListResponse", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    public class GetReportRequestListResponse
    {
        [XmlElement(ElementName = "GetReportRequestListResult", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public GetReportRequestListResult GetReportRequestListResult { get; set; }
        [XmlElement(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public ResponseMetadata ResponseMetadata { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "ReportRequestInfo", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    public class ReportRequestInfo
    {
        [XmlElement(ElementName = "ReportType", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public string ReportType { get; set; }
        [XmlElement(ElementName = "ReportProcessingStatus", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public string ReportProcessingStatus { get; set; }
        [XmlElement(ElementName = "EndDate", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public DateTime? EndDate { get; set; }
        [XmlElement(ElementName = "Scheduled", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public string Scheduled { get; set; }
        [XmlElement(ElementName = "ReportRequestId", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public string ReportRequestId { get; set; }
        [XmlElement(ElementName = "StartedProcessingDate", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public DateTime? StartedProcessingDate { get; set; }
        [XmlElement(ElementName = "SubmittedDate", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public DateTime? SubmittedDate { get; set; }
        [XmlElement(ElementName = "CompletedDate", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public string CompletedDate { get; set; }
        [XmlElement(ElementName = "StartDate", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public DateTime? StartDate { get; set; }
        [XmlElement(ElementName = "GeneratedReportId", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public Int64 GeneratedReportId { get; set; }
    }

    [XmlRoot(ElementName = "GetReportRequestListResult", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    public class GetReportRequestListResult
    {
        [XmlElement(ElementName = "HasNext", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public string HasNext { get; set; }
        [XmlElement(ElementName = "ReportRequestInfo", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public List<ReportRequestInfo> ReportRequestInfo { get; set; }
        [XmlElement(ElementName = "NextToken", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
        public string NextToken { get; set; }
    }

    //[XmlRoot(ElementName = "ResponseMetadata", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //public class ResponseMetadata
    //{
    //    [XmlElement(ElementName = "RequestId", Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    //    public string RequestId { get; set; }
    //}
}

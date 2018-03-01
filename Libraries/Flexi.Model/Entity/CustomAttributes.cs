using System;
using System.Xml.Serialization;

namespace Flexi.Model
{
    [Serializable]
    public class CustomAttributes
    {
        public string OperationType { get; set; }
        public string ASIN { get; set; }
        public string Title { get; set; }

        public string Brand { get; set; }
        public string MerchantShippingGroupName { get; set; }

        public string ItemType { get; set; }
        public string FulfillmentCenterID { get; set; }

        public string Lookup { get; set; }

        public string SwitchFulfillmentTo { get; set; }


        public string ToXML()
        {
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(this.GetType());
            serializer.Serialize(stringwriter, this);
            return stringwriter.ToString();
        }
    }
}

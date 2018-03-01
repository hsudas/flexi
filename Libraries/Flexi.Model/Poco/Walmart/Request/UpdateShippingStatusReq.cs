using System.Collections.Generic;
using System.Xml.Serialization;

namespace Flexi.Model.Poco.Walmart.Request
{
    [XmlRoot("orderShipment", Namespace = "http://walmart.com/mp/v3/orders")]
    public class OrderShipment
    {
        //[System.Xml.Serialization.XmlElement("orderLines")]
        private List<ShippingLineType> OrderLinesField;

        public OrderShipment()
        {
        }

        [XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns2 { get; set; }

        [XmlArray("orderLines", IsNullable = false)]
        [XmlArrayItem("orderLine", IsNullable = false)]
        public List<ShippingLineType> OrderLines
        {
            get
            {
                return this.OrderLinesField;
            }
            set
            {
                this.OrderLinesField = value;
            }
        }

        public partial class ShippingLineType
        {
            private string lineNumberField;

            private List<ShipLineStatusType> OrderLineStatusesField;

            public ShippingLineType()
            {
                this.OrderLineStatusesField = new List<ShipLineStatusType>();
            }

            public string lineNumber
            {
                get
                {
                    return this.lineNumberField;
                }
                set
                {
                    this.lineNumberField = value;
                }
            }

            [XmlArray("orderLineStatuses", IsNullable = false)]
            [XmlArrayItem("orderLineStatus", IsNullable = false)]
            public List<ShipLineStatusType> OrderLineStatuses
            {
                get
                {
                    return this.OrderLineStatusesField;
                }
                set
                {
                    this.OrderLineStatusesField = value;
                }
            }
        }

        public partial class ShipLineStatusType
        {

            private OrderLineStatusValueType statusField;

            private QuantityType statusQuantityField;

            private TrackingInfoType trackingInfoField;

            public ShipLineStatusType()
            {
                this.trackingInfoField = new TrackingInfoType();
                this.statusQuantityField = new QuantityType();
            }

            public OrderLineStatusValueType status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            public QuantityType statusQuantity
            {
                get
                {
                    return this.statusQuantityField;
                }
                set
                {
                    this.statusQuantityField = value;
                }
            }

            public TrackingInfoType trackingInfo
            {
                get
                {
                    return this.trackingInfoField;
                }
                set
                {
                    this.trackingInfoField = value;
                }
            }
        }

        public enum OrderLineStatusValueType
        {

            /// <remarks/>
            Created,

            /// <remarks/>
            Acknowledged,

            /// <remarks/>
            Shipped,

            /// <remarks/>
            Cancelled,

            /// <remarks/>
            Refund,
        }

        public partial class QuantityType
        {
            private string unitOfMeasurementField;

            private string amountField;

            public string unitOfMeasurement
            {
                get
                {
                    return this.unitOfMeasurementField;
                }
                set
                {
                    this.unitOfMeasurementField = value;
                }
            }

            public string amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }
        }

        public partial class CarrierNameType
        {
            private string otherCarrierField;

            public string otherCarrier
            {
                get
                {
                    return this.otherCarrierField;
                }
                set
                {
                    this.otherCarrierField = value;
                }
            }
            private CarrierType carrierField;

            public CarrierType carrier
            {
                get
                {
                    return this.carrierField;
                }
                set
                {
                    this.carrierField = value;
                }
            }
        }

        public enum CarrierType
        {

            /// <remarks/>
            UPS,

            /// <remarks/>
            USPS,

            /// <remarks/>
            FedEx,

            /// <remarks/>
            Airborne,

            /// <remarks/>
            OnTrac,
        }

        public partial class TrackingInfoType
        {

            private string ShipDateTimeField;

            private CarrierNameType CarrierNameField;

            private ShippingMethodCodeType MethodCodeField;

            private string TrackingNumberField;

            private string TrackingURLField;

            public TrackingInfoType()
            {

            }

            public string shipDateTime
            {
                get
                {
                    return this.ShipDateTimeField;
                }
                set
                {
                    this.ShipDateTimeField = value;
                }
            }

            public CarrierNameType carrierName
            {
                get
                {
                    return this.CarrierNameField;
                }
                set
                {
                    this.CarrierNameField = value;
                }
            }

            public ShippingMethodCodeType methodCode
            {
                get
                {
                    return this.MethodCodeField;
                }
                set
                {
                    this.MethodCodeField = value;
                }
            }

            [XmlElement("trackingNumber")]
            public string TrackingNumber
            {
                get
                {
                    return this.TrackingNumberField;
                }
                set
                {
                    this.TrackingNumberField = value;
                }
            }

            public string TrackingURL
            {
                get
                {
                    return this.TrackingURLField;
                }
                set
                {
                    this.TrackingURLField = value;
                }
            }
        }

        public partial class ShippingLinesType
        {

            private List<ShippingLineType> orderLineField;

            public ShippingLinesType()
            {
                this.orderLineField = new List<ShippingLineType>();
            }

            public List<ShippingLineType> orderLine
            {
                get
                {
                    return this.orderLineField;
                }
                set
                {
                    this.orderLineField = value;
                }
            }
        }

        public partial class ShipLineStatusesType
        {

            private List<ShipLineStatusType> OrderLineStatusField;

            public ShipLineStatusesType()
            {
                this.OrderLineStatusField = new List<ShipLineStatusType>();
            }

            public List<ShipLineStatusType> orderLineStatus
            {
                get
                {
                    return this.OrderLineStatusField;
                }
                set
                {
                    this.OrderLineStatusField = value;
                }
            }
        }
        public enum ShippingMethodCodeType
        {

            /// <remarks/>
            Standard,

            /// <remarks/>
            Express,

            /// <remarks/>
            OneDay,

            /// <remarks/>
            Freight,

            /// <remarks/>
            WhiteGlove,
        }
    }
}

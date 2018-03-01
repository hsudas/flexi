namespace Flexi.Model.Poco.Walmart.Api
{
    using System.Collections.Generic;
    using System.Xml.Serialization;


    public partial class InventoryHeader
    {

        private InventoryHeaderVersion versionField;

        private System.DateTime feedDateField;

        private bool feedDateFieldSpecified;

        public InventoryHeader()
        {
            this.versionField = InventoryHeaderVersion.Item14;
        }

        public InventoryHeaderVersion version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        public System.DateTime feedDate
        {
            get
            {
                return this.feedDateField;
            }
            set
            {
                this.feedDateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool feedDateSpecified
        {
            get
            {
                return this.feedDateFieldSpecified;
            }
            set
            {
                this.feedDateFieldSpecified = value;
            }
        }
    }

    public enum InventoryHeaderVersion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.4")]
        Item14,
    }

    [XmlRoot("inventory", Namespace = "http://walmart.com/")]
    public partial class Inventory
    {

        private string skuField;

        private Quantity quantityField;

        private int fulfillmentLagTimeField;

        public Inventory()
        {
            this.quantityField = new Quantity();
        }

        public string sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        public Quantity quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        public int fulfillmentLagTime
        {
            get
            {
                return this.fulfillmentLagTimeField;
            }
            set
            {
                this.fulfillmentLagTimeField = value;
            }
        }
    }

    public partial class Quantity
    {

        private UnitOfMeasurement unitField;

        private decimal amountField;

        public UnitOfMeasurement unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        public decimal amount
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

    public enum UnitOfMeasurement
    {

        /// <remarks/>
        EACH,
    }
    [XmlRoot("InventoryFeed", Namespace = "http://walmart.com/")]
    public partial class InventoryFeed
    {

        private InventoryHeader inventoryHeaderField;

        private List<Inventory> itemsField;

        public InventoryFeed()
        {
            this.itemsField = new List<Inventory>();
            this.inventoryHeaderField = new InventoryHeader();
        }

        public InventoryHeader InventoryHeader
        {
            get
            {
                return this.inventoryHeaderField;
            }
            set
            {
                this.inventoryHeaderField = value;
            }
        }


        public List<Inventory> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}

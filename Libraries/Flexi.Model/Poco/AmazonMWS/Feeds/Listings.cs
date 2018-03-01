namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Listings
    {
        
        private Product productField;
        
        private Relationship relationshipField;
        
        private ProductImage[] productImageField;
        
        private Price priceField;
        
        private Inventory inventoryField;
        
        private Override overrideField;
        
        /// <remarks/>
        public Product Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }
        
        /// <remarks/>
        public Relationship Relationship
        {
            get
            {
                return this.relationshipField;
            }
            set
            {
                this.relationshipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductImage")]
        public ProductImage[] ProductImage
        {
            get
            {
                return this.productImageField;
            }
            set
            {
                this.productImageField = value;
            }
        }
        
        /// <remarks/>
        public Price Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public Inventory Inventory
        {
            get
            {
                return this.inventoryField;
            }
            set
            {
                this.inventoryField = value;
            }
        }
        
        /// <remarks/>
        public Override Override
        {
            get
            {
                return this.overrideField;
            }
            set
            {
                this.overrideField = value;
            }
        }
    }
}

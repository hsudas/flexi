namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Beauty
    {
        
        private BeautyProductType productTypeField;
        
        private string batteryTypeLithiumIonField;
        
        private string batteryTypeLithiumMetalField;
        
        private decimal lithiumBatteryEnergyContentField;
        
        private bool lithiumBatteryEnergyContentFieldSpecified;
        
        private BeautyLithiumBatteryPackaging lithiumBatteryPackagingField;
        
        private bool lithiumBatteryPackagingFieldSpecified;
        
        private decimal lithiumBatteryVoltageField;
        
        private bool lithiumBatteryVoltageFieldSpecified;
        
        private decimal lithiumBatteryWeightField;
        
        private bool lithiumBatteryWeightFieldSpecified;
        
        private string medicineClassificationField;
        
        private string numberOfLithiumIonCellsField;
        
        private string numberOfLithiumMetalCellsField;
        
        private string plugTypeField;
        
        private string[] specificUsesForProductField;
        
        private string[] certificationField;
        
        private SunProtectionDimension sunProtectionField;
        
        private VoltageDecimalDimension voltageField;
        
        private WattageDimension wattageField;
        
        /// <remarks/>
        public BeautyProductType ProductType
        {
            get
            {
                return this.productTypeField;
            }
            set
            {
                this.productTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string BatteryTypeLithiumIon
        {
            get
            {
                return this.batteryTypeLithiumIonField;
            }
            set
            {
                this.batteryTypeLithiumIonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string BatteryTypeLithiumMetal
        {
            get
            {
                return this.batteryTypeLithiumMetalField;
            }
            set
            {
                this.batteryTypeLithiumMetalField = value;
            }
        }
        
        /// <remarks/>
        public decimal LithiumBatteryEnergyContent
        {
            get
            {
                return this.lithiumBatteryEnergyContentField;
            }
            set
            {
                this.lithiumBatteryEnergyContentField = value;
                this.LithiumBatteryEnergyContentSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LithiumBatteryEnergyContentSpecified
        {
            get
            {
                return this.lithiumBatteryEnergyContentFieldSpecified;
            }
            set
            {
                this.lithiumBatteryEnergyContentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public BeautyLithiumBatteryPackaging LithiumBatteryPackaging
        {
            get
            {
                return this.lithiumBatteryPackagingField;
            }
            set
            {
                this.lithiumBatteryPackagingField = value;
                this.LithiumBatteryPackagingSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LithiumBatteryPackagingSpecified
        {
            get
            {
                return this.lithiumBatteryPackagingFieldSpecified;
            }
            set
            {
                this.lithiumBatteryPackagingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal LithiumBatteryVoltage
        {
            get
            {
                return this.lithiumBatteryVoltageField;
            }
            set
            {
                this.lithiumBatteryVoltageField = value;
                this.LithiumBatteryVoltageSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LithiumBatteryVoltageSpecified
        {
            get
            {
                return this.lithiumBatteryVoltageFieldSpecified;
            }
            set
            {
                this.lithiumBatteryVoltageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal LithiumBatteryWeight
        {
            get
            {
                return this.lithiumBatteryWeightField;
            }
            set
            {
                this.lithiumBatteryWeightField = value;
                this.LithiumBatteryWeightSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LithiumBatteryWeightSpecified
        {
            get
            {
                return this.lithiumBatteryWeightFieldSpecified;
            }
            set
            {
                this.lithiumBatteryWeightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MedicineClassification
        {
            get
            {
                return this.medicineClassificationField;
            }
            set
            {
                this.medicineClassificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string NumberOfLithiumIonCells
        {
            get
            {
                return this.numberOfLithiumIonCellsField;
            }
            set
            {
                this.numberOfLithiumIonCellsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string NumberOfLithiumMetalCells
        {
            get
            {
                return this.numberOfLithiumMetalCellsField;
            }
            set
            {
                this.numberOfLithiumMetalCellsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string PlugType
        {
            get
            {
                return this.plugTypeField;
            }
            set
            {
                this.plugTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecificUsesForProduct", DataType="normalizedString")]
        public string[] SpecificUsesForProduct
        {
            get
            {
                return this.specificUsesForProductField;
            }
            set
            {
                this.specificUsesForProductField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Certification", DataType="normalizedString")]
        public string[] Certification
        {
            get
            {
                return this.certificationField;
            }
            set
            {
                this.certificationField = value;
            }
        }
        
        /// <remarks/>
        public SunProtectionDimension SunProtection
        {
            get
            {
                return this.sunProtectionField;
            }
            set
            {
                this.sunProtectionField = value;
            }
        }
        
        /// <remarks/>
        public VoltageDecimalDimension Voltage
        {
            get
            {
                return this.voltageField;
            }
            set
            {
                this.voltageField = value;
            }
        }
        
        /// <remarks/>
        public WattageDimension Wattage
        {
            get
            {
                return this.wattageField;
            }
            set
            {
                this.wattageField = value;
            }
        }
    }
}

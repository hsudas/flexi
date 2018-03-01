namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class FoodAndBeverages
    {
        
        private FoodAndBeveragesProductType productTypeField;
        
        private Battery batteryField;
        
        private decimal batteryAverageLifeField;
        
        private bool batteryAverageLifeFieldSpecified;
        
        private decimal batteryAverageLifeStandbyField;
        
        private bool batteryAverageLifeStandbyFieldSpecified;
        
        private decimal batteryChargeTimeField;
        
        private bool batteryChargeTimeFieldSpecified;
        
        private string colorField;
        
        private string colorMapField;
        
        private bool isAdultProductField;
        
        private bool isAdultProductFieldSpecified;
        
        private decimal lithiumBatteryEnergyContentField;
        
        private bool lithiumBatteryEnergyContentFieldSpecified;
        
        private FoodAndBeveragesLithiumBatteryPackaging lithiumBatteryPackagingField;
        
        private bool lithiumBatteryPackagingFieldSpecified;
        
        private string lithiumBatteryVoltageField;
        
        private string lithiumBatteryWeightField;
        
        private string mfrWarrantyDescriptionLaborField;
        
        private string mfrWarrantyDescriptionPartsField;
        
        private string mfrWarrantyDescriptionTypeField;
        
        private string numberOfLithiumIonCellsField;
        
        private string numberOfLithiumMetalCellsField;
        
        private string powerSourceField;
        
        private string sellerWarrantyDescriptionField;
        
        private FoodAndBeveragesTargetGender targetGenderField;
        
        private bool targetGenderFieldSpecified;
        
        private string deliveryScheduleGroupIdField;
        
        /// <remarks/>
        public FoodAndBeveragesProductType ProductType
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
        public Battery Battery
        {
            get
            {
                return this.batteryField;
            }
            set
            {
                this.batteryField = value;
            }
        }
        
        /// <remarks/>
        public decimal BatteryAverageLife
        {
            get
            {
                return this.batteryAverageLifeField;
            }
            set
            {
                this.batteryAverageLifeField = value;
                this.BatteryAverageLifeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatteryAverageLifeSpecified
        {
            get
            {
                return this.batteryAverageLifeFieldSpecified;
            }
            set
            {
                this.batteryAverageLifeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal BatteryAverageLifeStandby
        {
            get
            {
                return this.batteryAverageLifeStandbyField;
            }
            set
            {
                this.batteryAverageLifeStandbyField = value;
                this.BatteryAverageLifeStandbySpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatteryAverageLifeStandbySpecified
        {
            get
            {
                return this.batteryAverageLifeStandbyFieldSpecified;
            }
            set
            {
                this.batteryAverageLifeStandbyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal BatteryChargeTime
        {
            get
            {
                return this.batteryChargeTimeField;
            }
            set
            {
                this.batteryChargeTimeField = value;
                this.BatteryChargeTimeSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatteryChargeTimeSpecified
        {
            get
            {
                return this.batteryChargeTimeFieldSpecified;
            }
            set
            {
                this.batteryChargeTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string ColorMap
        {
            get
            {
                return this.colorMapField;
            }
            set
            {
                this.colorMapField = value;
            }
        }
        
        /// <remarks/>
        public bool IsAdultProduct
        {
            get
            {
                return this.isAdultProductField;
            }
            set
            {
                this.isAdultProductField = value;
                this.IsAdultProductSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAdultProductSpecified
        {
            get
            {
                return this.isAdultProductFieldSpecified;
            }
            set
            {
                this.isAdultProductFieldSpecified = value;
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
        public FoodAndBeveragesLithiumBatteryPackaging LithiumBatteryPackaging
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string LithiumBatteryVoltage
        {
            get
            {
                return this.lithiumBatteryVoltageField;
            }
            set
            {
                this.lithiumBatteryVoltageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string LithiumBatteryWeight
        {
            get
            {
                return this.lithiumBatteryWeightField;
            }
            set
            {
                this.lithiumBatteryWeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MfrWarrantyDescriptionLabor
        {
            get
            {
                return this.mfrWarrantyDescriptionLaborField;
            }
            set
            {
                this.mfrWarrantyDescriptionLaborField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MfrWarrantyDescriptionParts
        {
            get
            {
                return this.mfrWarrantyDescriptionPartsField;
            }
            set
            {
                this.mfrWarrantyDescriptionPartsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string MfrWarrantyDescriptionType
        {
            get
            {
                return this.mfrWarrantyDescriptionTypeField;
            }
            set
            {
                this.mfrWarrantyDescriptionTypeField = value;
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
        public string PowerSource
        {
            get
            {
                return this.powerSourceField;
            }
            set
            {
                this.powerSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string SellerWarrantyDescription
        {
            get
            {
                return this.sellerWarrantyDescriptionField;
            }
            set
            {
                this.sellerWarrantyDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public FoodAndBeveragesTargetGender TargetGender
        {
            get
            {
                return this.targetGenderField;
            }
            set
            {
                this.targetGenderField = value;
                this.TargetGenderSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TargetGenderSpecified
        {
            get
            {
                return this.targetGenderFieldSpecified;
            }
            set
            {
                this.targetGenderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="normalizedString")]
        public string DeliveryScheduleGroupId
        {
            get
            {
                return this.deliveryScheduleGroupIdField;
            }
            set
            {
                this.deliveryScheduleGroupIdField = value;
            }
        }
    }
}

namespace Flexi.Model.Poco.AmazonMWS.Feeds
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BatteryBatterySubgroup
    {
        
        private BatteryBatterySubgroupBatteryType batteryTypeField;
        
        private string numberOfBatteriesField;
        
        /// <remarks/>
        public BatteryBatterySubgroupBatteryType BatteryType
        {
            get
            {
                return this.batteryTypeField;
            }
            set
            {
                this.batteryTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string NumberOfBatteries
        {
            get
            {
                return this.numberOfBatteriesField;
            }
            set
            {
                this.numberOfBatteriesField = value;
            }
        }
    }
}

using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Request
{
    public class SkuUpload
    {
        public string product_title { get; set; }
        public int jet_browse_node_id { get; set; }
        public List<StandardProductCode> standard_product_codes { get; set; }
        public int multipack_quantity { get; set; }
        public string brand { get; set; }
        public string manufacturer { get; set; }
        public string mfr_part_number { get; set; }
        public string product_description { get; set; }
        public List<string> bullets { get; set; }
        public int number_units_for_price_per_unit { get; set; }
        public string type_of_unit_for_price_per_unit { get; set; }
        public decimal shipping_weight_pounds { get; set; }
        public decimal package_length_inches { get; set; }
        public decimal package_width_inches { get; set; }
        public decimal package_height_inches { get; set; }
        public decimal display_length_inches { get; set; }
        public decimal display_width_inches { get; set; }
        public decimal display_height_inches { get; set; }
        public bool prop_65 { get; set; }
        public string legal_disclaimer_description { get; set; }
        public List<string> cpsia_cautionary_statements { get; set; }
        public string country_of_origin { get; set; }
        public string safety_warning { get; set; }
        public int fulfillment_time { get; set; }
        public double msrp { get; set; }
        public double map_price { get; set; }
        public string map_implementation { get; set; }
        public string product_tax_code { get; set; }
        public double no_return_fee_adjustment { get; set; }
        public bool exclude_from_fee_adjustments { get; set; }
        public bool ships_alone { get; set; }
        public List<AttributesNodeSpecific> attributes_node_specific { get; set; }
        public string main_image_url { get; set; }
        public string swatch_image_url { get; set; }
        public List<AlternateImage> alternate_images { get; set; }
    }

    public class StandardProductCode
    {
        public string standard_product_code { get; set; }
        public string standard_product_code_type { get; set; }
    }

    public class AttributesNodeSpecific
    {
        public int attribute_id { get; set; }
        public string attribute_value { get; set; }
        public string attribute_value_unit { get; set; }
    }

    public class AlternateImage
    {
        public int image_slot_id { get; set; }
        public string image_url { get; set; }
    }


}

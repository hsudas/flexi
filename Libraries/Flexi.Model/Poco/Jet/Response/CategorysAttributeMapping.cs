using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Response
{
    public class CategorysAttributeMapping
    {
        public List<Attribute> attributes { get; set; }
    }

    public class Validation
    {
        public string data_type { get; set; }
        public int max_value { get; set; }
        public int min_value { get; set; }
    }

    public class Attribute
    {
        public int attribute_id { get; set; }
        public string attribute_description { get; set; }
        public bool free_text { get; set; }
        public bool variant { get; set; }
        public List<string> values { get; set; }
        public Validation validation { get; set; }
    }

}

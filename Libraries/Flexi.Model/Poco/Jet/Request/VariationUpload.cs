using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Request
{
    public class VariationUpload
    {
        public string relationship { get; set; }
        public List<int> variation_refinements { get; set; }
        public List<string> children_skus { get; set; }
    }
}

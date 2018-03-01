using System.Collections.Generic;

namespace Flexi.Model.Poco.Jet.Request
{

    public class JetException
    {
        public int time_to_return { get; set; }
        public List<string> return_location_ids { get; set; }
        public List<string> return_shipping_methods { get; set; }
    }
}

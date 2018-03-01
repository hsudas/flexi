using Flexi.Model.Entity.Amazon;

namespace Flexi.Model.Poco.Jet
{
    public class AsinMasterPoco
    {
        public AsinDetail AsinDetail { get; set; }
        public AsinFeeDetail AsinFeeDetail { get; set; }
        public int Quantity { get; set; }
        public decimal? Price { get; set; }

    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Flexi.Model.Entity.Amazon
{
    [Table("priceoffersub")]
    [DebuggerDisplay("Asin:{Asin}, SellerId:{SellerId}, ListingPrice: {ListingPrice}")]
    public class PriceOfferSub : PriceOffer
    {

    }
}
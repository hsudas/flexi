using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flexi.Model.Entity.Amazon
{
    [Table("pricelog")]
    public class PriceLog
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("asin")]
        public string Asin { get; set; }
        [Column("buyboxprice")]
        public decimal? BuyBoxPrice { get; set; }
        [Column("listprice")]
        public decimal? ListPrice { get; set; }
        [Column("lowestfba")]
        public decimal? LowestFba { get; set; }
        [Column("lowestmrc")]
        public decimal? LowestMrc { get; set; }
        [Column("shipping")]
        public decimal? Shipping { get; set; }
        [Column("buyboxeligfbacount")]
        public int? BuyBoxEligFbaCount { get; set; }
        [Column("buyboxeligmrccount")]
        public int? BuyBoxEligMrcCount { get; set; }
        [Column("offertime")]
        public DateTime? OfferTime { get; set; }
        [Column("systemdate")]
        public DateTime? SystemDate { get; set; }
        [Column("category")]
        public string Category { get; set; }
        [Column("ranking")]
        public int? Ranking { get; set; }
        [Column("myofferplacement")]
        public int? MyOfferPlacement { get; set; }
        [Column("myisbuyboxwinner")]
        public bool MyIsBuyBoxWinner { get; set; }
        [Column("myfbastatus")]
        public bool MyFbaStatus { get; set; }
        [Column("myavailablestock")]
        public bool MyAvailableStock { get; set; }
        [Column("myofferplacement2")]
        public int? MyOfferPlacement2 { get; set; }
        [Column("myisbuyboxwinner2")]
        public bool MyIsBuyBoxWinner2 { get; set; }
        [Column("myfbastatus2")]
        public bool MyFbaStatus2 { get; set; }
        [Column("mylistingprice")]
        public decimal MyListingPrice { get; set; }
        [Column("mylistingprice2")]
        public decimal MyListingPrice2 { get; set; }
        [Column("myavailablestock2")]
        public bool MyAvailableStock2 { get; set; }
        [Column("myofferplacement3")]
        public int? MyOfferPlacement3 { get; set; }
        [Column("myisbuyboxwinner3")]
        public bool MyIsBuyBoxWinner3 { get; set; }
        [Column("myfbastatus3")]
        public bool MyFbaStatus3 { get; set; }
        [Column("mylistingprice3")]
        public decimal? MyListingPrice3 { get; set; }
        [Column("myavailablestock3")]
        public bool MyAvailableStock3 { get; set; }
        [Column("fbaofferplacement")]
        public int? FbaOfferPlacement { get; set; }
        [Column("fbalistingprice")]
        public decimal? FbaListingPrice { get; set; }
        [Column("fbafbastatus")]
        public bool FbaFbaStatus { get; set; }
        [Column("fbaisbuyboxwinner")]
        public bool FbaIsBuyBoxWinner { get; set; }
        [Column("fbaavailablestock")]
        public bool FbaAvailableStock { get; set; }
        [Column("mrcofferplacement")]
        public int? MrcOfferPlacement { get; set; }
        [Column("mrclistingprice")]
        public decimal? MrcListingPrice { get; set; }
        [Column("mrcfbastatus")]
        public bool MrcFbaStatus { get; set; }
        [Column("mrcisbuyboxwinner")]
        public bool MrcIsBuyBoxWinner { get; set; }
        [Column("mrcavailablestock")]
        public bool MrcAvailableStock { get; set; }
        [Column("bbofferplacement")]
        public int? BbOfferPlacement { get; set; }
        [Column("bblistingprice")]
        public decimal? BbListingPrice { get; set; }
        [Column("bbavailablestock")]
        public bool BbAvailableStock { get; set; }
        [Column("bbisbuyboxwinner")]
        public bool BbIsBuyBoxWinner { get; set; }
        [Column("bbfbastatus")]
        public bool BbFbaStatus { get; set; }
        [Column("bbsellerid")]
        public string BbSellerid { get; set; }
        [Column("lowmrcsellerid")]
        public string LowMrcSellerId { get; set; }
        [Column("lowfbasellerid")]
        public string LowFbaSellerId { get; set; }
        [Column("priceupdateddate")]
        public DateTime? PriceUpdatedDate { get; set; }
        [Column("error")] public string Error { get; set; }
        [Column("mypriceupdate")]
        public DateTime? MyPriceUpdate { get; set; }
        [Column("updatecounter")]
        public decimal? UpdateCounter { get; set; }
        [Column("updatecounter2")]
        public decimal? UpdateCounter2 { get; set; }
        [Column("bofbaofferplacement")]
        public int? BoFbaOfferPlacement { get; set; }
        [Column("bofbalistingprice")]
        public decimal? BoFbaListingPrice { get; set; }
        [Column("bofbafbastatus")]
        public bool BoFbaFbaStatus { get; set; }
        [Column("bofbaisbuyboxwinner")]
        public bool BoFbaIsBuyBoxWinner { get; set; }
        [Column("bofbaavailablestock")]
        public bool BoFbaAvailableStock { get; set; }
        [Column("bolowfbasellerid")]
        public string BolowFbaSellerId { get; set; }

    }
}

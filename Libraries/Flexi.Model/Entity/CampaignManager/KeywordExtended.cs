using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Model.Entity.CampaignManager
{
    public class KeywordExtended : MongoRepository.Entity
    {
        public ulong KeywordId { get; set; }
        public int Status { get; set; }
        public ulong CampaignId { get; set; }
        public ulong AdGroupId { get; set; }
        public string State { get; set; }
        public string KeywordText { get; set; }
        public string MatchType { get; set; }
        public double Bid { get; set; }
        public long CreationDate { get; set; }
        public long LastUpdatedDate { get; set; }
        public string ServingStatus { get; set; }
        public DateTime CreateDate { get; set; }
        //public DateTime? LastUpdatedDate { get; set; }
    }
}

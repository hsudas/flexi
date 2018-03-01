using System;

namespace Flexi.Model.Entity.CampaignManager
{
    public class Token : MongoRepository.Entity
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public DateTime? expireDate { get; set; }
    }
}

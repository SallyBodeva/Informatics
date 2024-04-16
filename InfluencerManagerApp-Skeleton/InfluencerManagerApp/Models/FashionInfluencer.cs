using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class FashionInfluencer : Influencer
    {
        public FashionInfluencer(string username, int followers) : base(username, followers, 4.0)
        {
        }

        public override int CalculateCampaignPrice()
        {
            return (int)Math.Floor(this.Followers * this.EngagementRate * 0.1);
        }
    }
}

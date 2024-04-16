using InfluencerManagerApp.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public abstract class Influencer : IInfluencer
    {
        private readonly IReadOnlyCollection<string> participations;
        private string username;
        private int followers;
        private List<string> brands;

        protected Influencer(string username, int followers, double engagementRate)
        {
            this.Username = username;
            this.Followers = followers;
            this.EngagementRate = engagementRate;
            this.Income = 0;
            brands = new List<string>();
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username is required.");
                }
                username = value;
            }
        }

        public int Followers
        {
            get { return followers; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Followers count cannot be a negative number.");
                }
                followers = value;
            }
        }

        public double EngagementRate { get; set; }

        public double Income { get; set; }

        public IReadOnlyCollection<string> Participations
        {
            get
            {
                return this.brands.AsReadOnly() ;
            }
        }

        public abstract int CalculateCampaignPrice();

        public void EarnFee(double amount)
        {
            this.Income += amount;
        }

        public void EndParticipation(string brand)
        {
            this.brands.Remove(brand);
        }

        public void EnrollCampaign(string brand)
        {
            this.brands.Add(brand);
        }
        public override string ToString()
        {
            return $"{Username} - Followers: {Followers}, Total Income: {Income}";
        }
    }
}

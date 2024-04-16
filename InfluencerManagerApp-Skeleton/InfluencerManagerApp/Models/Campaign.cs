using InfluencerManagerApp.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class Campaign : ICampaign
    {
        private readonly IReadOnlyCollection<string> contributors;
        private List<string> influencers;
        private string brand;

        public Campaign(string brand, double budget)
        {
            this.Brand = brand;
            this.Budget = budget;
            influencers = new List<string>();
        }

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Brand is required.");
                }
                brand = value;
            }
        }

        public double Budget { get; set; }

        public IReadOnlyCollection<string> Contributors
        {
            get
            {
                return this.influencers.AsReadOnly();
            }
        }

        public void Engage(IInfluencer influencer)
        {
            this.influencers.Add(influencer.Username);
            this.Budget -= influencer.CalculateCampaignPrice();
        }

        public void Gain(double amount)
        {
            this.Budget += amount;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} - Brand: {Brand}, Budget: {Budget}, Contributors: {this.Contributors.Count}";
        }
    }
}

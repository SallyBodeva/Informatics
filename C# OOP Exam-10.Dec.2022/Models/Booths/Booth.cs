using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasPastryShop.Models.Booths
{
    public class Booth : IBooth
    {
        private int capacity;

        public Booth(int boothId, int capacity)
        {
            this.BoothId = boothId;
            this.Capacity = capacity;

        }

        public int BoothId { get; set; }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0!");
                }
                capacity = value;
            }
        }

        public IRepository<IDelicacy> DelicacyMenu { get; set; } = new DelicacyRepository();

        public IRepository<ICocktail> CocktailMenu { get; set; } = new CocktailRepository();

        public double CurrentBill { get; set; } = 0;

        public double Turnover { get; set; } = 0;

        public bool IsReserved { get; set; }

        public void ChangeStatus()
        {
            this.IsReserved = !IsReserved;
        }

        public void Charge()
        {
            this.Turnover += this.CurrentBill;
            this.CurrentBill = 0;
        }

        public void UpdateCurrentBill(double amount)
        {
            this.CurrentBill += amount;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Booth: {this.BoothId}");
            sb.AppendLine($"Capacity: {this.Capacity}");
            sb.AppendLine($"Turnover: {this.Turnover:f2} lv");
            sb.AppendLine("-Cocktail menu:");
            this.CocktailMenu.Models.ToList().ForEach(model => sb.AppendLine($"--{model.ToString()}"));
            sb.AppendLine("-Delicacy menu:");
            this.DelicacyMenu.Models.ToList().ForEach(model => sb.AppendLine($"--{model.ToString()}"));
            return base.ToString();
        }
    }
}

using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Booths
{
    public class Booth : IBooth
    {
        private int capacity;

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

        public IRepository<IDelicacy> DelicacyMenu { get; set; }

        public IRepository<ICocktail> CocktailMenu { get; set; }

        public double CurrentBill { get; set; } = 0;

        public double Turnover { get; set; } = 0;

        public bool IsReserved { get; set; }

        public void ChangeStatus()
        {
            throw new NotImplementedException();
        }

        public void Charge()
        {
            throw new NotImplementedException();
        }

        public void UpdateCurrentBill(double amount)
        {
            throw new NotImplementedException();
        }
    }
}

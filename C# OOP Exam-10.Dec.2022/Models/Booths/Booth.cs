using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Booths
{
    public abstract class Booth : IBooth
    {
        public abstract int BoothId { get; set; }
        public abstract int Capacity { get; set; }
        public abstract IRepository<IDelicacy> DelicacyMenu { get; set; }
        public abstract IRepository<ICocktail> CocktailMenu { get; set; }
        public abstract double CurrentBill { get; set; }
        public abstract double Turnover { get; set; }
        public abstract bool IsReserved { get; set; }

        public abstract void ChangeStatus();
        public abstract void Charge();
        public abstract void UpdateCurrentBill(double amount);
    }
}

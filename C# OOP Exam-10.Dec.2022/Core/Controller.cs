using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models.Booths;
using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasPastryShop.Core
{
    public class Controller : IController
    {
        private BoothRepository booths = new BoothRepository();

        public string AddBooth(int capacity)
        {
            int boothId = booths.Models.Count + 1;
            Booth booth = new Booth(boothId, capacity);
            booths.AddModel(booth);
            return string.Format(Utilities.Messages.OutputMessages.NewBoothAdded, boothId, capacity);
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            if (cocktailTypeName != nameof(Hibernation) && cocktailTypeName != nameof(MulledWine))
            {
                return string.Format(Utilities.Messages.OutputMessages.InvalidCocktailType, cocktailTypeName);
            }
            if (size != "Small" && size != "Middle" && size != "Large")
            {
                return string.Format(Utilities.Messages.OutputMessages.InvalidCocktailSize, size);
            }
            IBooth booth = booths.Models.FirstOrDefault(x => x.BoothId == boothId);
            if (booth.CocktailMenu.Models.Any(x => x.Name == cocktailName && x.Size == size))
            {
                return string.Format(Utilities.Messages.OutputMessages.CocktailAlreadyAdded, size, cocktailName);
            }
            Cocktail cocktail = null;
            switch (cocktailTypeName)
            {
                case nameof(Hibernation):
                    cocktail = new Hibernation(cocktailName, size);
                    break;
                case nameof(MulledWine):
                    cocktail = new Hibernation(cocktailName, size);
                    break;
                default:
                    throw new Exception("Not valid type of coctail...");
                    break;
            }
            booth.CocktailMenu.AddModel(cocktail);
            return string.Format(Utilities.Messages.OutputMessages.NewCocktailAdded, size, cocktailName, cocktailTypeName);
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            if (delicacyTypeName != nameof(Gingerbread) && delicacyTypeName != nameof(Stolen))
            {
                return string.Format(Utilities.Messages.OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }
            IBooth booth = booths.Models.FirstOrDefault(x => x.BoothId == boothId);
            if (booth.DelicacyMenu.Models.Any(x=>x.Name==delicacyName))
            {
                return string.Format(Utilities.Messages.OutputMessages.DelicacyAlreadyAdded,delicacyName);
            }
            Delicacy delicacy = null;
            switch (delicacyTypeName)
            {
                case nameof(Gingerbread):
                    delicacy = new Gingerbread(delicacyName);
                    break;
                case nameof(Stolen):
                    delicacy = new Stolen(delicacyName);
                    break;
                default:
                    throw new Exception("Not valid type of delicacy...");
                    break;
            }
            booth.DelicacyMenu.AddModel(delicacy);
            return string.Format(Utilities.Messages.OutputMessages.NewDelicacyAdded,delicacyTypeName,delicacyName);
        }

        public string BoothReport(int boothId)
        {
            throw new NotImplementedException();
        }

        public string LeaveBooth(int boothId)
        {
            throw new NotImplementedException();
        }

        public string ReserveBooth(int countOfPeople)
        {
            throw new NotImplementedException();
        }

        public string TryOrder(int boothId, string order)
        {
            throw new NotImplementedException();
        }
    }
}

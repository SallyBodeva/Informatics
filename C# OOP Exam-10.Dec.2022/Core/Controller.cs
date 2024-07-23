using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models.Booths;
using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Utilities.Messages;
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
            if (booth.DelicacyMenu.Models.Any(x => x.Name == delicacyName))
            {
                return string.Format(Utilities.Messages.OutputMessages.DelicacyAlreadyAdded, delicacyName);
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
            return string.Format(Utilities.Messages.OutputMessages.NewDelicacyAdded, delicacyTypeName, delicacyName);
        }

        public string BoothReport(int boothId)
        {
            return this.booths.Models.FirstOrDefault(b => b.BoothId == boothId).ToString().TrimEnd();
        }

        public string LeaveBooth(int boothId)
        {
            IBooth booth = booths.Models.FirstOrDefault(x => x.BoothId == boothId);
            double currentBill = booth.CurrentBill;
            booth.Charge();
            booth.ChangeStatus();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format(Utilities.Messages.OutputMessages.GetBill, $"{currentBill:f2}"));
            sb.AppendLine(string.Format(Utilities.Messages.OutputMessages.BoothIsAvailable, boothId));
            return sb.ToString().TrimEnd();
        }

        public string ReserveBooth(int countOfPeople)
        {
            List<IBooth> orderedBooths = booths.Models
                .Where(x => x.IsReserved == false && x.Capacity >= countOfPeople)
                .OrderBy(x => x.Capacity)
                .ThenByDescending(x => x.BoothId)
                .ToList();
            if (orderedBooths.Count == 0)
            {
                return $"No available booth for {countOfPeople} people!";
            }
            else
            {
                orderedBooths.FirstOrDefault().ChangeStatus();
                return $"Booth {orderedBooths.FirstOrDefault().BoothId} has been reserved for {countOfPeople} people!";
            }
        }

        public string TryOrder(int boothId, string order)
        {
            IBooth booth = this.booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            string[] orderArray = order.Split('/');

            bool isCocktail = false;

            string itemTypeName = orderArray[0];

            if (itemTypeName != nameof(MulledWine) &&
                itemTypeName != nameof(Hibernation) &&
                itemTypeName != nameof(Gingerbread) &&
                itemTypeName != nameof(Stolen))
            {
                return string.Format(OutputMessages.NotRecognizedType, itemTypeName);
            }

            string itemName = orderArray[1];

            if (!booth.CocktailMenu.Models.Any(m => m.Name == itemName) &&
                !booth.DelicacyMenu.Models.Any(m => m.Name == itemName))
            {
                return string.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
            }

            int pieces = int.Parse(orderArray[2]);



            if (itemTypeName == nameof(MulledWine) || itemTypeName == nameof(Hibernation))
            {
                isCocktail = true;
            }

            if (isCocktail)
            {
                string size = orderArray[3];

                ICocktail desiredCocktail = booth
                    .CocktailMenu.Models
                    .FirstOrDefault(m => m.GetType().Name == itemTypeName && m.Name == itemName && m.Size == size);

                if (desiredCocktail == null)
                {
                    return string.Format(OutputMessages.CocktailStillNotAdded, size, itemName);
                }

                booth.UpdateCurrentBill(desiredCocktail.Price * pieces);
                return string.Format(OutputMessages.SuccessfullyOrdered, boothId, pieces, itemName);
            }
            else
            {
                IDelicacy desiredDelicacy = booth
                .DelicacyMenu.Models
                    .FirstOrDefault(m => m.GetType().Name == itemTypeName && m.Name == itemName);

                if (desiredDelicacy == null)
                {
                    return string.Format(OutputMessages.DelicacyStillNotAdded, itemName);
                }

                booth.UpdateCurrentBill(desiredDelicacy.Price * pieces);
                return string.Format(OutputMessages.SuccessfullyOrdered, boothId, pieces, itemName);
            }
        }
    }
}


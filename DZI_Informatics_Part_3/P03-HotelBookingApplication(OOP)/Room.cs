using System;
using System.Collections.Generic;
using System.Text;

namespace P03_HotelBookingApplication_OOP_
{
    public class Room
    {
        private double pricePerNight =0;

        public Room(int bedCapacity)
        {
            this.BedCapacity = bedCapacity;
        }

        public int BedCapacity { get; set; }

        public double PricePerNight
        {
            get { return pricePerNight; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }
                pricePerNight = value;
            }
        }
        public void SetPrice(double price)
        {
            this.PricePerNight = price;
        }
    }
}

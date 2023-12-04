using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_HotelBookingApplication_OOP_
{
    public class Hotel
    {
        private string fullName;
        private int category;
        private RoomRepository rooms;
        private BookingRepository booking;

        public Hotel(string fullName, int category)
        {
            this.FullName = fullName;
            this.Category = category;
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hotel name cannot be null or empty!");
                }
                fullName = value;
            }
        }
        public int Category
        {
            get { return category; }
            set
            {
                if (value<1 || value>5)
                {
                    throw new ArgumentException("Category should be between 1 and 5 stars!");
                }
                category = value;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Hotel hotel &&
                   fullName == hotel.fullName &&
                   category == hotel.category;
        }

        public double Turnover()
        {
            return Math.Round(booking.All().Sum(x => x.ResidenceDuration * x.Room.PricePerNight), 2);
        }
    }
}

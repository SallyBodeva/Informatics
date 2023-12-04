using System;
using System.Collections.Generic;
using System.Text;

namespace P03_HotelBookingApplication_OOP_
{
    public class Hotel
    {
        private string fullName;
        private int category;
        private RoomRepository rooms;
        private BookingRepository booking;

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
        public double Turnover()
        {

        }
    }
}

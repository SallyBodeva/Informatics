using System;
using System.Collections.Generic;
using System.Text;

namespace P03_HotelBookingApplication_OOP_
{
    public class Booking
    {
        private int residenceDuration;
        private int adultsCount;
        private int childrenCount;

        public Booking(Room room, int residenceDuration, int adultsCount, int childrenCount, int bookingNumber)
        {
            this.Room = room;
            this.ResidenceDuration = residenceDuration;
            this.AdultsCount = adultsCount;
            this.ChildrenCount = childrenCount;
            this.BookingNumber = bookingNumber;
        }

        public Room Room { get; set; }

        public int ResidenceDuration
        {
            get { return residenceDuration; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Duration cannot be negative or zero!");
                }
                residenceDuration = value;
            }
        }

        public int AdultsCount
        {
            get { return adultsCount; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Adults count cannot be negative or zero!");
                }
                adultsCount = value;
            }
        }

        public int ChildrenCount
        {
            get { return childrenCount; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Children count cannot be negative!");
                }
                childrenCount = value;
            }
        }
        public int 	BookingNumber  { get; set; }
        public double TotalPaid()
        {
            return Math.Round(ResidenceDuration * this.Room.PricePerNight, 2);  
        }
        public string BookingSummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Booking number: {this.BookingNumber}");
            sb.AppendLine($"Room type: {this.GetType().Name}");
            sb.AppendLine($"Adults: {AdultsCount} Children: {ChildrenCount}");
            sb.AppendLine($"Total amount paid: {TotalPaid():F2} $");
            return sb.ToString().TrimEnd();
        }
    }
}

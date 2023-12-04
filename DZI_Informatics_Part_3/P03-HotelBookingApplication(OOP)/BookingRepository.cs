using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace P03_HotelBookingApplication_OOP_
{
    public class BookingRepository
    {
        private List<Booking> bookings;
        public BookingRepository()
        {
            bookings = new List<Booking>();
        }
        public void AddNew(Booking booking)
        {
            this.bookings.Add(booking);
        }
        public Booking Select(string bookingNumberToString)
        {
            return bookings.FirstOrDefault(x => x.BookingNumber.ToString() == bookingNumberToString);
        }
        public IReadOnlyCollection<Booking> All()
        {
            return this.bookings.AsReadOnly();
        }
    }
}

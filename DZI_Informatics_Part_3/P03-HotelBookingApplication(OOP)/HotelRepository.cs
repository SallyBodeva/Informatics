using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace P03_HotelBookingApplication_OOP_
{
    public class HotelRepository
    {
        private List<Hotel> hotels;
        public HotelRepository()
        {
            hotels = new List<Hotel>();
        }
        public void AddNew(Hotel hotel)
        {
            this.hotels.Add(hotel);
        }
        public Hotel Select(string hotelName)
        {
            return this.hotels.FirstOrDefault(x => x.FullName == hotelName);
        }
        public IReadOnlyCollection<Hotel> All()
        {
            return this.hotels.AsReadOnly();
        }
    }
}

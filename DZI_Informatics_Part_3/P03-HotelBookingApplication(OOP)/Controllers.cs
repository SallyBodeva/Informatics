using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace P03_HotelBookingApplication_OOP_
{
    public class Controllers
    {
        private HotelRepository hotels;

        public string AddHotel(string hotelName, int category)
        {
            if (hotels.Select(hotelName)!=null)
            {
                return $"Hotel {hotelName} is already registered in our platform.";
            }
            else
            {
                Hotel h = new Hotel(hotelName, category);
                hotels.AddNew(h);
                return $"{category} stars hotel {hotelName} is registered in our platform and expects room availability to be uploaded.";
            }
        }
        //public string UploadRoomTypes(string hotelName, string roomTypeName)
        //{
        //    if (hotels.Select(hotelName)!=null)
        //    {
        //        return $"Profile {hotelName} doesn’t exist!";
        //    }
        //    if (hotels.All().Any(x=>x.ro))
        //    {

        //    }
        //}
    }
}

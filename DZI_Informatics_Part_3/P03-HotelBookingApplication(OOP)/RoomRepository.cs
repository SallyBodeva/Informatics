using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_HotelBookingApplication_OOP_
{
    public class RoomRepository
    {

        private List<Room> rooms;
        public RoomRepository()
        {
            rooms = new List<Room>();
        }
        public void AddNew(Room room)
        {
            this.rooms.Add(room);
        }
        public Room Select(string roomTypeName)
        {
            return this.rooms.FirstOrDefault(x => x.GetType().Name == roomTypeName);
        }
        public IReadOnlyCollection<Room> All()
        {
            return this.rooms.AsReadOnly();
        }
    }
}

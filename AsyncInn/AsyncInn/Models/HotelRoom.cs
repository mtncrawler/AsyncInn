using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelRoom
    {
        public int HotelID { get; set; }

        public int RoomNumber { get; set; }

        public int RoomID { get; set; }

        public int Rate { get; set; }

        public bool PetFriendly { get; set; }

        public ICollection<Hotel> Hotels { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class RoomAmenities
    {
        public int AmenitiesID { get; set; }

        public int RoomID { get; set; }

        public ICollection<Amenities> Amenity { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class RoomAmenities
    {
        public int AmenitiesID { get; set; }

        [Display(Name = "Room Type")]
        public int RoomID { get; set; }

        public Amenities Amenity { get; set; }

        public Room Rooms { get; set; }
    }
}

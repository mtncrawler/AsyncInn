using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Room
    {
        public int ID { get; set; }

        public string Name { get; set; }

        //[Required]
        //[EnumDataType(typeof(Layout))]
        public Layout Layout { get; set; }

        public ICollection<HotelRoom> HotelRooms { get; set; }

        public ICollection<RoomAmenities> RoomAmenity { get; set; }
    }

    public enum Layout
    {
        [Display(Name = "Studio")]
        studio,
        [Display(Name = "One-bedroom")]
        oneBedroom,
        [Display(Name = "Two-bedroom")]
        twoBedroom
    }
}

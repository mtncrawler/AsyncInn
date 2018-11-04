using AsyncInn.Models;
using System;
using Xunit;

namespace asyncInnTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetRoomName()
        {
            Room room = new Room();
            room.Name = "Foggy";

            Assert.Equal("Foggy", room.Name);
        }

        [Fact]
        public void SetRoomName()
        {
            Room room = new Room();
            room.Name = "Foggy";

            room.Name = "Steamy";

            Assert.Equal("Steamy", room.Name);
        }

        [Fact]
        public void CanGetHotelName()
        {
            Hotel hotel = new Hotel();
            hotel.Name = "Hotel Motel Holiday Inn";
            Assert.Equal("Hotel Motel Holiday Inn", hotel.Name);
        }

        [Fact]
        public void CanSetHotelName()
        {
            Hotel hotel = new Hotel();
            hotel.Name = "Hotel Motel Holiday Inn";

            hotel.Name = "Hotel California";
            Assert.Equal("Hotel California", hotel.Name);
        }

        [Fact]
        public void CanGetHotelAddress()
        {
            Hotel hotel = new Hotel();
            hotel.Street = "500 Main Street";
            hotel.City = "Seattle";
            hotel.State = "WA";
            hotel.ZipCode = "98109";

            Assert.Equal("500 Main Street", hotel.Street);
            Assert.Equal("Seattle", hotel.City);
            Assert.Equal("WA", hotel.State);
            Assert.Equal("98109", hotel.ZipCode);
        }

        [Fact]
        public void CanSetHotelAddress()
        {
            Hotel hotel = new Hotel();
            hotel.Street = "500 Main Street";
            hotel.City = "Seattle";
            hotel.State = "WA";
            hotel.ZipCode = "98109";

            hotel.Street = "123 Front St";
            hotel.City = "Ballard";
            hotel.State = "WA";
            hotel.ZipCode = "98100";

            Assert.Equal("123 Front St", hotel.Street);
            Assert.Equal("Ballard", hotel.City);
            Assert.Equal("WA", hotel.State);
            Assert.Equal("98100", hotel.ZipCode);
        }

        [Fact]
        public void CanGetHotelPhone()
        {
            Hotel hotel = new Hotel();
            hotel.Phone = "404-317-5131";

            Assert.Equal("404-317-5131", hotel.Phone);
        }

        [Fact]
        public void CanSetHotelPhone()
        {
            Hotel hotel = new Hotel();
            hotel.Phone = "404-317-5131";

            hotel.Phone = "770-410-0233";
            Assert.Equal("770-410-0233", hotel.Phone);
        }

        [Fact]
        public void CanGetHotelRoomNumber()
        {
            HotelRoom hr = new HotelRoom();
            hr.RoomNumber = 666;

            Assert.Equal(666, hr.RoomNumber);
        }

        [Fact]
        public void CanSetHotelRoomNumber()
        {
            HotelRoom hr = new HotelRoom();
            hr.RoomNumber = 666;

            hr.RoomNumber = 999;
            Assert.Equal(999, hr.RoomNumber);
        }

        [Fact]
        public void CanGetHotelRoomRate()
        {
            HotelRoom hr = new HotelRoom();
            hr.Rate = 199;

            Assert.Equal(199, hr.Rate);
        }

        [Fact]
        public void CanSetHotelRoomRate()
        {
            HotelRoom hr = new HotelRoom();
            hr.Rate = 199;

            hr.Rate = 100;
            Assert.Equal(100, hr.Rate);
        }

        [Fact]
        public void CanGetAmenity()
        {
            Amenities am = new Amenities();
            am.Name = "A/C";

            Assert.Equal("A/C", am.Name);
        }

        [Fact]
        public void CanSetAmenity()
        {
            Amenities am = new Amenities();
            am.Name = "A/C";

            am.Name = "Hottub";
            Assert.Equal("Hottub", am.Name);
        }

        [Fact]
        public void CanGetHotelRoomPetFriendliness()
        {
            HotelRoom hr = new HotelRoom();
            hr.PetFriendly = true;

            Assert.True(hr.PetFriendly);
        }

        [Fact]
        public void CanSetHotelRoomPetFriendliness()
        {
            HotelRoom hr = new HotelRoom();
            hr.PetFriendly = true;

            hr.PetFriendly = false;
            Assert.False(hr.PetFriendly);
        }


    }
}

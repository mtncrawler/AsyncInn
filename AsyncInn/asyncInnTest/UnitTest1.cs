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
    }
}

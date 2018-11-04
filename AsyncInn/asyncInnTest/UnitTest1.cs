using AsyncInn.Data;
using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;
using System.Linq;

namespace asyncInnTest
{
    public class UnitTest1
    {
        /// <summary>
        /// get room name
        /// </summary>
        [Fact]
        public void CanGetRoomName()
        {
            Room room = new Room();
            room.Name = "Foggy";

            Assert.Equal("Foggy", room.Name);
        }

        /// <summary>
        /// set room name
        /// </summary>
        [Fact]
        public void SetRoomName()
        {
            Room room = new Room();
            room.Name = "Foggy";

            room.Name = "Steamy";

            Assert.Equal("Steamy", room.Name);
        }

        /// <summary>
        /// create and read room table
        /// </summary>
        [Fact]
        public async void CreateAndReadRoom()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("Create Room")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Room room = new Room();
                room.Name = "Slumber Party";

                context.Rooms.Add(room);
                await context.SaveChangesAsync();

                var roomName = await context.Rooms.FirstOrDefaultAsync(x => x.Name == room.Name);

                Assert.Equal("Slumber Party", room.Name);
            }
        }

        /// <summary>
        /// update room table
        /// </summary>
        [Fact]
        public async void UpdateRoom()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("UpdateRoom")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Room room = new Room();
                room.Name = "Slumber Party";

                context.Rooms.Add(room);
                await context.SaveChangesAsync();

                room.Name = "Red Room";
                context.Update(room);
                await context.SaveChangesAsync();

                var roomName = await context.Rooms.FirstOrDefaultAsync(x => x.Name == room.Name);

                Assert.Equal("Red Room", room.Name);
            }
        }

        /// <summary>
        /// delete from room table
        /// </summary>
        [Fact]
        public async void DeleteRoom()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("DeleteRoom")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Room room = new Room();
                room.Name = "Slumber Party";

                context.Rooms.Add(room);
                await context.SaveChangesAsync();

                context.Rooms.Remove(room);
                await context.SaveChangesAsync();

                var rooms = await context.Rooms.ToListAsync();

                Assert.DoesNotContain(room, rooms);
            }
        }

        /// <summary>
        /// get hotel name
        /// </summary>
        [Fact]
        public void CanGetHotelName()
        {
            Hotel hotel = new Hotel();
            hotel.Name = "Hotel Motel Holiday Inn";
            Assert.Equal("Hotel Motel Holiday Inn", hotel.Name);
        }

        /// <summary>
        /// set hotel name
        /// </summary>
        [Fact]
        public void CanSetHotelName()
        {
            Hotel hotel = new Hotel();
            hotel.Name = "Hotel Motel Holiday Inn";

            hotel.Name = "Hotel California";
            Assert.Equal("Hotel California", hotel.Name);
        }

        /// <summary>
        /// get hotel address
        /// </summary>
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

        /// <summary>
        /// set hotel address
        /// </summary>
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

        /// <summary>
        /// get hotel phone
        /// </summary>
        [Fact]
        public void CanGetHotelPhone()
        {
            Hotel hotel = new Hotel();
            hotel.Phone = "404-317-5131";

            Assert.Equal("404-317-5131", hotel.Phone);
        }

        /// <summary>
        /// set hotel phone
        /// </summary>
        [Fact]
        public void CanSetHotelPhone()
        {
            Hotel hotel = new Hotel();
            hotel.Phone = "404-317-5131";

            hotel.Phone = "770-410-0233";
            Assert.Equal("770-410-0233", hotel.Phone);
        }

        /// <summary>
        /// create and read from hotel table
        /// </summary>
        [Fact]
        public async void CreateAndReadHotel()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("CreateHotel")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Hotel hotel = new Hotel();
                hotel.Name = "Motel 9";

                context.Hotels.Add(hotel);
                await context.SaveChangesAsync();

                var hotelName = await context.Rooms.FirstOrDefaultAsync(x => x.Name == hotel.Name);

                Assert.Equal("Motel 9", hotel.Name);
            }
        }

        /// <summary>
        /// update hotel table
        /// </summary>
        [Fact]
        public async void UpdateHotel()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("UpdateHotel")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Hotel hotel = new Hotel();
                hotel.Name = "Motel 9";

                context.Hotels.Add(hotel);
                await context.SaveChangesAsync();
                
                context.Hotels.Remove(hotel);
                await context.SaveChangesAsync();

                var hotels = await context.Hotels.ToListAsync();

                Assert.DoesNotContain(hotel, hotels);
            }
        }

        /// <summary>
        /// delete from hotel table
        /// </summary>
        [Fact]
        public async void DeleteHotel()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("DeleteHotel")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Hotel hotel = new Hotel();
                hotel.Name = "Motel 9";

                context.Hotels.Add(hotel);
                await context.SaveChangesAsync();

                var roomName = await context.Rooms.FirstOrDefaultAsync(x => x.Name == hotel.Name);

                Assert.Equal("Motel 9", hotel.Name);
            }
        }

        /// <summary>
        /// get amenity name 
        /// </summary>
        [Fact]
        public void CanGetAmenity()
        {
            Amenities am = new Amenities();
            am.Name = "A/C";

            Assert.Equal("A/C", am.Name);
        }

        /// <summary>
        /// set amenity name
        /// </summary>
        [Fact]
        public void CanSetAmenity()
        {
            Amenities am = new Amenities();
            am.Name = "A/C";

            am.Name = "Hottub";
            Assert.Equal("Hottub", am.Name);
        }

        /// <summary>
        /// create and read from amenity table
        /// </summary>
        [Fact]
        public async void CreateAndReadAmenity()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("CreateAmenity")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities ament = new Amenities();
                ament.Name = "Heated toliet";

                context.Amenities.Add(ament);
                await context.SaveChangesAsync();

                var amenities = await context.Amenities.FirstOrDefaultAsync(x => x.Name == ament.Name);

                Assert.Equal("Heated toliet", amenities.Name);
            }
        }

        /// <summary>
        /// update amenity table
        /// </summary>
        [Fact]
        public async void UpdateAmenity()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("UpdateAmenity")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities ament = new Amenities();
                ament.Name = "Heated toliet";

                context.Amenities.Add(ament);
                await context.SaveChangesAsync();

                ament.Name = "Plunger";
                context.Amenities.Update(ament);
                await context.SaveChangesAsync();

                var amenities = await context.Amenities.FirstOrDefaultAsync(x => x.Name == ament.Name);

                Assert.Equal("Plunger", amenities.Name);
            }
        }

        /// <summary>
        /// delete from amenity table
        /// </summary>
        [Fact]
        public async void DeleteAmenity()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("DeleteAmenity")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities ament = new Amenities();
                ament.Name = "Heated toliet";

                context.Amenities.Add(ament);
                await context.SaveChangesAsync();

                context.Amenities.Remove(ament);
                await context.SaveChangesAsync();

                var amenities = await context.Amenities.ToListAsync();

                Assert.DoesNotContain(ament, amenities);
            }
        }

        /// <summary>
        /// get hotel room number
        /// </summary>
        [Fact]
        public void CanGetHotelRoomNumber()
        {
            HotelRoom hr = new HotelRoom();
            hr.RoomNumber = 666;

            Assert.Equal(666, hr.RoomNumber);
        }

        /// <summary>
        /// set hotel room number
        /// </summary>
        [Fact]
        public void CanSetHotelRoomNumber()
        {
            HotelRoom hr = new HotelRoom();
            hr.RoomNumber = 666;

            hr.RoomNumber = 999;
            Assert.Equal(999, hr.RoomNumber);
        }

        /// <summary>
        /// get hotel room rate
        /// </summary>
        [Fact]
        public void CanGetHotelRoomRate()
        {
            HotelRoom hr = new HotelRoom();
            hr.Rate = 199;

            Assert.Equal(199, hr.Rate);
        }

        /// <summary>
        /// set hotel room rate
        /// </summary>
        [Fact]
        public void CanSetHotelRoomRate()
        {
            HotelRoom hr = new HotelRoom();
            hr.Rate = 199;

            hr.Rate = 100;
            Assert.Equal(100, hr.Rate);
        }

        /// <summary>
        /// get hotel room petfriendly 
        /// </summary>
        [Fact]
        public void CanGetHotelRoomPetFriendliness()
        {
            HotelRoom hr = new HotelRoom();
            hr.PetFriendly = true;

            Assert.True(hr.PetFriendly);
        }

        /// <summary>
        /// set hotel room petfriendly
        /// </summary>
        [Fact]
        public void CanSetHotelRoomPetFriendliness()
        {
            HotelRoom hr = new HotelRoom();
            hr.PetFriendly = true;

            hr.PetFriendly = false;
            Assert.False(hr.PetFriendly);
        }

        /// <summary>
        /// create and read hotel room table
        /// </summary>
        [Fact]
        public async void CreateAndReadHotelRoom()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("CreateHotelRoom")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                HotelRoom hr = new HotelRoom();
                hr.Rate = 299;

                context.HotelRooms.Add(hr);
                await context.SaveChangesAsync();

                var hrRate = await context.HotelRooms.FirstOrDefaultAsync(x => x.Rate == hr.Rate);

                Assert.Equal(299, hr.Rate);
            }
        }

        /// <summary>
        /// update hotel room table
        /// </summary>
        [Fact]
        public async void UpdateHotelRoom()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("UpdateHotelRoom")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                HotelRoom hr = new HotelRoom();
                hr.Rate = 299;

                context.HotelRooms.Add(hr);
                await context.SaveChangesAsync();

                hr.Rate = 150;
                context.HotelRooms.Update(hr);
                await context.SaveChangesAsync();

                var hrRate = await context.HotelRooms.FirstOrDefaultAsync(x => x.Rate == hr.Rate);

                Assert.Equal(150, hr.Rate);
            }
        }

        /// <summary>
        /// delete from hotel room table
        /// </summary>
        [Fact]
        public async void DeleteHotelRoom()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("DeleteHotelRoom")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                HotelRoom hr = new HotelRoom();
                hr.Rate = 299;

                context.HotelRooms.Add(hr);
                await context.SaveChangesAsync();

                context.HotelRooms.Remove(hr);
                await context.SaveChangesAsync();

                var hrs = await context.HotelRooms.ToListAsync();

                Assert.DoesNotContain(hr, hrs);
            }
        }

        /// <summary>
        /// create and read from room amenity table
        /// </summary>
        [Fact]
        public async void CreateAndReadRoomAmenity()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("CreateRoomAmenity")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities ament = new Amenities();
                ament.Name = "Plunger";

                RoomAmenities ra = new RoomAmenities();
                ra.Amenity = ament;

                context.RoomAmenity.Add(ra);
                await context.SaveChangesAsync();

                var amenities = await context.Amenities.FirstOrDefaultAsync(x => x.Name == ament.Name);

                Assert.Equal("Plunger", amenities.Name);
            }
        }

        /// <summary>
        /// delete from room amenity table
        /// </summary>
        [Fact]
        public async void DeleteRoomAmenity()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("DeleteRoomAmenity")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities ament = new Amenities();
                ament.Name = "Plunger";

                RoomAmenities ra = new RoomAmenities();
                ra.Amenity = ament;

                context.RoomAmenity.Add(ra);
                await context.SaveChangesAsync();

                context.RoomAmenity.Remove(ra);
                await context.SaveChangesAsync();

                var amenities = await context.RoomAmenity.ToListAsync();

                Assert.DoesNotContain(ra, amenities);
            }
        }
    }
}

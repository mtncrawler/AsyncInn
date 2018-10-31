using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasKey(
                hr => new { hr.HotelID, hr.RoomNumber }
                );

            modelBuilder.Entity<RoomAmenities>().HasKey(
                rm => new { rm.AmenitiesID, rm.RoomID }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "Holiday Daze",
                    Street = "10 Derp St",
                    City = "Seattle",
                    State = "WA",
                    ZipCode = "98101",
                    Phone = "206-555-9876"
                },
                new Hotel
                {
                    ID = 2,
                    Name = "Days Out",
                    Street = "123 Western St",
                    City = "Seattle",
                    State = "WA",
                    ZipCode = "98101",
                    Phone = "206-675-1234"
                },
                new Hotel
                {
                    ID = 3,
                    Name = "Ace Motel",
                    Street = "987 Oregon St",
                    City = "Portland",
                    State = "OR",
                    ZipCode = "97101",
                    Phone = "206-675-9832"
                },
                new Hotel
                {
                    ID = 4,
                    Name = "Two Seasons",
                    Street = "4 Windy Way",
                    City = "Austin ",
                    State = "TX",
                    ZipCode = "54321",
                    Phone = "601-555-5432"
                },
                new Hotel
                {
                    ID = 5,
                    Name = "Best Eastern",
                    Street = "678 Leeward St",
                    City = "Boston",
                    State = "MA",
                    ZipCode = "01234",
                    Phone = "321-555-4512"
                }
                );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Name = "Honeymoon Suite",
                    Layout = (Layout)1
                },
                new Room
                {
                    ID = 2,
                    Name = "Solo Cup",
                    Layout = 0
                },
                new Room
                {
                    ID = 3,
                    Name = "Sounders Soiree",
                    Layout = (Layout)2
                },
                new Room
                {
                    ID = 4,
                    Name = "Tropical Escape",
                    Layout = (Layout)2
                },
                new Room
                {
                    ID = 5,
                    Name = "Mountain Refuge",
                    Layout = (Layout)2
                },
                new Room
                {
                    ID = 6,
                    Name = "Urban Delight",
                    Layout = (Layout)1
                }
                );

            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "A/C"
                },

                new Amenities {
                    ID = 2,
                    Name = "Waterview"
                },

                new Amenities
                {
                    ID = 3,
                    Name = "Hot tub"
                },

                new Amenities
                {
                    ID = 4,
                    Name = "Espresso machine"
                },

                new Amenities
                {
                    ID = 5,
                    Name = "Vinyl player"
                }

                );
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenity { get; set; }
        public DbSet<Amenities> Amenities { get; set; }

    }
}

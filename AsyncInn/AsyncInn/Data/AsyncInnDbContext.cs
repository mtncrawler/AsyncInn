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
                    Name = "Holiday Daze",
                    Street = "10 Derp St",
                    City = "Seattle",
                    State = "WA",
                    ZipCode = "98101",
                    Phone = "206-555-9876"
                },
                new Hotel
                {
                    Name = "Days Out",
                    Street = "123 Western St",
                    City = "Seattle",
                    State = "WA",
                    ZipCode = "98101",
                    Phone = "206-675-1234"
                },
                new Hotel
                {
                    Name = "Ace Motel",
                    Street = "987 Oregon St",
                    City = "Portland",
                    State = "OR",
                    ZipCode = "97101",
                    Phone = "206-675-9832"
                },
                new Hotel
                {
                    Name = "Two Seasons",
                    Street = "4 Windy Way",
                    City = "Austin ",
                    State = "TX",
                    ZipCode = "54321",
                    Phone = "601-555-5432"
                },
                new Hotel
                {
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
                    Name = "Honeymoon Suite",
                    Layout = (Layout)1
                },
                new Room
                {
                    Name = "Party for One",
                    Layout = 0
                },
                new Room
                {
                    Name = "Sounders Soiree",
                    Layout = 0
                },
                new Room
                {
                    Name = "Holiday Daze",
                    Layout = 0
                },
                new Room
                {
                    Name = "Holiday Daze",
                    Layout = 0
                },
                new Room
                {
                    Name = "Holiday Daze",
                    Layout = 0
                },
                );
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenity { get; set; }
        public DbSet<Amenities> Amenity { get; set; }

    }
}

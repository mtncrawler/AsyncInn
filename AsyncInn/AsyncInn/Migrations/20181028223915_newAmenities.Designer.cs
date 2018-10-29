﻿// <auto-generated />
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsyncInn.Migrations
{
    [DbContext(typeof(AsyncInnDbContext))]
    [Migration("20181028223915_newAmenities")]
    partial class newAmenities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsyncInn.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Amenity");

                    b.HasData(
                        new { ID = 1, Name = "A/C" },
                        new { ID = 2, Name = "Waterview" },
                        new { ID = 3, Name = "Hot tub" },
                        new { ID = 4, Name = "Espresso machine" },
                        new { ID = 5, Name = "Vinyl player" }
                    );
                });

            modelBuilder.Entity("AsyncInn.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.HasKey("ID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new { ID = 1, City = "Seattle", Name = "Holiday Daze", Phone = "206-555-9876", State = "WA", Street = "10 Derp St", ZipCode = "98101" },
                        new { ID = 2, City = "Seattle", Name = "Days Out", Phone = "206-675-1234", State = "WA", Street = "123 Western St", ZipCode = "98101" },
                        new { ID = 3, City = "Portland", Name = "Ace Motel", Phone = "206-675-9832", State = "OR", Street = "987 Oregon St", ZipCode = "97101" },
                        new { ID = 4, City = "Austin ", Name = "Two Seasons", Phone = "601-555-5432", State = "TX", Street = "4 Windy Way", ZipCode = "54321" },
                        new { ID = 5, City = "Boston", Name = "Best Eastern", Phone = "321-555-4512", State = "MA", Street = "678 Leeward St", ZipCode = "01234" }
                    );
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID");

                    b.Property<int>("RoomNumber");

                    b.Property<bool>("PetFriendly");

                    b.Property<decimal>("Rate");

                    b.Property<int>("RoomID");

                    b.HasKey("HotelID", "RoomNumber");

                    b.HasIndex("RoomID");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("AsyncInn.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Layout");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new { ID = 1, Layout = 1, Name = "Honeymoon Suite" },
                        new { ID = 2, Layout = 0, Name = "Solo Cup" },
                        new { ID = 3, Layout = 2, Name = "Sounders Soiree" },
                        new { ID = 4, Layout = 2, Name = "Tropical Escape" },
                        new { ID = 5, Layout = 2, Name = "Mountain Refuge" },
                        new { ID = 6, Layout = 1, Name = "Urban Delight" }
                    );
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.Property<int>("AmenitiesID");

                    b.Property<int>("RoomID");

                    b.HasKey("AmenitiesID", "RoomID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomAmenity");
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.HasOne("AsyncInn.Models.Hotel", "Hotels")
                        .WithMany("HotelRooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Rooms")
                        .WithMany("HotelRooms")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.HasOne("AsyncInn.Models.Amenities", "Amenity")
                        .WithMany("RoomAmenity")
                        .HasForeignKey("AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Rooms")
                        .WithMany("RoomAmenity")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

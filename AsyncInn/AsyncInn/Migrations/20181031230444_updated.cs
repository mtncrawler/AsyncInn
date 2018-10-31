using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAmenity_Amenity_AmenitiesID",
                table: "RoomAmenity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Amenity",
                table: "Amenity");

            migrationBuilder.RenameTable(
                name: "Amenity",
                newName: "Amenities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Amenities",
                table: "Amenities",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAmenity_Amenities_AmenitiesID",
                table: "RoomAmenity",
                column: "AmenitiesID",
                principalTable: "Amenities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAmenity_Amenities_AmenitiesID",
                table: "RoomAmenity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Amenities",
                table: "Amenities");

            migrationBuilder.RenameTable(
                name: "Amenities",
                newName: "Amenity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Amenity",
                table: "Amenity",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAmenity_Amenity_AmenitiesID",
                table: "RoomAmenity",
                column: "AmenitiesID",
                principalTable: "Amenity",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

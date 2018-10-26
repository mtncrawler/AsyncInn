using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class changedDataTypeToDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID",
                table: "HotelRooms");

            migrationBuilder.DropIndex(
                name: "IX_HotelRooms_RoomID",
                table: "HotelRooms");

            migrationBuilder.AlterColumn<decimal>(
                name: "RoomID",
                table: "HotelRooms",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "RoomsID",
                table: "HotelRooms",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_RoomsID",
                table: "HotelRooms",
                column: "RoomsID");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Rooms_RoomsID",
                table: "HotelRooms",
                column: "RoomsID",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Rooms_RoomsID",
                table: "HotelRooms");

            migrationBuilder.DropIndex(
                name: "IX_HotelRooms_RoomsID",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "RoomsID",
                table: "HotelRooms");

            migrationBuilder.AlterColumn<int>(
                name: "RoomID",
                table: "HotelRooms",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_RoomID",
                table: "HotelRooms",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID",
                table: "HotelRooms",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShauryaTechTest.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Photopath = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleNumber = table.Column<string>(nullable: false),
                    VehicleType = table.Column<string>(nullable: true),
                    ChassisNumber = table.Column<string>(nullable: true),
                    EngineNumber = table.Column<string>(nullable: true),
                    Manufacturingyear = table.Column<int>(nullable: false),
                    LoadCarryingCapacity = table.Column<string>(nullable: true),
                    Makeofvehicle = table.Column<string>(nullable: true),
                    ModelNumber = table.Column<string>(nullable: true),
                    BodyType = table.Column<string>(nullable: true),
                    OrganisationName = table.Column<string>(nullable: true),
                    DeviceID = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true),
                    UserID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleNumber);
                    table.ForeignKey(
                        name: "FK_Vehicles_Users_UserID1",
                        column: x => x.UserID1,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_UserID1",
                table: "Vehicles",
                column: "UserID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

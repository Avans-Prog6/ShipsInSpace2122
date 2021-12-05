using Microsoft.EntityFrameworkCore.Migrations;

namespace CentraalBureauVliegvaardigheden.LocalData.Migrations
{
    public partial class SDVTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motoren",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Energie = table.Column<int>(type: "int", nullable: false),
                    Gewicht = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motoren", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rompen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Draagvermogen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rompen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schepen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RompId = table.Column<int>(type: "int", nullable: true),
                    MotorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schepen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schepen_Motoren_MotorId",
                        column: x => x.MotorId,
                        principalTable: "Motoren",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schepen_Rompen_RompId",
                        column: x => x.RompId,
                        principalTable: "Rompen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vleugels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Energie = table.Column<int>(type: "int", nullable: false),
                    Gewicht = table.Column<int>(type: "int", nullable: false),
                    NumberOfHardpoints = table.Column<int>(type: "int", nullable: false),
                    SchipId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vleugels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vleugels_Schepen_SchipId",
                        column: x => x.SchipId,
                        principalTable: "Schepen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wapens",
                columns: table => new
                {
                    Naam = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SchadeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnergieVerbruik = table.Column<int>(type: "int", nullable: false),
                    Gewicht = table.Column<int>(type: "int", nullable: false),
                    VleugelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wapens", x => x.Naam);
                    table.ForeignKey(
                        name: "FK_Wapens_Vleugels_VleugelId",
                        column: x => x.VleugelId,
                        principalTable: "Vleugels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Motoren",
                columns: new[] { "Id", "Energie", "Gewicht", "Naam" },
                values: new object[,]
                {
                    { 1, 150, 150, "Galaxy Class" },
                    { 2, 350, 350, "Intrepid Class" },
                    { 3, 200, 200, "Constellation Class" }
                });

            migrationBuilder.InsertData(
                table: "Rompen",
                columns: new[] { "Id", "Draagvermogen", "Naam" },
                values: new object[,]
                {
                    { 1, "Interceptor", "Zenith" },
                    { 2, "HeavyTank", "Neptunus" },
                    { 3, "Tank", "Katalyst" },
                    { 4, "MediumFighter", "Racewing" }
                });

            migrationBuilder.InsertData(
                table: "Vleugels",
                columns: new[] { "Id", "Energie", "Gewicht", "Naam", "NumberOfHardpoints", "SchipId" },
                values: new object[,]
                {
                    { 5, 0, 175, "Raceing", 1, null },
                    { 4, 15, 250, "O-Fence", 2, null },
                    { 2, 0, 150, "Horizon", 1, null },
                    { 1, 0, 275, "Blade", 2, null },
                    { 3, 0, 300, "D-Fence", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Wapens",
                columns: new[] { "Naam", "EnergieVerbruik", "Gewicht", "SchadeType", "VleugelId" },
                values: new object[,]
                {
                    { "Ice Barrage", 41, 35, "Bevriezing", null },
                    { "Tidal Wave", 74, 18, "Electrisch", null },
                    { "Shredder", 13, 75, "Electrisch", null },
                    { "Levitator", 56, 59, "Electrisch", null },
                    { "Imploder", 43, 270, "Zwaartekracht", null },
                    { "Hailstorm", 56, 34, "Bevriezing", null },
                    { "Fury Cannon", 52, 76, "Hitte", null },
                    { "Shockwave", 47, 105, "Projectiel", null },
                    { "Freeze Ray", 52, 24, "Bevriezing", null },
                    { "Flamethrower", 74, 30, "Hitte", null },
                    { "Crusher", 56, 89, "Zwaartekracht", null },
                    { "Volcano", 10, 80, "Hitte", null },
                    { "Gauss Gun", 52, 110, "Projectiel", null },
                    { "Nullifier", 43, 23, "Zwaartekracht", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schepen_MotorId",
                table: "Schepen",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_Schepen_RompId",
                table: "Schepen",
                column: "RompId");

            migrationBuilder.CreateIndex(
                name: "IX_Vleugels_SchipId",
                table: "Vleugels",
                column: "SchipId");

            migrationBuilder.CreateIndex(
                name: "IX_Wapens_VleugelId",
                table: "Wapens",
                column: "VleugelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wapens");

            migrationBuilder.DropTable(
                name: "Vleugels");

            migrationBuilder.DropTable(
                name: "Schepen");

            migrationBuilder.DropTable(
                name: "Motoren");

            migrationBuilder.DropTable(
                name: "Rompen");
        }
    }
}

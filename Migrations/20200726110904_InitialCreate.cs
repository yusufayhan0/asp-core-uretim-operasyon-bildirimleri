using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UretimOperasyonBildirimleri.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bildirims",
                columns: table => new
                {
                    IsNo = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslangic = table.Column<DateTime>(nullable: false),
                    Bitis = table.Column<DateTime>(nullable: false),
                    ToplamSure = table.Column<DateTime>(nullable: false),
                    Statu = table.Column<string>(nullable: true),
                    DurusNedeni = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bildirims", x => x.IsNo);
                });

            migrationBuilder.CreateTable(
                name: "duruslars",
                columns: table => new
                {
                    DurusId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslangic = table.Column<DateTime>(nullable: false),
                    Bitis = table.Column<DateTime>(nullable: false),
                    DurusNededi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_duruslars", x => x.DurusId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bildirims");

            migrationBuilder.DropTable(
                name: "duruslars");
        }
    }
}

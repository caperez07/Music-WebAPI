using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class INIT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tabela_de_Músicas",
                columns: table => new
                {
                    MusicID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusicNAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SingerNAME = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    MusicGENDER = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MusicPLATFORMS = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela_de_Músicas", x => x.MusicID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tabela_de_Músicas");
        }
    }
}

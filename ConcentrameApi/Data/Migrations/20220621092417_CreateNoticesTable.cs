using Microsoft.EntityFrameworkCore.Migrations;

namespace ConcentrameApi.Data.Migrations
{
    public partial class CreateNoticesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: false),
                    Paragraph1 = table.Column<string>(nullable: false),
                    Paragraph2 = table.Column<string>(nullable: false),
                    Paragraph3 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notice", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Link");

            migrationBuilder.DropTable(
                name: "Notice");
        }
    }
}

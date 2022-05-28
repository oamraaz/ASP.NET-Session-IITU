using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Final.Data.Migrations
{
    public partial class secondDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BooksName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BooksPrice = table.Column<int>(type: "int", nullable: false),
                    BooksAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BooksPage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}

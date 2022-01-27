using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmCollection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    film_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: true),
                    rating = table.Column<string>(nullable: true),
                    edited = table.Column<bool>(nullable: false),
                    lent_to = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.film_id);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "film_id", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action/Adventure", "John Doe", false, "", "", "PG-13", "Casino Royale", 2006 });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "film_id", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Action/Adventure", "John Doe", false, "", "", "PG-13", "Skyfall", 2013 });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "film_id", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Action/Adventure", "John Doe", false, "", "", "PG-13", "No Time To Die", 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}

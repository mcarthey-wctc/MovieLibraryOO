using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieLibraryOO.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "genres",
                columns: table => new
                {
                    id = table.Column<long>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genres", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "genres_movies",
                columns: table => new
                {
                    id = table.Column<long>(type: "integer", nullable: false),
                    movie_id = table.Column<long>(type: "integer", nullable: true),
                    genre_id = table.Column<long>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genres_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<long>(type: "integer", nullable: false),
                    title = table.Column<string>(type: "varchar(255)", nullable: true),
                    release_date = table.Column<byte[]>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "occupations",
                columns: table => new
                {
                    id = table.Column<long>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_occupations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ratings",
                columns: table => new
                {
                    id = table.Column<long>(type: "integer", nullable: false),
                    user_id = table.Column<long>(type: "integer", nullable: true),
                    movie_id = table.Column<long>(type: "integer", nullable: true),
                    rating = table.Column<long>(type: "integer", nullable: true),
                    rated_at = table.Column<byte[]>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "integer", nullable: false),
                    age = table.Column<long>(type: "integer", nullable: true),
                    gender = table.Column<string>(type: "char(1)", nullable: true),
                    occupation_id = table.Column<long>(type: "integer", nullable: true),
                    zip_code = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "genres");

            migrationBuilder.DropTable(
                name: "genres_movies");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "occupations");

            migrationBuilder.DropTable(
                name: "ratings");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}

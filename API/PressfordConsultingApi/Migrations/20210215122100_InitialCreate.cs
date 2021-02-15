using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PressfordConsultingApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    articleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    articleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    likes = table.Column<int>(type: "int", nullable: true),
                    articleBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    articleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    articleDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.articleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");
        }
    }
}

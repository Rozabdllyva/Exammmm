using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Maxim.Migrations
{
    public partial class gfgdghkfh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Create = table.Column<DateTime>(nullable: false),
                    Update = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contents");
        }
    }
}

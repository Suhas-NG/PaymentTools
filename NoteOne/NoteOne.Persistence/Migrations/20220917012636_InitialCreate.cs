using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteOne.Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         
                migrationBuilder.CreateTable(
                    name: "Tags",
                    columns: table => new
                    {
                        Guid = table.Column<Guid>(type: "uuid", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Tags", x => x.Guid);
                    });

                migrationBuilder.CreateTable(
                    name: "Users",
                    columns: table => new
                    {
                        Guid = table.Column<Guid>(type: "uuid", nullable: false),
                        UserName = table.Column<string>(type: "text", nullable: true),
                        Password = table.Column<string>(type: "text", nullable: true)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Users", x => x.Guid);
                    });

                migrationBuilder.CreateTable(
                    name: "Category",
                    columns: table => new
                    {
                        Guid = table.Column<Guid>(type: "uuid", nullable: false),
                        CategoryName = table.Column<string>(type: "text", nullable: false),
                        UserGuid = table.Column<Guid>(type: "uuid", nullable: true)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Category", x => x.Guid);
                        table.ForeignKey(
                            name: "FK_Category_Users_UserGuid",
                            column: x => x.UserGuid,
                            principalTable: "Users",
                            principalColumn: "Guid");
                    });

                migrationBuilder.CreateTable(
                    name: "Pages",
                    columns: table => new
                    {
                        Guid = table.Column<Guid>(type: "uuid", nullable: false),
                        PageName = table.Column<string>(type: "text", nullable: true),
                        PageTitle = table.Column<string>(type: "text", nullable: true),
                        CategoryGuid = table.Column<Guid>(type: "uuid", nullable: true)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Pages", x => x.Guid);
                        table.ForeignKey(
                            name: "FK_Pages_Category_CategoryGuid",
                            column: x => x.CategoryGuid,
                            principalTable: "Category",
                            principalColumn: "Guid");
                    });

                migrationBuilder.CreateTable(
                    name: "Notes",
                    columns: table => new
                    {
                        Guid = table.Column<Guid>(type: "uuid", nullable: false),
                        Description = table.Column<string>(type: "text", nullable: true),
                        Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                        PageGuid = table.Column<Guid>(type: "uuid", nullable: true)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Notes", x => x.Guid);
                        table.ForeignKey(
                            name: "FK_Notes_Pages_PageGuid",
                            column: x => x.PageGuid,
                            principalTable: "Pages",
                            principalColumn: "Guid");
                    });

                migrationBuilder.CreateIndex(
                    name: "IX_Category_UserGuid",
                    table: "Category",
                    column: "UserGuid");

                migrationBuilder.CreateIndex(
                    name: "IX_Notes_PageGuid",
                    table: "Notes",
                    column: "PageGuid");

                migrationBuilder.CreateIndex(
                    name: "IX_Pages_CategoryGuid",
                    table: "Pages",
                    column: "CategoryGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

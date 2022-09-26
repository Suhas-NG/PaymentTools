using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteOne.Persistence.Migrations
{
    public partial class refactoryCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Users_UserGuid",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Category_CategoryGuid",
                table: "Pages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Category_UserGuid",
                table: "Categories",
                newName: "IX_Categories_UserGuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_UserGuid",
                table: "Categories",
                column: "UserGuid",
                principalTable: "Users",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Categories_CategoryGuid",
                table: "Pages",
                column: "CategoryGuid",
                principalTable: "Categories",
                principalColumn: "Guid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_UserGuid",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Categories_CategoryGuid",
                table: "Pages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_UserGuid",
                table: "Category",
                newName: "IX_Category_UserGuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Users_UserGuid",
                table: "Category",
                column: "UserGuid",
                principalTable: "Users",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Category_CategoryGuid",
                table: "Pages",
                column: "CategoryGuid",
                principalTable: "Category",
                principalColumn: "Guid");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteOne.Persistence.Migrations
{
    public partial class addUserGuidToCategoryModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_UserGuid",
                table: "Categories");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserGuid",
                table: "Categories",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_UserGuid",
                table: "Categories",
                column: "UserGuid",
                principalTable: "Users",
                principalColumn: "Guid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_UserGuid",
                table: "Categories");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserGuid",
                table: "Categories",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_UserGuid",
                table: "Categories",
                column: "UserGuid",
                principalTable: "Users",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

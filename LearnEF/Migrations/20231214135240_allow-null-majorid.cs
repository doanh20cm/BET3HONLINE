using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnEF.Migrations
{
    public partial class allownullmajorid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRooms_Majors_MajorId",
                table: "ClassRooms");

            migrationBuilder.AlterColumn<Guid>(
                name: "MajorId",
                table: "ClassRooms",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRooms_Majors_MajorId",
                table: "ClassRooms",
                column: "MajorId",
                principalTable: "Majors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRooms_Majors_MajorId",
                table: "ClassRooms");

            migrationBuilder.AlterColumn<Guid>(
                name: "MajorId",
                table: "ClassRooms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRooms_Majors_MajorId",
                table: "ClassRooms",
                column: "MajorId",
                principalTable: "Majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

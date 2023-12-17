using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnEF.Migrations
{
    public partial class addfkmajorclassroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ClassRooms_MajorId",
                table: "ClassRooms",
                column: "MajorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRooms_Majors_MajorId",
                table: "ClassRooms",
                column: "MajorId",
                principalTable: "Majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRooms_Majors_MajorId",
                table: "ClassRooms");

            migrationBuilder.DropIndex(
                name: "IX_ClassRooms_MajorId",
                table: "ClassRooms");
        }
    }
}

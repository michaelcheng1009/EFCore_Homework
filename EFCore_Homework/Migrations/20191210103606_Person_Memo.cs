using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_Homework.Migrations
{
    public partial class Person_Memo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Memo",
                table: "Person",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Memo",
                table: "Person");
        }
    }
}

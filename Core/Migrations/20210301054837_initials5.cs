using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class initials5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HContactDetailValue",
                table: "HeaderContactDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HContactDetailValue",
                table: "HeaderContactDetails");
        }
    }
}

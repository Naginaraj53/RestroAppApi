using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class Iniatil4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookTables",
                columns: table => new
                {
                    BookTableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    modifiedDate = table.Column<DateTime>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true),
                    CandidateName = table.Column<string>(nullable: true),
                    CandidateEmail = table.Column<string>(nullable: true),
                    CandidateMobileNo = table.Column<string>(nullable: true),
                    CondidateMessage = table.Column<string>(nullable: true),
                    CondidateTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTables", x => x.BookTableId);
                });

            migrationBuilder.CreateTable(
                name: "HeaderContactDetails",
                columns: table => new
                {
                    HContactDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    modifiedDate = table.Column<DateTime>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true),
                    HContactDetailName = table.Column<string>(nullable: true),
                    HContactDetailLink = table.Column<string>(nullable: true),
                    HContactDetailIcon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderContactDetails", x => x.HContactDetailId);
                });

            migrationBuilder.CreateTable(
                name: "LinkContents",
                columns: table => new
                {
                    LinkContentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkContentTitle = table.Column<string>(nullable: true),
                    LinkContentType = table.Column<string>(nullable: true),
                    LinkContentLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkContents", x => x.LinkContentId);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    modifiedDate = table.Column<DateTime>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true),
                    SocialMediaName = table.Column<string>(nullable: true),
                    SocialMediaImage = table.Column<string>(nullable: true),
                    SocialMediaLink = table.Column<string>(nullable: true),
                    SocialMediaFaClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    modifiedDate = table.Column<DateTime>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookTables");

            migrationBuilder.DropTable(
                name: "HeaderContactDetails");

            migrationBuilder.DropTable(
                name: "LinkContents");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

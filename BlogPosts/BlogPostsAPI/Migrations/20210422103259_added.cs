using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPostsAPI.Migrations
{
    public partial class added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "BlogPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BlogPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "BlogPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "BlogPosts");
        }
    }
}

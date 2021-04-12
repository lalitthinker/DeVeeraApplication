﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Data.Migrations
{
    public partial class AddedVideo_SubTitleColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Videos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Videos");
        }
    }
}

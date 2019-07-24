using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyStuff.Migrations
{
    public partial class Project_FullDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Projects",
                newName: "ShortDescription");

            migrationBuilder.AddColumn<string>(
                name: "FullDetails",
                table: "Projects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullDetails",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Projects",
                newName: "Description");
        }
    }
}

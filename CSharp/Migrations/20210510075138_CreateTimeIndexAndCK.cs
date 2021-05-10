using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharp.Migrations
{
    public partial class CreateTimeIndexAndCK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Register",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Register_CreateTime",
                table: "Register",
                column: "CreateTime",
                unique: true,
                filter: "[CreateTime] IS NOT NULL");

            migrationBuilder.AddCheckConstraint(
                name: "CK_CreateTime",
                table: "Register",
                sql: "CreateTime>='2000/1/1'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Register_CreateTime",
                table: "Register");

            migrationBuilder.DropCheckConstraint(
                name: "CK_CreateTime",
                table: "Register");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Register");
        }
    }
}

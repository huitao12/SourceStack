using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    InvitedById = table.Column<int>(type: "int", nullable: true),
                    InviteCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailId = table.Column<int>(type: "int", nullable: false),
                    EmailId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => x.Id);
                    table.CheckConstraint("CK_CreateTime", "CreateTime>='2000/1/1'");
                    table.ForeignKey(
                        name: "FK_Register_Email_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Register_Email_EmailId1",
                        column: x => x.EmailId1,
                        principalTable: "Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Register_Register_InvitedById",
                        column: x => x.InvitedById,
                        principalTable: "Register",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Register_CreateTime",
                table: "Register",
                column: "CreateTime",
                unique: true,
                filter: "[CreateTime] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Register_EmailId",
                table: "Register",
                column: "EmailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Register_EmailId1",
                table: "Register",
                column: "EmailId1",
                unique: true,
                filter: "[EmailId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Register_InvitedById",
                table: "Register",
                column: "InvitedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Register");

            migrationBuilder.DropTable(
                name: "Email");
        }
    }
}

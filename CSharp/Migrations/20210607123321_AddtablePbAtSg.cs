using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharp.Migrations
{
    public partial class AddtablePbAtSg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Appraise_ArticleId",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Article_Title",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kind",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProblemId",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Problem_Title",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDateTime",
                table: "Contents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reward",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Suggest_Title",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Keyword",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyword", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleKeyword",
                columns: table => new
                {
                    ArticlesId = table.Column<int>(type: "int", nullable: false),
                    keywordsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleKeyword", x => new { x.ArticlesId, x.keywordsId });
                    table.ForeignKey(
                        name: "FK_ArticleKeyword_Contents_ArticlesId",
                        column: x => x.ArticlesId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleKeyword_Keyword_keywordsId",
                        column: x => x.keywordsId,
                        principalTable: "Keyword",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeywordProblem",
                columns: table => new
                {
                    KeywordsId = table.Column<int>(type: "int", nullable: false),
                    ProblemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeywordProblem", x => new { x.KeywordsId, x.ProblemsId });
                    table.ForeignKey(
                        name: "FK_KeywordProblem_Contents_ProblemsId",
                        column: x => x.ProblemsId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeywordProblem_Keyword_KeywordsId",
                        column: x => x.KeywordsId,
                        principalTable: "Keyword",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_Appraise_ArticleId",
                table: "Contents",
                column: "Appraise_ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ArticleId",
                table: "Contents",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CommentId",
                table: "Contents",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ProblemId",
                table: "Contents",
                column: "ProblemId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleKeyword_keywordsId",
                table: "ArticleKeyword",
                column: "keywordsId");

            migrationBuilder.CreateIndex(
                name: "IX_KeywordProblem_ProblemsId",
                table: "KeywordProblem",
                column: "ProblemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Contents_Appraise_ArticleId",
                table: "Contents",
                column: "Appraise_ArticleId",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Contents_ArticleId",
                table: "Contents",
                column: "ArticleId",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Contents_CommentId",
                table: "Contents",
                column: "CommentId",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Contents_ProblemId",
                table: "Contents",
                column: "ProblemId",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Contents_Appraise_ArticleId",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Contents_ArticleId",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Contents_CommentId",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Contents_ProblemId",
                table: "Contents");

            migrationBuilder.DropTable(
                name: "ArticleKeyword");

            migrationBuilder.DropTable(
                name: "KeywordProblem");

            migrationBuilder.DropTable(
                name: "Keyword");

            migrationBuilder.DropIndex(
                name: "IX_Contents_Appraise_ArticleId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_ArticleId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_CommentId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_ProblemId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Appraise_ArticleId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Article_Title",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Kind",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "ProblemId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Problem_Title",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "PublishDateTime",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Reward",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Suggest_Title",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Contents");
        }
    }
}

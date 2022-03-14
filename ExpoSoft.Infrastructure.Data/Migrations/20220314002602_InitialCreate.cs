using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpoSoft.Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IncreaseFactor = table.Column<float>(type: "REAL", nullable: false),
                    NationalSales = table.Column<float>(type: "REAL", nullable: false),
                    CompetitiveFactor = table.Column<float>(type: "REAL", nullable: false),
                    ExportIntention = table.Column<float>(type: "REAL", nullable: false),
                    ActivityPerception = table.Column<float>(type: "REAL", nullable: false),
                    InternationalExperience = table.Column<float>(type: "REAL", nullable: false),
                    FutureExperience = table.Column<float>(type: "REAL", nullable: false),
                    ManagerProfile = table.Column<float>(type: "REAL", nullable: false),
                    TotalScore = table.Column<float>(type: "REAL", nullable: false),
                    StarDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    BusinessId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Nit = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    TypeOfBusiness = table.Column<string>(type: "TEXT", nullable: true),
                    Department = table.Column<string>(type: "TEXT", nullable: true),
                    Town = table.Column<string>(type: "TEXT", nullable: true),
                    OwnerName = table.Column<string>(type: "TEXT", nullable: true),
                    OwnerlastName = table.Column<string>(type: "TEXT", nullable: true),
                    ScoreId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Businesses_Scores_ScoreId",
                        column: x => x.ScoreId,
                        principalTable: "Scores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_ScoreId",
                table: "Businesses",
                column: "ScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_BusinessId",
                table: "Scores",
                column: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scores_Businesses_BusinessId",
                table: "Scores",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Businesses_Scores_ScoreId",
                table: "Businesses");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "Businesses");
        }
    }
}

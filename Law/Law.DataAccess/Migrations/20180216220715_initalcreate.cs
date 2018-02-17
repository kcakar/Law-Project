using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Law.DataAccess.Migrations
{
    public partial class initalcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticlePieces",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ArticleId = table.Column<string>(nullable: true),
                    ImagePosition = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Paragraph = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlePieces", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    AffiliateID = table.Column<string>(nullable: true),
                    BodyPreview = table.Column<string>(nullable: true),
                    CityID = table.Column<string>(nullable: true),
                    ContributorID = table.Column<string>(nullable: true),
                    CountryID = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LanguageID = table.Column<string>(nullable: true),
                    PracticeAreaID = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    ViewCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NameBases",
                columns: table => new
                {
                    Description = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    CountryID = table.Column<string>(nullable: true),
                    AffiliateID = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    CityID = table.Column<string>(nullable: true),
                    Contributor_CountryID = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Contributor_ImageURL = table.Column<string>(nullable: true),
                    LastPostDate = table.Column<DateTime>(nullable: true),
                    TotalContributions = table.Column<int>(nullable: true),
                    ID = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CommentCount = table.Column<int>(nullable: true),
                    User_Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NameBases", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlePieces");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "NameBases");
        }
    }
}

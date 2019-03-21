using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WoW.Data.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frameworks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Progress = table.Column<float>(nullable: false),
                    ProjectStarted = table.Column<DateTime>(nullable: false),
                    WhenYouStartToLearn = table.Column<DateTime>(nullable: false),
                    WhenYouFinish = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frameworks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Documentation = table.Column<string>(nullable: true),
                    Tutorials = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    Progress = table.Column<float>(nullable: false),
                    ProjectStarted = table.Column<DateTime>(nullable: false),
                    WhenYouStartToLearn = table.Column<DateTime>(nullable: false),
                    WhenYouFinish = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelatedTechnologies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Progress = table.Column<float>(nullable: false),
                    ProjectIsStart = table.Column<DateTime>(nullable: false),
                    WhenYouStartToLearn = table.Column<DateTime>(nullable: false),
                    WhenYouFinish = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedTechnologies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Progress = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UrlPath = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WayOfWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Progress = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WayOfWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrameworkLanguage",
                columns: table => new
                {
                    FrameworkId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameworkLanguage", x => new { x.FrameworkId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_FrameworkLanguage_Frameworks_FrameworkId",
                        column: x => x.FrameworkId,
                        principalTable: "Frameworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FrameworkLanguage_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FrameworkRelatedTechnology",
                columns: table => new
                {
                    FrameworkId = table.Column<int>(nullable: false),
                    RelatedTechnologyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameworkRelatedTechnology", x => new { x.FrameworkId, x.RelatedTechnologyId });
                    table.ForeignKey(
                        name: "FK_FrameworkRelatedTechnology_Frameworks_FrameworkId",
                        column: x => x.FrameworkId,
                        principalTable: "Frameworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FrameworkRelatedTechnology_RelatedTechnologies_RelatedTechnologyId",
                        column: x => x.RelatedTechnologyId,
                        principalTable: "RelatedTechnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageRelatedTechnology",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false),
                    RelatedTechnologyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageRelatedTechnology", x => new { x.LanguageId, x.RelatedTechnologyId });
                    table.ForeignKey(
                        name: "FK_LanguageRelatedTechnology_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageRelatedTechnology_RelatedTechnologies_RelatedTechnologyId",
                        column: x => x.RelatedTechnologyId,
                        principalTable: "RelatedTechnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FrameworkUrl",
                columns: table => new
                {
                    FrameworkId = table.Column<int>(nullable: false),
                    UrlId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameworkUrl", x => new { x.FrameworkId, x.UrlId });
                    table.ForeignKey(
                        name: "FK_FrameworkUrl_Frameworks_FrameworkId",
                        column: x => x.FrameworkId,
                        principalTable: "Frameworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FrameworkUrl_Urls_UrlId",
                        column: x => x.UrlId,
                        principalTable: "Urls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageUrl",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false),
                    UrlId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageUrl", x => new { x.LanguageId, x.UrlId });
                    table.ForeignKey(
                        name: "FK_LanguageUrl_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageUrl_Urls_UrlId",
                        column: x => x.UrlId,
                        principalTable: "Urls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatedTechnologyUrl",
                columns: table => new
                {
                    RelatedTechnologyId = table.Column<int>(nullable: false),
                    UrlId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedTechnologyUrl", x => new { x.RelatedTechnologyId, x.UrlId });
                    table.ForeignKey(
                        name: "FK_RelatedTechnologyUrl_RelatedTechnologies_RelatedTechnologyId",
                        column: x => x.RelatedTechnologyId,
                        principalTable: "RelatedTechnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedTechnologyUrl_Urls_UrlId",
                        column: x => x.UrlId,
                        principalTable: "Urls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Read = table.Column<bool>(nullable: false),
                    Progress = table.Column<float>(nullable: false),
                    WhenYouStartToLearn = table.Column<DateTime>(nullable: false),
                    WhenYouFinish = table.Column<DateTime>(nullable: false),
                    Release = table.Column<DateTime>(nullable: false),
                    Store = table.Column<byte[]>(nullable: true),
                    WayOfWorkId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_WayOfWorks_WayOfWorkId",
                        column: x => x.WayOfWorkId,
                        principalTable: "WayOfWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Watched = table.Column<bool>(nullable: false),
                    Progress = table.Column<float>(nullable: false),
                    Release = table.Column<DateTime>(nullable: false),
                    WhenYouStartToLearn = table.Column<DateTime>(nullable: false),
                    WhenYouFinish = table.Column<DateTime>(nullable: false),
                    WayOfWorkId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Videos_WayOfWorks_WayOfWorkId",
                        column: x => x.WayOfWorkId,
                        principalTable: "WayOfWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WayOfWorkFramework",
                columns: table => new
                {
                    WayOfWorkId = table.Column<int>(nullable: false),
                    FrameworkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WayOfWorkFramework", x => new { x.WayOfWorkId, x.FrameworkId });
                    table.ForeignKey(
                        name: "FK_WayOfWorkFramework_Frameworks_FrameworkId",
                        column: x => x.FrameworkId,
                        principalTable: "Frameworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WayOfWorkFramework_WayOfWorks_WayOfWorkId",
                        column: x => x.WayOfWorkId,
                        principalTable: "WayOfWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WayOfWorkLanguage",
                columns: table => new
                {
                    WayOfWorkId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WayOfWorkLanguage", x => new { x.WayOfWorkId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_WayOfWorkLanguage_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WayOfWorkLanguage_WayOfWorks_WayOfWorkId",
                        column: x => x.WayOfWorkId,
                        principalTable: "WayOfWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookStatus",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStatus", x => new { x.BookId, x.StatusId });
                    table.ForeignKey(
                        name: "FK_BookStatus_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookStatus_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FrameworkBook",
                columns: table => new
                {
                    FrameworkId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameworkBook", x => new { x.FrameworkId, x.BookId });
                    table.ForeignKey(
                        name: "FK_FrameworkBook_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FrameworkBook_Frameworks_FrameworkId",
                        column: x => x.FrameworkId,
                        principalTable: "Frameworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguagesBooks",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagesBooks", x => new { x.LanguageId, x.BookId });
                    table.ForeignKey(
                        name: "FK_LanguagesBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguagesBooks_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatedTechnologyBook",
                columns: table => new
                {
                    RelatedTechnologyId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedTechnologyBook", x => new { x.RelatedTechnologyId, x.BookId });
                    table.ForeignKey(
                        name: "FK_RelatedTechnologyBook_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedTechnologyBook_RelatedTechnologies_RelatedTechnologyId",
                        column: x => x.RelatedTechnologyId,
                        principalTable: "RelatedTechnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FrameworkVideo",
                columns: table => new
                {
                    FrameworkId = table.Column<int>(nullable: false),
                    VideoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameworkVideo", x => new { x.FrameworkId, x.VideoId });
                    table.ForeignKey(
                        name: "FK_FrameworkVideo_Frameworks_FrameworkId",
                        column: x => x.FrameworkId,
                        principalTable: "Frameworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FrameworkVideo_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageVideo",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false),
                    VideoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageVideo", x => new { x.LanguageId, x.VideoId });
                    table.ForeignKey(
                        name: "FK_LanguageVideo_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageVideo_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatedTechnologyVideo",
                columns: table => new
                {
                    RelatedTechnologyId = table.Column<int>(nullable: false),
                    VideoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedTechnologyVideo", x => new { x.RelatedTechnologyId, x.VideoId });
                    table.ForeignKey(
                        name: "FK_RelatedTechnologyVideo_RelatedTechnologies_RelatedTechnologyId",
                        column: x => x.RelatedTechnologyId,
                        principalTable: "RelatedTechnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedTechnologyVideo_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoStatus",
                columns: table => new
                {
                    VideoId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoStatus", x => new { x.VideoId, x.StatusId });
                    table.ForeignKey(
                        name: "FK_VideoStatus_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoStatus_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoUrl",
                columns: table => new
                {
                    VideoId = table.Column<int>(nullable: false),
                    UrlId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoUrl", x => new { x.VideoId, x.UrlId });
                    table.ForeignKey(
                        name: "FK_VideoUrl_Urls_UrlId",
                        column: x => x.UrlId,
                        principalTable: "Urls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoUrl_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_WayOfWorkId",
                table: "Books",
                column: "WayOfWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_BookStatus_StatusId",
                table: "BookStatus",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_FrameworkBook_BookId",
                table: "FrameworkBook",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_FrameworkLanguage_LanguageId",
                table: "FrameworkLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_FrameworkRelatedTechnology_RelatedTechnologyId",
                table: "FrameworkRelatedTechnology",
                column: "RelatedTechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_FrameworkUrl_UrlId",
                table: "FrameworkUrl",
                column: "UrlId");

            migrationBuilder.CreateIndex(
                name: "IX_FrameworkVideo_VideoId",
                table: "FrameworkVideo",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageRelatedTechnology_RelatedTechnologyId",
                table: "LanguageRelatedTechnology",
                column: "RelatedTechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguagesBooks_BookId",
                table: "LanguagesBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageUrl_UrlId",
                table: "LanguageUrl",
                column: "UrlId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageVideo_VideoId",
                table: "LanguageVideo",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedTechnologyBook_BookId",
                table: "RelatedTechnologyBook",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedTechnologyUrl_UrlId",
                table: "RelatedTechnologyUrl",
                column: "UrlId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedTechnologyVideo_VideoId",
                table: "RelatedTechnologyVideo",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_WayOfWorkId",
                table: "Videos",
                column: "WayOfWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoStatus_StatusId",
                table: "VideoStatus",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoUrl_UrlId",
                table: "VideoUrl",
                column: "UrlId");

            migrationBuilder.CreateIndex(
                name: "IX_WayOfWorkFramework_FrameworkId",
                table: "WayOfWorkFramework",
                column: "FrameworkId");

            migrationBuilder.CreateIndex(
                name: "IX_WayOfWorkLanguage_LanguageId",
                table: "WayOfWorkLanguage",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookStatus");

            migrationBuilder.DropTable(
                name: "FrameworkBook");

            migrationBuilder.DropTable(
                name: "FrameworkLanguage");

            migrationBuilder.DropTable(
                name: "FrameworkRelatedTechnology");

            migrationBuilder.DropTable(
                name: "FrameworkUrl");

            migrationBuilder.DropTable(
                name: "FrameworkVideo");

            migrationBuilder.DropTable(
                name: "LanguageRelatedTechnology");

            migrationBuilder.DropTable(
                name: "LanguagesBooks");

            migrationBuilder.DropTable(
                name: "LanguageUrl");

            migrationBuilder.DropTable(
                name: "LanguageVideo");

            migrationBuilder.DropTable(
                name: "RelatedTechnologyBook");

            migrationBuilder.DropTable(
                name: "RelatedTechnologyUrl");

            migrationBuilder.DropTable(
                name: "RelatedTechnologyVideo");

            migrationBuilder.DropTable(
                name: "VideoStatus");

            migrationBuilder.DropTable(
                name: "VideoUrl");

            migrationBuilder.DropTable(
                name: "WayOfWorkFramework");

            migrationBuilder.DropTable(
                name: "WayOfWorkLanguage");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "RelatedTechnologies");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Urls");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "Frameworks");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "WayOfWorks");
        }
    }
}

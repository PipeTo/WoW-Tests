﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WoW.Data;

namespace WoW.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190306213243_CreateDb")]
    partial class CreateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WoW.Data.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<float>("Progress");

                    b.Property<bool>("Read");

                    b.Property<DateTime>("Release");

                    b.Property<byte[]>("Store");

                    b.Property<string>("Title");

                    b.Property<int?>("WayOfWorkId");

                    b.Property<DateTime>("WhenYouFinish");

                    b.Property<DateTime>("WhenYouStartToLearn");

                    b.HasKey("Id");

                    b.HasIndex("WayOfWorkId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("WoW.Data.Models.Framework", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<float>("Progress");

                    b.Property<DateTime>("ProjectStarted");

                    b.Property<DateTime>("WhenYouFinish");

                    b.Property<DateTime>("WhenYouStartToLearn");

                    b.HasKey("Id");

                    b.ToTable("Frameworks");
                });

            modelBuilder.Entity("WoW.Data.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Documentation");

                    b.Property<string>("Name");

                    b.Property<float>("Progress");

                    b.Property<DateTime>("ProjectStarted");

                    b.Property<string>("Tutorials");

                    b.Property<string>("Version");

                    b.Property<DateTime>("WhenYouFinish");

                    b.Property<DateTime>("WhenYouStartToLearn");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("WoW.Data.Models.RelatedTechnology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<float>("Progress");

                    b.Property<DateTime>("ProjectIsStart");

                    b.Property<DateTime>("WhenYouFinish");

                    b.Property<DateTime>("WhenYouStartToLearn");

                    b.HasKey("Id");

                    b.ToTable("RelatedTechnologies");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.BookStatus", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("StatusId");

                    b.HasKey("BookId", "StatusId");

                    b.HasIndex("StatusId");

                    b.ToTable("BookStatus");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.FrameworkBook", b =>
                {
                    b.Property<int>("FrameworkId");

                    b.Property<int>("BookId");

                    b.HasKey("FrameworkId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("FrameworkBook");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.FrameworkLanguage", b =>
                {
                    b.Property<int>("FrameworkId");

                    b.Property<int>("LanguageId");

                    b.HasKey("FrameworkId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("FrameworkLanguage");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.FrameworkRelatedTechnology", b =>
                {
                    b.Property<int>("FrameworkId");

                    b.Property<int>("RelatedTechnologyId");

                    b.HasKey("FrameworkId", "RelatedTechnologyId");

                    b.HasIndex("RelatedTechnologyId");

                    b.ToTable("FrameworkRelatedTechnology");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.FrameworkUrl", b =>
                {
                    b.Property<int>("FrameworkId");

                    b.Property<int>("UrlId");

                    b.HasKey("FrameworkId", "UrlId");

                    b.HasIndex("UrlId");

                    b.ToTable("FrameworkUrl");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.FrameworkVideo", b =>
                {
                    b.Property<int>("FrameworkId");

                    b.Property<int>("VideoId");

                    b.HasKey("FrameworkId", "VideoId");

                    b.HasIndex("VideoId");

                    b.ToTable("FrameworkVideo");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.LanguageRelatedTechnology", b =>
                {
                    b.Property<int>("LanguageId");

                    b.Property<int>("RelatedTechnologyId");

                    b.HasKey("LanguageId", "RelatedTechnologyId");

                    b.HasIndex("RelatedTechnologyId");

                    b.ToTable("LanguageRelatedTechnology");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.LanguageUrl", b =>
                {
                    b.Property<int>("LanguageId");

                    b.Property<int>("UrlId");

                    b.HasKey("LanguageId", "UrlId");

                    b.HasIndex("UrlId");

                    b.ToTable("LanguageUrl");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.LanguageVideo", b =>
                {
                    b.Property<int>("LanguageId");

                    b.Property<int>("VideoId");

                    b.HasKey("LanguageId", "VideoId");

                    b.HasIndex("VideoId");

                    b.ToTable("LanguageVideo");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.LanguagesBooks", b =>
                {
                    b.Property<int>("LanguageId");

                    b.Property<int>("BookId");

                    b.HasKey("LanguageId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("LanguagesBooks");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.RelatedTechnologyBook", b =>
                {
                    b.Property<int>("RelatedTechnologyId");

                    b.Property<int>("BookId");

                    b.HasKey("RelatedTechnologyId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("RelatedTechnologyBook");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.RelatedTechnologyUrl", b =>
                {
                    b.Property<int>("RelatedTechnologyId");

                    b.Property<int>("UrlId");

                    b.HasKey("RelatedTechnologyId", "UrlId");

                    b.HasIndex("UrlId");

                    b.ToTable("RelatedTechnologyUrl");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.RelatedTechnologyVideo", b =>
                {
                    b.Property<int>("RelatedTechnologyId");

                    b.Property<int>("VideoId");

                    b.HasKey("RelatedTechnologyId", "VideoId");

                    b.HasIndex("VideoId");

                    b.ToTable("RelatedTechnologyVideo");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.VideoStatus", b =>
                {
                    b.Property<int>("VideoId");

                    b.Property<int>("StatusId");

                    b.HasKey("VideoId", "StatusId");

                    b.HasIndex("StatusId");

                    b.ToTable("VideoStatus");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.VideoUrl", b =>
                {
                    b.Property<int>("VideoId");

                    b.Property<int>("UrlId");

                    b.HasKey("VideoId", "UrlId");

                    b.HasIndex("UrlId");

                    b.ToTable("VideoUrl");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.WayOfWorkFramework", b =>
                {
                    b.Property<int>("WayOfWorkId");

                    b.Property<int>("FrameworkId");

                    b.HasKey("WayOfWorkId", "FrameworkId");

                    b.HasIndex("FrameworkId");

                    b.ToTable("WayOfWorkFramework");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.WayOfWorkLanguage", b =>
                {
                    b.Property<int>("WayOfWorkId");

                    b.Property<int>("LanguageId");

                    b.HasKey("WayOfWorkId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("WayOfWorkLanguage");
                });

            modelBuilder.Entity("WoW.Data.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<float>("Progress");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("WoW.Data.Models.Url", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("UrlPath");

                    b.HasKey("Id");

                    b.ToTable("Urls");
                });

            modelBuilder.Entity("WoW.Data.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<float>("Progress");

                    b.Property<DateTime>("Release");

                    b.Property<string>("Title");

                    b.Property<bool>("Watched");

                    b.Property<int?>("WayOfWorkId");

                    b.Property<DateTime>("WhenYouFinish");

                    b.Property<DateTime>("WhenYouStartToLearn");

                    b.HasKey("Id");

                    b.HasIndex("WayOfWorkId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("WoW.Data.Models.WayOfWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<float>("Progress");

                    b.HasKey("Id");

                    b.ToTable("WayOfWorks");
                });

            modelBuilder.Entity("WoW.Data.Models.Book", b =>
                {
                    b.HasOne("WoW.Data.Models.WayOfWork", "WayOfWork")
                        .WithMany("Books")
                        .HasForeignKey("WayOfWorkId");
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.BookStatus", b =>
                {
                    b.HasOne("WoW.Data.Models.Book", "Book")
                        .WithMany("Statuses")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Status", "Status")
                        .WithMany("Books")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.FrameworkBook", b =>
                {
                    b.HasOne("WoW.Data.Models.Book", "Book")
                        .WithMany("Frameworks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Framework", "Framework")
                        .WithMany("Books")
                        .HasForeignKey("FrameworkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.FrameworkLanguage", b =>
                {
                    b.HasOne("WoW.Data.Models.Framework", "Framework")
                        .WithMany("Languages")
                        .HasForeignKey("FrameworkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Language", "Language")
                        .WithMany("Frameworks")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.FrameworkRelatedTechnology", b =>
                {
                    b.HasOne("WoW.Data.Models.Framework", "Framework")
                        .WithMany("RelatedTechnologies")
                        .HasForeignKey("FrameworkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.RelatedTechnology", "RelatedTechnology")
                        .WithMany("Frameworks")
                        .HasForeignKey("RelatedTechnologyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.FrameworkUrl", b =>
                {
                    b.HasOne("WoW.Data.Models.Framework", "Framework")
                        .WithMany("Url")
                        .HasForeignKey("FrameworkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Url", "Url")
                        .WithMany()
                        .HasForeignKey("UrlId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.FrameworkVideo", b =>
                {
                    b.HasOne("WoW.Data.Models.Framework", "Framework")
                        .WithMany("Videos")
                        .HasForeignKey("FrameworkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Video", "Video")
                        .WithMany("Frameworks")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.LanguageRelatedTechnology", b =>
                {
                    b.HasOne("WoW.Data.Models.Language", "Language")
                        .WithMany("RelatedTechnologies")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.RelatedTechnology", "RelatedTechnology")
                        .WithMany("Languages")
                        .HasForeignKey("RelatedTechnologyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.LanguageUrl", b =>
                {
                    b.HasOne("WoW.Data.Models.Language", "Language")
                        .WithMany("Url")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Url", "Url")
                        .WithMany()
                        .HasForeignKey("UrlId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.LanguageVideo", b =>
                {
                    b.HasOne("WoW.Data.Models.Language", "Language")
                        .WithMany("Videos")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Video", "Video")
                        .WithMany("Languages")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.LanguagesBooks", b =>
                {
                    b.HasOne("WoW.Data.Models.Book", "Book")
                        .WithMany("Languages")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.RelatedTechnologyBook", b =>
                {
                    b.HasOne("WoW.Data.Models.Book", "Book")
                        .WithMany("RelatedTechnologies")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.RelatedTechnology", "RelatedTechnology")
                        .WithMany("Books")
                        .HasForeignKey("RelatedTechnologyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.RelatedTechnologyUrl", b =>
                {
                    b.HasOne("WoW.Data.Models.RelatedTechnology", "RelatedTechnology")
                        .WithMany("Urls")
                        .HasForeignKey("RelatedTechnologyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Url", "Url")
                        .WithMany()
                        .HasForeignKey("UrlId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.RelatedTechnologyVideo", b =>
                {
                    b.HasOne("WoW.Data.Models.RelatedTechnology", "RelatedTechnology")
                        .WithMany("Videos")
                        .HasForeignKey("RelatedTechnologyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Video", "Video")
                        .WithMany("RelatedTechnologies")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.VideoStatus", b =>
                {
                    b.HasOne("WoW.Data.Models.Status", "Status")
                        .WithMany("Videos")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Video", "Video")
                        .WithMany("Statuses")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.VideoUrl", b =>
                {
                    b.HasOne("WoW.Data.Models.Url", "Url")
                        .WithMany()
                        .HasForeignKey("UrlId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.Video", "Video")
                        .WithMany("Urls")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.WayOfWorkFramework", b =>
                {
                    b.HasOne("WoW.Data.Models.Framework", "Framework")
                        .WithMany("WayOfWorks")
                        .HasForeignKey("FrameworkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.WayOfWork", "WayOfWork")
                        .WithMany("Frameworks")
                        .HasForeignKey("WayOfWorkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Relations.WayOfWorkLanguage", b =>
                {
                    b.HasOne("WoW.Data.Models.Language", "Language")
                        .WithMany("WayOfWorks")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WoW.Data.Models.WayOfWork", "WayOfWork")
                        .WithMany("Languages")
                        .HasForeignKey("WayOfWorkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WoW.Data.Models.Video", b =>
                {
                    b.HasOne("WoW.Data.Models.WayOfWork", "WayOfWork")
                        .WithMany("Videos")
                        .HasForeignKey("WayOfWorkId");
                });
#pragma warning restore 612, 618
        }
    }
}

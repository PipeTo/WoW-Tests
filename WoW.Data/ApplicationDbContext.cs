using Microsoft.EntityFrameworkCore;
using WoW.Data.Models;
using WoW.Data.Models.Relations;

namespace WoW.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relations Many To Many
            //modelBuilder.Entity<BookProgress>().HasKey(sc => new { sc.BookId, sc.ProgressId });
            modelBuilder.Entity<BookStatus>().HasKey(sc => new { sc.BookId, sc.StatusId });
            modelBuilder.Entity<FrameworkBook>().HasKey(sc => new { sc.FrameworkId, sc.BookId });
            modelBuilder.Entity<FrameworkLanguage>().HasKey(sc => new { sc.FrameworkId, sc.LanguageId });
            //modelBuilder.Entity<FrameworkProgress>().HasKey(sc => new { sc.FrameworkId, sc.ProgressId });
            modelBuilder.Entity<FrameworkRelatedTechnology>().HasKey(sc => new { sc.FrameworkId, sc.RelatedTechnologyId });
            modelBuilder.Entity<FrameworkUrl>().HasKey(sc => new { sc.FrameworkId, sc.UrlId });
            modelBuilder.Entity<FrameworkVideo>().HasKey(sc => new { sc.FrameworkId, sc.VideoId });
            modelBuilder.Entity<LanguagesBooks>().HasKey(sc => new { sc.LanguageId, sc.BookId });
            //modelBuilder.Entity<LanguageProgress>().HasKey(sc => new { sc.LanguageId, sc.ProgressId });
            modelBuilder.Entity<LanguageRelatedTechnology>().HasKey(sc => new { sc.LanguageId, sc.RelatedTechnologyId });
            modelBuilder.Entity<LanguageUrl>().HasKey(sc => new { sc.LanguageId, sc.UrlId });
            modelBuilder.Entity<LanguageVideo>().HasKey(sc => new { sc.LanguageId, sc.VideoId });
           // modelBuilder.Entity<ProgressStatus>().HasKey(sc => new { sc.ProgressId, sc.StatusId });
            modelBuilder.Entity<RelatedTechnologyBook>().HasKey(sc => new { sc.RelatedTechnologyId, sc.BookId });
            //modelBuilder.Entity<RelatedTechnologyProgress>().HasKey(sc => new { sc.RelatedTechnologyId, sc.ProgressId });
            modelBuilder.Entity<RelatedTechnologyUrl>().HasKey(sc => new { sc.RelatedTechnologyId, sc.UrlId });
            modelBuilder.Entity<RelatedTechnologyVideo>().HasKey(sc => new { sc.RelatedTechnologyId, sc.VideoId });
            //modelBuilder.Entity<VideoProgress>().HasKey(sc => new { sc.VideoId, sc.ProgressId });
            modelBuilder.Entity<VideoStatus>().HasKey(sc => new { sc.VideoId, sc.StatusId });
            modelBuilder.Entity<VideoUrl>().HasKey(sc => new { sc.VideoId, sc.UrlId });
            modelBuilder.Entity<WayOfWorkFramework>().HasKey(sc => new { sc.WayOfWorkId, sc.FrameworkId });
            modelBuilder.Entity<WayOfWorkLanguage>().HasKey(sc => new { sc.WayOfWorkId, sc.LanguageId });
            //modelBuilder.Entity<WayOfWorkProgress>().HasKey(sc => new { sc.WayOfWorkId, sc.ProgressId });

            //Relations One To Many
            //modelBuilder.Entity<Progress>().HasOne(p => p.WayOfWork).WithMany(b => b.Progresses).IsRequired();

            //modelBuilder.Entity<WayOfWork>().HasMany(p => p.Books).WithOne(b => b.WayOfWork).OnDelete(DeleteBehavior.Cascade); ;
            //modelBuilder.Entity<WayOfWork>().HasMany(p => p.Videos).WithOne(b => b.WayOfWork).OnDelete(DeleteBehavior.Cascade); ;
            //modelBuilder.Entity<Video>().HasOne<WayOfWork>(s => s.WayOfWork).WithMany(g => g.Videos).HasForeignKey(s => s.CurrentWayOfWork).IsRequired().OnDelete(deleteBehavior:DeleteBehavior.Cascade);
            //modelBuilder.Entity<Book>().HasOne<WayOfWork>(s => s.WayOfWork).WithMany(g => g.Books).HasForeignKey(s => s.CurrentWayOfWork);
            //modelBuilder.Entity<Video>().HasOne<WayOfWork>(s => s.WayOfWork).WithMany(g => g.Videos).HasForeignKey(s => s.CurrentWayOfWork);









        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Framework> Frameworks { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<WayOfWork> WayOfWorks { get; set; }
        public DbSet<RelatedTechnology> RelatedTechnologies { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Url> Urls { get; set; }
        public DbSet<Video> Videos { get; set; }


        //relations nz dali ce treba ovie 
        //public DbSet<WayOfWorkFramework> WayOfWorkFrameworksRR { get; set; }

    }
}

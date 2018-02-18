using Law.Models;
using Law.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Law.DataAccess
{
    public class LawContext : IdentityDbContext<ApplicationUser>
    {
        public LawContext(DbContextOptions<LawContext> options) : base(options)
        {
           
        }

        public virtual DbSet<Affiliate> Affiliates { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticlePiece> ArticlePieces { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Contributor> Contributors { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<NameBase> NameBases { get; set; }  
        public virtual DbSet<PracticeArea> PracticeAreas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Affiliate>().ToTable("Affiliate");
            modelBuilder.Entity<Article>().ToTable("Article");
            modelBuilder.Entity<ArticlePiece>().ToTable("ArticlePiece");
            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<Contributor>().ToTable("Contributor");
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<PracticeArea>().ToTable("PracticeArea");
            modelBuilder.Entity<NameBase>().ToTable("NameBase");
        }

    }
}

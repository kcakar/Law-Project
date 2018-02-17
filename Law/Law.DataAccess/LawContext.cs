using Law.Models;
using Law.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Law.DataAccess
{
    public class LawContext : IdentityDbContext<ApplicationUser>
    {
        public LawContext(DbContextOptions<LawContext> options) : base(options)
        {
           
        }

        public DbSet<Affiliate> Affiliates { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticlePiece> ArticlePieces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Contributor> Contributors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<NameBase> NameBases { get; set; }  
        public DbSet<PracticeArea> PracticeAreas { get; set; }

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

        //public async Task<int> GetRowCountAsync<T>(DbSet<T> entries) where T : class
        //{
        //    return await entries.CountAsync();
        //}

        //public async Task<T> GetItemAsync<T>(DbSet<T> entries,string ID) where T : NameBase
        //{
        //    return await entries.SingleOrDefaultAsync(x=>x.ID==ID);
        //}
    }
}

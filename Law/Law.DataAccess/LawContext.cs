using Law.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Law.DataAccess
{
    public class LawContext : DbContext
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
        public DbSet<User> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Affiliate>().ToTable("Affiliate");
            modelBuilder.Entity<Article>().ToTable("Article");
            modelBuilder.Entity<ArticlePiece>().ToTable("ArticlePiece");
            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<Contributor>().ToTable("Contributor");
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<PracticeArea>().ToTable("PracticeArea");
            modelBuilder.Entity<NameBase>().ToTable("NameBase");
            modelBuilder.Entity<User>().ToTable("User");
        }

    }
}

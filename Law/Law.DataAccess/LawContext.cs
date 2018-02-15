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
        public DbSet<PracticeArea> PracticeAreas { get; set; }pa
        public DbSet<User> Users { get; set; }
        

    }
}

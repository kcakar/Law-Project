using Law.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Core
{
    public class CoreBase
    {
        private static DbContextOptions<LawContext> contextOptions = new DbContextOptionsBuilder<LawContext>()
        .UseSqlServer("Server=pltosman.cj8mtntenfpy.us-east-2.rds.amazonaws.com;DataBase=LawDb;User ID=admin;Password=Admin!7654")
        .Options;
        internal static readonly LawContext _context = new LawContext(contextOptions);
    }
}

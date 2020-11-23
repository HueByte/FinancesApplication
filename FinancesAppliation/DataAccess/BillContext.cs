using FinancesAppDLL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancesAppDLL.DataAccess
{
    public class BillContext : DbContext 
    {
        public DbSet<Bills> Bills { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Shops> Shops { get; set; }
        
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            //TODO-Change Data Source
            optionsBuilder.UseSqlite(@"DataSource=C:\Db\BillDb.db;");
        }
    }
}

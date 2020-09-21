using Microsoft.EntityFrameworkCore;
using ShauryaTechTest.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShauryaTechTest.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-45PRSB4; initial catalog=ShauryaTechTest; persist security info = true; integrated security = true;");
        }
    }
}

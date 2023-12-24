using hltv.Core.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hltv.Core.context
{
    public class hltvContext : DbContext
    {
        public hltvContext() 
        {
           // Database.EnsureCreated();
        }

        public DbSet<Statistics> Statistics => Set<Statistics>();
        public DbSet<Player> Player => Set<Player>();
        public DbSet<RoundStatistics> RoundStatistics => Set<RoundStatistics>();
        public DbSet<Team> Team => Set<Team>();
        public DbSet<Country> Country => Set<Country>();

    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connectionString = "Server=DESKTOP-9KSTUSR\\SQLEXPRESS;Database=db_hltv;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}

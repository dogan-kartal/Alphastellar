using Alphastellar.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Alphastellar.DataAccess
{
    public class AlphastellarDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DAKO; Database=AlphastellarDb;trusted_connection=true;");
        }

        public DbSet<Boat> Boats { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}

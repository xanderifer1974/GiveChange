using GiveChange.Domain.Entities;
using GiveChange.Infra.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace GiveChange.Infra.Data.Context
{
   public class GiveChangeContext: DbContext
    {
        public DbSet<Troco> Trocos { get; set; }

        public GiveChangeContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TrocoConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

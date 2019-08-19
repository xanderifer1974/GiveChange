using GiveChange.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GiveChange.Infra.Data.Context
{
   public class GiveChangeContext: DbContext
    {
        public DbSet<Troco> Trocos { get; set; }

        public GiveChangeContext(DbContextOptions options): base(options)
        {

        }
    }
}

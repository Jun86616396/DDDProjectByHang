using DDD.Domain.Models.OPWAY;

namespace Infra.EF.Contexts
{
    using System.Data.Entity;

    public partial class GwContext : DbContext
    {
        public GwContext()
            : base("name=GwContext")
        {
        }

        public virtual DbSet<OPWAYDATA> OPWAYDATAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OPWAYDATA>()
                .Property(e => e.EADAC)
                .IsFixedLength();
        }
    }
}

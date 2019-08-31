using DDD.Domain.Models;

namespace Infra.EF.Contexts
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ManageContext : DbContext
    {
        public ManageContext()
            : base("name=ManageContext")
        {
            Configuration.ValidateOnSaveEnabled = false;
        }

        public virtual DbSet<Assemble> Assembles { get; set; }
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<DayFinished> DayFinisheds { get; set; }
        public virtual DbSet<OrderBox> OrderBoxes { get; set; }
        public virtual DbSet<OrderPlacing> OrderPlacings { get; set; }
        public virtual DbSet<Right> Rights { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleRightRelation> RoleRightRelations { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRoleRelation> UserRoleRelations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderPlacing>()
                .Property(e => e.FinishedProductNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrderPlacing>()
                .Property(e => e.ProductTypeNo)
                .IsFixedLength();

            modelBuilder.Entity<OrderPlacing>()
                .Property(e => e.StorageFinishedFlag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrderPlacing>()
                .HasMany(e => e.Storages)
                .WithRequired(e => e.OrderPlacing)
                .WillCascadeOnDelete(false);
        }
    }
}

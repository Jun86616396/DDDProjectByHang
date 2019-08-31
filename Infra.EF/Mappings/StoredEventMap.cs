using System.Data.Entity.ModelConfiguration;
using DDD.Domain.Evens;

namespace Infra.EF.Mappings
{
    public class StoredEventMap : EntityTypeConfiguration<StoredEvent>
    {
        public  StoredEventMap()
        {
            this.Property(c => c.Timestamp)
                .HasColumnName("CreationDate");

            this.Property(c => c.MessageType)
                .HasColumnName("Action")
                .HasColumnType("varchar(100)");
        }
    }
}
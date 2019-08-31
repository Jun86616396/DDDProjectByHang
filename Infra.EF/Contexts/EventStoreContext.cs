using DDD.Domain.Evens;
using System.Data.Entity;
using System.IO;
using Infra.EF.Mappings;

namespace Infra.EF.Contexts
{
    /// <summary>
    /// 事件存储数据库上下文，继承 DbContext
    /// </summary>
    public class EventStoreContext : DbContext
    {
        // 事件存储模型
        public DbSet<StoredEvent> StoredEvent { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StoredEventMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
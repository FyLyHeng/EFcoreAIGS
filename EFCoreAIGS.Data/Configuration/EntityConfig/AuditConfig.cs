using EFCoreAIGS.Data.Entities.command;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAIGS.Data.Configuration.EntityConfig
{
    public abstract class AuditConfig : DbContext
    {
        
        protected AuditConfig (DbContextOptions<AIGSContext> options) : base(options){}
        protected AuditConfig() {}

        //Config Audit Database Add & Update
        public override int SaveChanges()
        {
            var entity = ChangeTracker.Entries().Where(q => q.State is EntityState.Added or EntityState.Modified);

            foreach (var entry in entity)
            {
                var audit = (BaseEntity)entry.Entity;
                audit.LastUpdateDate = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    audit.CreatedDate = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var entity = ChangeTracker.Entries().Where(q => q.State is EntityState.Added or EntityState.Modified);

            foreach (var entry in entity)
            {
                var audit = (BaseEntity)entry.Entity;
                audit.LastUpdateDate = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    audit.CreatedDate = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

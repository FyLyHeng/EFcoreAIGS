using EFCoreAIGS.Data.Entities.command;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAIGS.Data.Configuration.EntityConfig
{
    public abstract class AuditConfig : DbContext
    {
        
        protected AuditConfig (DbContextOptions<AIGSContext> options) : base(options){}
        protected AuditConfig() {}

        public override int SaveChanges()
        {
            var changeTracker = ChangeTracker.Entries().Where(q => q.State is EntityState.Added or EntityState.Modified or EntityState.Deleted);
            foreach (var entry in changeTracker)
            {
                if (entry.Entity is BaseEntity referenceEntity)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            referenceEntity.CreatedDate = DateTime.Now;
                            referenceEntity.CreateBy = "CurrentUserLogin";
                            break;

                        case EntityState.Modified:
                            referenceEntity.LastUpdateDate = DateTime.Now;
                            referenceEntity.LastUpdateBy = "CurrentUserLogin";
                            break;
                        case EntityState.Deleted:
                            entry.State = EntityState.Modified;
                            referenceEntity.Status = false;
                            
                            referenceEntity.LastUpdateDate = DateTime.Now;
                            referenceEntity.LastUpdateBy = "CurrentUserLogin";
                            break;
                    }
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

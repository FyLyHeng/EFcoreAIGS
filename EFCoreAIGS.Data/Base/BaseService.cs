using System.Linq.Expressions;
using EFCoreAIGS.Data.Entities.command;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAIGS.Data.Base
{
    public class BaseService<T>: IBaseService<T> where T : BaseEntity
    {
        private readonly AIGSContext _context;
        public readonly DbSet<T> repo;
        
        public BaseService()
        {
            _context = new AIGSContext();
            repo = _context.Set<T>();
        }

        /*
         * @Sample CRUD Operations
         */
        public virtual List<T> GetAll()
        {
            return repo.ToList();
        }
        
        public virtual T? Get(long id)
        {
            return repo.SingleOrDefault(s => s.Id == id);
        }
        
        public virtual T Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            var rs = this.repo.Add(entity);
            _context.SaveChanges();
            return rs.Entity;
        }
        
        public virtual T Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            var rs = repo.Update(entity);
            _context.SaveChanges();
            return rs.Entity;
        }
        
        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            this.repo.Remove(entity);
            _context.SaveChanges();
        }
        
        public virtual void SoftDelete(T entity)
        {
            if (entity is BaseEntity)
            {
                entity.Status = false;
            }
            this.repo.Update(entity);
            _context.SaveChanges();
        }


        /**
         * @Dynamic filter
         * @Dynamic return Type
         */
        public virtual List<T> listFilter (Expression<Func<T, bool>> selector)
        {
            return repo.ToList();
        }
    }
}

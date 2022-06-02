using EFCoreAIGS.Data.Entities.command;

namespace EFCoreAIGS.Data.Base
{
    public interface IBaseService<T> where T : BaseEntity
    {
        public List<T> GetAll();
    }
}

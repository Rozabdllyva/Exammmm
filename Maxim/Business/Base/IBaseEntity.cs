using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Base
{
    public interface IBaseEntity<TEntity>
    {
        Task<TEntity> Get(int? id);
        Task<List<TEntity>> GetAll();
        Task Update (TEntity entity);
        Task Delete (int id);
        Task Create(TEntity entity);

    }
}

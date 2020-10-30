using System.Linq;
using System.Threading.Tasks;

namespace ArticleApi.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        Task<TEntity> GetByIdAsync(int id);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(int id);
        int SaveChanges();
    }
}
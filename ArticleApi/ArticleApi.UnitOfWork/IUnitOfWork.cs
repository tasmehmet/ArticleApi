using ArticleApi.Entity;
using ArticleApi.Repository;

namespace ArticleApi.UnitOfWork
{
    public interface IUnitOfWork
    {
        #region RepositoriesInstance      
        IRepository<ArticleEntity> ArticleApiRepository { get; }
        #endregion
    }
}
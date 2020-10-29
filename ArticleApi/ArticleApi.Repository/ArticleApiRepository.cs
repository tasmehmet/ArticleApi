using ArticleApi.Data;

namespace ArticleApi.Repository
{
    public class ArticleApiRepository<TEntity> : BaseRepository<TEntity, ArticleApiContext> where TEntity : class, new()
    {
        public ArticleApiRepository(ArticleApiContext context) : base(context)
        {
        }
    }
}
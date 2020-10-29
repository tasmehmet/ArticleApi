using System.Collections.Generic;
using ArticleApi.Business.Abstract;
using ArticleApi.DataAccess.Abstract;
using ArticleApi.Dto.EntityDto;

namespace ArticleApi.Business.Concrete
{
    public class ArticleManager:IArticleService
    {
        private readonly IArticleDal _articleDal;
        
        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public IEnumerable<ArticleDto> GetAll()
        {
            return _articleDal.GetAll();
        }

        public ArticleDto GetById(int id)
        {
            return _articleDal.GetById(id);
        }

        public bool Insert(ArticleDto model)
        {
            return _articleDal.Insert(model);
        }

        public bool Update(ArticleDto model)
        {
            return _articleDal.Update(model);
        }

        public bool Delete(int id)
        {
            return _articleDal.Delete(id);
        }
    }
}
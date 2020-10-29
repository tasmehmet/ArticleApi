using System.Collections.Generic;
using ArticleApi.Dto.EntityDto;

namespace ArticleApi.DataAccess.Abstract
{
    public interface IArticleDal
    {
        IEnumerable<ArticleDto> GetAll();
        ArticleDto GetById(int id);
        bool Insert(ArticleDto model);
        bool Update(ArticleDto model);
        bool Delete(int id);
    }
}
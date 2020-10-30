using ArticleApi.DataAccess.Abstract;
using ArticleApi.Dto.EntityDto;
using ArticleApi.Entity;
using ArticleApi.UnitOfWork;
using System.Collections.Generic;

namespace ArticleApi.DataAccess.Concrete
{
    public class ArticleDal : IArticleDal
    {
        private readonly ArticleApiUow _uow;

        public ArticleDal()
        {
            _uow = new ArticleApiUow();
        }

        public IEnumerable<ArticleDto> GetAll()
        {
            List<ArticleDto> articles = new List<ArticleDto>();
            var dbResult = _uow.ArticleApiRepository.GetAll();
            foreach (var item in dbResult)
            {
                articles.Add(new ArticleDto()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Detail = item.Detail,
                    Permalink = item.Permalink,
                    File1 = item.File1,
                    File2 = item.File2,
                    CreateDate = item.CreateDate,
                    IsActive = item.IsActive,
                    IsDelete = item.IsDelete
                });
            }

            return articles;
        }

        public ArticleDto GetById(int id)
        {
            var dbResult = _uow.ArticleApiRepository.GetById(id);
            ArticleDto article = new ArticleDto()
            {
                Id = dbResult.Id,
                Title = dbResult.Title,
                Detail = dbResult.Detail,
                Permalink = dbResult.Permalink,
                File1 = dbResult.File1,
                File2 = dbResult.File2,
                CreateDate = dbResult.CreateDate,
                IsActive = dbResult.IsActive,
                IsDelete = dbResult.IsDelete
            };
            return article;
        }

        public bool Insert(ArticleDto model)
        {
            bool isOk = false;
            ArticleEntity article = new ArticleEntity()
            {
                Id = model.Id,
                Title = model.Title,
                Detail = model.Detail,
                Permalink = model.Permalink,
                File1 = model.File1,
                File2 = model.File2,
                CreateDate = model.CreateDate,
                IsActive = model.IsActive,
                IsDelete = model.IsDelete
            };
            _uow.ArticleApiRepository.Add(article);
            _uow.Save();
            isOk = true;
            return isOk;
        }

        public bool Update(ArticleDto model)
        {
            var isOk = false;
            var dbResult = _uow.ArticleApiRepository.GetById(model.Id);
            if (dbResult != null)
            {
                dbResult.Title = model.Title;
                dbResult.Detail = model.Detail;
                dbResult.Permalink = model.Permalink;
                dbResult.File1 = model.File1;
                dbResult.File2 = model.File2;
                dbResult.CreateDate = model.CreateDate;
                dbResult.IsActive = model.IsActive;
                dbResult.IsDelete = model.IsDelete;
                _uow.ArticleApiRepository.Update(dbResult);
                _uow.Save();
                isOk = true;
            }

            return isOk;
        }

        public bool Delete(int id)
        {
            var isOk = false;
            _uow.ArticleApiRepository.Remove(id);
            _uow.Save();
            isOk = true;
            return isOk;
        }
    }
}
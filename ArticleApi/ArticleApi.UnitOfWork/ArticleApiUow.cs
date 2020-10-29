﻿using ArticleApi.Data;
using ArticleApi.Entity;
using ArticleApi.Repository;

namespace ArticleApi.UnitOfWork
{
    public class ArticleApiUow: IUnitOfWork
    {
        public ArticleApiContext _context;

        public ArticleApiUow()
        {
            _context = new ArticleApiContext();
        }
        private IRepository<TEntity> GetRepositoryInstance<TEntity>(ArticleApiRepository<TEntity> repo) where TEntity : class, new()
        {
            if (repo == null)
                repo = new ArticleApiRepository<TEntity>(this._context);

            return repo;
        }
        private ArticleApiRepository<ArticleEntity> _articleApiRepository;
        
        public IRepository<ArticleEntity> ArticleApiRepository
        {
            get { return GetRepositoryInstance<ArticleEntity>(_articleApiRepository); }
        }
    }
}
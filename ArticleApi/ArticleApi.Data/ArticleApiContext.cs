﻿using ArticleApi.Entity;
using Microsoft.EntityFrameworkCore;

namespace ArticleApi.Data
{
    public class ArticleApiContext :DbContext
    {
        public ArticleApiContext()
        {
        }
        public ArticleApiContext(DbContextOptions<ArticleApiContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MakaleApiDb;Persist Security Info=True;Connect Timeout=300;"); ;
                optionsBuilder.EnableSensitiveDataLogging(true);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        #region DbSet
        public virtual DbSet<ArticleEntity> Article { get; set; }
        #endregion
    }
}
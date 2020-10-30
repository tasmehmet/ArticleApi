using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;
using ArticleApi.Business.Abstract;
using ArticleApi.Controllers;
using ArticleApi.Dto.EntityDto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Article.Test
{
    [TestClass]
    public class ArticleUnitTest
    {
        private readonly IArticleService _articleService;

        public ArticleUnitTest(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [TestMethod]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            var testProducts = _articleService.GetAll();
            var controller = new ArticleController(_articleService);

            var result = controller.GetAllArticles() as List<ArticleDto>;
            Assert.AreEqual(testProducts, result);
        }

        private List<ArticleDto> GetTestArticle()
        {
            var testArtile = new List<ArticleDto>();
            testArtile.Add(new ArticleDto
            {
                Title = "lorem ipsum",
                Detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                Permalink = "lorem-ipsum",
                File1 = "/upload/images/File1.jpeg",
                File2 = "/upload/images/File2.jpeg",
                CreateDate = DateTime.Now,
                IsActive = true,
                IsDelete = false,
            });
            testArtile.Add(new ArticleDto
            {
                Title = "lorem ipsum 2",
                Detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                Permalink = "lorem-ipsum-2",
                File1 = "/upload/images/File3.jpeg",
                File2 = "/upload/images/File4.jpeg",
                CreateDate = DateTime.Now,
                IsActive = true,
                IsDelete = false,
            });

            return testArtile;
        }
    }
}

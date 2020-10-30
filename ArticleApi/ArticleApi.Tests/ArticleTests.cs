using ArticleApi.Business.Abstract;
using ArticleApi.Controllers;
using ArticleApi.Dto.EntityDto;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ArticleApi.Tests
{
    public class ArticleTests
    {
        private readonly IArticleService _articleService;

        public ArticleTests(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [Fact]
        public void GetAllArticle_ShouldReturnAllArticle()
        {
            var testProducts = _articleService.GetAll();
            ArticleController controller = new ArticleController(_articleService);

            var result = controller.GetAllArticles() as List<ArticleDto>;
            Assert.Equal(testProducts, result);
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

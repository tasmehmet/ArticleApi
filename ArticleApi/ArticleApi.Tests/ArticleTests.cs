using ArticleApi.Business.Abstract;
using ArticleApi.Business.Concrete;
using ArticleApi.Controllers;
using ArticleApi.Dto.EntityDto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using Xunit;

namespace ArticleApi.Tests
{
    public class ArticleTests
    {
        private ArticleDto CreateArticleModel { get; set; }
        private ArticleDto UpdateArticleModel { get; set; }

        public ArticleTests()
        {
            CreateArticleModel = new ArticleDto()
            {
                Title = "lorem ipsum",
                Detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                Permalink = "lorem-ipsum",
                File1 = "/upload/images/File1.jpeg",
                File2 = "/upload/images/File2.jpeg",
                CreateDate = DateTime.Now,
                IsActive = true,
                IsDelete = false,
            };
            UpdateArticleModel = new ArticleDto()
            {
                Id = 9,
                Title = "lorem ipsum",
                Detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                Permalink = "lorem-ipsum",
                File1 = "/upload/images/File1.jpeg",
                File2 = "/upload/images/File2.jpeg",
                CreateDate = DateTime.Now,
                IsActive = true,
                IsDelete = false,
            };
        }
        [Fact]
        public async Task GetAllArticle_ShouldReturnAllArticle()
        {
            var client = new TestClientProvider().Client;
            var response = await client.GetAsync("/Article/GetAllArticle");
            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetArticleById_ShouldReturnArticleById()
        {
            var client = new TestClientProvider().Client;
            var response = await client.GetAsync("/Article/GetArticleById?id=9");
            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task CreateArticle_ShouldCreateArticle()
        {
            var client = new TestClientProvider().Client;
            var response = await client.PostAsync("/Article/CreateArticle", new StringContent(JsonConvert.SerializeObject(CreateArticleModel), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task UpdateArticle_ShouldUpdateArticle()
        {
            var client = new TestClientProvider().Client;
            var response = await client.PutAsync("/Article/UpdateArticle", new StringContent(JsonConvert.SerializeObject(UpdateArticleModel), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task DeleteArticle_ShouldDeleteArticle()
        {
            var client = new TestClientProvider().Client;
            var response = await client.DeleteAsync("/Article/DeleteArticle?id=5");
            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

    }
}

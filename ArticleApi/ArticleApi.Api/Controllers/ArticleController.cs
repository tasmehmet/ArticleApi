using ArticleApi.Business.Abstract;
using ArticleApi.Dto.EntityDto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ArticleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet("GetAllArticle")]
        public IEnumerable<ArticleDto> GetAllArticles()
        {
            var result = _articleService.GetAll();
           
            return result;
        }

        [HttpGet("GetArticleById")]
        public ArticleDto GetArticleById(int id)
        {
            var result = _articleService.GetById(id);

            return result;
        }

        [HttpPost("CreateArticle")]
        public IActionResult CreateArticle(ArticleDto model)
        {
            var result = _articleService.Insert(model);
            if (result)
                return Ok();

            return BadRequest();
        }

        [HttpPut("UpdateArticle")]
        public IActionResult UpdateArticle(ArticleDto model)
        {
            var result = _articleService.Update(model);
            if (result)
                return Ok();

            return BadRequest();
        }

        [HttpDelete("DeleteArticle")]
        public IActionResult DeleteArticle(int id)
        {
            var result = _articleService.Delete(id);
            if (result)
                return Ok();

            return BadRequest();
        }
    }
}
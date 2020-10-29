using Microsoft.AspNetCore.Mvc;

namespace ArticleApi.Controllers
{
    public class ArticleController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
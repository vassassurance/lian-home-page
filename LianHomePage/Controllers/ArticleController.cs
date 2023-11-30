using Microsoft.AspNetCore.Mvc;

namespace LianHomePage.Controllers
{
    [Route("bao-chi-noi-ve-lian")]
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace LianHomePage.Controllers
{
    [Route("ve-lian")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

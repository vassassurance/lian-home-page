using Microsoft.AspNetCore.Mvc;

namespace LianHomePage.Controllers
{
    [Route("lien-he")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

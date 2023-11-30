using Microsoft.AspNetCore.Mvc;

namespace LianHomePage.Controllers
{
    [Route("dieu-khoan-su-dung")]
    public class AgreementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

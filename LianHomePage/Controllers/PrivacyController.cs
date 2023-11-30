using Microsoft.AspNetCore.Mvc;

namespace LianHomePage.Controllers
{
    [Route("bao-mat-va-quyen-rieng-tu")]
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

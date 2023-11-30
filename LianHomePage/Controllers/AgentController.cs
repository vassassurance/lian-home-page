using Microsoft.AspNetCore.Mvc;

namespace LianHomePage.Controllers
{
    [Route("dai-ly")]
    public class AgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

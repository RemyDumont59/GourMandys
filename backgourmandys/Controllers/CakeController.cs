using Microsoft.AspNetCore.Mvc;

namespace backgourmandys.Controllers
{
    public class CakeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

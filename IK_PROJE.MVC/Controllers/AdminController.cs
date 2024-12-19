using Microsoft.AspNetCore.Mvc;

namespace İKProjesi.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

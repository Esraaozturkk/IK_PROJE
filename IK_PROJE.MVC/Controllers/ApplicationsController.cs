using Microsoft.AspNetCore.Mvc;

namespace İKProjesi.Controllers
{
    public class ApplicationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

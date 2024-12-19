using Microsoft.AspNetCore.Mvc;
using IK_PROJE.DataAccess;
using IK_PROJE.Entity.Entities.Concrete;

namespace IKIsAlimSistemi.Controllers
{
    public class JobsController : Controller
    {
        private readonly SqlDbContext _context;

        public JobsController(SqlDbContext context)
        {
            _context = context;
        }

        public IActionResult List()
        {
            var jobs = _context.JobPosts.ToList();
            return View(jobs);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(JobPost jobPost)
        {
            if (ModelState.IsValid)
            {
                _context.JobPosts.Add(jobPost);
                _context.SaveChanges();
                return RedirectToAction(nameof(List));
            }
            return View(jobPost);
        }

        public IActionResult Details(int id)
        {
            var job = _context.JobPosts.FirstOrDefault(j => j.Id == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }
    }
}
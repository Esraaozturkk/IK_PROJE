using Microsoft.AspNetCore.Mvc;
using IK_PROJE.DataAccess;
using IK_PROJE.Entity.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using IK_PROJE.MVC.Models.VMs;
using AspNetCoreHero.ToastNotification.Notyf;
using AspNetCoreHero.ToastNotification.Abstractions;
using IK_PROJE.Business.Managers.Abstract;
using IK_PROJE.Business.Managers.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IKIsAlimSistemi.Controllers
{
    public class JobsController : Controller
    {
        private readonly SqlDbContext _context;
        private readonly INotyfService notyfService;
        private readonly IManager<JobPost> jobManager;
        private readonly JobPostManager jobPostManager;
        private readonly IManager<Company> companyManager;
        public JobsController(SqlDbContext context)
        {
            jobPostManager = new JobPostManager();

            _context = context;
        }

        public IActionResult List()
        {
            var jobs = _context.JobPosts.ToList();
            return View(jobs);

        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            JobPostVM jobPostVM = new JobPostVM();
            return View(jobPostVM);
        }

        [HttpPost]
        [Authorize]

        public async Task< IActionResult> Create(JobPostVM jobPostVM)
        {
            var company = await jobPostManager.GetJobPostAsync();
            ViewBag.Company = company.Select(t => new SelectListItem
            {
                Text = t.Company,
                Value = t.Id.ToString()
            }).ToList();

            if (!ModelState.IsValid)
            {
                notyfService.Error("Düzeltilmesi gereken yerler var");
                return View(jobPostVM);
            }
            JobPost jobPost = new JobPost();
            jobPost.Title = jobPostVM.Title;
            jobPost.Description = jobPostVM.Description;
            jobPost.Requirements = jobPostVM.Requirements;
            jobPost.Salary = jobPostVM.Salary;

            jobManager.Create(jobPost);
            notyfService.Success("İşlem Başarılı");
            return View(jobPostVM);
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
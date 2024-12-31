using IK_PROJE.Business.Managers.Abstract;
using IK_PROJE.DataAccess.Repositories.Abstract;
using IK_PROJE.Entity.Entities.Concrete;
using IK_PROJE.MVC.Extensions;
using IK_PROJE.MVC.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace IK_PROJE.UI.Controllers
{
    public class ResumeController : Controller
    {
        private readonly IManager<Resume> _resumeRepository;
        private readonly IManager<Skills> _skillsRepository;
        private readonly IManager<Certificate> _certificateRepository;
        private readonly IManager<School> _schoolRepository;
        private readonly IManager<Project> _projectRepository;
        private readonly IManager<Reference> _referenceRepository;
        private readonly IManager<MyUser> _myUserRepository;
        public ResumeController(
             IManager<Resume> resumeRepository,
             IManager<Skills> skillsRepository,
             IManager<Certificate> certificateRepository,
             IManager<School> schoolRepository,
             IManager<Project> projectRepository,
             IManager<Reference> referenceRepository,
             IManager<MyUser> myUserRepository
            )

        {
            _myUserRepository = myUserRepository;
            _resumeRepository = resumeRepository;
            _skillsRepository = skillsRepository;
            _certificateRepository = certificateRepository;
            _schoolRepository = schoolRepository;
            _projectRepository = projectRepository;
            _referenceRepository = referenceRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CVCreateViewModel());
        }

        [HttpPost]
        public IActionResult Create(CVCreateViewModel model)
        {
            int userId = User.Identity.GetId();
            var resume = _resumeRepository.GetAll(p => p.UserId == userId).FirstOrDefault();
            if (!ModelState.IsValid)
            {
                return View(model);
            }
                // Yeni bir CV oluştur
                 resume = new Resume
                {
                    //Name = model.Name,
                    //SurName = model.SurName,
                   
                    skills = model.Skills.Select(s => new Skills { Adi = s }).ToList(),
                    certificates = model.Certificates.Select(c => new Certificate
                    {
                        Adi = c.Name,
                        Kurum = c.Institution,
                        AlındığıTarih = c.Date
                    }).ToList(),
                    schools = model.Schools.Select(s => new School
                    {
                        OkulAdı = s.SchoolName,
                        BolumAdı = s.Department,
                        MezuniyetTürü = s.GraduationType
                    }).ToList(),
                    projects = model.Projects.Select(p => new Project
                    {
                        Name = p.Name,
                        Açıklama = p.Description
                    }).ToList(),
                    references = model.References.Select(r => new Reference
                    {
                        ReferansAdi = r.Name,
                        KurumAdi = r.Company
                    }).ToList()
                };

                // CV'yi kaydet
                _resumeRepository.Create(resume);

                return RedirectToAction("Index", "Home");



           
        }
    }
}

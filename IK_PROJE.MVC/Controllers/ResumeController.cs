using IK_PROJE.DataAccess.Repositories.Abstract;
using IK_PROJE.Entity.Entities.Concrete;
using IK_PROJE.MVC.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace IK_PROJE.UI.Controllers
{
    public class ResumeController : Controller
    {
        private readonly IRepository<Resume> _resumeRepository;
        private readonly IRepository<Skills> _skillsRepository;
        private readonly IRepository<Certificate> _certificateRepository;
        private readonly IRepository<School> _schoolRepository;
        private readonly IRepository<Project> _projectRepository;
        private readonly IRepository<Reference> _referenceRepository;

        public ResumeController(
            IRepository<Resume> resumeRepository,
            IRepository<Skills> skillsRepository,
            IRepository<Certificate> certificateRepository,
            IRepository<School> schoolRepository,
            IRepository<Project> projectRepository,
            IRepository<Reference> referenceRepository)
        {
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
            if (ModelState.IsValid)
            {
                // Yeni bir CV oluştur
                var resume = new Resume
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

                return RedirectToAction("Index", "Resume");
            }

            return View(model);
        }
    }
}

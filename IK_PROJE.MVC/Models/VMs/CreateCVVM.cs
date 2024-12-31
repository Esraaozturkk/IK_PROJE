using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using IK_PROJE.Entity.Entities.Concrete;
namespace IK_PROJE.MVC.Models.VMs
{
    public class CreateCVVM
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }

        // 1 den fazla seçim yapılabilecek alanlar
        public List<int> OkulAdı { get; set; }
        public List<int> SkillsAdi { get; set; }
        public List<int>Project { get; set; }
        public List<int> certificates { get; set; }
        public List<int> ReferansAdi { get; set; }

        // Dropdown listler
        public List<School> Schools { get; set; }
        public List<Skills> Skills { get; set; }
        public List<Project> Projects { get; set; }
        public List<Certificate> Certificates { get; set; }
        public List<Reference> References { get; set; }
    }
}




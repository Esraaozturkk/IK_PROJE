using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public int RoleId { get; set; } // Çalışan, Başvuran ve Admin
        public Role roles { get; set; }
        public ICollection<Resume> resumes { get; set; }
    }

}

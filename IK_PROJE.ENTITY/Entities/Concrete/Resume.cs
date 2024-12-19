using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.Entities.Concrete
{
    public class Resume: BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Skills> skills { get; set; }
        public ICollection<Certificate> certificates { get; set; }
        public ICollection<School> schools { get; set; }
        public ICollection<Project> projects { get; set; }
        public ICollection<Reference> references { get; set; }



    }
}

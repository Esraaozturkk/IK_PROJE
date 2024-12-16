using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.Entities.Concrete
{
    public class JobPost : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Requirements { get; set; }

        public decimal Salary { get; set; }

        public DateTime CreatedDate { get; set; }

        public int EmployerId { get; set; } // İş ilanı post eden
    }
}

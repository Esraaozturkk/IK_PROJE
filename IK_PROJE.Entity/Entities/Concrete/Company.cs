using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.Entities.Concrete
{
    public class Company:BaseEntity
    {
        public string CompanyName { get; set; }
        public ICollection<JobPost> JobPosts { get; set; }
    }
}

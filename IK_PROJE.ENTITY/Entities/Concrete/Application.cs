using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.Entities.Concrete
{
    public class Application : BaseEntity
    {
        public int JobPostId { get; set; }
        public JobPost JobPost { get; set; }
        public int  ResumeId { get; set; }
        public  Resume Resume{ get; set; }
    }
}

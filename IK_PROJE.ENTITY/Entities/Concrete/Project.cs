using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.Entities.Concrete
{
    public class Project: BaseEntity

    {
        public int KullanıcıId { get; set; }
        public string Name { get; set; }
        public string Açıklama { get; set; }


    }
}

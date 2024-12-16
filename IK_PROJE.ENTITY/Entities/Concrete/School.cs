using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.Entities.Concrete
{
    public class School:BaseEntity

    {
        public int KullanıcıId { get; set; }
        public string OkulAdı { get; set; }
        public string BolumAdı { get; set; }
        public string MezuniyetTürü { get; set; }
    }
}

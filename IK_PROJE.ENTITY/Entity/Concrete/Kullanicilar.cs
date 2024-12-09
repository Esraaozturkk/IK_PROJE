using IK_PROJE.ENTITY.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.ENTITY.Entity.Concrete
{
    public class Kullanicilar : BaseEntity
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Sifre { get; set; }
    }
}

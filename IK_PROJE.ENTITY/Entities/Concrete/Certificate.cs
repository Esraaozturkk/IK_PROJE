using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.Entities.Concrete
{
    public class Certificate : BaseEntity
    {
        public int KullanıcıId { get; set; }
        public string Adi { get; set; }
        public string  Kurum { get; set; }
        public DateOnly AlındığıTarih { get; set; }

    }

}

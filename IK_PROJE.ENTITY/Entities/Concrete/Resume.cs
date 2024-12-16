using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.Entities.Concrete
{
    public class Resume: BaseEntity
    {
        public int KullancıId { get; set; }
        public string YetenekId { get; set; }
        public string SertifikaId { get; set; }
        public string OkulId { get; set; }
        public int ProjeId { get; set; }
        public string ReferansId { get; set; }



    }
}

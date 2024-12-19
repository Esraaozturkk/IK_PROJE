﻿using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.Entities.Concrete
{
    public class Certificate : BaseEntity
    {
       
        public string Adi { get; set; }
        public string  Kurum { get; set; }
        public DateOnly AlındığıTarih { get; set; }
        public ICollection<Resume> resumes { get; set; }

    }

}

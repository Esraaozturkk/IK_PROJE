﻿using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.Entities.Concrete
{
    public class Reference: BaseEntity
    {
  
        public string ReferansAdi {  get; set; }
        public string KurumAdi { get; set; }
        public ICollection<Resume> resumes { get; set; }
    }
}

using IK_PROJE.Entity.Entities.Concrete;
using IK_PROJE.Entity.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.EntityConfig.Concrete
{
    public class ResumeConfig : BaseConfig<Resume>
    {
        public override void Configure(EntityTypeBuilder<Resume> builder)
        {

            base.Configure(builder);
            builder.HasOne(p=>p.User).WithMany(p=>p.resumes).HasForeignKey(p=>p.UserId);
        }

    }
}


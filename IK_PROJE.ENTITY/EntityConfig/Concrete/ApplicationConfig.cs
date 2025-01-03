﻿using IK_PROJE.Entity.Entities.Concrete;
using IK_PROJE.Entity.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.EntityConfig.Concrete
{
    public class ApplicationConfig : BaseConfig<Application>
    {
        public override void Configure(EntityTypeBuilder<Application> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.JobPost).WithMany(p => p.Applications).HasForeignKey(p => p.JobPostId);
            builder.HasOne(p => p.Resume).WithMany(p => p.Applications).HasForeignKey(p => p.ResumeId);

        }
    }
}

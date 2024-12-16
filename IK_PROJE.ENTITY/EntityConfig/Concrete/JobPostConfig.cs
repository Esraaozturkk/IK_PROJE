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
    public class JobPostConfig : BaseConfig<JobPost>
    {
        public override void Configure(EntityTypeBuilder<JobPost> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Title).HasMaxLength(50);

            builder.Property(p => p.Description).HasMaxLength(50);

            builder.Property(p => p.Requirements).HasMaxLength(50);
            builder.Property(p => p.Salary).HasMaxLength(50);
            builder.Property(p => p.CreatedDate).HasMaxLength(50);
            builder.Property(p => p.EmployerId).HasMaxLength(50);

        }


    }
}
  
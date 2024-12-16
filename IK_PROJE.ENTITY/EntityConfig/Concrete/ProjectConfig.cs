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
    public class ProjectConfig : BaseConfig<Project>
    {
        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Açıklama)
                .HasMaxLength(200);
            builder.Property(p => p.Name)
                .HasMaxLength(80);
        }
    }
}
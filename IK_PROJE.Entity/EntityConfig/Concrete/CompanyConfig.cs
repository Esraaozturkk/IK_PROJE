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
    public class CompanyConfig : BaseConfig<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.CompanyName).HasMaxLength(50);
            builder.Property(p => p.CompanyName).IsRequired();
            builder.HasIndex(p => p.CompanyName).IsUnique();
        }
    }
}

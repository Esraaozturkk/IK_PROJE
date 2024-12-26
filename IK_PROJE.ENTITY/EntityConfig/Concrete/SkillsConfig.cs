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
    public class SkillsConfig : BaseConfig<Skills>
    {
        public override void Configure(EntityTypeBuilder<Skills> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Adi)
                .HasMaxLength(80);
            builder.HasData(new Skills()
            {
                Id = 1,

                Adi= "CRM SDK"

            });
            builder.HasData(new Skills()
            {
                Id = 2,

                Adi = "C#"

            });
            builder.HasData(new Skills()
            {
                Id = 3,

                Adi = "ASP.NET"

            });
            builder.HasData(new Skills()
            {
                Id = 4,

                Adi = "SQL Database"

            });

        }
    }
}
using IK_PROJE.Entity.Entities.Abstract;
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
    public class CertificateConfig : BaseConfig<Certificate>
    {
        public override void Configure(EntityTypeBuilder<Certificate> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Kurum).HasMaxLength(50);

            base.Configure(builder);
            builder.Property(p => p.Adi).HasMaxLength(50);


            builder.Property(p => p.Adi).IsRequired();

            builder.Property(p => p.KullanıcıId).HasMaxLength(50);
        }
    }
}
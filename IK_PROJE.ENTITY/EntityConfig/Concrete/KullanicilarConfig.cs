using IK_PROJE.ENTITY.Entity.Concrete;
using IK_PROJE.ENTITY.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.ENTITY.EntityConfig.Concrete
{
    public class KullanicilarConfig : BaseConfig<Kullanicilar>
    {
        public override void Configure(EntityTypeBuilder<Kullanicilar> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Adi).HasMaxLength(20);
            builder.Property(p => p.Adi).IsRequired();

            builder.Property(p=>p.Soyadi).HasMaxLength(20);
            builder.Property(p => p.Soyadi).IsRequired();

            builder.Property(p=>p.Email).HasMaxLength(20);
            builder.Property(p => p.Email).IsRequired();
            
            builder.Property(p=>p.Tel).IsRequired();
            builder.Property(p => p.Tel).HasMaxLength(11);
            builder.Property(p => p.Tel).IsUnique();

            builder.Property(p => p.Sifre).IsRequired();
            builder.Property(p => p.Sifre).HasMaxLength(16);

        }
    }
}

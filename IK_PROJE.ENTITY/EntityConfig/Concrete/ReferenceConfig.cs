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
    public class ReferenceConfig : BaseConfig<Reference>
    {
        public override void Configure(EntityTypeBuilder<Reference> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.ReferansAdi)
                .HasMaxLength(80);
            builder.Property(p => p.KurumAdi)
               .HasMaxLength(80);
            builder.HasData(new Reference()
            {
                Id =1,
                ReferansAdi= "Adnan Ercan Öztürk",
                KurumAdi="Bahçeşehir Üniversitesi Wissen Akademie"
                

            });
        }
    }
}
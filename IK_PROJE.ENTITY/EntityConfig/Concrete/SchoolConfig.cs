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
    public class SchoolConfig : BaseConfig<School>
    {
        public override void Configure(EntityTypeBuilder<School> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.OkulAdı)
                .HasMaxLength(100);
             builder.Property(p => p.BolumAdı)
                .HasMaxLength(100);
            builder.Property(p => p.MezuniyetTürü)
               .HasMaxLength(100);
            builder.HasData(new School()
            {
                Id=1,
               OkulAdı="Uludağ Üniversitesi",
               BolumAdı="Bilgisayar Mühendisliği",
               MezuniyetTürü="Lisans "
               
            });
        }
    } }

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
            builder.Property(p => p.CompanyName).HasMaxLength(200);
            builder.Property(p => p.CompanyName).IsRequired();
            builder.HasIndex(p => p.CompanyName).IsUnique();

            builder.HasData(new Company()
            {
                Id = 1,
                CompanyName = "İş Bankası"
            });
            builder.HasData(new Company()
            {
                Id = 2,
                CompanyName = "TEV"
            });
            builder.HasData(new Company()
            {
                Id = 3,
                CompanyName = "Yapıkredi"
            });
            builder.HasData(new Company()
            {
                Id = 4,
                CompanyName = "ZiraatBankası"
            });
            builder.HasData(new Company()
            {
                Id = 5,
                CompanyName = "Akbank"
            });
            builder.HasData(new Company()
            {
                Id = 6,
                CompanyName = "Baykar"
            });
            builder.HasData(new Company()
            {
                Id = 7,
                CompanyName = "Vodafone"
            });
        }
    }
}
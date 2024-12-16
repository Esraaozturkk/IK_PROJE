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
    public class UserConfig : BaseConfig<User>

    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name)
                .HasMaxLength(30);
            builder.Property(p => p.Surname)
               .HasMaxLength(30);
            builder.Property(p => p.TelNo)
               .HasMaxLength(11);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Password).HasMaxLength(50);

            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p => p.TelNo).IsUnique();



        }
    }
}

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
    public class RoleConfig : BaseConfig<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.RoleName)
                .HasMaxLength(30);
            builder.HasData(new Role() { Id = 1, RoleName = "Yonetici" });
            builder.HasData(new Role() { Id = 2, RoleName = "Kullanici" });
        }
    }
}
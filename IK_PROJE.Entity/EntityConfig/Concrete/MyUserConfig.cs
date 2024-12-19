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
    public class MyUserConfig : BaseConfig<MyUser>

    {
        public override void Configure(EntityTypeBuilder<MyUser> builder)
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

            builder.HasOne(p => p.roles).WithMany(p => p.users).HasForeignKey(p => p.RoleId);
            builder.HasData(new MyUser() { Id = 1, Name = "Esra", Surname = "Öztürk", TelNo = "05031234266", Email = "esra@gmail.com", Password = "esra12", RoleId = 1 });
            builder.HasData(new MyUser() { Id = 2, Name = "emre", Surname = "andac", TelNo = "05431234266", Email = "emre@gmail.com", Password = "qweasd", RoleId = 2 });

        }
    }
} 

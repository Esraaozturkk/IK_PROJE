using IK_PROJE.Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Entity.EntityConfig.Abstract
{
    public abstract class BaseConfig<T> : IEntityTypeConfiguration<T>
        where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasIndex(p => p.Id); // Id ile sorgu hızlandırılması için Index atılır.
            builder.HasKey(p => p.Id);//Primary key birincil anahtar oluşturur.

        }
    }
}

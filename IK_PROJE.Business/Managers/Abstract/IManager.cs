using IK_PROJE.DataAccess.Repositories.Abstract;
using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Business.Managers.Abstract
{
    public interface IManager<T> : IRepository<T> where T : BaseEntity
    {
    }
}

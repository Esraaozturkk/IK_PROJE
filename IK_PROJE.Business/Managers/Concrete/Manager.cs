using IK_PROJE.Business.Managers.Abstract;
using IK_PROJE.DataAccess.Repositories.Concrete;
using IK_PROJE.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Business.Managers.Concrete
{
    public class Manager<T> : Repository<T>, IManager<T> where T : BaseEntity
    {
    }
}

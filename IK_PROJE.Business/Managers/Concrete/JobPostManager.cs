using IK_PROJE.Business.Managers.Abstract;
using IK_PROJE.DataAccess.Repositories.Concrete;
using IK_PROJE.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_PROJE.Business.Managers.Concrete
{
  public  class JobPostManager
    {
        private readonly Repository<JobPost> jobPostRepository;
        private readonly IManager<Company> companyManager;
        public JobPostManager()
        {
            jobPostRepository = new Repository<JobPost>();
        }
        public async Task<List<JobPost>> GetJobPostAsync()
        {
            return await Task.Run(() => jobPostRepository.GetAll());
        }
    }
}

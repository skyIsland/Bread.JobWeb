using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bread.Models;

namespace Bread.JobWeb.Project.Task
{
    public interface IJobSpider
    {
        List<JobCategory> GetJobCategories();

        List<JobInfo> GetJobList();
    }

    public class JobSpider: IJobSpider
    {
        public List<JobCategory> GetJobCategories()
        {
            var result = new List<JobCategory>();

            return result;
        }

        public List<JobInfo> GetJobList()
        {
            var result = new List<JobInfo>();

            return result;
        }
    }
}

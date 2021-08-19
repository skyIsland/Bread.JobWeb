using Bread.Models;
using Microsoft.AspNetCore.Mvc;
using NewLife.Cube;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Bread.Areas.Job.Controllers
{
    [JobArea]
    [DisplayName("岗位分类")]
    public class JobCategoryManagerController : EntityController<JobCategory>
    {
    }
}

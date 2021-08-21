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
    [DisplayName("岗位")]
    public class JobManagerController : EntityController<JobInfo>
    {
        static JobManagerController()
        {
            AddFormFields.RemoveCreateField();
            EditFormFields.RemoveCreateField();
            EditFormFields.RemoveUpdateField();
        }
    }
}

using System;
using System.ComponentModel;
using NewLife;
using NewLife.Cube;

namespace Bread.Areas.Job
{
    [DisplayName("招聘系统")]
    public class JobArea : AreaBase
    {
        public JobArea() : base(nameof(JobArea).TrimEnd("Area")) { }

        static JobArea() => RegisterArea<JobArea>();
    }
}
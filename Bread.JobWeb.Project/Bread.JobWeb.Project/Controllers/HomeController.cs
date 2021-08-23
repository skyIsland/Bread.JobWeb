using Bread.JobWeb.Project.Task;
using Bread.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bread.JobWeb.Project.Controllers
{
    public class HomeController : Controller
    {
        private IJobSpider _jobSpider;

        public HomeController(IJobSpider jobSpider)
        {
            _jobSpider = jobSpider;
        }

        public IActionResult Index()
        {
            var categories = JobCategory.FindAll();

            ViewBag.Categories = categories;
            return View();
        }

        public IActionResult UpdateJobData()
        {
            _jobSpider.GetJobCategories();
            _jobSpider.GetJobList();

            return Ok();
        }
    }
}

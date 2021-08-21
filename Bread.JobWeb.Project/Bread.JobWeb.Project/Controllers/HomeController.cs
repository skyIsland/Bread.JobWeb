﻿using Bread.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bread.JobWeb.Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var categories = JobCategory.FindAll();

            ViewBag.Categories = categories;
            return View();
        }
    }
}

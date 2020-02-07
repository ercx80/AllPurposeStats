using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllPurposeStats.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllPurposeStats.Controllers
{
    public class MainController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            DashboardViewModel dashboardViewModel = new DashboardViewModel();
            return View(dashboardViewModel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllPurposeStats.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllPurposeStats.Controllers
{
    
    public class SearchController : Controller
    {
        private StatsDbContext context;
        public SearchController(StatsDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }
    }
}

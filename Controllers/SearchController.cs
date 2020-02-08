using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllPurposeStats.Data;
using AllPurposeStats.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AllPurposeStats.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllPurposeStats.Controllers
{
    
    public class SearchController : Controller
    {
        private UserDbContext userContext;
        public SearchController(UserDbContext dbContext)
        {
            userContext = dbContext;
        }
      
        // GET: /<controller>/
        public IActionResult Search()//this method renders the viewmodel of the search feature
        {
            SearchViewModel searchViewModel = new SearchViewModel();
            return View(searchViewModel);
            
        }
        public IActionResult AddToProfile(SearchViewModel searchViewModel)
        {
            if (ModelState.IsValid)
            {
                Player newPlayer = new Player
                {

                    Name = searchViewModel.Name,
                    Position = searchViewModel.Position
                    
                };
                userContext.Players.Add(newPlayer);
                userContext.SaveChanges();
                Statline newStat = new Statline
                {
                    Category = searchViewModel.Category,
                    WeekOf = searchViewModel.WeekOf
                };
                userContext.Stats.Add(newStat);
                userContext.SaveChanges();


                return Redirect("/Main/Dashboard");


            }
            return View(searchViewModel);
        }
       
    }
}

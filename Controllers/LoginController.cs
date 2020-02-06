using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllPurposeStats.Data;
using AllPurposeStats.Models;
using AllPurposeStats.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllPurposeStats.Controllers
{
    public class LoginController : Controller
    {
        private UserDbContext userContext;
        public LoginController(UserDbContext dbContext)//this constructor asks to receive a an instance of user dbcontext
        {
            userContext = dbContext;// the construuctor assigns my dbcontext to userContext
        }
        // GET: /<controller>/
        public IActionResult Login()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View(loginViewModel);
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                User activeUser = new User


                {

                    Email = loginViewModel.Email,
                    Password = loginViewModel.Password
                    
                    
                };
                
                    
               
                userContext.Users(activeUser);
                userContext.SaveChanges();
                return Redirect("/Main");
            }

            return View(loginViewModel);
        }
        public IActionResult Register()
        {
            RegisterViewModel registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    
                    Name = registerViewModel.Name,
                    LastName = registerViewModel.LastName,
                    Email = registerViewModel.Email,
                    Password = registerViewModel.Password
                };
                userContext.Users.Add(newUser);
                userContext.SaveChanges();

                return Redirect("/Main");


            }
            return View(registerViewModel);

        }
    }
}

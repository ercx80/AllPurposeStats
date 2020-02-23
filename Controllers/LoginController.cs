using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllPurposeStats.Data;
using AllPurposeStats.Models;
using AllPurposeStats.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;

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
        [AllowAnonymous]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                // User activeUser = new User();// the line below is the same as this using var





             var   activeUser = userContext.Users.Where(a => a.Email.Equals(loginViewModel.Email) && loginViewModel.Password.Equals(loginViewModel.Password));
           

            
            
                 if (activeUser!=null)
                {
                   
                    return Redirect("/Main");
                }
                if (activeUser!= loginViewModel)
                {

                    //var email_error = "Email is incorrect";
                    //var password_error = "Password is incorrect";
                    loginViewModel.Email = "Email is incorrect";
                    loginViewModel.Password = "Password is incorrect";
                }

                

                
               
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

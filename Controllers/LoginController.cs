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
using Microsoft.EntityFrameworkCore.Internal;

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

                //var  activeUser = userContext.Users.Where(a => a.Email.Equals(loginViewModel.Email) && loginViewModel.Password.Equals(loginViewModel.Password));
                var activeUserEmail = userContext.Users.Where(a => a.Email == loginViewModel.Email);//this variable queries the database for the email of user
                var activeUserPassword = userContext.Users.Where(a => a.Password == loginViewModel.Password);
               
                
               if (activeUserEmail.Any() && activeUserPassword.Any())//here the conditional checks whether the email or password exists
                {

                    
                    return Redirect("/Main");
                    

                    
                }
                else if (!activeUserEmail.Any())//here if email does not exist it shows an error
                {
                    loginViewModel.Email_error = "Email does not exists";
                    


                }
                 else if (!activeUserPassword.Any())
                  {



                    loginViewModel.Password_error = "Password is incorrect";


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

using CodeAcademy.DAL.Models;
using CodeAcademy.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CodeAcademy.PL.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _usermanager;
        private readonly SignInManager<ApplicationUser> _signinmanager;
        public AccountController(SignInManager<ApplicationUser> signinmanager ,UserManager<ApplicationUser> usermanager )
        {
            _signinmanager = signinmanager;
            _usermanager = usermanager;
        }

      
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if(ModelState.IsValid)
            {
                var User = new ApplicationUser()
                {
                    UserName = model.Email.Split('@')[0],
                    Fname=model.Fname,
                    Lname=model.Lname,
                    Email=model.Email,
                };
                var result = await _usermanager.CreateAsync(User , model.Password);
                if(result.Succeeded)
                {
                   return RedirectToAction("LogIn");
                }
                else
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, err.Description);
                    }
                }

            }
            return View(model);
        }

        public IActionResult LogIn()
        {
            return View();
        }

       
    }
}

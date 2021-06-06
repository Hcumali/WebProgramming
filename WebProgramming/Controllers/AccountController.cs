using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramming.Models;

namespace WebProgramming.Controllers
{
    public class AccountController : Controller
    {
        private  UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;
        private IConfiguration Configuration { get; }
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            Configuration = configuration;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult AccessDenied()
        {
            return Content("You are not admin");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                    if ((await _signInManager.PasswordSignInAsync(user,model.Password,false,false)).Succeeded)
                    {
                        return Redirect("/Admin");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid UserName Or Password");
            return View(model);
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel signUpModel)
        {
            if (ModelState.IsValid)
            {
                if (signUpModel.Password != signUpModel.ConfrimPassword)
                {
                    ModelState.AddModelError("", "ConfirmPassword Not Match Password");
                    return View(signUpModel);
                }
                IdentityUser user = new IdentityUser
                {
                    UserName = signUpModel.UserName,
                    NormalizedEmail = signUpModel.Email.ToLower(),
                    SecurityStamp = Configuration["Security:Secret"],
                    AccessFailedCount = 0,
                    NormalizedUserName = signUpModel.UserName.ToLower(),
                    Email = signUpModel.Email,
                    PhoneNumber = signUpModel.TelphoneNumber
                };
                var result = await _userManager.CreateAsync(user,signUpModel.Password);
                var resultRole  = await _userManager.AddToRoleAsync(user,"Admin");
                if (result.Errors.Count() > 0)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(signUpModel);
                }
                return RedirectToAction("Index", "Home");
            }
            return View(signUpModel);
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
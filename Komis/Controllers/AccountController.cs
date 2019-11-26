using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komis.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Komis.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager; //sprawdzanie czy uzytkownik moze sie logowac  
        private readonly UserManager<IdentityUser> _userManager; // pracowanie z uzytkownikami sprawdzanie roli tworzenie uzytkownikow

        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVm loginVM) //
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            var user = await _userManager.FindByNameAsync(loginVM.UserName);

            if (user != null)
            {
                var reuslt = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false); // proba logowanie
                if (reuslt.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Nazwa uzytkownnia lub haslo jest niewlasciwe");

            return View(loginVM);
        }
        public IActionResult Register()
        {
            return View(new LoginVm());
        }
        [HttpPost]
        public async Task<IActionResult> Register(LoginVm loginVM)
        {

            if (!ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = loginVM.UserName };
                var result = await _userManager.CreateAsync(user, loginVM.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(loginVM);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
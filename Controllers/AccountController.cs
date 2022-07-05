using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using MudTestApp.Models;
using MudTestApp.Models.TestViewModels;
using System.Linq;
using MudTestApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace MudTestApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager; 


        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync(); 
            return RedirectToAction("Index", "tests");
        }


        public SignInManager<IdentityUser> SignInManager { get; set; }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
    
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.UserName };
                var result = await userManager.CreateAsync(user, model.Password); 

                if (result.Succeeded)
                {
                    if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {
                        return RedirectToAction("ListUsers", "Administration");
                    }

                    await SignInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Tests");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }



       
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl)
        {
            if (ModelState.IsValid)
            {

                var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl)) 
                    {
                        return LocalRedirect(returnUrl); //check for valid returnUrl
                    }
                    else
                    {                    
                        return RedirectToAction("Index", "Tests");
                    }

                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt");

            }

            return View(model);
        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ChangePassword(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if(user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found.";
                return View("NotFound");
            }

            var model = new ChangePasswordViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
            };

            return View(model);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
                var user = await userManager.FindByIdAsync(model.Id);

                if (user == null)
                {
                    return RedirectToAction("Login");
                }
                
                var result = await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                    
                if (!result.Succeeded)
                {
                     foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
                //await signInManager.RefreshSignInAsync(user);
                return View("PasswordChangeConfirmation");

        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View("AccessDenied");
        }

    }
 
}

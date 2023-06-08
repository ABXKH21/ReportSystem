using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReportSystem.ViewModels;
using System.Threading.Tasks;

namespace ReportSystem.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signManager)
        {
            _userManager = userManager;
            _signInManager = signManager;
        }


        public IActionResult Index()
        {
            return View();
        }


       [HttpGet]
       [AllowAnonymous]
        public IActionResult Login()
        {
         
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
               var result = await _signInManager. PasswordSignInAsync(model.UserName, model.Password, 
                            isPersistent: true, 
                            lockoutOnFailure: false);
                if (result.Succeeded)
                {                    
                    HttpContext.Session.SetString("UserEmail", model.UserName.ToString());                 
                    return RedirectToAction("Index", "Report");
                }               
                else
                {
                    ModelState.AddModelError("", "There is something wrong with your username or password. Please try again. ");
                    return View(model);
                }
            }
        }



        [HttpPost]
        public async Task<ActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("UserName");          
            return RedirectToAction("Login", "Account");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }


    }
}


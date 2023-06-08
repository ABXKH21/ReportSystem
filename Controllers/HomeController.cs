using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReportSystem.Context;
using ReportSystem.Models;
using System.Diagnostics;
using System.Linq;

namespace ReportSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ReportSysContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ReportSysContext context ,
                ILogger<HomeController> logger)
        {
           _context = context;
            _logger = logger;   
        }

        //[Authentication]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /*

                // POST: LoginController/Create
                [HttpPost]
                [ValidateAntiForgeryToken]
                public ActionResult Authentication(UsersMe userModel)
                {
                    var userDetails = _context.Users.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
                    if (userDetails == null)
                    {
                        userModel.LoninErrorMessage = "Wrong Username or Password";
                        return View("Index", userModel);
                    }
                    else
                    {
                        HttpContext.Session.SetString("UserName", userDetails.UserName.ToString());
                        return RedirectToAction("Index", "Report");
                    }
                }



                // Get Action
                public IActionResult Login()
                {
                    return View();           
                }


                //Post Action
                [HttpPost]
                [ValidateAntiForgeryToken]
                public ActionResult Login(UsersMe userModel)
                {
                    var userDetails = _context.Users.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
                    if (userDetails == null)
                    {
                        userModel.LoninErrorMessage = "Wrong Username or Password";
                        return View("Index", userModel);
                    }
                    else
                    {
                        HttpContext.Session.SetString("UserName", userDetails.UserName.ToString());
                        return RedirectToAction("Index", "Report");
                    }


                    *//*if (HttpContext.Session.GetString("UserName") == null)
                    {
                        if (ModelState.IsValid)
                        {

                            var userDetails = _context.Users.Where(a => a.UserName.Equals(userModel.UserName) && a.Password.Equals(userModel.Password)).FirstOrDefault();
                            if (userDetails != null)
                            {
                                HttpContext.Session.SetString("UserName", userDetails.UserName.ToString());
                                //return RedirectToAction("Index", "Report");
                                return RedirectToAction("Index");
                            }
                            else
                            {
                                userModel.LoninErrorMessage = "Wrong Username or Password";
                                //return View("Login", userModel);
                                return RedirectToAction("Login");
                            }
                        }
                    }

                     return RedirectToAction("Login");
                         //return View("Index", userModel);*//*

                }


                public ActionResult Logout()
                {
                    HttpContext.Session.Clear();
                    HttpContext.Session.Remove("UserName");
                    return RedirectToAction("Login");
                }*/
    }
}

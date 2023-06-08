using Microsoft.AspNetCore.Mvc;

namespace ReportSystem.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BTBuoi4.Areas.Admin.Controllers
{ 
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

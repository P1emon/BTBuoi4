using BTBuoi4.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTBuoi4.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee emp)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Lỗi", "Dữ liệu không hợp lệ");
            }
            return View();
        }
    }
}

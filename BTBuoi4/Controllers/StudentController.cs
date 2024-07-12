using BTBuoi4.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTBuoi4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Enroll()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Enroll(Student model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Lỗi", "Dữ liệu không hợp lệ");
            }
            return View();
        }
    }
}

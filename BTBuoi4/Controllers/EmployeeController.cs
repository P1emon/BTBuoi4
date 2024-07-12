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
        public IActionResult checkExistedEmployee(string EmplyeeNo)
        {
            var dsNhanVien = new List<string>{"aaaaaa", "bbbbbb", "cccccc"};
            if (dsNhanVien.Contains(EmplyeeNo))
            {
                return Json($"{EmplyeeNo} đã có");
            }
            return Json(true);
        }   
    }
}

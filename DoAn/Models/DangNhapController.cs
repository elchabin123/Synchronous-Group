using Microsoft.AspNetCore.Mvc;

namespace DoAn.Models
{
    public class DangNhapController : Controller
    {
        public IActionResult DangNhap()
        {
            return View();
        }
    }
}

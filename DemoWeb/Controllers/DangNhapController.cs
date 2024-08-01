using Microsoft.AspNetCore.Mvc;

namespace DemoWeb.Controllers
{
    public class DangNhapController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}

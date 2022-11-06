using Microsoft.AspNetCore.Mvc;

namespace EunoiaDigi.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Login() => View();
        public IActionResult Register()=>View();   
        public IActionResult Error400()=>View();
        public IActionResult Error403()=>View();
        public IActionResult Error404()=>View();
        public IActionResult Error500()=>View();
        public IActionResult Error503()=>View();
        public IActionResult LockScreen()=>View();
        public IActionResult EmptyPage()=>View();
        public IActionResult ForgetPassword()=>View();
    }
}

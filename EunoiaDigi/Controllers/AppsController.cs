using Microsoft.AspNetCore.Mvc;

namespace EunoiaDigi.Controllers
{
    public class AppsController : Controller
    {
        public IActionResult Profile() => View();
        public IActionResult EditProfile()=>View();
        public IActionResult PostDetails()=>View();
        public IActionResult Compose()=>View();
        public IActionResult Inbox()=>View();
        public IActionResult Read()=>View();
        public IActionResult Calendar()=>View();
        public IActionResult ProductGrid()=>View();
        public IActionResult ProductList()=>View();
        public IActionResult ProductDetails()=>View();
        public IActionResult Order()=>View();
        public IActionResult Checkout()=>View();
        public IActionResult Invoice()=>View();
        public IActionResult Customers()=>View();
        
    }
}

using Microsoft.AspNetCore.Mvc;

namespace EunoiaDigi.Controllers
{
    public class WidgetsController : Controller
    {
        public IActionResult Chart() => View();
        public IActionResult Card()=>View();
        public IActionResult List()=>View();
        
    }
}

using Microsoft.AspNetCore.Mvc;

namespace EunoiaDigi.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Index_2()=>View();
        public IActionResult Banking()=>View();
        public IActionResult Ticketing()=>View();
        public IActionResult Crypto()=>View();
        public IActionResult Invoice()=>View();
        public IActionResult Contact()=>View();
        public IActionResult Kanban()=>View();
        
    }
}

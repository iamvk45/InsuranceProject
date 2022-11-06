using Microsoft.AspNetCore.Mvc;

namespace EunoiaDigi.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult Flot() => View();
        public IActionResult Morris()=>View();
        public IActionResult Chartjs()=>View();
        public IActionResult Chartist()=>View();
        public IActionResult Sparkline()=>View();
        public IActionResult Peity()=>View();
    }
}

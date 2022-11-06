using Microsoft.AspNetCore.Mvc;

namespace EunoiaDigi.Controllers
{
    public class PluginsController : Controller
    {
        public IActionResult Select2() => View();
        public IActionResult Nestedable()=>View();
        public IActionResult NouiSlider()=>View();
        public IActionResult SweetAlert()=>View();
        public IActionResult Toastr()=>View();
        public IActionResult JqvMap()=>View();
        public IActionResult LightGallery()=>View();
    }
}

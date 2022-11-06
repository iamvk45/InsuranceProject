using Microsoft.AspNetCore.Mvc;

namespace EunoiaDigi.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult FormElements() => View();
        public IActionResult Wizard()=>View();
        public IActionResult CkEditor()=>View();
        public IActionResult Pickers()=>View();
        public IActionResult FormValidate()=>View();
    }
}

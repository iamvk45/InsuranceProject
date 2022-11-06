using Microsoft.AspNetCore.Mvc;

namespace EunoiaDigi.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Bootstrap() => View();
        public IActionResult Datatable()=>View();
    }
}

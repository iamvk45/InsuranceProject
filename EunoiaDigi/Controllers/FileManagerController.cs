using Microsoft.AspNetCore.Mvc;

namespace EunoiaDigi.Controllers
{
    public class FileManagerController : Controller
    {
        public IActionResult FileManager() => View();
        public IActionResult Users()=>View();   
        public IActionResult Calendar()=>View();
        public IActionResult ToDoList()=>View();
        public IActionResult Chat()=>View();
        public IActionResult Activity()=>View();
    }
}

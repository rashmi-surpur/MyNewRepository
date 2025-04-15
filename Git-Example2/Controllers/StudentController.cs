using Microsoft.AspNetCore.Mvc;

namespace Git_Example2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Page1()
        {
            return View();
        }

        
        public IActionResult Page3()
        {
            return Content("This is page3");
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Git_Example2.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

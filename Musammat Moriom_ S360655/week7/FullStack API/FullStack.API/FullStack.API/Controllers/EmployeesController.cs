using Microsoft.AspNetCore.Mvc;

namespace FullStack.API.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

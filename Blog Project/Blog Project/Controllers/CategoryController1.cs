using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
    public class CategoryController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

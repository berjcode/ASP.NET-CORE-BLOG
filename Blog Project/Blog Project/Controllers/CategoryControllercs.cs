using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
    public class CategoryControllercs : Controller
    {
        //Bütün Metotlarıma erişim sağlıyorum.
        CategoryManager _cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = _cm.GetList();
            return View(values);
        }
    }
}

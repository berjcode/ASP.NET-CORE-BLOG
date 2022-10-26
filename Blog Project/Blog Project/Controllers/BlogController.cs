using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = _bm.GetBlogListWithCategory();
            return View(values);
        }

        public ActionResult BlogReadAll(int id)
        {
            var values = _bm.GetBlogByID(id);
            return View(values);
        }
    }
}

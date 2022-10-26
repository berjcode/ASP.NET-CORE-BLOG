using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.Controllers
{
	public class CommentController : Controller
	{

		CommentManager _Cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult PartialAddComment()
		{
			return PartialView();	
		}

		public PartialViewResult PartialCommentList(int id)
		{
			 var values = _Cm.GetList(id);
			return PartialView(values);
		}
	}
}

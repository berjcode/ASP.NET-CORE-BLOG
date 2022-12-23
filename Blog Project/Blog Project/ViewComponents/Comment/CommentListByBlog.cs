using Blog_Project.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Project.ViewComponents.Comment
{
	public class CommentListByBlog :ViewComponent
	{
		CommentManager _Cm = new CommentManager(new EfCommentRepository());
		public IViewComponentResult Invoke()
		{
			var values = _Cm.GetList(2);


			return View(values);
		}
	}
}

using Blog_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Blog_Project.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>()
			{
				new UserComment
				{
					ID=1,
					UserName="Murat"
				},

				new UserComment
				{
					ID=2,
					UserName="Abdullah"
				}
			};

			
			return View();	
		}
	}
}

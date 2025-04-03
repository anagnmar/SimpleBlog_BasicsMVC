using System;
using System.Collections.Generic;

using System.Web;
using System.Web.Mvc;


namespace SimpleBlog.Controllers
{
	public class PostsController : Controller
	{

		public ActionResult Index()
		{
			return Content("Hello, World!");
		}




	}
}
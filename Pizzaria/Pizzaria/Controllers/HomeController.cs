using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Pizzaria.Controllers
{
	public class HomeController : Controller
	{
		

		public IActionResult Index()
		{
			return View();
		}

		
	}
}

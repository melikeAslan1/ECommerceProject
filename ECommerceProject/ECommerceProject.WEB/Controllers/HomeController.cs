using ECommerceProject.Business.Abstract;
using ECommerceProject.Entity.Models;
using ECommerceProject.WEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECommerceProject.WEB.Controllers
{
	[AllowAnonymous]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		private readonly ICategoryService _categoryService;

		public HomeController(ILogger<HomeController> logger, ICategoryService categoryService)
		{
			_logger = logger;
			_categoryService = categoryService;
		}

		public async Task<IActionResult> Index()
		{
			

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}



	}
}
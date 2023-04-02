using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.WEB.Controllers
{
	public class CartController : Controller
	{
		[AllowAnonymous]
		public IActionResult Cart()
		{
			return View();
		}
	}
}

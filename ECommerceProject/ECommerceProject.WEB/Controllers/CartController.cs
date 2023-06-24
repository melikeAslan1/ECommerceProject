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

        [HttpGet]
        public async Task<IActionResult> Cart(int ProductId)
        {
            List<int> productIds = new List<int>();

            productIds.Add(ProductId);

            return View();
        }
    }
}

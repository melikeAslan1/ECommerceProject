using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.WEB.Controllers
{
	[AllowAnonymous]
	public class ProductListingController : Controller
    {

        public IActionResult ProductListing()
        {
            return View();
        }
    }
}

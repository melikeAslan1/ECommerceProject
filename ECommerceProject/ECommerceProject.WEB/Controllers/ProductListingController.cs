using ECommerceProject.Business.Abstract;
using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.DataAccess.Concrete;
using ECommerceProject.WEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.WEB.Controllers
{
	[AllowAnonymous]
	public class ProductListingController : Controller
	{
		//isim ve ucret.
		private readonly IProductService _productService;

		public ProductListingController(IProductRepo productService)
		{
			_productService = (IProductService?)productService;

		}


		[HttpGet]
		public IActionResult ProductListing()
		{
			var products = _productService.TGetList();
          
			return View(products);
		}



	}
}


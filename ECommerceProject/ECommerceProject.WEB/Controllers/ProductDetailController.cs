using ECommerceProject.Business.Abstract;
using ECommerceProject.WEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.WEB.Controllers
{
	[AllowAnonymous]
	public class ProductDetailController : Controller
    {
        private readonly IProductService _productService;

		public ProductDetailController(IProductService productService)
		{
			_productService= productService;
		}
        public async Task<IActionResult> ProductDetail(int ProductId)
        {
			var product = await _productService.TGetById(ProductId);

			ProductViewModel model =new ProductViewModel();
			model.ProductId = ProductId;
			model.Price = product.Price;
			model.Name= product.Name;
			model.Description= product.Description;

			return View(model);
        }
    }
}

using ECommerceProject.Business.Abstract;
using ECommerceProject.WEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.WEB.Controllers
{
	[AllowAnonymous]
	public class ProductController : Controller
    {
        private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService= productService;
		}

        [HttpGet]
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

        [HttpGet]
        public async Task<IActionResult> ProductListing()
        {
            var products = await _productService.TGetList();

            List<ProductViewModel> productList = new List<ProductViewModel>();

            foreach (var item in products)
            {
                ProductViewModel model = new ProductViewModel();
                model.ProductId = item.Id;
                model.Name = item.Name;
                model.Price = item.Price;

                productList.Add(model);

            }

            return View(productList);
        }
    }
}

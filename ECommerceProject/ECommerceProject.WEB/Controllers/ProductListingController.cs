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

        public ProductListingController(IProductService productService)
        {
            _productService =productService;

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


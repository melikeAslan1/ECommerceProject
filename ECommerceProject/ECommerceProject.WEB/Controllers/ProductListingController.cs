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

            List<ProductListingViewModel> productList = new List<ProductListingViewModel>();

            ProductListingViewModel model = new ProductListingViewModel();

            foreach (var item in products)
            {
                model.Name = item.Name;
                model.Price = item.Price;

                productList.Add(model);

            }

            return View(productList);
        }



    }
}


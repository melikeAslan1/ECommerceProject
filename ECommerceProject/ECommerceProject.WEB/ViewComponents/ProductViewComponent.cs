using ECommerceProject.DataAccess.Concrete;
using ECommerceProject.WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.WEB.ViewComponents
{
	public class ProductViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			ProductRepo repo= new ProductRepo();

			var products = await repo.GetList();

			List<ProductViewModel> productViewModels= new List<ProductViewModel>();

			foreach (var item in products)
			{
				ProductViewModel productViewModel = new ProductViewModel();
				productViewModel.ProductId = item.Id;
				productViewModel.Price = item.Price;
				productViewModel.Description = item.Description;
				productViewModel.Name = item.Name;
				productViewModel.Description=item.Description;
				productViewModel.ImageUrl = item.ImageUrl;
				productViewModel.Stock = item.Stock;

				productViewModels.Add(productViewModel);
			}
			return View(productViewModels);
		}


	}
}

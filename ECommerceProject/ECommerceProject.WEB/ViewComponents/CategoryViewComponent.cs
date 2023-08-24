using ECommerceProject.DataAccess.Concrete;
using ECommerceProject.WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.WEB.ViewComponents
{
    public class CategoryViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            CategoryRepo repo = new CategoryRepo();

            var categories=await repo.GetList();

            List<CategoryVM> categoriesVMs = new List<CategoryVM>();
           

            foreach (var category in categories)
            {
                CategoryVM cVM = new CategoryVM();
                cVM.CategoryDescription = category.CategoryDescription;
                cVM.CategoryId = category.Id;
                cVM.CategoryName = category.CategoryName;
                cVM.Products = category.Products;
                categoriesVMs.Add(cVM);
            }


            return View(categoriesVMs);
        }
    }
}

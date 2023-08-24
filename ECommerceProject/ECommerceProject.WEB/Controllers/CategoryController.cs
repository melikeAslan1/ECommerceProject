using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.WEB.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

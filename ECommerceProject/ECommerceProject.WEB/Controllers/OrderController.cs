using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.WEB.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using ECommerceProject.Entity.Models;

namespace ECommerceProject.WEB.Models
{
    public class CategoryVM
    {
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public List<Product> Products { get; set; }

        public int CategoryId { get; set; }
    }
}

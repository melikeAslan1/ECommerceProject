using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entity.Models
{
    public class Category : BaseEntity, IEntity
    {
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public List<Product> Products { get; set; }
    }
}

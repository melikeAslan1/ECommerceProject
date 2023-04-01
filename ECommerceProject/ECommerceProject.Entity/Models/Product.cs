using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entity.Models
{
	public class Product : BaseEntity, IEntity
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public int Stock { get; set; }
	}
}

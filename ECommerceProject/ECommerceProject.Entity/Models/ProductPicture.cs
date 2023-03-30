using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entity.Models
{
	public class ProductPicture : BaseEntity
	{
		public string Picture { get; set; }

		public int ProductId { get; set; }
	}
}

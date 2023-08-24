using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string ImageUrl { get; set; }

        public string ThambNailImageUrl { get; set; }

		public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
	}
}

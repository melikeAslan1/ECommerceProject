﻿namespace ECommerceProject.WEB.Models
{
	public class ProductViewModel
	{
		public string Name { get; set; }

		public decimal Price { get; set; }

		public int ProductId { get; set; }

		public string Description { get; set; }

		public string ImageUrl { get; set; }

		public int Stock { get; set; }

        public string CategoryName { get; set; }

    }
}

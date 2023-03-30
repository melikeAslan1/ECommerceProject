using ECommerceProject.Business.Abstract;
using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.Concrete
{
	public class ProductManager : IProductService
	{
		private IProductRepo _productRepo;

		public ProductManager(IProductRepo productRepo)
		{
			_productRepo = productRepo;
		}

		public void TAdd(Product entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Product entity)
		{
			throw new NotImplementedException();
		}

		public Product TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Product>> TGetList()
		{
			var products = await _productRepo.GetList();

			return products;
			
		}

		public void TUpdate(Product entity)
		{
			throw new NotImplementedException();
		}
	}
}

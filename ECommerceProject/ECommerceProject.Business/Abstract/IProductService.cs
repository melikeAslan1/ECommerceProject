
using ECommerceProject.Entities.ResultModels;
using ECommerceProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
	{
		Task<List<Product>> TGetByCategoryId(int categoryId);
	}
}

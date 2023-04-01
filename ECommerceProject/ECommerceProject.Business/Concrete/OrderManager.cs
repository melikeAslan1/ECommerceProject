using ECommerceProject.Business.Abstract;
using ECommerceProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.Concrete
{
	public class OrderManager : IOrderService
	{
		public void TAdd(Order entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Order entity)
		{
			throw new NotImplementedException();
		}

		public Task<Order> TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<Order>> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Order entity)
		{
			throw new NotImplementedException();
		}

		
	}
}

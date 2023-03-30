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
	public class CustomerManager : ICustomerService
	{
		private ICustomerRepo _customerRepo;

		public CustomerManager(ICustomerRepo customerRepo)
		{
			_customerRepo = customerRepo;
		}

		public void TAdd(Customer entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Customer entity)
		{
			throw new NotImplementedException();
		}

		public Customer TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Customer entity)
		{
			throw new NotImplementedException();
		}

		Task<List<Customer>> IGenericService<Customer>.TGetList()
		{
			throw new NotImplementedException();
		}
	}
}

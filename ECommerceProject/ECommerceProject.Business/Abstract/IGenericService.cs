using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.Abstract
{
	public interface IGenericService<T>
	{
		void TAdd(T entity);

		void TDelete(T entity);	

		void TUpdate(T entity);

		Task<List<T>> TGetList();

		T TGetById(int id);	
	}
}

using ECommerceProject.Business.Abstract;
using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.DataAccess.Concrete;
using ECommerceProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private ICategoryRepo _categoryRepo;

		public CategoryManager(ICategoryRepo categoryRepo)
		{
            _categoryRepo = categoryRepo;
		}
		public async Task<Category> TGetById(int id)
		{
            Category category = await _categoryRepo.Get(x => x.Id == id);

			if(category!=null)
			{
				return category;
			}

            return null;
        }

        public async Task<List<Category>> TGetList()
		{
			 
			var categories = await _categoryRepo.GetList();
			return categories;
		}

		void IGenericService<Category>.TAdd(Category entity)
		{
			throw new NotImplementedException();
		}

		void IGenericService<Category>.TDelete(Category entity)
		{
			throw new NotImplementedException();
		}

		
		void IGenericService<Category>.TUpdate(Category entity)
		{
			throw new NotImplementedException();
		}
	}
}

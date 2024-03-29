﻿using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.DataAccess.Concrete.EntityFramework;
using ECommerceProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DataAccess.Concrete
{
    public class CategoryRepo : RepositoryBase<Category, ECommerceProjectContext>, ICategoryRepo
    {
    }
}

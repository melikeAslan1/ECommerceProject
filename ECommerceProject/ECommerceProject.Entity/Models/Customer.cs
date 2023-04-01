﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entity.Models
{
	public class Customer : BaseEntity, IEntity
    {
		public string Name { get; set; }

		public List<int> OrderIds { get; set; }
	}
}

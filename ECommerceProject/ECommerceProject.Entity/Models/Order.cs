using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entity.Models
{
	public class Order : BaseEntity, IEntity
    {
		public string Address { get; set; }

		public List<int> ProductIds { get; set; }
	}
}

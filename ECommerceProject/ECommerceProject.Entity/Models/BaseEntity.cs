using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entity.Models
{
	public class BaseEntity
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public DateTime CreateDate { get; set; } = DateTime.UtcNow;
		public DateTime UpdateDate { get; set; }
		public bool IsDeleted { get; set; } = false;
	}
}

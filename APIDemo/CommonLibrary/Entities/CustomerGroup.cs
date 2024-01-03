using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Entities
{
	public class CustomerGroup
	{
		/// <summary>
		/// Customer group Id (primary key) must be Guid 
		/// </summary>
		public Guid CustomerGroupId { get; set; }

		/// <summary>
		/// Customer group Name 
		/// </summary>
		public string CustomerGroupName { get; set; }
	}
}

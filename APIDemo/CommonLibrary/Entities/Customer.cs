using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Entities
{
	public class Customer
	{
		/// <summary>
		/// Customer id
		/// </summary>
		public Guid CustomerId { get; set; }
		/// <summary>
		/// Customer code
		/// </summary>
		[Required(ErrorMessage = "Customer code could not be null")]
		public string CustomerCode { get; set; }
		/// <summary>
		/// Customer's Full Name
		/// </summary>
		public string? FullName { get; set; }
		/// <summary>
		/// Customer's Email
		/// </summary>
		public string? Email { get; set; }
	}
}

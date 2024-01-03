using CommonLibrary.Entities;
using Microsoft.AspNetCore.Http;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Entities;
using DatabaseLayer.Interfaces;

namespace ServiceLayer.Services
{
	public class CustomerService : ICustomerService
	{
		public IDbContext<Customer> _dbContext;
		public CustomerService()
		{

		}
		/// <summary>
		/// check is all customer's property is valid to insert 
		/// </summary>
		/// <param name="customer">Customer to check </param>
		/// <returns>
		/// true -> all property is valid
		/// false -> there filed is not valid to insert
		/// </returns>
		///  created by: Nguyễn Thiện Thắng
		/// created_at: 2023/11/17	
		public bool InsertService(Customer customer)
		{
			return !String.IsNullOrEmpty(customer.CustomerCode);
		}
	}
}

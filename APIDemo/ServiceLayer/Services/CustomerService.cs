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
		public int ImportService(IFormFile file)
		{
			//validate data
			// data valid -> insert data
			throw new NotImplementedException();
		}

		public bool InsertService(Customer customer)
		{
			return !String.IsNullOrEmpty(customer.CustomerCode);
		}
	}
}

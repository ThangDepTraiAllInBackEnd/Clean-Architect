using CommonLibrary.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
	public interface ICustomerService
	{
		bool InsertService(Customer customer);
		int ImportService(IFormFile file);
	}
}

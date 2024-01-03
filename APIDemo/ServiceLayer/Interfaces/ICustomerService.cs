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
		bool InsertService(Customer customer);
		
	}
}

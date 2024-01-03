using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using MySqlConnector;
using DatabaseLayer;
using ServiceLayer.Services;
using CommonLibrary.Entities;
using DatabaseLayer.Interfaces;
using ServiceLayer.Interfaces;

namespace APIDemo.Controllers
{
	[Route("api/v1/customers")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		IDbContext<Customer> _dbContext;
		ICustomerService _customerService;
		public CustomersController(IDbContext<Customer> dbContext, ICustomerService customerService)
		{
			_dbContext = dbContext;
			_customerService = customerService;
		}

		/// <summary>
		/// get all customer from database
		/// </summary>
		/// <returns>Customer List with Json format || null</returns>
		///  created by: Nguyễn Thiện Thắng
		///  created_at: 2023/11/17
		[HttpGet]
		public IActionResult Get()
		{
			var customers = _dbContext.GetAll();
			if (customers.Count() > 0)
			{
				return Ok(customers);
			}
			return StatusCode(201, customers);
		}

		/// <summary>
		/// recevice Customer and insert to Database 
		/// </summary>
		/// <returns>Result with JSON format</returns>
		///  created by: Nguyễn Thiện Thắng
		///  created_at: 2023/12/2
		[HttpPost]
		public IActionResult Post(Customer customer)
		{
	
			var serviceResult = _customerService.InsertService(customer);
			// data ok -> insert
			if (serviceResult)
			{
				var response = _dbContext.Insert(customer);
				return Ok(response);
			}
			var res = new
			{
				devMsg = "customer not valid",
				userMsg = "customer not valid",
				data = "data"
			};
			return BadRequest(res);
		}
	}
}

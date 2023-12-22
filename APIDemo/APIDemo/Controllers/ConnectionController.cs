
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace APIDemo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ConnectionController<T> : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			return Ok();
		}

		[HttpPost]
		public IActionResult Post([FromBody] T entity)
		{
			return Ok();
		}
	}
}

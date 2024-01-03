using DatabaseLayer.Interfaces;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using static Dapper.SqlMapper;

namespace DatabaseLayer
{
	public class DbContext<Entity> : IDbContext<Entity>
	{
		protected readonly string connectionString = "Host=8.222.228.150;Port=3306;" +
			" Database=W08.NTTHANG.MF1786;" +
			"User Id=nvmanh;" +
			"Password=12345678";
		protected MySqlConnection _connection;
		protected string _tableName;

		public DbContext()
		{
			_tableName = typeof(Entity).Name;
			_connection = new MySqlConnection(connectionString);
		}

		/// <summary>
		///  Delete entity by Id
		/// </summary>
		/// <param name="item">Entity to Delete </param>
		/// <returns>nummber of record affected</returns>
		///  created by: Nguyễn Thiện Thắng
		///  created_at: 2023/11/17	
		public int Delete(Entity item)
		{
			throw new NotImplementedException();
		}


		// <summary>
		/// Get all record in a table in Database 
		/// </summary>
		/// <returns>An Entity List with type T or null if not found</returns>
		///  created by: Nguyễn Thiện Thắng
		///  created_at: 2023/11/17	
		public List<Entity> GetAll()
		{
			var sql = $"SELECT * FROM {_tableName}";
			var customers = _connection.Query<Entity>(sql);
			return customers.ToList();
		}

		/// <summary>
		/// insert record in to table in Database 
		/// </summary>
		/// <param name="item">Entity to insert </param>
		/// <returns>nummber of record affected</returns>
		///  created by: Nguyễn Thiện Thắng
		/// created_at: 2023/11/17	
		public int Insert(Entity item)
		{
			var colNameList = "";
			var colValueList = "";

			var props = typeof(Entity).GetProperties();
			foreach (var prop in props)
			{
				var propName = prop.Name;
				var value = prop.GetValue(item);
				colNameList += $"{propName},";
				colValueList += $"@{propName},";
			}

			colNameList = colNameList.Substring(0, colNameList.Length - 1);
			colValueList = colValueList.Substring(0, colValueList.Length - 1);
			var sqlCommand = $"INSERT INTO {_tableName} ({colNameList}) " +
		$" VALUES ({colValueList})";

			var res = _connection.Execute(sqlCommand, item);
			return res;
		}
		/// <summary>
		///  Update entity by Id
		/// </summary>
		/// <param name="item">Entity to Update </param>
		/// <returns>nummber of record affected</returns>
		///  created by: Nguyễn Thiện Thắng
		///  created_at: 2023/11/17	
		public int Update(Entity item)
		{
			throw new NotImplementedException();
		}
	}
}

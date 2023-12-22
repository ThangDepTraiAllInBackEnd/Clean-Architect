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

		public int Delete(Entity item)
		{
			throw new NotImplementedException();
		}

		public List<Entity> GetAll()	
		{
			var sql = $"SELECT * FROM {_tableName}";
			var customers = _connection.Query<Entity>(sql);
			return customers.ToList();
		}

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

		public int Update(Entity item)
		{
			throw new NotImplementedException();
		}
	}
}

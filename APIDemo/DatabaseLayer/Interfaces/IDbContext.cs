using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Interfaces
{
	public interface IDbContext<T>
	{
		// <summary>
		/// Get all record in a table in Database 
		/// </summary>
		/// <returns>An Entity List with type T or null if not found</returns>
		///  created by: Nguyễn Thiện Thắng
		///  created_at: 2023/11/17	
		List<T> GetAll();
		/// <summary>
		/// insert record in to table in Database 
		/// </summary>
		/// <param name="item">Entity to insert </param>
		/// <returns>nummber of record affected</returns>
		///  created by: Nguyễn Thiện Thắng
		/// created_at: 2023/11/17	
		int Insert(T item);
		/// <summary>
		///  Update entity by Id
		/// </summary>
		/// <param name="item">Entity to Update </param>
		/// <returns>nummber of record affected</returns>
		///  created by: Nguyễn Thiện Thắng
		///  created_at: 2023/11/17	
		int Update(T item);
		/// <summary>
		///  Delete entity by Id
		/// </summary>
		/// <param name="item">Entity to Delete </param>
		/// <returns>nummber of record affected</returns>
		///  created by: Nguyễn Thiện Thắng
		///  created_at: 2023/11/17	
		int Delete(T item);
	}
}

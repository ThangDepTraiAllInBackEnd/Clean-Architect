using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Interfaces
{
	public interface IDbContext<T>
	{
		List<T> GetAll();
		int Insert(T item);
		int Update(T item);
		int Delete(T item);
	}
}

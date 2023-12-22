using DatabaseLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
	public class DBContextBackUp<T> : IDbContext<T>
	{
		public int Delete(T item)
		{
			throw new NotImplementedException();
		}

		public List<T> GetAll()
		{
			return null;
		}

		public int Insert(T item)
		{
			throw new NotImplementedException();
		}

		public int Update(T item)
		{
			throw new NotImplementedException();
		}
	}
}

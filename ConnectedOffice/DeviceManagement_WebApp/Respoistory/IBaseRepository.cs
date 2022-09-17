using System;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Respoistory
{
	public interface IBaseRepository<T> where T : class
	{
		T GetById(Guid id);
		IEnumerable<T> GetAll();
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		bool Exists(Guid id);
	}
}

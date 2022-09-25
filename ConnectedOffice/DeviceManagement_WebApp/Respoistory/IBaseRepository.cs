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
		
		// This is absolutely horrible, because each repository has full access to the underlying context of all other tables
		// RIP seperation of concerns
		IEnumerable<U> GetDbSet<U>() where U:class; // Might fix the issue with select list, I guess
	}
}

using DeviceManagement_WebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Respoistory
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		protected readonly ConnectedOfficeContext _ctx;

		public BaseRepository(ConnectedOfficeContext ctx)
		{
			this._ctx = ctx;
		}

		public void Add(T entity)
		{
			_ctx.Set<T>().Add(entity);
		}

		public void Delete(T entity)
		{
			_ctx.Set<T>().Remove(entity);
		}

		public bool Exists(Guid id)
		{
			return _ctx.Set<T>().Find(id) != null;
		}

		public IEnumerable<T> GetAll()
		{
			return _ctx.Set<T>().ToList();
		}

		public T GetById(Guid id)
		{
			return _ctx.Set<T>().Find(id);
		}

		public void Update(T entity)
		{
			_ctx.Update(entity);
		}
	}
}

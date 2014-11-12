using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;

namespace iSchool.Api.Core.Data
{
	public abstract class DataAccessBase<T> where T : Model.IEntityBase
	{
		private Context _context;
		protected Context context
		{
			get
			{
				if (_context == null)
					_context = new Context();
				return _context;
			}
		}
		public T GetElement(int id = 0)
		{
			if (id == 0)
				return default(T);
			T entity = GetCollection(id).FirstOrDefault();
			return entity;
		}
		public List<T> GetCollection(int id)
		{
			return id != 0 ? GetCollection().Where(x => x.Id == id).ToList() : GetCollection();
		}
		public void Delete(int id)
		{
			T entity = GetElement(id);
			GetCurrent(entity).State = System.Data.Entity.EntityState.Deleted;
			context.SaveChanges();
		}
		public void Update(T entity)
		{
			T original = GetElement(entity.Id);
			GetCurrent(entity).CurrentValues.SetValues(entity);
			context.SaveChanges();
		}
		public abstract DbEntityEntry GetCurrent(T entity);
		public abstract void Insert(T entity);
		protected abstract List<T> GetCollection();
	}
}

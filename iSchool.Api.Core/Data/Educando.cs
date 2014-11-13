using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Educando : DataAccessBase<Model.Educando>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Educando entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Educando entity)
		{
			context.Educandos.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Educando> GetCollection()
		{
			return context.Educandos.ToList();
		}
	}
}

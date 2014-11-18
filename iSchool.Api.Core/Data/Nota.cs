using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Nota : DataAccessBase<Model.Nota>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Nota entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Nota entity)
		{
			context.Notas.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Nota> GetCollection()
		{
			return context.Notas.ToList();
		}

		public override void Update(Model.Nota entity)
		{
			throw new NotImplementedException();
		}
	}
}

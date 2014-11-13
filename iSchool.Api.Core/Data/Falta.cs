using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Falta : DataAccessBase<Model.Falta>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Falta entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Falta entity)
		{
			context.Faltas.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Falta> GetCollection()
		{
			return context.Faltas.ToList();
		}
	}
}

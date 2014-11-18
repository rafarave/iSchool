using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Comunicado : DataAccessBase<Model.Comunicado>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Comunicado entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Comunicado entity)
		{
			context.Comunicados.Add(entity);
			context.SaveChanges();
		}
		public override void Update(Model.Comunicado entity)
		{
			Model.Comunicado original = context.Comunicados.Find(entity.Id);
			context.Entry(original).CurrentValues.SetValues(entity);
			context.SaveChanges();
		}

		protected override List<Model.Comunicado> GetCollection()
		{
			return context.Comunicados.ToList();
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Planejamento : DataAccessBase<Model.Planejamento>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Planejamento entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Planejamento entity)
		{
			context.Planejamentos.Add(entity);
			context.SaveChanges();
		}
		public override void Update(Model.Planejamento entity)
		{
			Model.Planejamento original = context.Planejamentos.Find(entity.Id);
			context.Entry(original).CurrentValues.SetValues(entity);
			context.SaveChanges();
		}

		protected override List<Model.Planejamento> GetCollection()
		{
			return context.Planejamentos.ToList();
		}

	}
}

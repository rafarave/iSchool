using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Periodo : DataAccessBase<Model.Periodo>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Periodo entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Periodo entity)
		{
			context.Periodos.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Periodo> GetCollection()
		{
			return context.Periodos.ToList();
		}

		public override void Update(Model.Periodo entity)
		{
			throw new NotImplementedException();
		}
	}
}

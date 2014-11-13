using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Matricula : DataAccessBase<Model.Matricula>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Matricula entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Matricula entity)
		{
			context.Matriculas.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Matricula> GetCollection()
		{
			return context.Matriculas.ToList();
		}
	}
}

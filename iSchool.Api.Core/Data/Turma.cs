using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Turma : DataAccessBase<Model.Turma>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Turma entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Turma entity)
		{
			context.Turmas.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Turma> GetCollection()
		{
			return context.Turmas.ToList();
		}

		public override void Update(Model.Turma entity)
		{
			throw new NotImplementedException();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Disciplina : DataAccessBase<Model.Disciplina>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Disciplina entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Disciplina entity)
		{
			context.Disciplinas.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Disciplina> GetCollection()
		{
			return context.Disciplinas.ToList();
		}

		public override void Update(Model.Disciplina entity)
		{
			throw new NotImplementedException();
		}
	}
}

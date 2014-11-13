using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
public	class Aula: DataAccessBase<Model.Aula>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Aula entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Aula entity)
		{
			context.Aulas.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Aula> GetCollection()
		{
			return context.Aulas.Include("Ausencias").Include("Cadeira").ToList();
		}
	}
}

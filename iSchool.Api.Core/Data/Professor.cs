using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Professor : DataAccessBase<Model.Professor>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Professor entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Professor entity)
		{
			context.Professores.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Professor> GetCollection()
		{
			return context.Professores.ToList();
		}

		public override void Update(Model.Professor entity)
		{
			throw new NotImplementedException();
		}
	}
}

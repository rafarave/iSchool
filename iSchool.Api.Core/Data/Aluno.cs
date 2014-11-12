using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Aluno : DataAccessBase<Model.Aluno>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Aluno entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Aluno entity)
		{
			context.Alunos.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Aluno> GetCollection()
		{
			return context.Alunos.Include("Responsaveis").ToList();
		}
	}
}

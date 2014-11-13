using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Boletim : DataAccessBase<Model.Boletim>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Boletim entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Boletim entity)
		{
			context.Boletins.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Boletim> GetCollection()
		{
			return context.Boletins.Include("Aluno").Include("Notas").Include("Faltas").ToList();
		}
	}
}

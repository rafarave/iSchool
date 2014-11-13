using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Avaliacao : DataAccessBase<Model.Avaliacao>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Avaliacao entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Avaliacao entity)
		{
			context.Avaliacoes.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Avaliacao> GetCollection()
		{
			return context.Avaliacoes.Include("Notas").Include("Cadeira").Include("Periodo").ToList();
		}
	}
}

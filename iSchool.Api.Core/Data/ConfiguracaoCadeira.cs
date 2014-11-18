using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class ConfiguracaoCadeira : DataAccessBase<Model.ConfiguracaoCadeira>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.ConfiguracaoCadeira entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.ConfiguracaoCadeira entity)
		{
			context.ConfiguracoesCadeira.Add(entity);
			context.SaveChanges();
		}

		public override void Update(Model.ConfiguracaoCadeira entity)
		{
			Model.ConfiguracaoCadeira original = context.ConfiguracoesCadeira.Find(entity.Id);
			context.Entry(original).CurrentValues.SetValues(entity);
			context.SaveChanges();
		}

		protected override List<Model.ConfiguracaoCadeira> GetCollection()
		{
			return context.ConfiguracoesCadeira.ToList();
		}
	}
}

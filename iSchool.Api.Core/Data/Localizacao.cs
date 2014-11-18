using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Localizacao : DataAccessBase<Model.Localizacao>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Localizacao entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Localizacao entity)
		{
			context.Localizacoes.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Localizacao> GetCollection()
		{
			return context.Localizacoes.ToList();
		}

		public override void Update(Model.Localizacao entity)
		{
			throw new NotImplementedException();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Ocorrencia : DataAccessBase<Model.Ocorrencia>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Ocorrencia entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Ocorrencia entity)
		{
			context.Ocorrencias.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Ocorrencia> GetCollection()
		{
			return context.Ocorrencias.ToList();
		}

		public override void Update(Model.Ocorrencia entity)
		{
			throw new NotImplementedException();
		}
	}
}

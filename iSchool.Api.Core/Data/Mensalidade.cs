using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Mensalidade : DataAccessBase<Model.Mensalidade>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Mensalidade entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Mensalidade entity)
		{
			context.Mensalidades.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Mensalidade> GetCollection()
		{
			return context.Mensalidades.ToList();
		}

		public override void Update(Model.Mensalidade entity)
		{
			throw new NotImplementedException();
		}
	}
}

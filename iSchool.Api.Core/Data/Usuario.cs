using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Usuario : DataAccessBase<Model.Usuario>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Usuario entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Usuario entity)
		{
			context.Usuarios.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Usuario> GetCollection()
		{
			return context.Usuarios.ToList();
		}
	}
}

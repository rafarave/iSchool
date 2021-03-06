﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Responsavel : DataAccessBase<Model.Responsavel>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Responsavel entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Responsavel entity)
		{
			context.Responsaveis.Add(entity);
			context.SaveChanges();
		}
		public override void Update(Model.Responsavel entity)
		{
			Model.Responsavel original = context.Responsaveis.Find(entity.Id);
			context.Entry(original).CurrentValues.SetValues(entity);
			context.SaveChanges();
		}

		protected override List<Model.Responsavel> GetCollection()
		{
			return context.Responsaveis.ToList();
		}

	}
}

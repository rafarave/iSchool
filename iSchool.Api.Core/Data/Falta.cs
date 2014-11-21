using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Falta : DataAccessBase<Model.Falta>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Falta entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Falta entity)
		{
			context.Faltas.Add(entity);
			context.SaveChanges();
		}
		public override void Update(Model.Falta entity)
		{
			Model.Falta original = context.Faltas.Find(entity.Id);
			context.Entry(original).CurrentValues.SetValues(entity);
			context.SaveChanges();
		}

		protected override List<Model.Falta> GetCollection()
		{
			return context.Faltas.ToList();
		}

		public bool AtribuirFalta(int EducandoId, int AulaId)
		{
			bool exists = context.Faltas.Where(f => f.EducandoId == EducandoId && f.AulaId == AulaId).Count() > 0;
			Model.Falta falta = exists ? context.Faltas.FirstOrDefault(f => f.EducandoId == EducandoId && f.AulaId == AulaId) : new Model.Falta();
			falta.AulaId = AulaId;
			falta.EducandoId = EducandoId;
			context.Entry(falta).State = exists ? EntityState.Deleted : EntityState.Added;
			context.SaveChanges();
			return !exists;
		}
	}
}

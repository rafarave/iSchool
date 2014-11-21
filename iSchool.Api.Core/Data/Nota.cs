using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Nota : DataAccessBase<Model.Nota>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Nota entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Nota entity)
		{
			context.Notas.Add(entity);
			context.SaveChanges();
		}
		public override void Update(Model.Nota entity)
		{
			Model.Nota original = context.Notas.Find(entity.Id);
			context.Entry(original).CurrentValues.SetValues(entity);
			context.SaveChanges();
		}

		protected override List<Model.Nota> GetCollection()
		{
			return context.Notas.ToList();
		}


		public void AvaliarAluno(int educandoId, int avaliacaoId, decimal valor)
		{
			bool exists = context.Notas.Where(n => n.EducandoId == educandoId && n.AvaliacaoId == avaliacaoId).Count() > 0;
			Model.Nota nota = exists ? context.Notas.FirstOrDefault(n => n.EducandoId == educandoId && n.AvaliacaoId == avaliacaoId) : new Model.Nota();
			nota.EducandoId = educandoId;
			nota.AvaliacaoId = avaliacaoId;
			nota.Valor = valor;
			context.Entry(nota).State = exists ? EntityState.Modified : EntityState.Added;
			context.SaveChanges();
		}
	}
}

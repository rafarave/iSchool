using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Cadeira : DataAccessBase<Model.Cadeira>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Cadeira entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Cadeira entity)
		{
			context.Cadeiras.Add(entity);
			context.SaveChanges();
		}
		public override void Update(Model.Cadeira entity)
		{
			Model.Cadeira original = context.Cadeiras.Find(entity.Id);
			context.Entry(original).CurrentValues.SetValues(entity);
			context.SaveChanges();
		}

		protected override List<Model.Cadeira> GetCollection()
		{
			return context.Cadeiras.ToList();
		}
		public Model.Cadeira GetCabecalhoListaChamada(int cadeiraId, int periodoId)
		{
			Model.Cadeira cadeira = context.Cadeiras.Include("Aulas").Include("Avaliacoes").FirstOrDefault(c => c.Id == cadeiraId);
			cadeira.Aulas = cadeira.Aulas.Where(a => a.PeriodoId == periodoId).ToList();
			cadeira.Avaliacoes = cadeira.Avaliacoes.Where(a => a.PeriodoId == periodoId).ToList();
			return cadeira;
		}
		public Model.Cadeira GetListaChamada(int cadeiraId, int periodoId)
		{
			Model.Cadeira cadeira = context.Cadeiras.Include("Aulas").Include("Aulas.Ausencias")
				.Include("Avaliacoes").Include("Avaliacoes.Notas")
				.Include("Alunos").Include("Alunos.Aluno")
				.FirstOrDefault(c => c.Id == cadeiraId);
			cadeira.Aulas = cadeira.Aulas.Where(a => a.PeriodoId == periodoId).ToList();
			cadeira.Avaliacoes = cadeira.Avaliacoes.Where(a => a.PeriodoId == periodoId).ToList();
			return cadeira;
		}
	}
}

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

		protected override List<Model.Cadeira> GetCollection()
		{
			return context.Cadeiras.ToList();
		}
		public List<Model.Cadeira> GetDiarioClasse(int cadeiraId)
		{
			List<Model.Cadeira> cadeiras = context.Cadeiras
				.Include("Alunos").Include("Aluno")
				.Include("Aulas").Include("Ausencias")
				.Include("Avaliacoes").Include("Periodo").Include("Notas")
				.Include("Professor")
				.Include("Turma")
				.Include("Disciplina")
				.Where(c => c.Id == cadeiraId)
				.ToList();
			return cadeiras;
		}
	}
}

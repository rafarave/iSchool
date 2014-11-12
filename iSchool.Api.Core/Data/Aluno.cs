using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	public class Aluno : DataAccessBase<Model.Aluno>
	{
		public override System.Data.Entity.Infrastructure.DbEntityEntry GetCurrent(Model.Aluno entity)
		{
			return context.Entry(entity);
		}

		public override void Insert(Model.Aluno entity)
		{
			context.Alunos.Add(entity);
			context.SaveChanges();
		}

		protected override List<Model.Aluno> GetCollection()
		{
			return context.Alunos.Include("Responsaveis").Include("AulasAtendidas").Include("Aulas")
				.Include("Aulas").Include("Ausencias").Include("Avaliacoes").Include("Notas")
				.ToList();
		}
		public List<Model.Aluno> GetCollection(string nome = "", int turmaId = 0, int responsavelId = 0)
		{
			List<Model.Aluno> alunos = GetCollection();
			return alunos.Where(a =>
				(a.Nome == nome || nome == string.Empty) &&
				(a.AulasAtendidas.Where(
					aa => aa.Aulas.Where(au => au.TurmaId == turmaId).Count() > 0
					).Count() > 0 || turmaId == 0) &&
				(a.Responsaveis.Where(r => r.Id == responsavelId).Count() > 0 || responsavelId == 0)
				).ToList();
		}

		public List<Model.Aluno> GetLista(int professorId, int cadeiraId)
		{
			List<Model.Aluno> alunos = GetCollection().Where(a =>
				(a.AulasAtendidas.Where(aa => aa.Aulas.Where(au=> au.ProfessorId == professorId && au.Id == cadeiraId).Count() > 0).Count() > 0)
				).OrderBy(a => a.AulasAtendidas.OrderBy(au => au.OrdemChamada)).ToList();
			return alunos;
		}
	}
}

﻿using System;
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
			entity.Matricula = new Model.Matricula(DateTime.Now);
			context.Alunos.Add(entity);
			context.SaveChanges();
		}
		public override void Update(Model.Aluno entity)
		{
			Model.Aluno original = context.Alunos.Find(entity.Id);
			context.Entry(original).CurrentValues.SetValues(entity);
			context.SaveChanges();
		}

		protected override List<Model.Aluno> GetCollection()
		{
			return context.Alunos.ToList();
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
			List<Model.Aluno> alunos = context.Alunos.Include("Responsaveis").Include("AulasAtendidas").Include("AulasAtendidas.Aulas")
				.Include("AulasAtendidas.Aulas.Aulas").Include("AulasAtendidas.Aulas.Aulas.Ausencias").Include("AulasAtendidas.Aulas.Aulas.Avaliacoes").Include("AulasAtendidas.Aulas.Aulas.Notas").Where(a =>
				(a.AulasAtendidas.Where(aa => aa.Aulas.Where(au=> au.ProfessorId == professorId && au.Id == cadeiraId).Count() > 0).Count() > 0)
				).OrderBy(a => a.AulasAtendidas.OrderBy(au => au.OrdemChamada)).ToList();
			return alunos;
		}

	}
}

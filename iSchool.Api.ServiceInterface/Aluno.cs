﻿using iSchool.Api.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using model = iSchool.Api.Core.Model;
using data = iSchool.Api.Core.Data;
using ServiceStack;
using ServiceStack.ServiceInterface;
namespace iSchool.Api.ServiceInterface
{
	public class Aluno : Service
	{
		public model.Aluno Get(GetAluno request)
		{
			data.Aluno aluno = new data.Aluno();
			return aluno.GetElement(request.Id);
		}
		public List<model.Aluno> Get(GetAlunos request)
		{
			return new data.Aluno().GetCollection(0);
		}
		public List<model.Aluno> Get(FilterAlunos request)
		{
			return new data.Aluno().GetCollection(request.nome, request.turmaId, request.responsavelId);
		}
		public model.Aluno Post(NewAluno request)
		{
			new data.Aluno().Insert(request.Aluno);
			List<model.Aluno> alunos = new data.Aluno().GetCollection();
			return alunos[alunos.Count() - 1];
		}
		public model.Aluno Post(UpdateAluno request)
		{
			new data.Aluno().Update(request.Aluno);
			return new data.Aluno().GetCollection(request.Aluno.Id).FirstOrDefault();
		}
		public void Get(DeleteAluno request)
		{
			new data.Aluno().Delete(request.Id);
		}
		public List<DiarioDeSalaResponse> GetDiario(DiarioDeSala request)
		{
			List<model.Aluno> alunos = new data.Aluno().GetLista(request.ProfessorId, request.CadeiraId);
			List<DiarioDeSalaResponse> response = new List<DiarioDeSalaResponse>();
			foreach (model.Aluno aluno in alunos)
			{
				response.Add(new DiarioDeSalaResponse
				{
					Ordem = aluno.AulasAtendidas.FirstOrDefault().OrdemChamada,
					Nome = aluno.Nome,
					Aulas = new List<bool>()
				});
				foreach(model.Aula aula in aluno.AulasAtendidas.FirstOrDefault().Aulas.FirstOrDefault().Aulas)
				{
					if (aula.Ausencias.Find(ausencia => ausencia.Educando.Aluno.Id == aluno.Id) != null)
						response[response.Count - 1].Aulas.Add(false);
					else
						response[response.Count - 1].Aulas.Add(true);
				}
			}
			return response;
		}
	}
}

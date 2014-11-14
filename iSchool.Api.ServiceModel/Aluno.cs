using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/alunos/{Id}", Verbs = "GET")]
	public class GetAluno
	{
		public int Id { get; set; }
	}

	[Route("/alunos/", Verbs = "GET")]
	public class GetAlunos
	{
	}

	[Route("/alunos/", Verbs = "GET")]
	public class FilterAlunos
	{
		public string nome { get; set; }
		public int turmaId { get; set; }
		public int responsavelId { get; set; }
	}

	[Route("/alunos/new/", Verbs = "POST")]
	public class NewAluno
	{
		public Core.Model.Aluno Aluno { get; set; }
	}

	[Route("/alunos/modify/", Verbs = "POST")]
	public class UpdateAluno
	{
		public Core.Model.Aluno Aluno { get; set; }
	}

	[Route("/alunos/delete/", Verbs = "get")]
	public class DeleteAluno
	{
		public int Id { get; set; }
	}
	[Route("/diario/", Verbs = "get")]
	public class DiarioDeSala
	{
		public int ProfessorId { get; set; }
		public int CadeiraId { get; set; }
	}
	public class DiarioDeSalaResponse
	{
		public int Ordem { get; set; }
		public string Nome { get; set; }
		public List<bool> Aulas { get; set; }
	}
}

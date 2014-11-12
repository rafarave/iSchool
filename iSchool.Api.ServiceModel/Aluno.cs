using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	public class AlunoResponse
	{
		public string Nome { get; set; }
		public string NomePai { get; set; }
		public bool Aprovado { get; set; }
	}

	[Route("/alunos")]
	[Route("/alunos/{Id}")]
	[Route("/alunos/{Nome}")]
	[Route("/alunos/{Aprovado}")]
	public class Aluno
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public bool Aprovado { get; set; }
	}

	[Route("/alunos/", Verbs = "GET")]
	public class AlunoGet
	{
		public int Disciplina { get; set; }
		public int Turma { get; set; }
	}

}

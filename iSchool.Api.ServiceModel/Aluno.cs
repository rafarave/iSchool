using ServiceStack;
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

}

using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/alunos/{Id}", "GET")]
	public class GetAluno : IReturn<Core.Model.Aluno>
	{
		public int Id { get; set; }
	}

	[Route("/alunos", "GET")]
	public class GetAlunos : IReturn<List<Core.Model.Aluno>>
	{
	}

	[Route("/alunos", "GET")]
	public class FilterAlunos : IReturn<List<Core.Model.Aluno>>
	{
		public string nome { get; set; }
		public int turmaId { get; set; }
		public int responsavelId { get; set; }
	}

	[Route("/alunos/", "POST")]
	public class NewAluno
	{
		public Core.Model.Aluno Aluno { get; set; }
	}

	[Route("/alunos/", "PUT")]
	public class UpdateAluno
	{
		public Core.Model.Aluno Aluno { get; set; }
	}

	[Route("/alunos/{Id}", "DELETE")]
	public class DeleteAluno
	{
		public int Id { get; set; }
	}
}

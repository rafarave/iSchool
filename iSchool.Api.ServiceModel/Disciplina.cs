using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/disciplinas/{Id}", Verbs = "GET")]
	public class GetDisciplina
	{
		public int Id { get; set; }
	}

	[Route("/disciplinas/", Verbs = "GET")]
	public class GetDisciplinas
	{
	}

	[Route("/disciplinas/", Verbs = "GET")]
	public class FilterDisciplinas
	{
		public string nome { get; set; }
		public int turmaId { get; set; }
		public int responsavelId { get; set; }
	}

	[Route("/disciplinas/new/", Verbs = "POST")]
	public class NewDisciplina
	{
		public Core.Model.Disciplina Disciplina { get; set; }
	}

	[Route("/disciplinas/modify/", Verbs = "POST")]
	public class UpdateDisciplina
	{
		public Core.Model.Disciplina Disciplina { get; set; }
	}

	[Route("/disciplinas/delete/", Verbs = "get")]
	public class DeleteDisciplina
	{
		public int Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack;
namespace iSchool.Api.ServiceModel
{
	[Route("/turmas/{Id}", Verbs = "GET")]
	public class GetTurma
	{
		public int Id { get; set; }
	}

	[Route("/turmas/", Verbs = "GET")]
	public class GetTurmas
	{
	}

	[Route("/turmas/new/", Verbs = "POST")]
	public class NewTurma
	{
		public Core.Model.Turma Turma { get; set; }
	}

	[Route("/turmas/modify/", Verbs = "POST")]
	public class UpdateTurma
	{
		public Core.Model.Turma Turma { get; set; }
	}

	[Route("/turmas/delete/", Verbs = "get")]
	public class DeleteTurma
	{
		public int Id { get; set; }
	}
}

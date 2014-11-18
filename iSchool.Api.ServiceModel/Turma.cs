using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/turmas/{Id}", "GET")]
	public class GetTurma : IReturn<Core.Model.Turma>
	{
		public int Id { get; set; }
	}

	[Route("/turmas", "GET")]
	public class GetTurmas : IReturn<List<Core.Model.Turma>>
	{
	}

	[Route("/turmas", "POST")]
	public class NewTurma
	{
		public Core.Model.Turma Turma { get; set; }
	}

	[Route("/turmas", "PUT")]
	public class UpdateTurma
	{
		public Core.Model.Turma Turma { get; set; }
	}

	[Route("/turmas/{Id}", "DELETE")]
	public class DeleteTurma
	{
		public int Id { get; set; }
	}
}

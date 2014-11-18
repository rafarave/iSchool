using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/disciplinas/{Id}", "GET")]
	public class GetDisciplina : IReturn<Core.Model.Disciplina>
	{
		public int Id { get; set; }
	}

	[Route("/disciplinas", "GET")]
	public class GetDisciplinas : IReturn<List<Core.Model.Disciplina>>
	{
	}

	[Route("/disciplinas", "POST")]
	public class NewDisciplina
	{
		public Core.Model.Disciplina Disciplina { get; set; }
	}

	[Route("/disciplinas", "PUT")]
	public class UpdateDisciplina
	{
		public Core.Model.Disciplina Disciplina { get; set; }
	}

	[Route("/disciplinas/{Id}", "DELETE")]
	public class DeleteDisciplina
	{
		public int Id { get; set; }
	}
}

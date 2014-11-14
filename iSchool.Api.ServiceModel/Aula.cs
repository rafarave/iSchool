using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/aulas/{Id}", Verbs = "GET")]
	public class GetAula
	{
		public int Id { get; set; }
	}

	[Route("/aulas/", Verbs = "GET")]
	public class GetAulas
	{
	}

	[Route("/aulas/new/", Verbs = "POST")]
	public class NewAula
	{
		public Core.Model.Aula Aula { get; set; }
	}

	[Route("/aulas/modify/", Verbs = "POST")]
	public class UpdateAula
	{
		public Core.Model.Aula Aula { get; set; }
	}

	[Route("/aulas/delete/", Verbs = "get")]
	public class DeleteAula
	{
		public int Id { get; set; }
	}
}

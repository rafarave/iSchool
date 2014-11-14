using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack;
using ServiceStack.ServiceHost;
namespace iSchool.Api.ServiceModel
{
	[Route("/professores/{Id}", Verbs = "GET")]
	public class GetProfessor
	{
		public int Id { get; set; }
	}

	[Route("/professores/", Verbs = "GET")]
	public class GetProfessores
	{
	}

	[Route("/professores/new/", Verbs = "POST")]
	public class NewProfessor
	{
		public Core.Model.Professor Professor { get; set; }
	}

	[Route("/professores/modify/", Verbs = "POST")]
	public class UpdateProfessor
	{
		public Core.Model.Professor Professor { get; set; }
	}

	[Route("/professores/delete/", Verbs = "get")]
	public class DeleteProfessor
	{
		public int Id { get; set; }
	}
}

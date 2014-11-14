using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/matriculas/{Id}", Verbs = "GET")]
	public class GetMatricula
	{
		public int Id { get; set; }
	}

	[Route("/matriculas/", Verbs = "GET")]
	public class GetMatriculas
	{
	}

	[Route("/matriculas/new/", Verbs = "POST")]
	public class NewMatricula
	{
		public Core.Model.Matricula Matricula { get; set; }
	}

	[Route("/matriculas/modify/", Verbs = "POST")]
	public class UpdateMatricula
	{
		public Core.Model.Matricula Matricula { get; set; }
	}

	[Route("/matriculas/delete/", Verbs = "get")]
	public class DeleteMatricula
	{
		public int Id { get; set; }
	}
}

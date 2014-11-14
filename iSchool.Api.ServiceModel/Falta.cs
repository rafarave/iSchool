using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/falta/{Id}", Verbs = "GET")]
	public class GetFalta
	{
		public int Id { get; set; }
	}

	[Route("/falta/", Verbs = "GET")]
	public class GetFaltas
	{
	}

	[Route("/falta/new/", Verbs = "POST")]
	public class NewFalta
	{
		public Core.Model.Falta Falta { get; set; }
	}

	[Route("/falta/modify/", Verbs = "POST")]
	public class UpdateFalta
	{
		public Core.Model.Falta Falta { get; set; }
	}

	[Route("/falta/delete/", Verbs = "get")]
	public class DeleteFalta
	{
		public int Id { get; set; }
	}
}

using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/boletims/{Id}", Verbs = "GET")]
	public class GetBoletim
	{
		public int Id { get; set; }
	}

	[Route("/boletims/", Verbs = "GET")]
	public class GetBoletins
	{
	}

	[Route("/boletims/new/", Verbs = "POST")]
	public class NewBoletim
	{
		public Core.Model.Boletim Boletim { get; set; }
	}

	[Route("/boletims/modify/", Verbs = "POST")]
	public class UpdateBoletim
	{
		public Core.Model.Boletim Boletim { get; set; }
	}

	[Route("/boletims/delete/", Verbs = "get")]
	public class DeleteBoletim
	{
		public int Id { get; set; }
	}
}

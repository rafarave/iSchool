using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/cadeiras/{Id}", Verbs = "GET")]
	public class GetCadeira
	{
		public int Id { get; set; }
	}

	[Route("/cadeiras/", Verbs = "GET")]
	public class GetCadeiras
	{
	}

	[Route("/cadeiras/new/", Verbs = "POST")]
	public class NewCadeira
	{
		public Core.Model.Cadeira Cadeira { get; set; }
	}

	[Route("/cadeiras/modify/", Verbs = "POST")]
	public class UpdateCadeira
	{
		public Core.Model.Cadeira Cadeira { get; set; }
	}

	[Route("/cadeiras/delete/", Verbs = "get")]
	public class DeleteCadeira
	{
		public int Id { get; set; }
	}
}

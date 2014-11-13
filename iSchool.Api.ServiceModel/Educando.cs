using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/educandos/{Id}", Verbs = "GET")]
	public class GetEducando
	{
		public int Id { get; set; }
	}

	[Route("/educandos/", Verbs = "GET")]
	public class GetEducandos
	{
	}

	[Route("/educandos/new/", Verbs = "POST")]
	public class NewEducando
	{
		public Core.Model.Educando Educando { get; set; }
	}

	[Route("/educandos/modify/", Verbs = "POST")]
	public class UpdateEducando
	{
		public Core.Model.Educando Educando { get; set; }
	}

	[Route("/educandos/delete/", Verbs = "get")]
	public class DeleteEducando
	{
		public int Id { get; set; }
	}
}

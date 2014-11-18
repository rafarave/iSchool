using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/educandos/{Id}", "GET")]
	public class GetEducando : IReturn<Core.Model.Educando>
	{
		public int Id { get; set; }
	}

	[Route("/educandos", "GET")]
	public class GetEducandos : IReturn<List<Core.Model.Educando>>
	{
	}

	[Route("/educandos", "POST")]
	public class NewEducando
	{
		public Core.Model.Educando Educando { get; set; }
	}

	[Route("/educandos", "PUT")]
	public class UpdateEducando
	{
		public Core.Model.Educando Educando { get; set; }
	}

	[Route("/educandos/{Id}", "DELETE")]
	public class DeleteEducando
	{
		public int Id { get; set; }
	}
}

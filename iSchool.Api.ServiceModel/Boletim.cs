using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/boletins/{Id}", "GET")]
	public class GetBoletim : IReturn<Core.Model.Boletim>
	{
		public int Id { get; set; }
	}

	[Route("/boletins", "GET")]
	public class GetBoletins : IReturn<List<Core.Model.Boletim>>
	{
	}

	[Route("/boletins", "POST")]
	public class NewBoletim
	{
		public Core.Model.Boletim Boletim { get; set; }
	}

	[Route("/boletins", "PUT")]
	public class UpdateBoletim
	{
		public Core.Model.Boletim Boletim { get; set; }
	}

	[Route("/boletins/{Id}", "DELETE")]
	public class DeleteBoletim
	{
		public int Id { get; set; }
	}
}

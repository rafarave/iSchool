using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/cadeiras/{Id}", "GET")]
	public class GetCadeira : IReturn<Core.Model.Cadeira>
	{
		public int Id { get; set; }
	}

	[Route("/cadeiras", "GET")]
	public class GetCadeiras : IReturn<List<Core.Model.Cadeira>>
	{
	}

	[Route("/cadeiras", "POST")]
	public class NewCadeira
	{
		public Core.Model.Cadeira Cadeira { get; set; }
	}

	[Route("/cadeiras", "PUT")]
	public class UpdateCadeira
	{
		public Core.Model.Cadeira Cadeira { get; set; }
	}

	[Route("/cadeiras/{Id}", "DELETE")]
	public class DeleteCadeira
	{
		public int Id { get; set; }
	}
}

using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/responsavels/{Id}", "GET")]
	public class GetResponsavel : IReturn<Core.Model.Responsavel>
	{
		public int Id { get; set; }
	}

	[Route("/responsavels", "GET")]
	public class GetResponsaveis : IReturn<List<Core.Model.Responsavel>>
	{
	}

	[Route("/responsavels", "POST")]
	public class NewResponsavel
	{
		public Core.Model.Responsavel Responsavel { get; set; }
	}

	[Route("/responsavels", "PUT")]
	public class UpdateResponsavel
	{
		public Core.Model.Responsavel Responsavel { get; set; }
	}

	[Route("/responsavels/{Id}", "DELETE")]
	public class DeleteResponsavel
	{
		public int Id { get; set; }
	}
}

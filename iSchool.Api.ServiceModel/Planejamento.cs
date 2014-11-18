using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/planejamentos/{Id}", "GET")]
	public class GetPlanejamento : IReturn<Core.Model.Planejamento>
	{
		public int Id { get; set; }
	}

	[Route("/planejamentos", "GET")]
	public class GetPlanejamentos : IReturn<List<Core.Model.Planejamento>>
	{
	}

	[Route("/planejamentos", "POST")]
	public class NewPlanejamento
	{
		public Core.Model.Planejamento Planejamento { get; set; }
	}

	[Route("/planejamentos", "PUT")]
	public class UpdatePlanejamento
	{
		public Core.Model.Planejamento Planejamento { get; set; }
	}

	[Route("/planejamentos/{Id}", "DELETE")]
	public class DeletePlanejamento
	{
		public int Id { get; set; }
	}
}

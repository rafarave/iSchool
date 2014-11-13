using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack;
namespace iSchool.Api.ServiceModel
{
	[Route("/planejamentos/{Id}", Verbs = "GET")]
	public class GetPlanejamento
	{
		public int Id { get; set; }
	}

	[Route("/planejamentos/", Verbs = "GET")]
	public class GetPlanejamentos
	{
	}

	[Route("/planejamentos/new/", Verbs = "POST")]
	public class NewPlanejamento
	{
		public Core.Model.Planejamento Planejamento { get; set; }
	}

	[Route("/planejamentos/modify/", Verbs = "POST")]
	public class UpdatePlanejamento
	{
		public Core.Model.Planejamento Planejamento { get; set; }
	}

	[Route("/planejamentos/delete/", Verbs = "get")]
	public class DeletePlanejamento
	{
		public int Id { get; set; }
	}
}

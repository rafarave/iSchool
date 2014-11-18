using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/periodos/{Id}", "GET")]
	public class GetPeriodo : IReturn<Core.Model.Periodo>
	{
		public int Id { get; set; }
	}

	[Route("/periodos", "GET")]
	public class GetPeriodos : IReturn<List<Core.Model.Periodo>>
	{
	}

	[Route("/periodos", "POST")]
	public class NewPeriodo
	{
		public Core.Model.Periodo Periodo { get; set; }
	}

	[Route("/periodos", "PUT")]
	public class UpdatePeriodo
	{
		public Core.Model.Periodo Periodo { get; set; }
	}

	[Route("/periodos/{Id}", "DELETE")]
	public class DeletePeriodo
	{
		public int Id { get; set; }
	}
}

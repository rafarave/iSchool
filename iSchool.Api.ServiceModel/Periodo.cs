using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack;
namespace iSchool.Api.ServiceModel
{
	[Route("/periodos/{Id}", Verbs = "GET")]
	public class GetPeriodo
	{
		public int Id { get; set; }
	}

	[Route("/periodos/", Verbs = "GET")]
	public class GetPeriodos
	{
	}

	[Route("/periodos/new/", Verbs = "POST")]
	public class NewPeriodo
	{
		public Core.Model.Periodo Periodo { get; set; }
	}

	[Route("/periodos/modify/", Verbs = "POST")]
	public class UpdatePeriodo
	{
		public Core.Model.Periodo Periodo { get; set; }
	}

	[Route("/periodos/delete/", Verbs = "get")]
	public class DeletePeriodo
	{
		public int Id { get; set; }
	}
}

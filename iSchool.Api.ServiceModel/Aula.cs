using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/aulas/{Id}", "GET")]
	public class GetAula : IReturn<Core.Model.Aula>
	{
		public int Id { get; set; }
	}

	[Route("/aulas", "GET")]
	public class GetAulas : IReturn<List<Core.Model.Aula>>
	{
	}

	[Route("/aulas", "POST")]
	public class NewAula
	{
		public Core.Model.Aula Aula { get; set; }
	}

	[Route("/aulas", "PUT")]
	public class UpdateAula
	{
		public Core.Model.Aula Aula { get; set; }
	}

	[Route("/aulas/{Id}", "DELETE")]
	public class DeleteAula
	{
		public int Id { get; set; }
	}
	[Route("/aulas/dar_aula", "GET")]
	public class CreateAula
	{
		public int CadeiraId { get; set; }
		public int PeriodoId { get; set; }
		public DateTime Data { get; set; }
	}
}

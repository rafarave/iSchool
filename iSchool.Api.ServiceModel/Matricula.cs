using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/matriculas/{Id}", "GET")]
	public class GetMatricula : IReturn<Core.Model.Matricula>
	{
		public int Id { get; set; }
	}

	[Route("/matriculas", "GET")]
	public class GetMatriculas : IReturn<List<Core.Model.Matricula>>
	{
	}

	[Route("/matriculas", "POST")]
	public class NewMatricula
	{
		public Core.Model.Matricula Matricula { get; set; }
	}

	[Route("/matriculas", "PUT")]
	public class UpdateMatricula
	{
		public Core.Model.Matricula Matricula { get; set; }
	}

	[Route("/matriculas/{Id}", "DELETE")]
	public class DeleteMatricula
	{
		public int Id { get; set; }
	}
}

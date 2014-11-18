using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/comunicados/{Id}", "GET")]
	public class GetComunicado : IReturn<Core.Model.Comunicado>
	{
		public int Id { get; set; }
	}

	[Route("/comunicados", "GET")]
	public class GetComunicados : IReturn<List<Core.Model.Comunicado>>
	{
	}

	[Route("/comunicados", "POST")]
	public class NewComunicado
	{
		public Core.Model.Comunicado Comunicado { get; set; }
	}

	[Route("/comunicados", "PUT")]
	public class UpdateComunicado
	{
		public Core.Model.Comunicado Comunicado { get; set; }
	}

	[Route("/comunicados/{Id}", "DELETE")]
	public class DeleteComunicado
	{
		public int Id { get; set; }
	}
}

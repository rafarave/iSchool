using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/comunicados/{Id}", Verbs = "GET")]
	public class GetComunicado
	{
		public int Id { get; set; }
	}

	[Route("/comunicados/", Verbs = "GET")]
	public class GetComunicados
	{
	}

	[Route("/comunicados/new/", Verbs = "POST")]
	public class NewComunicado
	{
		public Core.Model.Comunicado Comunicado { get; set; }
	}

	[Route("/comunicados/modify/", Verbs = "POST")]
	public class UpdateComunicado
	{
		public Core.Model.Comunicado Comunicado { get; set; }
	}

	[Route("/comunicados/delete/", Verbs = "get")]
	public class DeleteComunicado
	{
		public int Id { get; set; }
	}
}

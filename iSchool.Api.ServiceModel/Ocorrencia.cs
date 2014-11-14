using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/ocorrencias/{Id}", Verbs = "GET")]
	public class GetOcorrencia
	{
		public int Id { get; set; }
	}

	[Route("/ocorrencias/", Verbs = "GET")]
	public class GetOcorrencias
	{
	}

	[Route("/ocorrencias/new/", Verbs = "POST")]
	public class NewOcorrencia
	{
		public Core.Model.Ocorrencia Ocorrencia { get; set; }
	}

	[Route("/ocorrencias/modify/", Verbs = "POST")]
	public class UpdateOcorrencia
	{
		public Core.Model.Ocorrencia Ocorrencia { get; set; }
	}

	[Route("/ocorrencias/delete/", Verbs = "get")]
	public class DeleteOcorrencia
	{
		public int Id { get; set; }
	}
}

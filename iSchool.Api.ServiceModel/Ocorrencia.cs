using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/ocorrencias/{Id}", "GET")]
	public class GetOcorrencia : IReturn<Core.Model.Ocorrencia>
	{
		public int Id { get; set; }
	}

	[Route("/ocorrencias", "GET")]
	public class GetOcorrencias : IReturn<List<Core.Model.Ocorrencia>>
	{
	}

	[Route("/ocorrencias", "POST")]
	public class NewOcorrencia
	{
		public Core.Model.Ocorrencia Ocorrencia { get; set; }
	}

	[Route("/ocorrencias", "PUT")]
	public class UpdateOcorrencia
	{
		public Core.Model.Ocorrencia Ocorrencia { get; set; }
	}

	[Route("/ocorrencias/{Id}", "DELETE")]
	public class DeleteOcorrencia
	{
		public int Id { get; set; }
	}
}

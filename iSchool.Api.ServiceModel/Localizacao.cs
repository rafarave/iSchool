using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/localizacaos/{Id}", "GET")]
	public class GetLocalizacao : IReturn<Core.Model.Localizacao>
	{
		public int Id { get; set; }
	}

	[Route("/localizacaos", "GET")]
	public class GetLocalizacoes : IReturn<List<Core.Model.Localizacao>>
	{
	}

	[Route("/localizacaos", "POST")]
	public class NewLocalizacao
	{
		public Core.Model.Localizacao Localizacao { get; set; }
	}

	[Route("/localizacaos", "PUT")]
	public class UpdateLocalizacao
	{
		public Core.Model.Localizacao Localizacao { get; set; }
	}

	[Route("/localizacaos/{Id}", "DELETE")]
	public class DeleteLocalizacao
	{
		public int Id { get; set; }
	}
}

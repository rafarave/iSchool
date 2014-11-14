using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/localizacoes/{Id}", Verbs = "GET")]
	public class GetLocalizacao
	{
		public int Id { get; set; }
	}

	[Route("/localizacoes/", Verbs = "GET")]
	public class GetLocalizacoes
	{
	}

	[Route("/localizacoes/new/", Verbs = "POST")]
	public class NewLocalizacao
	{
		public Core.Model.Localizacao Localizacao { get; set; }
	}

	[Route("/localizacoes/modify/", Verbs = "POST")]
	public class UpdateLocalizacao
	{
		public Core.Model.Localizacao Localizacao { get; set; }
	}

	[Route("/localizacoes/delete/", Verbs = "get")]
	public class DeleteLocalizacao
	{
		public int Id { get; set; }
	}
}

using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/avaliacoes/{Id}", Verbs = "GET")]
	public class GetAvaliacao
	{
		public int Id { get; set; }
	}

	[Route("/avaliacoes/", Verbs = "GET")]
	public class GetAvaliacoes
	{
	}

	[Route("/avaliacoes/new/", Verbs = "POST")]
	public class NewAvaliacao
	{
		public Core.Model.Avaliacao Avaliacao { get; set; }
	}

	[Route("/avaliacoes/modify/", Verbs = "POST")]
	public class UpdateAvaliacao
	{
		public Core.Model.Avaliacao Avaliacao { get; set; }
	}

	[Route("/avaliacoes/delete/", Verbs = "get")]
	public class DeleteAvaliacao
	{
		public int Id { get; set; }
	}
}

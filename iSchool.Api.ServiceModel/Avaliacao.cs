using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/avaliacoes/{Id}", "GET")]
	public class GetAvaliacao : IReturn<Core.Model.Avaliacao>
	{
		public int Id { get; set; }
	}

	[Route("/avaliacoes", "GET")]
	public class GetAvaliacoes : IReturn<List<Core.Model.Avaliacao>>
	{
	}

	[Route("/avaliacoes", "POST")]
	public class NewAvaliacao
	{
		public Core.Model.Avaliacao Avaliacao { get; set; }
	}

	[Route("/avaliacoes", "PUT")]
	public class UpdateAvaliacao
	{
		public Core.Model.Avaliacao Avaliacao { get; set; }
	}

	[Route("/avaliacoes/{Id}", "DELETE")]
	public class DeleteAvaliacao
	{
		public int Id { get; set; }
	}
}

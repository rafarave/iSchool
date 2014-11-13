using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack;
namespace iSchool.Api.ServiceModel
{
	[Route("/responsaveis/{Id}", Verbs = "GET")]
	public class GetResponsavel
	{
		public int Id { get; set; }
	}

	[Route("/responsaveis/", Verbs = "GET")]
	public class GetResponsaveis
	{
	}

	[Route("/responsaveis/new/", Verbs = "POST")]
	public class NewResponsavel
	{
		public Core.Model.Responsavel Responsavel { get; set; }
	}

	[Route("/responsaveis/modify/", Verbs = "POST")]
	public class UpdateResponsavel
	{
		public Core.Model.Responsavel Responsavel { get; set; }
	}

	[Route("/responsaveis/delete/", Verbs = "get")]
	public class DeleteResponsavel
	{
		public int Id { get; set; }
	}
}

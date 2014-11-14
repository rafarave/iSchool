using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/mensalidades/{Id}", Verbs = "GET")]
	public class GetMensalidade
	{
		public int Id { get; set; }
	}

	[Route("/mensalidades/", Verbs = "GET")]
	public class GetMensalidades
	{
	}

	[Route("/mensalidades/new/", Verbs = "POST")]
	public class NewMensalidade
	{
		public Core.Model.Mensalidade Mensalidade { get; set; }
	}

	[Route("/mensalidades/modify/", Verbs = "POST")]
	public class UpdateMensalidade
	{
		public Core.Model.Mensalidade Mensalidade { get; set; }
	}

	[Route("/mensalidades/delete/", Verbs = "get")]
	public class DeleteMensalidade
	{
		public int Id { get; set; }
	}
}

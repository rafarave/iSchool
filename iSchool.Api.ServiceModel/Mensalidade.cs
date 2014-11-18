using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/mensalidades/{Id}", "GET")]
	public class GetMensalidade : IReturn<Core.Model.Mensalidade>
	{
		public int Id { get; set; }
	}

	[Route("/mensalidades", "GET")]
	public class GetMensalidades : IReturn<List<Core.Model.Mensalidade>>
	{
	}

	[Route("/mensalidades", "POST")]
	public class NewMensalidade
	{
		public Core.Model.Mensalidade Mensalidade { get; set; }
	}

	[Route("/mensalidades", "PUT")]
	public class UpdateMensalidade
	{
		public Core.Model.Mensalidade Mensalidade { get; set; }
	}

	[Route("/mensalidades/{Id}", "DELETE")]
	public class DeleteMensalidade
	{
		public int Id { get; set; }
	}
}

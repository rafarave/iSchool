using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/configuracoes_cadeira/{Id}", "GET")]
	public class GetConfiguracaoCadeira : IReturn<Core.Model.ConfiguracaoCadeira>
	{
		public int Id { get; set; }
	}

	[Route("/configuracoes_cadeira", "GET")]
	public class GetConfiguracoesCadeira : IReturn<List<Core.Model.ConfiguracaoCadeira>>
	{
	}

	[Route("/configuracoes_cadeira", "POST")]
	public class NewConfiguracaoCadeira
	{
		public Core.Model.ConfiguracaoCadeira ConfiguracaoCadeira { get; set; }
	}

	[Route("/configuracoes_cadeira", "PUT")]
	public class UpdateConfiguracaoCadeira
	{
		public Core.Model.ConfiguracaoCadeira ConfiguracaoCadeira { get; set; }
	}

	[Route("/configuracoes_cadeira/{Id}", "DELETE")]
	public class DeleteConfiguracaoCadeira
	{
		public int Id { get; set; }
	}
}

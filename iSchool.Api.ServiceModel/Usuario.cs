using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/usuarios/{Id}", "GET")]
	public class GetUsuario : IReturn<Core.Model.Usuario>
	{
		public int Id { get; set; }
	}

	[Route("/usuarios", "GET")]
	public class GetUsuarios : IReturn<List<Core.Model.Usuario>>
	{
	}

	[Route("/usuarios", "POST")]
	public class NewUsuario
	{
		public Core.Model.Usuario Usuario { get; set; }
	}

	[Route("/usuarios", "PUT")]
	public class UpdateUsuario
	{
		public Core.Model.Usuario Usuario { get; set; }
	}

	[Route("/usuarios/{Id}", "DELETE")]
	public class DeleteUsuario
	{
		public int Id { get; set; }
	}
}

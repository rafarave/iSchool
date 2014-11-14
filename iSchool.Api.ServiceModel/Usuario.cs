using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack;
using ServiceStack.ServiceHost;
namespace iSchool.Api.ServiceModel
{
	[Route("/usuarios/{Id}", Verbs = "GET")]
	public class GetUsuario
	{
		public int Id { get; set; }
	}

	[Route("/usuarios/", Verbs = "GET")]
	public class GetUsuarios
	{
	}

	[Route("/usuarios/new/", Verbs = "POST")]
	public class NewUsuario
	{
		public Core.Model.Usuario Usuario { get; set; }
	}

	[Route("/usuarios/modify/", Verbs = "POST")]
	public class UpdateUsuario
	{
		public Core.Model.Usuario Usuario { get; set; }
	}

	[Route("/usuarios/delete/", Verbs = "get")]
	public class DeleteUsuario
	{
		public int Id { get; set; }
	}
}

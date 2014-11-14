using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/notas/{Id}", Verbs = "GET")]
	public class GetNota
	{
		public int Id { get; set; }
	}

	[Route("/notas/", Verbs = "GET")]
	public class GetNotas
	{
	}

	[Route("/notas/new/", Verbs = "POST")]
	public class NewNota
	{
		public Core.Model.Nota Nota { get; set; }
	}

	[Route("/notas/modify/", Verbs = "POST")]
	public class UpdateNota
	{
		public Core.Model.Nota Nota { get; set; }
	}

	[Route("/notas/delete/", Verbs = "get")]
	public class DeleteNota
	{
		public int Id { get; set; }
	}
}

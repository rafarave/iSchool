using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/professors/{Id}", "GET")]
	public class GetProfessor : IReturn<Core.Model.Professor>
	{
		public int Id { get; set; }
	}

	[Route("/professors", "GET")]
	public class GetProfessores : IReturn<List<Core.Model.Professor>>
	{
	}

	[Route("/professors", "POST")]
	public class NewProfessor
	{
		public Core.Model.Professor Professor { get; set; }
	}

	[Route("/professors", "PUT")]
	public class UpdateProfessor
	{
		public Core.Model.Professor Professor { get; set; }
	}

	[Route("/professors/{Id}", "DELETE")]
	public class DeleteProfessor
	{
		public int Id { get; set; }
	}
}

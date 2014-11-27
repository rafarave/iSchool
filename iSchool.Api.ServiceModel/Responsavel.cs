using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/responsaveis/{Id}", "GET")]
	public class GetResponsavel : IReturn<Core.Model.Responsavel>
	{
		public int Id { get; set; }
	}

	//TODO: fazer o DATA desse cara, trazer responsaveis por aluno
	[Route("/responsaveis/aluno/{Id}", "GET")]
	public class GetResponsaveisPorAluno : IReturn<Core.Model.Responsavel>
	{
		public int Id { get; set; }
	}

	[Route("/responsaveis", "GET")]
	public class GetResponsaveis : IReturn<List<Core.Model.Responsavel>>
	{
	}

	[Route("/responsaveis", "POST")]
	public class NewResponsavel
	{
		public Core.Model.Responsavel Responsavel { get; set; }
	}

	[Route("/responsaveis", "PUT")]
	public class UpdateResponsavel
	{
		public Core.Model.Responsavel Responsavel { get; set; }
	}

	[Route("/responsaveis/{Id}", "DELETE")]
	public class DeleteResponsavel
	{
		public int Id { get; set; }
	}
}

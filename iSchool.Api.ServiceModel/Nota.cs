using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/notas/{Id}", "GET")]
	public class GetNota : IReturn<Core.Model.Nota>
	{
		public int Id { get; set; }
	}

	[Route("/notas", "GET")]
	public class GetNotas : IReturn<List<Core.Model.Nota>>
	{
	}

	[Route("/notas", "POST")]
	public class NewNota
	{
		public Core.Model.Nota Nota { get; set; }
	}

	[Route("/notas", "PUT")]
	public class UpdateNota
	{
		public Core.Model.Nota Nota { get; set; }
	}

	[Route("/notas/{Id}", "DELETE")]
	public class DeleteNota
	{
		public int Id { get; set; }
	}
	[Route("/notas/avaliar_aluno", "GET")]
	public class SetNota
	{
		public int EducandoId { get; set; }
		public int AvaliacaoId { get; set; }
		public decimal Valor { get; set; }
	}
}

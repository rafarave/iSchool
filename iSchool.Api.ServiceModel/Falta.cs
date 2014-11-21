using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/faltas/{Id}", "GET")]
	public class GetFalta : IReturn<Core.Model.Falta>
	{
		public int Id { get; set; }
	}

	[Route("/faltas", "GET")]
	public class GetFaltas : IReturn<List<Core.Model.Falta>>
	{
	}

	[Route("/faltas", "POST")]
	public class NewFalta
	{
		public Core.Model.Falta Falta { get; set; }
	}

	[Route("/faltas", "PUT")]
	public class UpdateFalta
	{
		public Core.Model.Falta Falta { get; set; }
	}

	[Route("/faltas/{Id}", "DELETE")]
	public class DeleteFalta
	{
		public int Id { get; set; }
	}

	[Route("/alunos/atribuir_falta", "GET")]
	public class AtribuirFalta
	{
		public int EducandoId { get; set; }
		public int AulaId { get; set; }
	}
}

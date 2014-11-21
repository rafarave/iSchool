using ServiceStack;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.ServiceModel
{
	[Route("/cadeiras/{Id}", "GET")]
	public class GetCadeira : IReturn<Core.Model.Cadeira>
	{
		public int Id { get; set; }
	}

	[Route("/cadeiras", "GET")]
	public class GetCadeiras : IReturn<List<Core.Model.Cadeira>>
	{
	}

	[Route("/cadeiras", "POST")]
	public class NewCadeira
	{
		public Core.Model.Cadeira Cadeira { get; set; }
	}

	[Route("/cadeiras", "PUT")]
	public class UpdateCadeira
	{
		public Core.Model.Cadeira Cadeira { get; set; }
	}

	[Route("/cadeiras/{Id}", "DELETE")]
	public class DeleteCadeira
	{
		public int Id { get; set; }
	}

	[Route("/cadeiras/cabecalho", "GET")]
	public class GetCabecalhoListaChamada : IReturn<CabecalhoListaChamada>
	{
		public int CadeiraId { get; set; }
		public int PeriodoId { get; set; }
	}
	public class CabecalhoListaChamada
	{
		/// <summary>
		/// AulaId, Data
		/// Ordenar por data da aula crescente
		/// </summary>
		public Dictionary<int, DateTime> AulasDadas { get; set; }
		/// <summary>
		/// AvaliacaoId, Nome da avaliação
		/// Ordenar por data da avaliacao crescente
		/// </summary>
		public Dictionary<int, string> Avaliacoes { get; set; }
	}

	[Route("/cadeiras/lista", "GET")]
	public class GetListaChamada
	{
		public int CadeiraId { get; set; }
		public int PeriodoId { get; set; }
	}
	public class ItemListaChamada
	{
		public int CadeiraId { get; set; }
		public int EducandoId { get; set; }
		public string NomeAluno { get; set; }
		public int NumeroChamadaAluno { get; set; }
		/// <summary>
		/// AulaId, [EstavaPresente: true; Faltou: false]
		/// Ordenar por data da aula crescente
		/// </summary>
		public Dictionary<int, bool> Presencas { get; set; }
		/// <summary>
		/// AvaliacaoId, Nota
		/// Ordenar por data da avaliacao crescente
		/// </summary>
		public Dictionary<int, decimal> Avaliacoes { get; set; }
	}
}

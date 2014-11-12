using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Planejamento : IEntityBase
	{
		public int Id { get; set; }
		public int PeriodoId { get; set; }
		[Display(Name = "Período")]
		public Periodo Periodo { get; set; }
		public string Objetivo { get; set; }
		[Display(Name = "Conteúdo lecionado")]
		public string Conteudo { get; set; }
		public string Metodologia { get; set; }
		[Display(Name = "Processo avaliativo")]
		public string ProcessoAvaliatorio { get; set; }
		[Display(Name = "Material didático")]
		public string MaterialDidatico { get; set; }
	}
}

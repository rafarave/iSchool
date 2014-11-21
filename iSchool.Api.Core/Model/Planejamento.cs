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
		public Periodo Periodo { get; set; }
		public string Objetivo { get; set; }
		public string Conteudo { get; set; }
		public string Metodologia { get; set; }
		public string ProcessoAvaliatorio { get; set; }
		public string MaterialDidatico { get; set; }
	}
}

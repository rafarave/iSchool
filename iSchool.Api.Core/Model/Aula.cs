using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Aula : IEntityBase
	{
		public int Id { get; set; }
		public int PeriodoId { get; set; }
		public Periodo Periodo { get; set; }
		public int CadeiraId { get; set; }
		public Cadeira Cadeira { get; set; }
		public DateTime Data { get; set; }
		public string ConteudoLecionado { get; set; }
		public List<Falta> Ausencias { get; set; }
	}
}

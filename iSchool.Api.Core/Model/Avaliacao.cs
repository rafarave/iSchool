using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Avaliacao : IEntityBase
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int CadeiraId { get; set; }
		public Cadeira Cadeira { get; set; }
		public int PeriodoId { get; set; }
		public Periodo Periodo { get; set; }
		public List<Nota> Notas { get; set; }
	}
}

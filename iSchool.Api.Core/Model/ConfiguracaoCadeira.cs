using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSchool.Api.Core.Model
{
	public class ConfiguracaoCadeira : IEntityBase
	{
		public int Id { get; set; }
		public int CadeiraId { get; set; }
		public Cadeira Cadeira { get; set; }
		public int DiaSemana { get; set; }
		public int Ordem { get; set; }
		public int Duracao { get; set; }
	}
}

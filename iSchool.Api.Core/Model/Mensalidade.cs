using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Mensalidade : IEntityBase
	{
		public int InstituicaoId { get; set; }
		public int Id { get; set; }
		public DateTime Referencia { get; set; }
		public decimal Valor { get; set; }
	}
}

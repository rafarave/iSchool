using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Instituicao : IEntityBase
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string HashCode { get; set; }
		public bool Ativa { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Comunicado : IEntityBase
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public DateTime Enviado { get; set; }
	}
}

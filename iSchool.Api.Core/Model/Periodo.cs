using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Periodo : IEntityBase
	{
		public int Id { get; set; }
		public DateTime VigenciaInicio { get; set; }
		public DateTime VigenciaTermino { get; set; }
	}
}

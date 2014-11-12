using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Falta : IEntityBase
	{
		public int Id { get; set; }
		public int AulaId { get; set; }
		public Aula Aula { get; set; }
		public int EducandoId { get; set; }
		public Educando Educando { get; set; }
	}
}

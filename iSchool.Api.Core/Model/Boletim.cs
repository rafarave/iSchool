using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Boletim : IEntityBase
	{
		public int Id { get; set; }
		public int AlunoId { get; set; }
		public Aluno Aluno { get; set; }
		public List<Nota> Notas { get; set; }
		public List<Falta> Faltas { get; set; }

	}
}

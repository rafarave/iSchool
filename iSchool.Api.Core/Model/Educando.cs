using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Educando : IEntityBase
	{
		public int Id { get; set; }
		public int OrdemChamada { get; set; }
		public int alunoId { get; set; }
		public Aluno Aluno { get; set; }
		public List<Cadeira> Aulas { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Nota : IEntityBase
	{
		public int InstituicaoId { get; set; }
		public int Id { get; set; }
		public int alunoId { get; set; }
		public Aluno Aluno { get; set; }
		public int AvaliacaoId { get; set; }
		public Avaliacao Avaliacao { get; set; }
		public decimal Valor { get; set; }
		public string Mencao { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Responsavel : IEntityBase 
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public List<Aluno> Alunos { get; set; }
		public List<Comunicado> Comunicados { get; set; }
	}
}

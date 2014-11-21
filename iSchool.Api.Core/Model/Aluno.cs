using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Aluno : IEntityBase
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public bool AprovadoUltimoPeriodo { get; set; }
		public List<Responsavel> Responsaveis { get; set; }
		public List<Educando> AulasAtendidas { get; set; }
		public List<Comunicado> Comunicados { get; set; }
		public List<Mensalidade> Mensalidade { get; set; }
		public List<Ocorrencia> Ocorrencias { get; set; }
		public Boletim Boletim { get; set; }
		public Matricula Matricula { get; set; }
		public string Nome { get; set; }
		public DateTime Nascimento { get; set; }
		public string Endereco { get; set; }
		public short Numero { get; set; }
		public string Complemento { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public int CEP { get; set; }
	}
}

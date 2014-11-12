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

	//}
	//public class DadosCadastrais
	//{
	//	public int alunoId { get; set; }
	//	public Aluno Aluno { get; set; }
		public string Nome { get; set; }
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		[Display(Name = "Data de nascimento")]
		public DateTime Nascimento { get; set; }
		[Display(Name = "Número de matrícula")]
		public string Matricula { get; set; }
		[Display(Name = "Endereço")]
		public string Endereco { get; set; }
		[Range(0, 99000)]
		[Display(Name = "Número")]
		public short Numero { get; set; }
		public string Complemento { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }

		[DisplayFormat(DataFormatString = "{0:F8}")]
		public int CEP { get; set; }
	}
}

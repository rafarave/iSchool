using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Professor : IEntityBase
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public List<Disciplina> Lecionaveis { get; set; }
		public List<Cadeira> Aulas { get; set; }
	}
}

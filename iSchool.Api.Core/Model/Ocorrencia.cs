using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Ocorrencia : IEntityBase
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
	}
}

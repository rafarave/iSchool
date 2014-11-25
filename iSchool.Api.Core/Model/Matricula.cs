using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Matricula : IEntityBase
	{
		public Matricula() { }
		public Matricula(DateTime data)
		{
			this.Hash = string.Empty;
			char[] hexOutput = data.ToString("yyyyMMddhhmmss").ToCharArray();
			foreach(char c in hexOutput)
				this.Hash += string.Format("{0:X}", c);
		}
		public int InstituicaoId { get; set; }
		public int Id { get; set; }
		public string Codigo { get; set; }
		public string Hash { get; set; }
	}
}

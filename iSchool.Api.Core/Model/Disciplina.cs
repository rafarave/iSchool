﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Disciplina : IEntityBase
	{
		public int InstituicaoId { get; set; }
		public int Id { get; set; }
		public string Nome { get; set; }
		public List<Professor> ProfessoresElegiveis { get; set; }
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Model
{
	public class Cadeira : IEntityBase
	{
		public int Id { get; set; }
		public int TurmaId { get; set; }
		public Turma Turma { get; set; }
		public int DisciplinaId { get; set; }
		public Disciplina Disciplina { get; set; }
		public int ProfessorId { get; set; }
		public Professor Professor { get; set; }
		public List<Planejamento> Planejamentos { get; set; }
		public List<Educando> Alunos { get; set; }
		public List<Aula> Aulas { get; set; }
		public List<Avaliacao> Avaliacoes { get; set; }
		public List<ConfiguracaoCadeira> Configuracoes { get; set; }
	}
}

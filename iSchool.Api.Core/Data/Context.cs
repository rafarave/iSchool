using System.Data.Entity;

namespace iSchool.Api.Core.Data
{
	public class Context : DbContext
	{
		public DbSet<Model.Aluno> Alunos { get; set; }
		public DbSet<Model.Aula> Aulas { get; set; }
		public DbSet<Model.Avaliacao> Avaliacoes { get; set; }
		public DbSet<Model.Boletim> Boletins { get; set; }
		public DbSet<Model.Cadeira> Cadeiras { get; set; }
		public DbSet<Model.Comunicado> Comunicados { get; set; }
		public DbSet<Model.Disciplina> Disciplinas { get; set; }
		public DbSet<Model.Educando> Educandos { get; set; }
		public DbSet<Model.Falta> Faltas { get; set; }
		public DbSet<Model.Instituicao> Instituicoes { get; set; }
		public DbSet<Model.Localizacao> Localizacoes { get; set; }
		public DbSet<Model.Matricula> Matriculas { get; set; }
		public DbSet<Model.Mensalidade> Mensalidades { get; set; }
		public DbSet<Model.Nota> Notas { get; set; }
		public DbSet<Model.Ocorrencia> Ocorrencias { get; set; }
		public DbSet<Model.Periodo> Periodos { get; set; }
		public DbSet<Model.Planejamento> Planejamentos { get; set; }
		public DbSet<Model.Professor> Professores { get; set; }
		public DbSet<Model.Responsavel> Responsaveis { get; set; }
		public DbSet<Model.Turma> Turmas { get; set; }
		public DbSet<Model.Usuario> Usuarios { get; set; }
	}
}

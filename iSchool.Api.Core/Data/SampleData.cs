using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSchool.Api.Core.Data
{
	internal class SampleData : DropCreateDatabaseIfModelChanges<Context>
	{
		protected override void Seed(Context context)
		{
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Língua portuguesa" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Literatura" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Filosofia" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Sociologia" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Matemática" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Física" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Química" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Biologia" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "História" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Geografia" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Educação física" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Inglês" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Espanhol" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Informática" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Teatro" });
			context.Disciplinas.Add(new Model.Disciplina { InstituicaoId = 1, Nome = "Religião" });
			context.SaveChanges();

			context.Alunos.Add(new Model.Aluno { Nome = "Chaves", Nascimento = new DateTime(1999, 2, 28), Email = "chaves@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Quico", Nascimento = new DateTime(1999, 2, 28), Email = "quico@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Chiquinha", Nascimento = new DateTime(1999, 2, 28), Email = "chiquinha@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Nhonho", Nascimento = new DateTime(1999, 2, 28), Email = "nhonho@gmail.com", Senha = "123" });

			context.Responsaveis.Add(new Model.Responsavel { Nome = "Dona Florinda", Email = "florinda@gmail.com", Senha = "123" });
			context.Responsaveis.Add(new Model.Responsavel { Nome = "Seu Madruga", Email = "madruga@gmail.com", Senha = "123" });

			context.Professores.Add(new Model.Professor { Nome = "Girafales" });
		}
	}
}

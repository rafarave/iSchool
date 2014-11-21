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
			context.Alunos.Add(new Model.Aluno { Nome = "Roberto Gomez Bolaños", Nascimento = new DateTime(1999, 2, 28), Email = "robertobolhanos@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Carlos Villagrán", Nascimento = new DateTime(1999, 2, 28), Email = "carlosvillagran@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "María Antonieta de las Nieves", Nascimento = new DateTime(1999, 2, 28), Email = "marianieves@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Édgar Vivar", Nascimento = new DateTime(1999, 2, 28), Email = "edvivar@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Raúl Chato Padilla", Nascimento = new DateTime(1999, 2, 28), Email = "raulpadilla@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Horacio Gómez Bolaños", Nascimento = new DateTime(1999, 2, 28), Email = "horaciobolanos@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Angelines Fernández", Nascimento = new DateTime(1999, 2, 28), Email = "angelfernandez@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "María Luisa Alcalá", Nascimento = new DateTime(1999, 2, 28), Email = "mariaalcala@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Maria Joaquina Medsen", Nascimento = new DateTime(1999, 2, 28), Email = "maria_joaquina_medsen@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Cirilo River", Nascimento = new DateTime(1999, 2, 28), Email = "cirilo_river@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Jaime Palillo", Nascimento = new DateTime(1999, 2, 28), Email = "jaime_palillo@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Valéria Ferreira", Nascimento = new DateTime(1999, 2, 28), Email = "valeria_ferreira@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Paulo Guerra", Nascimento = new DateTime(1999, 2, 28), Email = "paulo_guerra@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Laura Gianolli", Nascimento = new DateTime(1999, 2, 28), Email = "laura_gianolli@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Carmen Carrilho", Nascimento = new DateTime(1999, 2, 28), Email = "carmen_carrilho@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Davi Rabinovich", Nascimento = new DateTime(1999, 2, 28), Email = "davi_rabinovich@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Adriano Ramos", Nascimento = new DateTime(1999, 2, 28), Email = "adriano_ramos@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Daniel Zapata", Nascimento = new DateTime(1999, 2, 28), Email = "daniel_zapata@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Marcelina Guerra", Nascimento = new DateTime(1999, 2, 28), Email = "marcelina_guerra@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Alícia Gusman", Nascimento = new DateTime(1999, 2, 28), Email = "alicia_gusman@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Bibi Smith", Nascimento = new DateTime(1999, 2, 28), Email = "bibi_smith@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Kokimoto Mishima", Nascimento = new DateTime(1999, 2, 28), Email = "kokimoto_mishima@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Mário Ayala", Nascimento = new DateTime(1999, 2, 28), Email = "mario_ayala@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Margarida Garcia", Nascimento = new DateTime(1999, 2, 28), Email = "margarida_garcia@gmail.com", Senha = "123" });
			context.Alunos.Add(new Model.Aluno { Nome = "Jorge Cavalieri", Nascimento = new DateTime(1999, 2, 28), Email = "jorge_cavalieri@gmail.com", Senha = "123" });
			context.SaveChanges();
			List<Model.Aluno> alunos = context.Alunos.OrderBy(a => a.Nome).ToList();
			int j = 0;
			foreach(Model.Aluno aluno in alunos)
			{
				j++;
				context.Educandos.Add(new Model.Educando { OrdemChamada = j, alunoId = aluno.Id });
			}
			context.SaveChanges();

			context.Responsaveis.Add(new Model.Responsavel { Nome = "Dona Florinda", Email = "florinda@gmail.com", Senha = "123" });
			context.Responsaveis.Add(new Model.Responsavel { Nome = "Seu Madruga", Email = "madruga@gmail.com", Senha = "123" });
			context.Responsaveis.Add(new Model.Responsavel { Nome = "Dona Florinda", Email = "florinda@gmail.com", Senha = "123" });
			context.Responsaveis.Add(new Model.Responsavel { Nome = "Ramón Valdés", Email = "ramonvaldez@gmail.com", Senha = "123" });
			context.SaveChanges();

			context.Professores.Add(new Model.Professor { Nome = "Girafales" });
			context.Professores.Add(new Model.Professor { Nome = "Héctor Bonilha" });
			context.Professores.Add(new Model.Professor { Nome = "Rubén Aguirre" });
			context.Professores.Add(new Model.Professor { Nome = "Janet Arceo" });
			context.Professores.Add(new Model.Professor { Nome = "Helena Fernandes" });
			context.Professores.Add(new Model.Professor { Nome = "Ximena Hezergovina Fernández" });
			context.Professores.Add(new Model.Professor { Nome = "Professora Matilde" });
			context.Professores.Add(new Model.Professor { Nome = "Suzana Bustamante" });
			context.SaveChanges();

			context.Turmas.Add(new Model.Turma { Nome = "1ª Série Fundamental" });
			context.Turmas.Add(new Model.Turma { Nome = "2ª Série Fundamental" });
			context.Turmas.Add(new Model.Turma { Nome = "3ª Série Fundamental" });
			context.Turmas.Add(new Model.Turma { Nome = "4ª Série Fundamental" });
			context.Turmas.Add(new Model.Turma { Nome = "5ª Série Fundamental" });
			context.Turmas.Add(new Model.Turma { Nome = "6ª Série Fundamental" });
			context.Turmas.Add(new Model.Turma { Nome = "7ª Série Fundamental" });
			context.Turmas.Add(new Model.Turma { Nome = "8ª Série Fundamental" });
			context.Turmas.Add(new Model.Turma { Nome = "9ª Série Fundamental" });
			context.Turmas.Add(new Model.Turma { Nome = "1ª Série Médio" });
			context.Turmas.Add(new Model.Turma { Nome = "2ª Série Médio" });
			context.Turmas.Add(new Model.Turma { Nome = "3ª Série Médio" });
			context.SaveChanges();

			Model.Cadeira lp = new Model.Cadeira
			{
				Alunos = context.Educandos.ToList(),
				ProfessorId = context.Professores.FirstOrDefault(p => p.Nome == "Girafales").Id,
				DisciplinaId = context.Disciplinas.FirstOrDefault(d => d.Nome == "Língua portuguesa").Id,
				TurmaId = context.Turmas.ToList()[0].Id
			};
			Model.Cadeira literatura = new Model.Cadeira
			{
				Alunos = context.Educandos.ToList(),
				ProfessorId = context.Professores.FirstOrDefault(p => p.Nome == "Héctor Bonilha").Id,
				DisciplinaId = context.Disciplinas.FirstOrDefault(d => d.Nome == "Literatura").Id,
				TurmaId = context.Turmas.ToList()[0].Id
			};
			Model.Cadeira filosofia = new Model.Cadeira
			{
				Alunos = context.Educandos.ToList(),
				ProfessorId = context.Professores.FirstOrDefault(p => p.Nome == "Rubén Aguirre").Id,
				DisciplinaId = context.Disciplinas.FirstOrDefault(d => d.Nome == "Filosofia").Id,
				TurmaId = context.Turmas.ToList()[0].Id
			};
			Model.Cadeira sociologia = new Model.Cadeira
			{
				Alunos = context.Educandos.ToList(),
				ProfessorId = context.Professores.FirstOrDefault(p => p.Nome == "Janet Arceo").Id,
				DisciplinaId = context.Disciplinas.FirstOrDefault(d => d.Nome == "Sociologia").Id,
				TurmaId = context.Turmas.ToList()[0].Id
			};
			Model.Cadeira matematica = new Model.Cadeira
			{
				Alunos = context.Educandos.ToList(),
				ProfessorId = context.Professores.FirstOrDefault(p => p.Nome == "Helena Fernandes").Id,
				DisciplinaId = context.Disciplinas.FirstOrDefault(d => d.Nome == "Matemática").Id,
				TurmaId = context.Turmas.ToList()[0].Id
			};
			Model.Cadeira fisica = new Model.Cadeira
			{
				Alunos = context.Educandos.ToList(),
				ProfessorId = context.Professores.FirstOrDefault(p => p.Nome == "Ximena Hezergovina Fernández").Id,
				DisciplinaId = context.Disciplinas.FirstOrDefault(d => d.Nome == "Física").Id,
				TurmaId = context.Turmas.ToList()[0].Id
			};
			Model.Cadeira quimica = new Model.Cadeira
			{
				Alunos = context.Educandos.ToList(),
				ProfessorId = context.Professores.FirstOrDefault(p => p.Nome == "Professora Matilde").Id,
				DisciplinaId = context.Disciplinas.FirstOrDefault(d => d.Nome == "Química").Id,
				TurmaId = context.Turmas.ToList()[0].Id
			};
			Model.Cadeira biologia = new Model.Cadeira
			{
				Alunos = context.Educandos.ToList(),
				ProfessorId = context.Professores.FirstOrDefault(p => p.Nome == "Suzana Bustamante").Id,
				DisciplinaId = context.Disciplinas.FirstOrDefault(d => d.Nome == "Biologia").Id,
				TurmaId = context.Turmas.ToList()[0].Id
			};
			context.Cadeiras.Add(lp);
			context.Cadeiras.Add(literatura);
			context.Cadeiras.Add(filosofia);
			context.Cadeiras.Add(sociologia);
			context.Cadeiras.Add(matematica);
			context.Cadeiras.Add(fisica);
			context.Cadeiras.Add(quimica);
			context.Cadeiras.Add(biologia);
			context.SaveChanges();

			context.Periodos.Add(new Model.Periodo { VigenciaInicio = new DateTime(2014, 1, 1), VigenciaTermino = new DateTime(2014, 3, 31) });
			context.Periodos.Add(new Model.Periodo { VigenciaInicio = new DateTime(2014, 4, 1), VigenciaTermino = new DateTime(2014, 6, 30) });
			context.Periodos.Add(new Model.Periodo { VigenciaInicio = new DateTime(2014, 7, 1), VigenciaTermino = new DateTime(2014, 9, 30) });
			context.Periodos.Add(new Model.Periodo { VigenciaInicio = new DateTime(2014, 10, 1), VigenciaTermino = new DateTime(2014, 12, 31) });
			context.SaveChanges();

			List<Model.Cadeira> cadeiras = context.Cadeiras.ToList();
			Random rdm = new Random();
			foreach(Model.Cadeira cadeira in cadeiras)
			{
				DateTime inicial = DateTime.Now.AddDays((double)rdm.Next(-1, 3));
				for(int i = 0; i< 15; i++)
				{
					context.Aulas.Add(new Model.Aula { CadeiraId = cadeira.Id, Data = inicial.AddDays((double)i*-7), PeriodoId = 1 });
				}
				for(int i = 0; i<4; i++)
				{
					context.Avaliacoes.Add(new Model.Avaliacao { CadeiraId = cadeira.Id, Nome = i + "ª avaliação", PeriodoId = 1, Aplicada = inicial.AddDays((double)-1 * rdm.Next(5, 100)) });
				}
			}
			context.SaveChanges();
		}
	}
}

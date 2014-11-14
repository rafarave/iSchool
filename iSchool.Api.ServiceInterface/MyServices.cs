using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using iSchool.Api.ServiceModel;
using ServiceStack.ServiceInterface;

namespace iSchool.Api.ServiceInterface
{
	public class MyServices : Service
	{
		public object Any(Hello request)
		{
			return new HelloResponse { Result = "Hello, {0}!" };
		}

		//public object Get(AlunoGet request)
		//{
		//	//Aluno aluno = new Aluno().ObterAlunoPorId(request.Disciplina, request.Turma);
		//	//return aluno;
		//	//return new string[]
		//	//{
		//	//	Aprovado = aluno.Aprovado,
		//	//	Nome = aluno.Nome,
		//	//	NomePai = aluno.Pai.Nome
		//	//};
		//	return "MyAss";
		//}
	}
}
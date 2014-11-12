using iSchool.Api.ServiceModel;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = iSchool.Api.Core.Model;
using data = iSchool.Api.Core.Data;

namespace iSchool.Api.ServiceInterface
{
	public class Aluno : Service
	{
		public model.Aluno Get(GetAluno request)
		{
			data.Aluno aluno = new data.Aluno();
			return aluno.GetElement(request.Id);
		}
		public List<model.Aluno> Get(GetAlunos request)
		{
			return new data.Aluno().GetCollection(0);
		}
		public void Insert(NewAluno request)
		{
			new data.Aluno().Insert(request.Aluno);
		}
		public void Update(UpdateAluno request)
		{
			new data.Aluno().Update(request.Aluno);
		}
		public void Delete(DeleteAluno request)
		{
			new data.Aluno().Delete(request.Id);
		}
	}
}

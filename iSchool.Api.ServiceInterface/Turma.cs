using iSchool.Api.ServiceModel;
using ServiceStack;
using ServiceStack.ServiceInterface;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Turma : Service
	{
		public model.Turma Get(GetTurma request)
		{
			data.Turma aluno = new data.Turma();
			return aluno.GetElement(request.Id);
		}
		public List<model.Turma> Get(GetTurmas request)
		{
			return new data.Turma().GetCollection(0);
		}
		public void Insert(NewTurma request)
		{
			new data.Turma().Insert(request.Turma);
		}
		public void Update(UpdateTurma request)
		{
			new data.Turma().Update(request.Turma);
		}
		public void Delete(DeleteTurma request)
		{
			new data.Turma().Delete(request.Id);
		}
	}
}

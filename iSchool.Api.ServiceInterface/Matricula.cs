using iSchool.Api.ServiceModel;
using ServiceStack;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Matricula : Service
	{
		public model.Matricula Get(GetMatricula request)
		{
			data.Matricula aluno = new data.Matricula();
			return aluno.GetElement(request.Id);
		}
		public List<model.Matricula> Get(GetMatriculas request)
		{
			return new data.Matricula().GetCollection(0);
		}
		public void Insert(NewMatricula request)
		{
			new data.Matricula().Insert(request.Matricula);
		}
		public void Update(UpdateMatricula request)
		{
			new data.Matricula().Update(request.Matricula);
		}
		public void Delete(DeleteMatricula request)
		{
			new data.Matricula().Delete(request.Id);
		}
	}
}

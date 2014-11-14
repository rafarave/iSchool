using iSchool.Api.ServiceModel;
using ServiceStack;
using ServiceStack.ServiceInterface;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Professor : Service
	{
		public model.Professor Get(GetProfessor request)
		{
			data.Professor aluno = new data.Professor();
			return aluno.GetElement(request.Id);
		}
		public List<model.Professor> Get(GetProfessores request)
		{
			return new data.Professor().GetCollection(0);
		}
		public void Insert(NewProfessor request)
		{
			new data.Professor().Insert(request.Professor);
		}
		public void Update(UpdateProfessor request)
		{
			new data.Professor().Update(request.Professor);
		}
		public void Delete(DeleteProfessor request)
		{
			new data.Professor().Delete(request.Id);
		}
	}
}

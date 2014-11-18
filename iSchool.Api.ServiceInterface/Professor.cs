using iSchool.Api.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = iSchool.Api.Core.Model;
using data = iSchool.Api.Core.Data;
using ServiceStack;
using ServiceStack.ServiceInterface;
using ServiceStack.Common.Web;

namespace iSchool.Api.ServiceInterface
{
	public class Professor : Service
	{
		public model.Professor Get(GetProfessor request)
		{
			data.Professor Professor = new data.Professor();
			return Professor.GetElement(request.Id);
		}
		public List<model.Professor> Get(GetProfessores request)
		{
			return new data.Professor().GetCollection(0);
		}
		public HttpResult Post(NewProfessor request)
		{
			new data.Professor().Insert(request.Professor);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateProfessor request)
		{
			new data.Professor().Update(request.Professor);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteProfessor request)
		{
			new data.Professor().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

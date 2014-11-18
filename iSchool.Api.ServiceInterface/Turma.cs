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
	public class Turma : Service
	{
		public model.Turma Get(GetTurma request)
		{
			data.Turma Turma = new data.Turma();
			return Turma.GetElement(request.Id);
		}
		public List<model.Turma> Get(GetTurmas request)
		{
			return new data.Turma().GetCollection(0);
		}
		public HttpResult Post(NewTurma request)
		{
			new data.Turma().Insert(request.Turma);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateTurma request)
		{
			new data.Turma().Update(request.Turma);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteTurma request)
		{
			new data.Turma().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

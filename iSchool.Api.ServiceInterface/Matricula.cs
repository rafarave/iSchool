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
	public class Matricula : Service
	{
		public model.Matricula Get(GetMatricula request)
		{
			data.Matricula Matricula = new data.Matricula();
			return Matricula.GetElement(request.Id);
		}
		public List<model.Matricula> Get(GetMatriculas request)
		{
			return new data.Matricula().GetCollection(0);
		}
		public HttpResult Post(NewMatricula request)
		{
			new data.Matricula().Insert(request.Matricula);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateMatricula request)
		{
			new data.Matricula().Update(request.Matricula);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteMatricula request)
		{
			new data.Matricula().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

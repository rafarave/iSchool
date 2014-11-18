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
	public class Comunicado : Service
	{
		public model.Comunicado Get(GetComunicado request)
		{
			data.Comunicado Comunicado = new data.Comunicado();
			return Comunicado.GetElement(request.Id);
		}
		public List<model.Comunicado> Get(GetComunicados request)
		{
			return new data.Comunicado().GetCollection(0);
		}
		public HttpResult Post(NewComunicado request)
		{
			new data.Comunicado().Insert(request.Comunicado);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateComunicado request)
		{
			new data.Comunicado().Update(request.Comunicado);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteComunicado request)
		{
			new data.Comunicado().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

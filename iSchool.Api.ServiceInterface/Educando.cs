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
	public class Educando : Service
	{
		public model.Educando Get(GetEducando request)
		{
			data.Educando Educando = new data.Educando();
			return Educando.GetElement(request.Id);
		}
		public List<model.Educando> Get(GetEducandos request)
		{
			return new data.Educando().GetCollection(0);
		}
		public HttpResult Post(NewEducando request)
		{
			new data.Educando().Insert(request.Educando);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateEducando request)
		{
			new data.Educando().Update(request.Educando);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteEducando request)
		{
			new data.Educando().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

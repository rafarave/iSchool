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
	public class Falta : Service
	{
		public model.Falta Get(GetFalta request)
		{
			data.Falta Falta = new data.Falta();
			return Falta.GetElement(request.Id);
		}
		public List<model.Falta> Get(GetFaltas request)
		{
			return new data.Falta().GetCollection(0);
		}
		public HttpResult Post(NewFalta request)
		{
			new data.Falta().Insert(request.Falta);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateFalta request)
		{
			new data.Falta().Update(request.Falta);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteFalta request)
		{
			new data.Falta().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

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
	public class Boletim : Service
	{
		public model.Boletim Get(GetBoletim request)
		{
			data.Boletim Boletim = new data.Boletim();
			return Boletim.GetElement(request.Id);
		}
		public List<model.Boletim> Get(GetBoletins request)
		{
			return new data.Boletim().GetCollection(0);
		}
		public HttpResult Post(NewBoletim request)
		{
			new data.Boletim().Insert(request.Boletim);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateBoletim request)
		{
			new data.Boletim().Update(request.Boletim);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteBoletim request)
		{
			new data.Boletim().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

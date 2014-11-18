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
	public class Cadeira : Service
	{
		public model.Cadeira Get(GetCadeira request)
		{
			data.Cadeira Cadeira = new data.Cadeira();
			return Cadeira.GetElement(request.Id);
		}
		public List<model.Cadeira> Get(GetCadeiras request)
		{
			return new data.Cadeira().GetCollection(0);
		}
		public HttpResult Post(NewCadeira request)
		{
			new data.Cadeira().Insert(request.Cadeira);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateCadeira request)
		{
			new data.Cadeira().Update(request.Cadeira);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteCadeira request)
		{
			new data.Cadeira().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

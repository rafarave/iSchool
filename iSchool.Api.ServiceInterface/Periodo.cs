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
	public class Periodo : Service
	{
		public model.Periodo Get(GetPeriodo request)
		{
			data.Periodo Periodo = new data.Periodo();
			return Periodo.GetElement(request.Id);
		}
		public List<model.Periodo> Get(GetPeriodos request)
		{
			return new data.Periodo().GetCollection(0);
		}
		public HttpResult Post(NewPeriodo request)
		{
			new data.Periodo().Insert(request.Periodo);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdatePeriodo request)
		{
			new data.Periodo().Update(request.Periodo);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeletePeriodo request)
		{
			new data.Periodo().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

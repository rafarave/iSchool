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
	public class Planejamento : Service
	{
		public model.Planejamento Get(GetPlanejamento request)
		{
			data.Planejamento Planejamento = new data.Planejamento();
			return Planejamento.GetElement(request.Id);
		}
		public List<model.Planejamento> Get(GetPlanejamentos request)
		{
			return new data.Planejamento().GetCollection(0);
		}
		public HttpResult Post(NewPlanejamento request)
		{
			new data.Planejamento().Insert(request.Planejamento);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdatePlanejamento request)
		{
			new data.Planejamento().Update(request.Planejamento);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeletePlanejamento request)
		{
			new data.Planejamento().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

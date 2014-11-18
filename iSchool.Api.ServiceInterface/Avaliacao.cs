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
	public class Avaliacao : Service
	{
		public model.Avaliacao Get(GetAvaliacao request)
		{
			data.Avaliacao avaliacao = new data.Avaliacao();
			return avaliacao.GetElement(request.Id);
		}
		public List<model.Avaliacao> Get(GetAvaliacoes request)
		{
			return new data.Avaliacao().GetCollection(0);
		}
		public HttpResult Post(NewAvaliacao request)
		{
			new data.Avaliacao().Insert(request.Avaliacao);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateAvaliacao request)
		{
			new data.Avaliacao().Update(request.Avaliacao);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteAvaliacao request)
		{
			new data.Avaliacao().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

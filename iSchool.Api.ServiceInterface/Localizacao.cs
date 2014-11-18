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
	public class Localizacao : Service
	{
		public model.Localizacao Get(GetLocalizacao request)
		{
			data.Localizacao Localizacao = new data.Localizacao();
			return Localizacao.GetElement(request.Id);
		}
		public List<model.Localizacao> Get(GetLocalizacoes request)
		{
			return new data.Localizacao().GetCollection(0);
		}
		public HttpResult Post(NewLocalizacao request)
		{
			new data.Localizacao().Insert(request.Localizacao);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateLocalizacao request)
		{
			new data.Localizacao().Update(request.Localizacao);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteLocalizacao request)
		{
			new data.Localizacao().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

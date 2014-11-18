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
	public class ConfiguracaoCadeira : Service
	{
		public model.ConfiguracaoCadeira Get(GetConfiguracaoCadeira request)
		{
			data.ConfiguracaoCadeira configuracaoCadeira = new data.ConfiguracaoCadeira();
			return configuracaoCadeira.GetElement(request.Id);
		}
		public List<model.ConfiguracaoCadeira> Get(GetConfiguracoesCadeira request)
		{
			return new data.ConfiguracaoCadeira().GetCollection(0);
		}
		public HttpResult Post(NewConfiguracaoCadeira request)
		{
			new data.ConfiguracaoCadeira().Insert(request.ConfiguracaoCadeira);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateConfiguracaoCadeira request)
		{
			new data.ConfiguracaoCadeira().Update(request.ConfiguracaoCadeira);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteConfiguracaoCadeira request)
		{
			new data.ConfiguracaoCadeira().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

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
	public class Mensalidade : Service
	{
		public model.Mensalidade Get(GetMensalidade request)
		{
			data.Mensalidade Mensalidade = new data.Mensalidade();
			return Mensalidade.GetElement(request.Id);
		}
		public List<model.Mensalidade> Get(GetMensalidades request)
		{
			return new data.Mensalidade().GetCollection(0);
		}
		public HttpResult Post(NewMensalidade request)
		{
			new data.Mensalidade().Insert(request.Mensalidade);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateMensalidade request)
		{
			new data.Mensalidade().Update(request.Mensalidade);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteMensalidade request)
		{
			new data.Mensalidade().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

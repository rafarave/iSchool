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
	public class Ocorrencia : Service
	{
		public model.Ocorrencia Get(GetOcorrencia request)
		{
			data.Ocorrencia Ocorrencia = new data.Ocorrencia();
			return Ocorrencia.GetElement(request.Id);
		}
		public List<model.Ocorrencia> Get(GetOcorrencias request)
		{
			return new data.Ocorrencia().GetCollection(0);
		}
		public HttpResult Post(NewOcorrencia request)
		{
			new data.Ocorrencia().Insert(request.Ocorrencia);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateOcorrencia request)
		{
			new data.Ocorrencia().Update(request.Ocorrencia);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteOcorrencia request)
		{
			new data.Ocorrencia().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

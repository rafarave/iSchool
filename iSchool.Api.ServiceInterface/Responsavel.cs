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
	public class Responsavel : Service
	{
		public model.Responsavel Get(GetResponsavel request)
		{
			data.Responsavel Responsavel = new data.Responsavel();
			return Responsavel.GetElement(request.Id);
		}
		public List<model.Responsavel> Get(GetResponsaveis request)
		{
			return new data.Responsavel().GetCollection(0);
		}
		public HttpResult Post(NewResponsavel request)
		{
			new data.Responsavel().Insert(request.Responsavel);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateResponsavel request)
		{
			new data.Responsavel().Update(request.Responsavel);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteResponsavel request)
		{
			new data.Responsavel().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

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
	public class Aula : Service
	{
		public model.Aula Get(GetAula request)
		{
			data.Aula aula = new data.Aula();
			return aula.GetElement(request.Id);
		}
		public List<model.Aula> Get(GetAulas request)
		{
			return new data.Aula().GetCollection(0);
		}
		public HttpResult Post(NewAula request)
		{
			new data.Aula().Insert(request.Aula);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateAula request)
		{
			new data.Aula().Update(request.Aula);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteAula request)
		{
			new data.Aula().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

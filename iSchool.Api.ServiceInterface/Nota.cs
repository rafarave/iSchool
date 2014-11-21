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
	public class Nota : Service
	{
		public model.Nota Get(GetNota request)
		{
			data.Nota Nota = new data.Nota();
			return Nota.GetElement(request.Id);
		}
		public List<model.Nota> Get(GetNotas request)
		{
			return new data.Nota().GetCollection(0);
		}
		public HttpResult Post(NewNota request)
		{
			new data.Nota().Insert(request.Nota);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateNota request)
		{
			new data.Nota().Update(request.Nota);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteNota request)
		{
			new data.Nota().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Get(SetNota request)
		{
			new data.Nota().AvaliarAluno(request.EducandoId, request.AvaliacaoId, request.Valor);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

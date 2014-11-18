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
	public class Disciplina : Service
	{
		public model.Disciplina Get(GetDisciplina request)
		{
			data.Disciplina Disciplina = new data.Disciplina();
			return Disciplina.GetElement(request.Id);
		}
		public List<model.Disciplina> Get(GetDisciplinas request)
		{
			return new data.Disciplina().GetCollection(0);
		}
		public HttpResult Post(NewDisciplina request)
		{
			new data.Disciplina().Insert(request.Disciplina);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateDisciplina request)
		{
			new data.Disciplina().Update(request.Disciplina);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteDisciplina request)
		{
			new data.Disciplina().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}

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
	public class Aluno : Service
	{
		public model.Aluno Get(GetAluno request)
		{
			data.Aluno aluno = new data.Aluno();
			return aluno.GetElement(request.Id);
		}
		public List<model.Aluno> Get(GetAlunos request)
		{
			return new data.Aluno().GetCollection(0);
		}
		public HttpResult Post(NewAluno request)
		{
			new data.Aluno().Insert(request.Aluno);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateAluno request)
		{
			new data.Aluno().Update(request.Aluno);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteAluno request)
		{
			new data.Aluno().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public List<model.Aluno> Get(FilterAlunos request)
		{
			if (request.Nome == null) request.Nome = string.Empty;
			if (request.Codigo == null) request.Codigo = string.Empty;
			return new data.Aluno().GetLista(request.Nome, request.Codigo);
		}
	}
}

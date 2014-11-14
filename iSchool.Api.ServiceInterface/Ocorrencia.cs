using iSchool.Api.ServiceModel;
using ServiceStack;
using ServiceStack.ServiceInterface;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Ocorrencia : Service
	{
		public model.Ocorrencia Get(GetOcorrencia request)
		{
			data.Ocorrencia aluno = new data.Ocorrencia();
			return aluno.GetElement(request.Id);
		}
		public List<model.Ocorrencia> Get(GetOcorrencias request)
		{
			return new data.Ocorrencia().GetCollection(0);
		}
		public void Insert(NewOcorrencia request)
		{
			new data.Ocorrencia().Insert(request.Ocorrencia);
		}
		public void Update(UpdateOcorrencia request)
		{
			new data.Ocorrencia().Update(request.Ocorrencia);
		}
		public void Delete(DeleteOcorrencia request)
		{
			new data.Ocorrencia().Delete(request.Id);
		}
	}
}

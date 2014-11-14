using iSchool.Api.ServiceModel;
using ServiceStack;
using ServiceStack.ServiceInterface;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Localizacao : Service
	{
		public model.Localizacao Get(GetLocalizacao request)
		{
			data.Localizacao aluno = new data.Localizacao();
			return aluno.GetElement(request.Id);
		}
		public List<model.Localizacao> Get(GetLocalizacoes request)
		{
			return new data.Localizacao().GetCollection(0);
		}
		public void Insert(NewLocalizacao request)
		{
			new data.Localizacao().Insert(request.Localizacao);
		}
		public void Update(UpdateLocalizacao request)
		{
			new data.Localizacao().Update(request.Localizacao);
		}
		public void Delete(DeleteLocalizacao request)
		{
			new data.Localizacao().Delete(request.Id);
		}
	}
}

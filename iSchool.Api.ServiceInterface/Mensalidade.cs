using iSchool.Api.ServiceModel;
using ServiceStack;
using ServiceStack.ServiceInterface;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Mensalidade : Service
	{
		public model.Mensalidade Get(GetMensalidade request)
		{
			data.Mensalidade aluno = new data.Mensalidade();
			return aluno.GetElement(request.Id);
		}
		public List<model.Mensalidade> Get(GetMensalidades request)
		{
			return new data.Mensalidade().GetCollection(0);
		}
		public void Insert(NewMensalidade request)
		{
			new data.Mensalidade().Insert(request.Mensalidade);
		}
		public void Update(UpdateMensalidade request)
		{
			new data.Mensalidade().Update(request.Mensalidade);
		}
		public void Delete(DeleteMensalidade request)
		{
			new data.Mensalidade().Delete(request.Id);
		}
	}
}

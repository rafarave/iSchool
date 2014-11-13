using iSchool.Api.ServiceModel;
using ServiceStack;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Responsavel : Service
	{
		public model.Responsavel Get(GetResponsavel request)
		{
			data.Responsavel aluno = new data.Responsavel();
			return aluno.GetElement(request.Id);
		}
		public List<model.Responsavel> Get(GetResponsaveis request)
		{
			return new data.Responsavel().GetCollection(0);
		}
		public void Insert(NewResponsavel request)
		{
			new data.Responsavel().Insert(request.Responsavel);
		}
		public void Update(UpdateResponsavel request)
		{
			new data.Responsavel().Update(request.Responsavel);
		}
		public void Delete(DeleteResponsavel request)
		{
			new data.Responsavel().Delete(request.Id);
		}
	}
}

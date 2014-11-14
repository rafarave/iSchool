using iSchool.Api.ServiceModel;
using ServiceStack;
using ServiceStack.ServiceInterface;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Planejamento : Service
	{
		public model.Planejamento Get(GetPlanejamento request)
		{
			data.Planejamento aluno = new data.Planejamento();
			return aluno.GetElement(request.Id);
		}
		public List<model.Planejamento> Get(GetPlanejamentos request)
		{
			return new data.Planejamento().GetCollection(0);
		}
		public void Insert(NewPlanejamento request)
		{
			new data.Planejamento().Insert(request.Planejamento);
		}
		public void Update(UpdatePlanejamento request)
		{
			new data.Planejamento().Update(request.Planejamento);
		}
		public void Delete(DeletePlanejamento request)
		{
			new data.Planejamento().Delete(request.Id);
		}
	}
}

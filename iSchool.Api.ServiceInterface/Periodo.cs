using iSchool.Api.ServiceModel;
using ServiceStack;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Periodo : Service
	{
		public model.Periodo Get(GetPeriodo request)
		{
			data.Periodo aluno = new data.Periodo();
			return aluno.GetElement(request.Id);
		}
		public List<model.Periodo> Get(GetPeriodos request)
		{
			return new data.Periodo().GetCollection(0);
		}
		public void Insert(NewPeriodo request)
		{
			new data.Periodo().Insert(request.Periodo);
		}
		public void Update(UpdatePeriodo request)
		{
			new data.Periodo().Update(request.Periodo);
		}
		public void Delete(DeletePeriodo request)
		{
			new data.Periodo().Delete(request.Id);
		}
	}
}

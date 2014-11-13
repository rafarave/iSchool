using iSchool.Api.ServiceModel;
using ServiceStack;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Falta : Service
	{
		public model.Falta Get(GetFalta request)
		{
			data.Falta aluno = new data.Falta();
			return aluno.GetElement(request.Id);
		}
		public List<model.Falta> Get(GetFaltas request)
		{
			return new data.Falta().GetCollection(0);
		}
		public void Insert(NewFalta request)
		{
			new data.Falta().Insert(request.Falta);
		}
		public void Update(UpdateFalta request)
		{
			new data.Falta().Update(request.Falta);
		}
		public void Delete(DeleteFalta request)
		{
			new data.Falta().Delete(request.Id);
		}
	}
}

using iSchool.Api.ServiceModel;
using ServiceStack;
using ServiceStack.ServiceInterface;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Educando : Service
	{
		public model.Educando Get(GetEducando request)
		{
			data.Educando aluno = new data.Educando();
			return aluno.GetElement(request.Id);
		}
		public List<model.Educando> Get(GetEducandos request)
		{
			return new data.Educando().GetCollection(0);
		}
		public void Insert(NewEducando request)
		{
			new data.Educando().Insert(request.Educando);
		}
		public void Update(UpdateEducando request)
		{
			new data.Educando().Update(request.Educando);
		}
		public void Delete(DeleteEducando request)
		{
			new data.Educando().Delete(request.Id);
		}
	}
}

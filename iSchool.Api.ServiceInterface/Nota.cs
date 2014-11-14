using iSchool.Api.ServiceModel;
using ServiceStack;
using ServiceStack.ServiceInterface;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Nota : Service
	{
		public model.Nota Get(GetNota request)
		{
			data.Nota aluno = new data.Nota();
			return aluno.GetElement(request.Id);
		}
		public List<model.Nota> Get(GetNotas request)
		{
			return new data.Nota().GetCollection(0);
		}
		public void Insert(NewNota request)
		{
			new data.Nota().Insert(request.Nota);
		}
		public void Update(UpdateNota request)
		{
			new data.Nota().Update(request.Nota);
		}
		public void Delete(DeleteNota request)
		{
			new data.Nota().Delete(request.Id);
		}
	}
}

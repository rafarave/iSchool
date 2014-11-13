using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = iSchool.Api.Core.Model;
using data = iSchool.Api.Core.Data;
using iSchool.Api.ServiceModel;

namespace iSchool.Api.ServiceInterface
{
	public class Aula : Service
	{
		public model.Aula Get(GetAula request)
		{
			data.Aula aluno = new data.Aula();
			return aluno.GetElement(request.Id);
		}
		public List<model.Aula> Get(GetAulas request)
		{
			return new data.Aula().GetCollection(0);
		}
		public void Insert(NewAula request)
		{
			new data.Aula().Insert(request.Aula);
		}
		public void Update(UpdateAula request)
		{
			new data.Aula().Update(request.Aula);
		}
		public void Delete(DeleteAula request)
		{
			new data.Aula().Delete(request.Id);
		}
	}
}

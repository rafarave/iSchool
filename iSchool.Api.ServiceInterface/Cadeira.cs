using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iSchool.Api.ServiceModel;
using model = iSchool.Api.Core.Model;
using data = iSchool.Api.Core.Data;
using ServiceStack;
using ServiceStack.ServiceInterface;
namespace iSchool.Api.ServiceInterface
{
	public class Cadeira : Service
	{
		public model.Cadeira Get(GetCadeira request)
		{
			data.Cadeira aluno = new data.Cadeira();
			return aluno.GetElement(request.Id);
		}
		public List<model.Cadeira> Get(GetCadeiras request)
		{
			return new data.Cadeira().GetCollection(0);
		}
		public void Insert(NewCadeira request)
		{
			new data.Cadeira().Insert(request.Cadeira);
		}
		public void Update(UpdateCadeira request)
		{
			new data.Cadeira().Update(request.Cadeira);
		}
		public void Delete(DeleteCadeira request)
		{
			new data.Cadeira().Delete(request.Id);
		}
	}
}

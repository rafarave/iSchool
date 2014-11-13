using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iSchool.Api.ServiceModel;
using model = iSchool.Api.Core.Model;
using data = iSchool.Api.Core.Data;
using ServiceStack;
namespace iSchool.Api.ServiceInterface
{
	public class Boletim : Service
	{
		public model.Boletim Get(GetBoletim request)
		{
			data.Boletim aluno = new data.Boletim();
			return aluno.GetElement(request.Id);
		}
		public List<model.Boletim> Get(GetBoletins request)
		{
			return new data.Boletim().GetCollection(0);
		}
		public void Insert(NewBoletim request)
		{
			new data.Boletim().Insert(request.Boletim);
		}
		public void Update(UpdateBoletim request)
		{
			new data.Boletim().Update(request.Boletim);
		}
		public void Delete(DeleteBoletim request)
		{
			new data.Boletim().Delete(request.Id);
		}
	}
}

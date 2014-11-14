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
	public class Comunicado : Service
	{
		public model.Comunicado Get(GetComunicado request)
		{
			data.Comunicado aluno = new data.Comunicado();
			return aluno.GetElement(request.Id);
		}
		public List<model.Comunicado> Get(GetComunicados request)
		{
			return new data.Comunicado().GetCollection(0);
		}
		public void Insert(NewComunicado request)
		{
			new data.Comunicado().Insert(request.Comunicado);
		}
		public void Update(UpdateComunicado request)
		{
			new data.Comunicado().Update(request.Comunicado);
		}
		public void Delete(DeleteComunicado request)
		{
			new data.Comunicado().Delete(request.Id);
		}
	}
}

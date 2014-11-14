using iSchool.Api.ServiceModel;
using ServiceStack;
using ServiceStack.ServiceInterface;
using System.Collections.Generic;
using data = iSchool.Api.Core.Data;
using model = iSchool.Api.Core.Model;

namespace iSchool.Api.ServiceInterface
{
	public class Usuario : Service
	{
		public model.Usuario Get(GetUsuario request)
		{
			data.Usuario aluno = new data.Usuario();
			return aluno.GetElement(request.Id);
		}
		public List<model.Usuario> Get(GetUsuarios request)
		{
			return new data.Usuario().GetCollection(0);
		}
		public void Insert(NewUsuario request)
		{
			new data.Usuario().Insert(request.Usuario);
		}
		public void Update(UpdateUsuario request)
		{
			new data.Usuario().Update(request.Usuario);
		}
		public void Delete(DeleteUsuario request)
		{
			new data.Usuario().Delete(request.Id);
		}
	}
}

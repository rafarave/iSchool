using iSchool.Api.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = iSchool.Api.Core.Model;
using data = iSchool.Api.Core.Data;
using ServiceStack;
using ServiceStack.ServiceInterface;
using ServiceStack.Common.Web;

namespace iSchool.Api.ServiceInterface
{
	public class Usuario : Service
	{
		public model.Usuario Get(GetUsuario request)
		{
			data.Usuario Usuario = new data.Usuario();
			return Usuario.GetElement(request.Id);
		}
		public List<model.Usuario> Get(GetUsuarios request)
		{
			return new data.Usuario().GetCollection(0);
		}
		public HttpResult Post(NewUsuario request)
		{
			new data.Usuario().Insert(request.Usuario);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateUsuario request)
		{
			new data.Usuario().Update(request.Usuario);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteUsuario request)
		{
			new data.Usuario().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
	}
}
